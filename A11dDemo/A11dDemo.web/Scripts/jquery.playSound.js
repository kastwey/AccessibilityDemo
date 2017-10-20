/**
 * @author Alexander Manzyuk <admsev@gmail.com>
 * Copyright (c) 2012 Alexander Manzyuk - released under MIT License
 * https://github.com/admsev/jquery-play-sound
 * Usage: $.playSound('http://example.org/sound');
**/

(function ($) {

	$.extend({
		playSound: function () {
			var audio = new Audio(arguments[0] + ".mp3");
			audio.play();
		}
	});

})(jQuery);
