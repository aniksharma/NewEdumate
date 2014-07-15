$(document).ready(function() {

	// NAVIGATION 
	
	$('#nav').each(function() {
		var $links = $(this).find('a'),
			panelIds = $links.map(function() { return this.hash; }).get().join(","),
			$panels = $(panelIds),
			$panelWrapper = $panels.filter(':first').parent(),
			delay = 500;
			
		$panels.hide();

		$links.click(function() {
			var $link = $(this),
				link = (this);
				
			if ($link.is('.selected')) {
				return;
			}
		
			$links.removeClass('selected');
			$link.addClass('selected');
			
			$panels.animate({ opacity : 0 }, delay);
			$panelWrapper.animate({
				height: 0
			}, delay, function() {
				var height = $panels.hide().filter(link.hash).show().css('opacity', 1).outerHeight();
							
				$panelWrapper.animate({
					height: height
				}, delay);
			});	
		});
		
		var showtab = window.location.hash ? '[hash=' + window.location.hash + ']' : ':first';
		
		$links.filter(showtab).click();
	
	});
	


	// VCARD POPUP BUBBLE
	
	$("#vcard a").hover(function() { //mouseover
		$("#bubble").show();
		$("#bubble").animate({
			top: "-75px",
			opacity: 1
		}, 250 );
	}, function() { // mouseout
		$("#bubble").animate({ 
			top: "-70px",
			opacity: 0
		}, 250 );
		setTimeout("$('#bubble').hide();", 250);
		$("#bubble").animate({ 
			top: "-80px",
		}, 250 );
	});
	


	// SOCIAL ICONS HOVER

	$('#networks a').hover(function() {
		$('img', this).stop().animate({
			'marginLeft' : -5
		});
	}, function() {
		$('img', this).stop().animate({
			'marginLeft' : 5
		});
	});
	
	
	
	// CONTACT FORM 
		
	$('#contactform').ajaxForm({
	   	target: '#error',
	   	beforeSubmit: function() {
	   		$('#error').addClass('visible');
		},
		success: function() {
			$('#error p.loading').fadeOut();
			$('#error p').fadeIn('slow');
		}
	});

	// Pretty Box
	
			$(document).ready(function(){
			$("a[rel^='prettyPhoto']").prettyPhoto();
		});	
	
});	