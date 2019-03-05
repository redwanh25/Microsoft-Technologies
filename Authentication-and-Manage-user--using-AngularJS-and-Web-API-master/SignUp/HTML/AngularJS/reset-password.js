
var resetPasswordApp = angular.module('resetPasswordApp',[]);

resetPasswordApp.controller('resetPasswordController', ['$scope', '$window','$location','resetPasswordService', function ($scope,$window,$location,resetPasswordService) {


    $scope.ResetPassword = {
        Email: "",
        Password: "",
        ConfirmPassword: "",
        code: ""
    }

    var parseLocation = function (location) {
        var pairs = location.substring(1).split("&");
        var obj = {};
        var pair;
        var i;

        for (i in pairs) {
            if (pairs[i] === "") continue;

            pair = pairs[i].split("=");
            obj[decodeURIComponent(pair[0])] = decodeURIComponent(pair[1]);
        }

        return obj;
    };

    $scope.ResetPassword.code = parseLocation(window.location.search)['code'];
    //console.log(x);

    $scope.ChangePassword = function () {

        resetPasswordService.resetPassword($scope.ResetPassword).then(function (response) {
            alert("Password Changed Successfully");
            $window.location.href = "/User/login";

        }, function () {
            alert("Failed.Please try again.");
        })
    }

}])

resetPasswordApp.factory('resetPasswordService', ['$http', function ($http) {

    var fac = {};

    fac.resetPassword = function (resetPasswordData) {
        return $http.post('/api/Account/ResetPassword', resetPasswordData)
    };

    return fac;

}])