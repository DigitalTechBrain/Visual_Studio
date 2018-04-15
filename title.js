var page = require('webpage').create();

var system = require("system");

page.open(system.args[1], function (status) {
	
	console.log('page title : ' + page.title);
	
	console.log('page.url: ' + page.url);
	
	phantom.exit();
	
});