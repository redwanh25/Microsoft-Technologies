

var forgotPasswordApp = angular.module('forgotPasswordApp',[]);

forgotPasswordApp.controller('forgotPasswordController', ['$scope', 'forgotPasswordService', function ($scope, forgotPasswordService) {

    $scope.forgotPassword = {
        Email: ""
    };

    $scope.ForgotPassword = function () {
        forgotPasswordService.forgotPassword($scope.forgotPassword).then(function () {
            $scope.message = "Please Check your Email to reset your password.";
        }, function () {
            alert("Something going wrong. Please try again...");
            $scope.message = "Something going wrong. Please try again...";
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

