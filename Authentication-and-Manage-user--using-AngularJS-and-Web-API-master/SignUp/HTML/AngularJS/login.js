/// <reference path="angular.js" />
var loginApp = angular.module('loginApp', ['LocalStorageModule', 'AuthApp']);

loginApp.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
})

//loginApp.run(['authService', function (authService) {
//    authService.fillAuthData();
//}])

loginApp.controller('loginController', ['$scope', '$window', 'authService', function ($scope, $window, authService) {
    $scope.init = function () {
        $scope.isProcessing = false;
        $scope.LoginBtnText = "Sign In";
    }

    $scope.init();

    $scope.loginData = {
        userName: "",
        password:""
    }

    $scope.Login = function () {
        $scope.isProcessing = true;
        $scope.LoginBtnText = "Signing in.....";

        authService.login($scope.loginData).then(function (response) {
            alert("Login Successfully");
            $window.location.href = "user.html";
        }, function () {
            alert("Failed.Please try again.");
            $scope.init();
        })
    }

}])