/// <reference path="angular.js" />
var UserApp = angular.module('UserApp', ['LocalStorageModule', 'AuthApp']);

UserApp.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

UserApp.controller('UserController', ['$scope', 'UserService', function ($scope,UserService) {

    $scope.init = function () {
        UserService.GetAllUser().then(function (response) {
            $scope.Users = response.data;
        }, function () {
            alert("Failed.");
        })
    }

    $scope.init();

    $scope.ViewUser = function (user) {
        $scope.viewUser = angular.copy(user);
    }

    $scope.DeleteUser = function (Id) {
        UserService.DeleteUser(Id).then(function () {
            alert("Deleted Successfully.");
            $scope.init();
        }, function () {
            alert("Failed");
        })
    }


}])

UserApp.factory('UserService', ['$http', function ($http) {

    var fac = {};

    fac.GetAllUser = function () {
        return $http.get('/api/AspNetUsers')
    }

    fac.DeleteUser = function (Id) {
        return $http.delete('/api/AspNetUsers/'+Id)
    }

    return fac;

}])