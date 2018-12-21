

var forgotPasswordApp = angular.module('forgotPasswordApp',[]);

forgotPasswordApp.controller('forgotPasswordController', ['$scope', 'forgotPasswordService', function ($scope, forgotPasswordService) {

    $scope.forgotPassword = {
        Email: ""
    };

    $scope.ForgotPassword = function () {
        forgotPasswordService.forgotPassword($scope.forgotPassword).then(function () {
            //$scope.message = "Please Check your Email to reset your password.";
            //alert("Please Check your Email to reset your password.");
            swal("Email has been sent!", "Please check your Email. We have sent you a ResetLink. click there and Reset your password!. Thank you!", "success");
        }, function () {
            //alert("Something going wrong. Please try again...");
            //$scope.message = "Something going wrong. Please try again...";
            swal("Error!", "Please provide a valid Email ID!", "error");
        });
    };

}]);

forgotPasswordApp.factory('forgotPasswordService', ['$http', function ($http) {

    var fac = {};

    fac.forgotPassword = function (forgotPasswordData) {
        return $http.post('/api/Account/ForgotPassword', forgotPasswordData);
    };

    return fac;

}]);

