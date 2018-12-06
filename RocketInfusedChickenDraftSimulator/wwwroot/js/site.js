(function RocketInfused() {

    getRavnicaBooster();
    var allCards = document.getElementById('current-pack').getElementsByClassName('mtg-card');

    for (var i = 0; i < allCards.length; i++) {
        allCards[i].addEventListener('mouseover', onHover);
        allCards[i].addEventListener('click', onClick);
    }

    function onHover(event) {
        document.getElementsByClassName('mtg-preview')[0].src = this.src;
    }

    function onClick(event) {
        var cardList = document.getElementById('user-deck').getElementsByClassName('card-list')[0];
        this.removeEventListener('click', onClick);
        cardList.appendChild(this);
    }

    function getRavnicaBooster() {
        var url = 'http://api.magicthegathering.io/v1/sets/GRN/booster';

        //fetch(url, { 
        //    method: 'GET', 
        //    headers: { 'content-type': 'application/json' } 
        //})
        //    .then(function (response) {
        //        console.log(response)
        //    })

        //var xmlHttp = new XMLHttpRequest();
        //xmlHttp.open('GET', url, false);
        //xmlHttp.withCredentials = true;
        //xmlHttp.setRequestHeader("Content-Type", "application/json");
        //xmlHttp.send(null);

        //var result = xmlHttp.responseText;
    }
}());