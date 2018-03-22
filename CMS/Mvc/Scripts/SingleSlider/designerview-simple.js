!function (e) {
	var r = angular.module("designer");
	r.requires.push("sfSelectors"), r.controller("SimpleCtrl", ["$scope", "propertyService", function (e, r) {
		e.$watch("selectedItem", function (r, t) {
			r && r !== t && (e.properties.SliderItem.PropertyValue = JSON.stringify(r))
		}, !0),
			e.$watch("selectedId", function (r, t) {
				r && r !== t && (e.properties.SliderId.PropertyValue = r)
			}, !0),
			e.provider = "OpenAccessProvider",
			e.itemType = "Telerik.Sitefinity.DynamicTypes.Model.Sliders.Slider",
			r.get().then(function (t) {
				if (t) {
					e.properties = r.toAssociativeArray(t.Items);
					var i = e.properties.SliderItem.PropertyValue; "" != i && (e.selectedItem = JSON.parse(i));
					var o = e.properties.SliderId.PropertyValue; "" != o && (e.selectedId = o)
				}
			}, function (r) { e.feedback.showError = !0, r && (e.feedback.errorMessage = r.Detail) }).finally(function () {
				e.feedback.showLoadingIndicator = !1
			})
	}])
}(jQuery);