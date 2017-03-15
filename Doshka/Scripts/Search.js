var SearchHelper = function() {
    var search = {
        OnClick: function() {
            $("#search-field").val("");
        }
    };

    return search;
}();

var SearchHider = jQuery(function ($) {
    $(document).mouseup(function (e) {
        var div = $("#search-field"); 
        if (!div.is(e.target) 
		    && div.has(e.target).length === 0) { 
            div.val("Search..."); 
        }
    });
});