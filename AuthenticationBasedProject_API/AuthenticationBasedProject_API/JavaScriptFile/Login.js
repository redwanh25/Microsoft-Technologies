
$(document).ready(function () {

    $('#linkClose').click(function () {
        $('#divError').hide('fade');
    });

    $('#btnShowRegister').click(function () {
        window.location.href = "http://localhost:50374/RegistrationAndLoginPage/Register.aspx";

    });

    $('#btnShowModal').click(function () {
        $('#loginModal').modal('show');
    })
    $('#btnHideModal').click(function () {
        $('#loginModal').modal('hide');
    });
    $('#login').click(function () {
        swal("Good job!", "You clicked the button!", "success");
        $('#loginModal').modal('hide');
    });

    $('#btnLogin').click(function () {
        $.ajax({
            // Post username, password & the grant type to /token
            url: '/token',
            method: 'POST',
            contentType: 'application/json',
            data: {
                userName: $('#txtUserName').val(),
                password: $('#txtPassword').val(),
                grant_type: 'password'
            },

            success: function (response) {
                localStorage.setItem("accessToken", response.access_token);
                localStorage.setItem("userName", response.userName);

                window.location.href = "http://localhost:50374/Home/Index";
            },
            // Display errors if any in the Bootstrap alert <div>
            error: function (jqXHR) {
                $('#divErrorText').text(jqXHR.responseText);
                $('#divError').show('fade');
            }
        });
    });
});