$(document).ready(function () {
    $(".start-button").click(function () {
        let music = document.getElementById("startSound");
        music.play();
        setTimeout("start()", 4300);
    });
});

function start() {
    $("#videoBackground").fadeOut(2500);
    $(".start-button").fadeOut(2500);
};