var iContardor = 3;
function fAgregar() {
    var elemlista = document.createElement("li");
    var objlista = document.getElementById("lista");
    elemlista.innerText = "Valor" + iContardor.toString();
    objlista.appendChild(elemlista);

    iContardor = iContardor+1;
    return;
}