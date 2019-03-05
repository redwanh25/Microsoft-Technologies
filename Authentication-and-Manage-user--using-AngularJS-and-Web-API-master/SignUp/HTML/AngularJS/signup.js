'use strict';
var signUpApp = angular.module('signUpApp', []);

signUpApp.controller('signupController', ['$scope', '$window', 'signUpService',
function ($scope, $window, signUpService) {

    $scope.init = function () {
        $scope.isProcessing = false;
        $scope.RegisterBtnText = "Register";
    };

    $scope.init();

    $scope.registration = {
        Email: "",
        Password: "",
        ConfirmPassword: ""
    };

    $scope.signUp = function () {
        $scope.isProcessing = true;
        $scope.RegisterBtnText = "Please wait...";
        signUpService.saveRegistration($scope.registration).then(function (response) {
            alert("Registration Successfully Completed. Please sign in to Continue.");
            $window.location.href = "login.html";
        }, function () {
            alert("Error occured. Please try again.");
            $scope.isProcessing = false;
            $scope.RegisterBtnText = "Register";
        });
    };

}]);

signUpApp.factory('signUpService', ['$http', function ($http) {

    var signUpServiceFactory = {};

    signUpServiceFactory.saveRegistration = function (registration) {
        return $http.post('/api/account/register', registration)
    };

    return signUpServiceFactory;
}]);