function PasswordToggle() {

    var x = document.getElementById("myTypedPassword");

    if (x.type == "password") {
        x.type = "text";
    }
    else {
        x.type = "password";
    }

}