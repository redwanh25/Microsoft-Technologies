$(document).ready(function () {

    if (localStorage.getItem('accessToken') == null) {
        window.location.href = "http://localhost:64491/RegistrationAndLoginPage/RegisterAndLogin.aspx";
    }
    else {
        $('#spanUserName').text('Hello ' + localStorage.getItem('userName') + ' !');
    }
    $('#btnLogoff').click(function () {
        localStorage.removeItem('accessToken');
        window.location.href = "http://localhost:64491/RegistrationAndLoginPage/RegisterAndLogin.aspx";
    });
});