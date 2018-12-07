
$(document).ready(function () {

    $('#btnLogin').click(function () {
        $.ajax({
            // Post username, password & the grant type to /token
            url: '/token',
            method: 'POST',
            contentType: 'application/json',
            data: {
                userName: $('#txtUserNameLogin').val(),
                password: $('#txtPasswordLogin').val(),
                grant_type: 'password'
            },

            success: function (response) {
                localStorage.setItem("accessToken", response.access_token);
                localStorage.setItem("userName", response.userName);

                window.location.href = "http://localhost:64491/Home/Index";
            },
            // Display errors if any in the Bootstrap alert <div>
            error: function (jqXHR) {
                swal("Login Failed!", "May Be Your Username Or Password Is Incorrect!", "error");
            }
        });
    });
});