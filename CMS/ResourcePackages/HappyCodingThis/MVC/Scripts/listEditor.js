var viewModel = kendo.observable({
	isVisible: false,
	listItem: null,
	onClose: function (e) {
		this.set("isVisible", false);
		this.set("listItem", null);
	},
	newItemClick: function (e) {
		e.preventDefault();
		this.set("isVisible", true);
		this.set("listItem", {});
		debugger;
		return false;
	},
	saveListItem: function () {
		debugger;
		console.log(this.listItem);
	},
	cancelListItem: function (e) {

	}
});

kendo.bind($("#listItemEditor"), viewModel);
