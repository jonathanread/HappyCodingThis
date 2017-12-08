$(document).ready(function () {
	initCrewMembers();
});
/************************ Crew Member expertise setup ************************************/
function initCrewMembers() {
	var viewModel = kendo.observable({
		membersSource: new kendo.data.DataSource({
			transport: {
				read: {
					url: "/api/crew/members?$expand=Image",
					dataType: "json"
				}
			},
			schema: {
				data: "value",
				total: function (e) {
					if (e.type === "read") {
						totalCrewMembers = e.response.length;
					}
				}
			},
			aggregate: [
				{ field: "VisualDesignExperience", aggregate: "sum" },
				{ field: "VisualDesignExperience", aggregate: "count" },
				{ field: "PrototypingExperience", aggregate: "sum" },
				{ field: "PrototypingExperience", aggregate: "count" },
				{ field: "HtmlCssExperience", aggregate: "sum" },
				{ field: "HtmlCssExperience", aggregate: "count" },
				{ field: "UxExperience", aggregate: "sum" },
				{ field: "UxExperience", aggregate: "count" }
			]
		}),
		crewLinkClickHandler: function (e) {
			if ($(e.srcElement).attr('href') === '#') {
				e.preventDefault();
			}
		}
	});

	kendo.bind($("#members"), viewModel);
	viewModel.membersSource.bind('change', function () {
		animateBars();
	});
}
/****************** Setup Animate Crew Member Expertise Bars ***********************/
function animateBars() {
	var bar = $('.bar');
	bar.width('0%');
	bar.waypoint(function () {
		bar.each(function () {
			var width = $(this).data("percentage");
			$(this).animate({
				width: width
			}, {
				duration: 2000,
				easing: 'easeOutExpo',
			});
		});
	}, {
		offset: '85%'
	});
}