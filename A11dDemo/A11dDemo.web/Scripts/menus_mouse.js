$(function () {
	$("li[data-level!='1']").addClass("hidden");
	$("li[data-level='1']").on("mouseover", function (e) {
		$("li[data-level!='1']").addClass("hidden");
		$(this).find("li").removeClass("hidden");
	});

});