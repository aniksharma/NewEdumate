 <script type="text/javascript">
            $(function() {
                $('#navigation a').stop().animate({'marginLeft':'-100px'},1000);

                $('#navigation > li').hover(
                    function () {
                        $('a',$(this)).stop().animate({'marginLeft':'0px'},200);
                    },
                    function () {
                        $('a',$(this)).stop().animate({'marginLeft':'-100px'},200);
                    }
                );
            });
        </script>