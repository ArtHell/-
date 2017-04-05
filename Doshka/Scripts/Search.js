var searchAction = function() {
    $("#search-field,#min-price,#max-price").keyup(function (event) {
        if (event.keyCode === 13) {
            search(event);
        }
    });
}

var search = function(event) {
    var searchQuery = $('#search-field').val();
    var minPriceQuery = $('#min-price').val();
    var maxPriceQuery = $('#max-price').val();
    var typeQuery = $('#type').val();
    $.ajax({
        type: 'POST',
        url: '/Ads/RenderAds',
        data: { "searchString": searchQuery, "minPrice": minPriceQuery, "maxPrice": maxPriceQuery, "type": typeQuery },
        success: function (data, textstatus) {
            if (data !== '') {
                $("#body-id").html(data);
                $('#min-price').val(minPriceQuery);
                $('#max-price').val(maxPriceQuery);
                $('#type').val(typeQuery);
            }
        }
    });
}