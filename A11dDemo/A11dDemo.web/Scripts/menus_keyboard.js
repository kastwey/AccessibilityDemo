$(function () {
	$("li[data-level!='1']").addClass("hidden");
	$("li[data-level='1']").attr("aria-expanded", "false")
	.attr("role", "link")
	.attr("tabindex", "0");
	$("li[data-level='1']").on("mouseover", function (e) {
		expandMenu($(this));
	});
	$("li[data-level='1']").on("click", function (e) {
		if ($(this).attr("aria-expanded") == "true")
		{
			collapseMenu($(this));
		}
		else
		{
			expandMenu($(this));
		}
	});
});

function expandMenu($menuItem)
{
	$("li[data-level!='1']").addClass("hidden");
	$("li[data-level='1']").attr("aria-expanded", "false");
	$menuItem.find("li").removeClass("hidden")
	$menuItem.attr("aria-expanded", "true");
}


function collapseMenu($menuItem)
{
	$menuItem.find("li").addClass("hidden")
	$menuItem.attr("aria-expanded", "false");
}


