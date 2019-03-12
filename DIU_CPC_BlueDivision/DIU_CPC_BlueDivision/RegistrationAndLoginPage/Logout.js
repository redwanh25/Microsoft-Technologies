$(document).ready(function () {

    if (localStorage.getItem('accessToken') == null) {
        var root = location.protocol + '//' + location.host;
        window.location.href = root + "/RegistrationAndLoginPage/RegisterAndLogin.aspx";
        //window.location.href = "http://localhost:50120/RegistrationAndLoginPage/RegisterAndLogin.aspx";
    }
    else {
        $('#spanUserName').text('Hello ' + localStorage.getItem('userName') + ' !');
    }
    $('#btnLogoff').click(function () {
        localStorage.removeItem('accessToken');
        var root = location.protocol + '//' + location.host;
        window.location.href = root + "/RegistrationAndLoginPage/RegisterAndLogin.aspx";
        //window.location.href = "http://localhost:50120/RegistrationAndLoginPage/RegisterAndLogin.aspx";
    });
});