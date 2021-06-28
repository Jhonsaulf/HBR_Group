﻿//Validation for Login Page//
function RequestLogin() {
    var usertxt = document.getElementById("userbox").value;
    var passtxt = document.getElementById("passbox").value;
    if (usertxt.length == 0 || passtxt.length == 0) {
        window.alert("Empty fields");
    }
}

//Validation for Register Page//
function RequestRegister() {
    var nametxt = document.getElementById("nametxt").value;
    var passtxt = document.getElementById("passtxt").value;
    var usertxt = document.getElementById("usertxt").value;
    var lastnametxt = document.getElementById("lastnametxt").value;
    if (usertxt.length == 0 || passtxt.length == 0 || nametxt.length == 0 || lastnametxt.length == 0 ) {
        window.alert("Empty fields");
    }
}

//Validation for new category//
function RequestNewCategory() {
    var categorybox = document.getElementById("categorybox").value;
    var descbox = document.getElementById("descbox").value;
    if (categorybox.length == 0 || descbox.length == 0) {
        window.alert("Empty fields");
    }
}

//Validation for new product//
function RequestNewProduct() {
    var nameproductbox = document.getElementById("nameproductbox").value;
    var priceproductbox = document.getElementById("priceproductbox").value;
    var listview = document.getElementById("listview").value;
    if (nameproductbox.length == 0 || priceproductbox.length == 0 || listview.length == 0) {
        window.alert("Empty fields");
    }
}

//Validation for edit product//
function RequestForEditProduct() {
    var nombretxt = document.getElementById("nombretxt").value;
    var preciotxt = document.getElementById("preciotxt").value;
    var listview = document.getElementById("listview").value;
    if (nombretxt.length == 0 || preciotxt.length == 0 || listview.length == 0) {
        window.alert("Empty fields");
    }
}

//Validation for edit user//
function RequestEditUser() {
    var username = document.getElementById("username").value;
    var nameuser = document.getElementById("nameuser").value;
    var lastuser = document.getElementById("lastuser").value;
    var passuser = document.getElementById("passuser").value;
    if (username.length == 0 || nameuser.length == 0 || lastuser.length == 0 || passuser.length == 0 ) {
        window.alert("Empty fields");
    }
}