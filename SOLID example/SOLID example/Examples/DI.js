﻿
var jqxhr = $.ajax( "example.php" )
    .done(function() {
        alert( "success" );
    })
    .fail(function() {
        alert( "error" );
    })
    .always(function() {
        alert( "complete" );
    });

// Perform other work here ...

// Set another completion function for the request above
jqxhr.always(function() {
    alert( "second complete" );
});




var ajaxProxy  = function (options) {

    //modify request, add header or tag do it for every request

    return $.ajax(options);
};
    
