$(function () {
    $(".slider").slick({
        autoplay: false,
        dots: true,
        arrows: false,

        customPaging: function (slider, i) {
            var thumb = $(slider.$slides[i]).data('thumb');
            return '<a><img src="' + thumb + '"></a>';
        },
    });
})
       