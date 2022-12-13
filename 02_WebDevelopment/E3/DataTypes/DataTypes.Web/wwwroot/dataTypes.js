
function onButtonClick(evt) {
    ///////////////////////////
    var t = document.getElementById("sampleUl");

    var currentHtml = t.innerHTML;

    for (var i = 0; i < arrayCustomers.length; i++) {

        t.innerHTML += "<li>" + "Name: " + arrayCustomers[i].name + "Registration Date: " + arrayCustomers[i].date + "</li>";

    }
    //////////////////////////
}

var button = document.getElementById("arrayButton");

button.addEventListener("click", onButtonClick);

var date = new Date();

class Customers {
    constructor(name, date) {
        this.name = name;
        this.date = date;
    }
}

var arrayCustomers = [
    new Customers("Juancho ", date.toUTCString()),
    new Customers("Miguel ", date.toUTCString()),
    new Customers("Roberto ", date.toUTCString()),
    new Customers("Jason ", date.toUTCString()),
    new Customers("Maria ", date.toUTCString()),
    new Customers("Daniela ", date.toUTCString()),
    new Customers("Ramirez ", date.toUTCString()),
    new Customers("Jose ", date.toUTCString()),
    new Customers("Alberto ", date.toUTCString()),
    new Customers("Fernando ", date.toUTCString())
];


