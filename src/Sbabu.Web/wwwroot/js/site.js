jQuery(document).ready(function ($) {
    $(".validation-summary-errors").removeClass("validation-summary-errors");
    $(".input-validation-error").removeClass("input-validation-error").parent().addClass("has-error");
    $("input:text").addClass("form-control col-xs-9");
    $("select").addClass("form-control col-xs-9");
    $("textarea").addClass("form-control col-xs-9");
    $(":input[type='number']").addClass("form-control col-xs-9");
    $(":input[type='datetime']").addClass("form-control col-xs-9");
    $(":input[type='checkbox']").addClass("form-control col-xs-9");

    $(".scroll a, .navbar-brand, .gototop").click(function (event) {
        event.preventDefault();
        $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 600, 'swing');
        $(".scroll li").removeClass('active');
        $(this).parents('li').toggleClass('active');

    });
    $()
});