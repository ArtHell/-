var Search = function(e) {
    var searchQuery = $('#search-field').val();
    var minPriceQuery = $('#min-price').val();
    var maxPriceQuery = $('#max-price').val();
    var typeQuery = $('#type').val();
    $.ajax({
        type: 'POST',
        url: '/Ads/RenderAds',
        data: { "searchString": searchQuery, "minPrice": minPriceQuery, "maxPrice": maxPriceQuery, "type": typeQuery },
        success: function (data, textstatus) {
            if (data != '') {
                $("#body-id").html(data);
            }
        }
    });
}