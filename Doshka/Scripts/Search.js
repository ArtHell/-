var searchAction = function() {
    $("#search-field,#min-price,#max-price").keyup(function (event) {
        if (event.keyCode === 13) {
            search(event);
        }
    });
}

var search = function (event) {

    var searchQuery = $('#search-field').val();
    var minPriceQuery = $('#min-price').val();
    var maxPriceQuery = $('#max-price').val();
    var typeQuery = $('#type').val();
    var categoryQuery = $('#category').val();
    var subCategoryQuery = $('#subcategory').val();

    if (typeQuery === "Sale" && searchQuery !== undefined) {
        $('#min-price').show();
        $('#max-price').show();
    } else {
        $('#min-price').hide();
        $('#max-price').hide();
    }

    $.ajax({
        type: 'POST',
        url: '/Ads/RenderAds',
        data: {
            "searchString": searchQuery, "minPrice": minPriceQuery, "maxPrice": maxPriceQuery,
            "type": typeQuery, "category": categoryQuery, "subCategory": subCategoryQuery
        },
        success: function (data, textstatus) {
            if (data !== '') {
                $("#body-id").html(data);
                $('#min-price').val(minPriceQuery);
                $('#max-price').val(maxPriceQuery);
                $('#category').val(categoryQuery);
                $('#subcategory').val(subCategoryQuery);
                if (typeQuery === "Sale") {
                    $('#min-price').show();
                    $('#max-price').show();
                } else {
                    $('#min-price').hide();
                    $('#max-price').hide();
                }
                if (typeQuery !== undefined) {
                    $('#type').val(typeQuery);
                }
            }
        }
    });
}

var getSubCategoriesCreate = function(event) {
    var categoryQuery = $('#category-create').val();
    $.ajax({
        type: 'POST',
        url: '/SubCategories/GetSubCategories',
        data: { "categoryName": categoryQuery },
        success: function (data, textstatus) {
            var target = $('#subcategory-create').selectpicker();
            target.empty();
            for (var i = 0; i < data.length; i++) {
                var newitemnum = i;
                var newitemdesc = data[i].Name;
                target.append('<option value="' + newitemdesc + '" selected="">' + newitemdesc + '</option>');
                target.selectpicker("refresh");
            }
        }
    });
}