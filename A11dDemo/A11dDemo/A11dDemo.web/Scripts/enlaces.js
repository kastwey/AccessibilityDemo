$(function() {
	$(".danger").on("click", function(e) {
		$.playSound("/sounds/explosion");
		$("body").empty()
		.html("<h1 class=\"danger\">" + resources.Explosion + "</hcaracter1>");
	});
});