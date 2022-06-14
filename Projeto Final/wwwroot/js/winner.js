
function cardWinnerAppear() {
    $(".align-div").fadeTo(2000, 1);
    timeOut();
};

function timeOut() {
    setTimeout(function () {
        $(".winner-card-div").fadeTo(2000, 1);
    }
        , 2000);
    setTimeout(function() {
        $(".return-start").fadeTo(1400, 1);
    }
        , 4000);
}
