$(document).ready(function () {
    $("#frmJS").submit(function () {
        var PatronNombProd = "[0-9a-zA-Z\\s_-]{3,50}";
        var ElemProd = $("#CodProducto").val();
        var valDatos = String(ElemProd).search(PatronNombProd);
        if (valDatos) {
            alert("Datos no completos");
        }
    });
});