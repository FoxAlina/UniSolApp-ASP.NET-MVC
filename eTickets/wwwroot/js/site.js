// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function offcanvas_open() {
    document.getElementById("offcanvas").className = "offcanvas offcanvas-start sidebar"
    document.getElementById("offcanvas").style.visibility = "visible";
    document.getElementById("backdrop").className = "modal-backdrop show"
    document.getElementById("backdrop").style.visibility = "visible";
}

function offcanvas_close() {
    document.getElementById("offcanvas").className = "offcanvas offcanvas-start sidebar"
    document.getElementById("offcanvas").style.visibility = "hidden";
    document.getElementById("backdrop").className = "modal-backdrop fade"
    document.getElementById("backdrop").style.visibility = "hidden";
}