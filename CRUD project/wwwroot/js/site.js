// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function myFunction() {
    var x = document.getElementById("password");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

function newFunction() {
    var x = document.getElementById("Retype_password");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}
