/// <reference path="angular.js" />
var changePasswordApp = angular.module('changePasswordApp', ['LocalStorageModule', 'AuthApp']);

changePasswordApp.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
})

changePasswordApp.controller('changePasswordController', ['$scope', '$window', 'authService', function ($scope, $window, authService) {
    $scope.init = function () {
        $scope.isProcessing = false;
        $scope.SubmitBtnText = "Change Password";
    }

    $scope.init();

    $scope.Password = {
        OldPassword: "",
        NewPassword: "",
        ConfirmPassword:""
    }

    $scope.ChangePassword = function () {
        $scope.isProcessing = true;
        $scope.SubmitBtnText = "Please wait.....";

        authService.changePassword($scope.Password).then(function (response) {
            alert("Password Changed Successfully");
            $scope.init();
        }, function () {
            alert("Failed.Please try again.");
            $scope.init();
        })
    }

}])