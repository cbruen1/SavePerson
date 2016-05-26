//$(document.documentElement).on("click", "span.item-display", function (event) {
//    $(event.currentTarget)
//        .hide()
//        .next("span.item-field")
//        .show()
//        .find(":input:first")
//        .focus()
//        .select();
//});

$(document).ready(function () { 
    $("#btn-show").click(function () {
        $(".item-panel").show();
    });
    $("#btn-save").click(function () {
        $(".item-panel").hide();
    });
});//