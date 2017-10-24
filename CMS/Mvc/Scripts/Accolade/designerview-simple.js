(function ($) {
    var designerModule = angular.module('designer');
    designerModule.controller('SimpleCtrl', ['$scope', 'propertyService', function ($scope, propertyService) {

        var icons = [{name:"World Wide", ""}];
        $("#iconClass").kendoDropDownList({
            dataTextField: "name",
            dataValueField: "cssClass",
            headerTemplate: '<div class="dropdown-header k-widget k-header">' +
                    '<span>Icon</span>' +
                    '<span>Name</span>' +
                '</div>',
            valueTemplate: '<span class="selected-value #: data.cssClass #"></span><span>#:data.name#</span>',
            template: '<span class="k-state-default" style="background-image: url(\'../content/web/Customers/#:data.CustomerID#.jpg\')"></span>' +
                      '<span class="k-state-default"><h3>#: data.ContactName #</h3><p>#: data.CompanyName #</p></span>',
            dataSource: {
                data: icons
            },
            height: 400
        });
        propertyService.get()
            .then(function (data) {
                if (data) {
                    $scope.properties = propertyService.toAssociativeArray(data.Items);
                    $scope.properties.NumberOfAccolades.PropertyValue = parseInt($scope.properties.NumberOfAccolades.PropertyValue);
                }
            },
            function (data) {
                $scope.feedback.showError = true;
                if (data)
                    $scope.feedback.errorMessage = data.Detail;
            })
            .then(function () {
                $scope.feedback.savingHandlers.push(function () {
                    $scope.properties.NumberOfAccolades.PropertyValue = parseInt($scope.properties.NumberOfAccolades.PropertyValue);
                });
            })
            .finally(function () {
                $scope.feedback.showLoadingIndicator = false;
            });
    }]);
})(jQuery);