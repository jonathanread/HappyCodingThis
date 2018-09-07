class TreeViewer {
	constructor(treeViewSelector, rootLibraryId) {
		this.rootLibraryId = rootLibraryId;
		this.treeviewIdSelector = treeViewSelector;
		this.initTreeview();
	}

	get DocumentsFoldersInFolders() {
		return {
			schema: {
				model: {
					id: "Id",
					hasChildren: "ChildrenCount",
					children: TreeViewer.DocumentsFoldersInFolders
				}
			},
			transport: {
				read: function (options) {
					var docsUrl = kendo.format("/api/docs/documents?$filter=(FolderId eq {0})", options.data.Id);
					var folderUrl = kendo.format("/api/docs/folders?$filter=ParentId eq {0}", options.data.Id);
					TreeViewer.getDocsAndFoldersByParentId(docsUrl, folderUrl, options);
				}
			}
		};
	};

	get DocumentsFoldersInLibraries() {
		return {
			transport: {
				read: function (options) {
					var docsUrl = kendo.format("/api/docs/documents?$filter=(ParentId eq {0}) and (FolderId eq null)", options.data.Id);
					var folderUrl = kendo.format("/api/docs/folders?$filter=(RootId eq {0}) and (ParentId eq null)", options.data.Id);
					TreeViewer.getDocsAndFoldersByParentId(docsUrl, folderUrl, options);
				}
			},
			schema: {
				data: function (data) {
					return data;
				},
				total: function (data) {
					return data.length;
				},
				model: {
					hasChildren: "ChildrenCount",
					children: this.DocumentsFoldersInFolders,
					id: "Id",
					title: "Title"
				}
			}
		}
	};

	get RootLibrary() {
		var rootLibraryId = this.rootLibraryId;
		return new kendo.data.HierarchicalDataSource({
			transport: {
				read: function (options) {
					$.ajax({
						url: "/api/docs/documentlibraries(" + rootLibraryId + ")",
						beforeSend: function (xhr) {
							var token = TreeViewer.getCookie(".AspNet.Cookies");
							xhr.setRequestHeader("Authorization", "Bearer " + token);
							xhr.setRequestHeader("x-sf-service-request", true)
						}
					})
						.success(function (result) {
							options.success(result);
						})
						.error();
				}
			},
			schema: {
				data: function (data) {
					data.spriteCssClass = "fas fa-folder";
					data.expanded = true;
					return [data];
				},
				total: function (data) {
					return 1;
				},
				model: {
					children: this.DocumentsFoldersInLibraries,
					hasChildren: true,
					id: "Id"
				}
			}
		});
	}

	initTreeview() {
		$(this.treeviewIdSelector).kendoTreeView({
			dataSource: this.RootLibrary,
			dataUrlField: "Url",
			dataTextField: ["Title"],
			template: kendo.template($("#treeview-template").html()),
			dataBound: function (e) {
				var links = $(e.node).find("a.k-link").attr("target", "_blank");
			}
		});
	};

	static getCookie(name) {
		var match = document.cookie.match(new RegExp('(^| )' + name + '=([^;]+)'));
		if (match) return match[2];
	}

	static getFoldersByParentId(url, options, docs) {
		$.ajax({
			url: url,
			beforeSend: function (xhr) {
				var token = TreeViewer.getCookie(".AspNet.Cookies");
				xhr.setRequestHeader("Authorization", "Bearer " + token);
				xhr.setRequestHeader("x-sf-service-request", true)
			}
		})
			.success(function (result) {
				var folders = result.value;
				for (var i = 0; i < folders.length; i++) {
					folders[i].ChildrenCount = 1;
					folders[i].spriteCssClass = "far fa-folder";
				}
				options.success(docs.concat(folders));
			})
			.error(function (error) {

			});
	};

	static getDocsAndFoldersByParentId(docsUrl, folderUrl, options) {
		var token = TreeViewer.getCookie(".AspNet.Cookies");
		$.ajax({
			url: docsUrl,
			beforeSend: function (xhr) {
				xhr.setRequestHeader("Authorization", "Bearer " + token);
				xhr.setRequestHeader("x-sf-service-request", true);
			}
		})
			.success(function (result) {
				var docs = result.value;
				for (var i = 0; i < docs.length; i++) {
					docs[i].spriteCssClass = TreeViewer.getExtensionCssClass(docs[i].Extension);
					docs[i].target = "_blank";
				}
				TreeViewer.getFoldersByParentId(folderUrl, options, docs, token);
			})
			.error(function (error) { });
	};

	static getExtensionCssClass(extension) {
		var cssClass = "";

		switch (extension) {
			case ".doc":
			case ".docx":
				cssClass = "fa-file-word"
				break;
			case ".pdf":
				cssClass = "fa-file-pdf";
				break;
			case ".txt":
			case ".rtf":
				cssClass = "fa-file-alt";
				break;
			case ".xls":
			case ".xlsx":
				cssClass = "fa-file-excel";
				break;
			default:
				cssClass = "";
		}
		return "fas " + cssClass;
	};
}
