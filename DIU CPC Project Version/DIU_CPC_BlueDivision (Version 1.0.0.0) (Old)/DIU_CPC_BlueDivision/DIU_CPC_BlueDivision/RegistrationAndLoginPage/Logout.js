$(document).ready(function () {

    if (localStorage.getItem('accessTokenForDIU_CPC_BlueDivision') == null) {
        var root = location.protocol + '//' + location.host;
        window.location.href = root + "/RegistrationAndLoginPage/RegisterAndLogin.aspx";
        //window.location.href = "http://localhost:50120/RegistrationAndLoginPage/RegisterAndLogin.aspx";
    }
    else {
        $('#spanUserName').text('Hello ' + localStorage.getItem('userName1') + ' !');
    }
    $('#btnLogoff').click(function () {
        localStorage.removeItem('accessTokenForDIU_CPC_BlueDivision');
        var root = location.protocol + '//' + location.host;
        window.location.href = root + "/RegistrationAndLoginPage/RegisterAndLogin.aspx";
        //window.location.href = "http://localhost:50120/RegistrationAndLoginPage/RegisterAndLogin.aspx";
    });
});