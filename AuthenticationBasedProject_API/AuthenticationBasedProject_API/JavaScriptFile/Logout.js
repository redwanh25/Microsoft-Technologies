$(document).ready(function () {

    if (localStorage.getItem('accessToken') == null) {
        $('#btnLogoff').hide();
        $('#btnShowModal').show();
        $('#btnShowRegister').show();
        window.location.href = "http://localhost:50374/RegistrationAndLoginPage/WebForm1.aspx";
        //window.location.href = "http://localhost:50374/Home/Index";
    }
    else {
        $('#spanUserName').text('Hello ' + localStorage.getItem('userName') + ' !');
        $('#btnLogoff').show();
        $('#btnShowModal').hide();
        $('#btnShowRegister').hide();
    }
    $('#btnLogoff').click(function () {
        localStorage.removeItem('accessToken');
        $('#btnLogoff').hide();
        $('#btnShowModal').show();
        $('#btnShowRegister').show();
        $('#spanUserName').hide();
        window.location.href = "http://localhost:50374/RegistrationAndLoginPage/WebForm1.aspx";
        //window.location.href = "http://localhost:50374/Home/Index";
    });
});