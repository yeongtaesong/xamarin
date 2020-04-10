/*
  SoftChalk mobile js
	
	Peter adjusted -> May 26, 2011
	Donny adjusted -> June 10, 2011
*/

$(function(){
	$('a.TOC').click(function(){
        $(this).toggleClass('TOCA');
        $('#navtoc').toggle();
        
        if ($('#navtoc').is(":visible")) {
            $(this).html('<img src="images/nav_contract_button.png" width="29" height="25" alt="Hide TOC">');
        }
        else {
            $(this).html('<img src="images/nav_expand_button.png" width="29" height="25" alt="Show TOC">');
        }
	});
	
	$('a.less').click(function(){
		$('#banner').toggle();
        if (jQuery.store) {
            bannerPrefNow = jQuery.store.get('bannerPref');
            bannerPrefNow == 1 ? jQuery.store.set('bannerPref', 0): jQuery.store.set('bannerPref', 1);
        }
        
        if ($('#banner').is(":visible")) {
            $(this).html('<img src="images/nav_hide_button.png" width="29" height="25" alt="Hide">');
        }
        else {
            $(this).html('<img src="images/nav_show_button.png" width="29" height="25" alt="Show">');
        }

    	return false;
	});

	//$('p:has("img[src="ada-activity.gif"]")').replaceWith("<p class='mediaerror'>Media element not available on mobile.</p>");
	//$('#report').replaceWith("<p class='mediaerror'>Reporting features not available on mobile.</p>");
	
    if (jQuery.store) {
        bannerPrefNow = jQuery.store.get('bannerPref');
    }
    else {
        bannerPrefNow = undefined;
    }
	if(bannerPrefNow == undefined){
		bannerPrefNow = 1;
	}
	
	if(bannerPrefNow == 0){
		$('#banner').toggle();
		$('a.less').html('<img src="images/nav_show_button.png" width="29" height="25" alt="Show">');
	}else{
		$('a.less').html('<img src="images/nav_hide_button.png" width="29" height="25" alt="Hide">');
	}
	
});
