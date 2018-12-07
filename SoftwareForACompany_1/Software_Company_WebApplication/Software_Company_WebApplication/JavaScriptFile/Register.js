
$(document).ready(function () {
    //Close the bootstrap alert
    $('#linkCloseRegister').click(function () {
        $('#divErrorRegister').hide('fade');
    });

    $('#successModal').on('hidden.bs.modal', function () {
        //window.location.href = "Login.aspx";
    });

    // Save the new user details
    $('#btnRegister').click(function () {
        if ($('#textEmployeeCode').val() === "1234_U1" || $('#textEmployeeCode').val() === "1234_U2") {
            $.ajax({
                url: '/api/account/register',
                method: 'POST',
                data: {
                    userName: $('#txtUserName').val(),
                    phoneNumber: $('#txtPhoneNumber').val(),
                    employeeCode: $('#textEmployeeCode').val(),
                    email: $('#txtEmail').val(),
                    password: $('#txtPassword').val(),
                    confirmPassword: $('#txtConfirmPassword').val()
                },
                success: function () {
                    swal("Registration Successful!", "Thank You For Registration. Now You Can Login.", "success");
                    $('#divErrorRegister').hide();
                },
                error: function (jqXHR) {
                    $('#divErrorTextRegister').text(jqXHR.responseText);
                    $('#divErrorRegister').show('fade');
                }
            });
        }
        else {
            $('#divErrorTextRegister').text("Please Enter A Valid EmployeeCode");
            $('#divErrorRegister').show('fade');
        }
        
    });
});