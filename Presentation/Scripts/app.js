$(document).on('ready', function (e) {
    $("#menu-toggle").on('click', function (e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");
    });
});