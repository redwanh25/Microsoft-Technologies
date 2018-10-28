
$(document).ready(function () {
    //Close the bootstrap alert
    $('#linkClose').click(function () {
        $('#divError').hide('fade');
    });

    $('#successModal').on('hidden.bs.modal', function () {
        window.location.href = "Login.aspx";
    });

    // Save the new user details
    $('#btnRegister').click(function () {
        $.ajax({
            url: '/api/account/register',
            method: 'POST',
            data: {
                userName: $('#txtUserName').val(),
                phoneNumber: $('#txtPhoneNumber').val(),
                userSelfId: $('#dropDownUserSelfId option:selected').val(),
                email: $('#txtEmail').val(),
                password: $('#txtPassword').val(),
                confirmPassword: $('#txtConfirmPassword').val()
            },
            success: function () {
                $('#successModal').modal('show');
            },
            error: function (jqXHR) {
                $('#divErrorText').text(jqXHR.responseText);
                $('#divError').show('fade');
            }
        });
    });
});