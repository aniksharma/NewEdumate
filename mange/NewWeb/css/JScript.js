$(function () {
    $('#navigation a').stop().animate({ 'marginLeft': '-160px' }, 1000);

    $('#navigation > li').hover(
                    function () {
                        $('a', $(this)).stop().animate({ 'marginLeft': '0px' }, 200);
                    },
                    function () {
                        $('a', $(this)).stop().animate({ 'marginLeft': '-160px' }, 200);
                    }
                );
});