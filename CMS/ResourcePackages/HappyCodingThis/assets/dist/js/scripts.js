$(document).ready(function () {
	initSite();
});

function initSite() {
	/***************** Article Class Finder ******************/
	$('.latest-articles').find('img').each(function () {
		var imgClass = (this.width / this.height > 1) ? 'wide' : 'tall';
		$(this).addClass(imgClass);
	});

	/***************** Like Counter ******************/
	$('.count').each(function () {
		var clicks = Math.floor((Math.random() * 100) + 1);
		$(this).text(clicks);
	});

	$(".like_button").one("click", function () {
		var $count = $(this).parent().find('.count');
		$count.html($count.html() * 1 + 1);
		var $icon = $(this).parent().find('.like-counter');
		$($icon).removeClass("fa-heart-o");
		$($icon).addClass("fa-heart");
	});

	$(".like_button").on("click", function (event) {
		event.preventDefault();
	});

	/***************** Share Dropdown ******************/
	$("li a.share-trigger").on("click", function () {
		$('.share-dropdown').toggleClass("is-open");
		event.preventDefault();
	});

	/***************** Search Component ******************/
	$(".show-search").on("click", function () {
		$(".search-wrapper").addClass("is-visible");
	});

	$(".hide-search").on("click", function () {
		var searchWrapper = $(".search-wrapper");
		searchWrapper.removeClass("is-visible");
		searchWrapper.children("input").removeClass("is-selected");
	});

	$(".search-wrapper input").on("click", function () {
		$(this).addClass("is-selected");
	});

	$('.search-wrapper input').keypress(function (e) {
		if (e.which === 13) { //Enter key pressed
			window.alert("Ready for implementation.");
		}
	});

	/***************** Stats Counter ******************/

	var counterZero = '0';
	var statsNumber =
    $('.stats-number');

	statsNumber.text(counterZero);

	statsNumber.waypoint(function () {
		statsNumber.each(function () {
			var $this = $(this);
			$({
				Counter: 0
			}).animate({
				Counter: $this.attr('data-stop')
			}, {
				duration: 5000,
				easing: 'swing',
				step: function (now) {
					$this.text(Math.ceil(now));
				}
			});
		});
		this.destroy();
	}, {
		offset: '75%'
	});

	/***************** Smooth Scroll ******************/
	$('a[href*=\\#]:not([href=\\#])').click(function () {
		if (location.pathname.replace(/^\//, '') === this.pathname.replace(/^\//, '') && location.hostname === this.hostname) {

			var target = $(this.hash);
			target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
			if (target.length) {
				$('html,body').animate({
					scrollTop: target.offset().top
				}, 2000);
				return false;
			}
		}
	});

	/***************** Responsive Nav ******************/
	$('.nav-toggle').click(function () {
		$(this).toggleClass('active');
		$('.navicon').toggleClass('fixed');
		$('.primary-nav-wrapper').toggleClass('open');
		event.preventDefault();
	});

	$('.primary-nav-wrapper li a').click(function () {
		$('.nav-toggle').toggleClass('active');
		$('.navicon').toggleClass('fixed');
		$('.primary-nav-wrapper').toggleClass('open');
	});

	/***************** Waypoints ******************/
	if (isDesignMode) {
		$('.wp1, .wp2, .wp3, .wp4, .wp5, .wp6, .wp7, .wp8').css('visibility', 'visible');;
	} else {
		setupWaypoints('wp1', 'fadeInUp', '80%');
		setupWaypoints('.wp2, .wp3', 'fadeInUp', '95%');
		setupWaypoints('wp4', 'fadeInUp');
		setupWaypoints('.wp5, .wp6, .wp7, .wp8', 'fadeIn');
	}


	/***************** Overlay touch/hover events ******************/

	if (Modernizr.touch) {
		$('figure').bind('touchstart touchend', function (e) {
			$(this).toggleClass('hover');
		});
	}

	function setupWaypoints(cssClass, animationClass, offset) {
		if (cssClass.indexOf('.') === -1 && cssClass.indexOf(',') === -1) {
			cssClass = '.' + cssClass;
		}
		var wp = $(cssClass);
		wp.waypoint(function () {
			wp.addClass('animated ' + animationClass);
		}, {
			offset: !offset ? '75%' : offset
		});
	}
}
