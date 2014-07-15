function ddlChkSelect(CtlID) {
    var ddl = document.getElementById(CtlID);
    document.getElementById(CtlID).style.visibility = "visible";
    return true;
}


(function ($) {
    $(function () {
        $("#scroller").simplyScroll({
            pauseOnTouch: true,
            pauseOnHover: false
        });
    });
})(jQuery);

//Live Traffic.
jQuery(document).ready(function() {

            jQuery('#mycarousel').jcarousel({

                vertical: true,

                auto: 2,

                scroll: 1,

                wrap: 'circular'

            });

        });


        
