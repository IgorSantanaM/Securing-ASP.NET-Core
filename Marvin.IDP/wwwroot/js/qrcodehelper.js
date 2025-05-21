window.addEventListener("load", function () {
    var keyUri = document.getElementById("grCodeKeyUri");
    new QRCode(document.getElementById("qrCode"),
        {
            text: keyUri.innerText,
            width: 150,
            height: 150
        });
});