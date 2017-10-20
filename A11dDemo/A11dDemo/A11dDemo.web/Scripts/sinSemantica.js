$(function () {
	$("html").on("click", ".btn-link", function (e) {
		alert("¡He pulsado el no-botón!");
	});
	$("html").on("click", "#btnEnviar", function (e) {
		alert("¡Voy a enviar el formulario!");
	});
});
