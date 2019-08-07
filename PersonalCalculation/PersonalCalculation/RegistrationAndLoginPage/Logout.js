$(document).ready(function () {

    if (localStorage.getItem('accessToken') == null) {
        var root = location.protocol + '//' + location.host;
        window.location.href = root + "/RegistrationAndLoginPage/RegisterAndLogin.aspx";
        //window.location.href = "http://localhost:49649/RegistrationAndLoginPage/RegisterAndLogin.aspx";
    }
    else {
        $('#spanUserName').text('Hello ' + localStorage.getItem('userName1') + ' !');
    }
    $('#btnLogoff').click(function () {
        localStorage.removeItem('accessToken');
        var root = location.protocol + '//' + location.host;
        window.location.href = root + "/RegistrationAndLoginPage/RegisterAndLogin.aspx";
        //window.location.href = "http://localhost:49649/RegistrationAndLoginPage/RegisterAndLogin.aspx";
    });
});