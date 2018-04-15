var page = require('webpage').create();
 
var system = require("system");
 
 page.open("https://login.yahoo.com/", function (status) {
   
    page.includeJs('https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js', function () {
   
       
        page.onLoadFinished = function () {
           
           page.render("submit_Password.png");
		    phantom.exit();
           
        };
		
		
             
        page.evaluate(function () {
           
            $("#login-username").val("letsexplorebrain");
            $("#login-signin").click();
        });
       
        page.render("submit_UserName.png");
		
		page.evaluate(function () {
           
            $("#login-passwd").val("testing@123");
            $("#login-signin").click();
        });
       
          
    });
     
});
