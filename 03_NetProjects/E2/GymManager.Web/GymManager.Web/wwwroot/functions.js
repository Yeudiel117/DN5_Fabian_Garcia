

var myModal = new bootstrap.Modal(document.getElementById('myModal'), {});

var id = document.getElementById('id');

(function () {
    document.getElementById("register").addEventListener("click", function () {
        if (id.value != "") {

            showModal();

        } else {
            alert("An ID its required to do an entry");
        }
    });

    id.addEventListener("keypress", function (event) {

        if (event.key === "Enter") {
            if (id.value != "") {

                showModal();

            } else {
                alert("An ID its required to do a register");
            }
        }

    });

}());

function showModal() {
    var t = document.getElementById("showId");

    t.innerHTML = id.value;

    myModal.show();

    setTimeout(function () {
        myModal.hide();
    }, 3000);
}


        //var t = document.getElementById("showId");

        ////var currentHtml = t.innerHTML;

        //t.innerHTML += id.value;

        //myModal.show();

