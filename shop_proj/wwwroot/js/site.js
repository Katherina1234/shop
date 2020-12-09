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
    $('#sex').change(function () {
        var id = $(this).val();
        $.ajax({
            type: 'GET',
            url: 'GetCategories/' + id,
            success: function (data) {
                $('#categories').replaceWith(data);
            }
        });
    });
    $('#category').change(function () {
        var id = $(this).val();
       
        $.ajax({
            type: 'GET',
            url: 'GetModells/' + id,
            success: function (data) {
              
                $('#modells').replaceWith(data);
            }
        });
    });




})
       