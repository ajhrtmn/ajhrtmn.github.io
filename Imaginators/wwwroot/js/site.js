// function dragstart_handler(ev) {
//     ev.dataTransfer.setData("text/html", ev.target.id);
//     ev.dataTransfer.effectAllowed = "move";
// }

// function dragover_handler(ev) {
//     ev.preventDefault();
//     ev.dataTransfer.effectAllowed = "move";
// }

// function drop_handler(ev) {
//     ev.preventDefault();
//     var data = ev.dataTransfer.getData("text/html");
//     ev.dataTransfer.dropEffect = "move";
//     ev.target.appendChild(document.getElementById(data));
// }

window.GetWinW = () => {
    var w = window.innerWidth
    || document.documentElement.clientWidth
    || document.body.clientWidth;
    return w;
}

window.GetWinH = () => {
    var h = window.innerHeight
    || document.documentElement.clientHeight
    || document.body.clientHeight;
    return h;
}

