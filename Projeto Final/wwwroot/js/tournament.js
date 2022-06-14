
var chosen = new Array();
var remainingChoices = 16;

function getId(id) {
    var card = document.getElementById(id);

    if (chosen.length < 16) {
        addChosen(id);
        card.style = "filter: grayscale(0);";
    }
    else {
        deleteChosen(id);
        card.style = "filter: grayscale(1);";
    }
}

function addChosen(id) {
    if (chosen.indexOf(id) == -1) {
        chosen.push(id);
        remainingChoices--;
    }
}

function deleteChosen(id) {
    if (chosen.indexOf(id) != -1) {
        chosen.splice(chosen.indexOf(id), 1);
        remainingChoices++;
    }
}

function sendChosenId() {
    var array = JSON.stringify(chosen.toString());
    return $.ajax({
        url: "/Tournament/Draft",
        type: 'POST',
        contentType: 'application/json',
        data: array,
        success: function (data) {
            window.location = data.url;
        }
    });
}

function startTournament() {
    if (remainingChoices == 0) {
        cardDisappear2();
        sendChosenId();
    } else {
        alert('Você não selecionou todos os competidores, restam ' + remainingChoices + ' escolha(s).');
    }
}

function cardDisappear2() {
    $(".align-div").fadeOut(1500, 0);
}