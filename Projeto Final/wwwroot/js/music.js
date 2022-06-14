
function ctrlMusic() {
    let music = document.getElementById("music");
    let image = document.getElementById("imageId")
    let mySrc = image.getAttribute('src');

    music.volume = "0.1"

    if (mySrc == "/media/images/play.png") {
        music.play();
        image.setAttribute('src', '/media/images/pause.png')
    }
    else {
        music.pause();
        image.setAttribute('src', '/media/images/play.png')
    }
}