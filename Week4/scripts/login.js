function login_validate() {
    
    // Email and Password Validation
    document.getElementById('login_email_error').style.visibility = "hidden";
    document.getElementById('login_password_error').style.visibility = "hidden";

    let email = document.getElementById('login_email').value;
    let password = document.getElementById('login_password').value;
    var emailformat = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

    //console.debug('Email: ' + email);
    //console.debug('Password: ' + password);

    if (!email.match(emailformat)) {
        document.getElementById('login_email_error').style.visibility = "visible";
    }

    if (password == '') {
        document.getElementById('login_password_error').style.visibility = "visible";
    }

    // Login cookie
    var currentTime = new Date();
    currentTime.setDate(currentTime.getDate() + 30);
    expireTime = currentTime.toUTCString();
    document.cookie = "useremail=${email}; expires=" + expireTime + "; path=/";

    //console.debug('Cookie Expire Time: ' + expireTime);
}