(function ($) {
	var designerModule = angular.module('designer');
	designerModule.controller('SimpleCtrl', ['$scope', 'propertyService', function ($scope, propertyService) {
		var icons = [
			{ name: "Select", cssClass: "" },
			{ name: "World Wide", cssClass: "WorldWide" },
    		{ name: "World Globe", cssClass: "WorldGlobe" },
    		{ name: "Underpants", cssClass: "Underpants" },
    		{ name: "T-Shirt", cssClass: "Tshirt" },
    		{ name: "Trousers", cssClass: "Trousers" },
    		{ name: "Tie", cssClass: "Tie" },
    		{ name: "Tennis Ball", cssClass: "TennisBall" },
    		{ name: "Telesocpe", cssClass: "Telesocpe" },
    		{ name: "Stop", cssClass: "Stop" },
    		{ name: "Starship", cssClass: "Starship" },
    		{ name: "Starship 2", cssClass: "Starship2" },
    		{ name: "Speaker", cssClass: "Speaker" },
    		{ name: "Speaker 2", cssClass: "Speaker2" },
    		{ name: "Soccer", cssClass: "Soccer" },
    		{ name: "Snikers", cssClass: "Snikers" },
    		{ name: "Scisors", cssClass: "Scisors" },
    		{ name: "Puzzle", cssClass: "Puzzle" },
    		{ name: "Printer", cssClass: "Printer" },
    		{ name: "Pool", cssClass: "Pool" },
    		{ name: "Podium", cssClass: "Podium" },
    		{ name: "Play", cssClass: "Play" },
    		{ name: "Planet", cssClass: "Planet" },
    		{ name: "Pause", cssClass: "Pause" },
    		{ name: "Next", cssClass: "Next" },
    		{ name: "Music Note", cssClass: "MusicNote" },
    		{ name: "Music Note 2", cssClass: "MusicNote2" },
    		{ name: "MusicMixer", cssClass: "MusicMixer" },
    		{ name: "Microphone", cssClass: "Microphone" },
    		{ name: "Medal", cssClass: "Medal" },
    		{ name: "Man Figure", cssClass: "ManFigure" },
    		{ name: "Magnet", cssClass: "Magnet" },
    		{ name: "Like", cssClass: "Like" },
    		{ name: "Hanger", cssClass: "Hanger" },
    		{ name: "Handicap", cssClass: "Handicap" },
    		{ name: "Forward", cssClass: "Forward" },
    		{ name: "Football", cssClass: "Footbal" },
    		{ name: "Flag", cssClass: "Flag" },
    		{ name: "Female Figure", cssClass: "FemaleFigure" },
    		{ name: "Dislike", cssClass: "Dislike" },
    		{ name: "Diamond Ring", cssClass: "DiamondRing" },
    		{ name: "Cup", cssClass: "Cup" },
    		{ name: "Crown", cssClass: "Crown" },
    		{ name: "Column", cssClass: "Column" },
    		{ name: "Click", cssClass: "Click" },
    		{ name: "Cassette", cssClass: "Cassette" },
    		{ name: "Bomb", cssClass: "Bomb" },
    		{ name: "Battery Low", cssClass: "BatteryLow" },
    		{ name: "Battery Full", cssClass: "BatteryFull" },
    		{ name: "Bascketball", cssClass: "Bascketball" },
    		{ name: "Astronaut", cssClass: "Astronaut" },
    		{ name: "Wine Glass", cssClass: "WineGlass" },
    		{ name: "Water", cssClass: "Water" },
    		{ name: "Wallet", cssClass: "Wallet" },
    		{ name: "Umbrella", cssClass: "Umbrella" },
    		{ name: "TV", cssClass: "TV" },
    		{ name: "Tea Mug", cssClass: "TeaMug" },
    		{ name: "Tablet", cssClass: "Tablet" },
    		{ name: "Soda", cssClass: "Soda" },
    		{ name: "Soda Can", cssClass: "SodaCan" },
    		{ name: "SimCard", cssClass: "SimCard" },
    		{ name: "Signal", cssClass: "Signal" },
    		{ name: "Shaker", cssClass: "Shaker" },
    		{ name: "Radio", cssClass: "Radio" },
    		{ name: "Pizza", cssClass: "Pizza" },
    		{ name: "Phone", cssClass: "Phone" },
    		{ name: "Notebook", cssClass: "Notebook" },
    		{ name: "Mug", cssClass: "Mug" },
    		{ name: "Mastercard", cssClass: "Mastercard" },
    		{ name: "iPod", cssClass: "Ipod" },
    		{ name: "Info", cssClass: "Info" },
    		{ name: "Ice Cream", cssClass: "Icecream1" },
    		{ name: "Ice Cream 2", cssClass: "Icecream2" },
    		{ name: "Hourglass", cssClass: "Hourglass" },
    		{ name: "Help", cssClass: "Help" },
    		{ name: "Goto", cssClass: "Goto" },
    		{ name: "Glasses", cssClass: "Glasses" },
    		{ name: "Gameboy", cssClass: "Gameboy" },
    		{ name: "Fork and Knife", cssClass: "ForkandKnife" },
    		{ name: "Export", cssClass: "Export" },
    		{ name: "Exit", cssClass: "Exit" },
    		{ name: "Espresso", cssClass: "Espresso" },
    		{ name: "Drop", cssClass: "Drop" },
    		{ name: "Download", cssClass: "Download" },
    		{ name: "Dollars", cssClass: "Dollars" },
    		{ name: "Dollar", cssClass: "Dollar" },
    		{ name: "Desktop Monitor", cssClass: "DesktopMonitor" },
    		{ name: "Corkscrew", cssClass: "Corkscrew" },
    		{ name: "Coffee To Go", cssClass: "CoffeeToGo" },
    		{ name: "Chart", cssClass: "Chart" },
    		{ name: "Chart Up", cssClass: "ChartUp" },
    		{ name: "Chart Down", cssClass: "ChartDown" },
    		{ name: "Calculator", cssClass: "Calculator" },
    		{ name: "Bread", cssClass: "Bread" },
    		{ name: "Bourbon", cssClass: "Bourbon" },
    		{ name: "Bottle of Wine", cssClass: "BottleofWIne" },
    		{ name: "Bag", cssClass: "Bag" },
    		{ name: "Arrow", cssClass: "Arrow" },
    		{ name: "Antenna", cssClass: "Antenna1" },
    		{ name: "Antenna 2", cssClass: "Antenna2" },
    		{ name: "Anchor", cssClass: "Anchor" },
    		{ name: "Wheelbarrow", cssClass: "Wheelbarrow" },
    		{ name: "Webcam", cssClass: "Webcam" },
    		{ name: "Unlinked", cssClass: "Unlinked" },
    		{ name: "Truck", cssClass: "Truck" },
    		{ name: "Timer", cssClass: "Timer" },
    		{ name: "Time", cssClass: "Time" },
    		{ name: "Storage Box", cssClass: "StorageBox" },
    		{ name: "Star", cssClass: "Star" },
    		{ name: "Shopping Cart", cssClass: "ShoppingCart" },
    		{ name: "Shield", cssClass: "Shield" },
    		{ name: "Syringe", cssClass: "Seringe" },
    		{ name: "Pulse", cssClass: "Pulse" },
    		{ name: "Plaster", cssClass: "Plaster" },
    		{ name: "Plaine", cssClass: "Plaine" },
    		{ name: "Pill", cssClass: "Pill" },
    		{ name: "Picnic Basket", cssClass: "PicnicBasket" },
    		{ name: "Phone2", cssClass: "Phone2" },
    		{ name: "Pencil", cssClass: "Pencil" },
    		{ name: "Pen", cssClass: "Pen" },
    		{ name: "Paper Clip", cssClass: "PaperClip" },
    		{ name: "On/Off", cssClass: "On-Off" },
    		{ name: "Mouse", cssClass: "Mouse" },
    		{ name: "Megaphone", cssClass: "Megaphone" },
    		{ name: "Linked", cssClass: "Linked" },
    		{ name: "Keyboard", cssClass: "Keyboard" },
    		{ name: "House", cssClass: "House" },
    		{ name: "Heart", cssClass: "Heart" },
    		{ name: "Headset", cssClass: "Headset" },
    		{ name: "Full Shopping Cart", cssClass: "FullShoppingCart" },
    		{ name: "Full Screen", cssClass: "FullScreen" },
    		{ name: "Folder", cssClass: "Folder" },
    		{ name: "Floppy", cssClass: "Floppy" },
    		{ name: "Files", cssClass: "Files" },
    		{ name: "File", cssClass: "File" },
    		{ name: "File Box", cssClass: "FileBox" },
    		{ name: "Exit Full Screen", cssClass: "ExitFullScreen" },
    		{ name: "Empty Box", cssClass: "EmptyBox" },
    		{ name: "Delete", cssClass: "Delete" },
    		{ name: "Controller", cssClass: "Controller" },
    		{ name: "Compass", cssClass: "Compass" },
    		{ name: "Compass Tool", cssClass: "CompassTool" },
    		{ name: "Clipboard Text", cssClass: "ClipboardText" },
    		{ name: "Clipboard Chart", cssClass: "ClipboardChart" },
    		{ name: "Chemical Glass", cssClass: "ChemicalGlass" },
    		{ name: "CD", cssClass: "CD" },
    		{ name: "Carioca", cssClass: "Carioca" },
    		{ name: "Car", cssClass: "Car" },
    		{ name: "Book", cssClass: "Book" },
    		{ name: "Big Truck", cssClass: "BigTruck" },
    		{ name: "Bicycle", cssClass: "Bicycle" },
    		{ name: "Wrench", cssClass: "Wrench" },
    		{ name: "Web", cssClass: "Web" },
    		{ name: "Watch", cssClass: "Watch" },
    		{ name: "Volume", cssClass: "Volume" },
    		{ name: "Video", cssClass: "Video" },
    		{ name: "Users", cssClass: "Users" },
    		{ name: "User", cssClass: "User" },
    		{ name: "Upload Cloud", cssClass: "UploadCLoud" },
    		{ name: "Typing", cssClass: "Typing" },
    		{ name: "Tools", cssClass: "Tools" },
    		{ name: "Tag", cssClass: "Tag" },
    		{ name: "Speedometer", cssClass: "Speedometter" },
    		{ name: "Share", cssClass: "Share" },
    		{ name: "Settings", cssClass: "Settings" },
    		{ name: "Search", cssClass: "Search" },
    		{ name: "Screwdriver", cssClass: "Screwdriver" },
    		{ name: "Rolodex", cssClass: "Rolodex" },
    		{ name: "Ringer", cssClass: "Ringer" },
    		{ name: "Resume", cssClass: "Resume" },
    		{ name: "Restart", cssClass: "Restart" },
    		{ name: "PowerOff", cssClass: "PowerOff" },
    		{ name: "Pointer", cssClass: "Pointer" },
    		{ name: "Picture", cssClass: "Picture" },
    		{ name: "Opened Lock", cssClass: "OpenedLock" },
    		{ name: "Notes", cssClass: "Notes" },
    		{ name: "Mute", cssClass: "Mute" },
    		{ name: "Movie", cssClass: "Movie" },
    		{ name: "Microphone 2", cssClass: "Microphone2" },
    		{ name: "Message", cssClass: "Message" },
    		{ name: "Message Right", cssClass: "MessageRight" },
    		{ name: "MessageLeft", cssClass: "MessageLeft" },
    		{ name: "Menu", cssClass: "Menu" },
    		{ name: "Media", cssClass: "Media" },
    		{ name: "Mail", cssClass: "Mail" },
    		{ name: "List", cssClass: "List" },
    		{ name: "Layers", cssClass: "Layers" },
    		{ name: "Key", cssClass: "Key" },
    		{ name: "Imbox", cssClass: "Imbox" },
    		{ name: "Eye", cssClass: "Eye" },
    		{ name: "Edit", cssClass: "Edit" },
    		{ name: "DSLR Camera", cssClass: "DSLRCamera" },
    		{ name: "Download Cloud", cssClass: "DownloadCloud" },
    		{ name: "Compact Camera", cssClass: "CompactCamera" },
    		{ name: "Cloud", cssClass: "Cloud" },
    		{ name: "Closed Lock", cssClass: "ClosedLock" },
    		{ name: "Chart 2", cssClass: "Chart2" },
    		{ name: "Bulb", cssClass: "Bulb" },
    		{ name: "Briefcase", cssClass: "Briefcase" },
    		{ name: "Blog", cssClass: "Blog" },
    		{ name: "Agenda", cssClass: "Agenda" }];

		$scope.iconSelector = $("#iconClass").kendoDropDownList({
			dataTextField: "name",
			dataValueField: "cssClass",
			valueTemplate: '<i class="selected-value icon icon-#: data.cssClass #"></i>&nbsp;<span>#:data.name#</span>',
			template: '<i class="icon icon-#: data.cssClass #"></i>&nbsp;<span>#:data.name#</span>',
			dataSource: {
				data: icons,
				sort: { field: "name", dir: "asc" }
			},
			height: 400
		}).data("kendoDropDownList");

		$scope.checkBoxChange = function (isChecked) {
			debugger;
			if (isChecked === 'True')
				$scope.properties.NumberOfAccolades.PropertyValue = null;
		};

		propertyService.get()
            .then(function (data) {
            	if (data) {
            		$scope.properties = propertyService.toAssociativeArray(data.Items);

            		$scope.iconSelector.select(function (dataItem) {
            			return dataItem.cssClass === $scope.properties.IconClass.PropertyValue
            		});
            	}
            },
            function (data) {
            	$scope.feedback.showError = true;
            	if (data)
            		$scope.feedback.errorMessage = data.Detail;
            })
            .then(function () {
            	$scope.feedback.savingHandlers.push(function () {
            		$scope.properties.IconClass.PropertyValue = $scope.iconSelector.value();
            		$scope.properties.NumberOfAccolades.PropertyValue = parseInt($scope.properties.NumberOfAccolades.PropertyValue);
            	});
            })
            .finally(function () {
            	$scope.feedback.showLoadingIndicator = false;
            });
	}])
	.directive('stringToNumber', function () {
		return {
			require: 'ngModel',
			link: function (scope, element, attrs, ngModel) {
				ngModel.$parsers.push(function (value) {
					return '' + value;
				});
				ngModel.$formatters.push(function (value) {
					return parseFloat(value);
				});
			}
		};
	});
})(jQuery);