$(document).ready(function () {
    jQuery('#mycarousel-1').jcarousel({
        horisontal: true,
        wrap: 'circular',
        scroll: 1,
        easing: 'easeInOutBack',
        animation: 1200
    });
    $("a.plus").fancybox({
        'transitionIn': 'elastic',
        'transitionOut': 'elastic',
        'speedIn': 600,
        'speedOut': 200,
        'overlayShow': true
    })
});