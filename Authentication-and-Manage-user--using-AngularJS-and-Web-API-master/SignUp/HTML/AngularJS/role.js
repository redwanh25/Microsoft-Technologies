/// <reference path="angular.js" />
var manageRoleApp = angular.module('manageRoleApp', ['LocalStorageModule','AuthApp']);

manageRoleApp.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});


manageRoleApp.controller('manageRoleController', ['$scope', 'manageRoleService', function ($scope, manageRoleService) {

    $scope.init = function () {
        manageRoleService.GetAllRoles().then(function (response) {
            $scope.Roles = response.data;
        }, function () {
            alert("Failed!");
        })
    }

    $scope.init();

    $scope.createRole = function () {
        manageRoleService.CreateRole($scope.RoleName).then(function () {
            $scope.init();
        }, function () {
            alert("Failed to Create");
        })
    }

    $scope.DeleteRole = function (Id) {
        manageRoleService.DeleteRole(Id).then(function () {

            alert("Deleted");
            $scope.init();

        }, function () {
            alert("Failed to Delete.Try Again");
        })
    }


}])

manageRoleApp.factory('manageRoleService', ['$http', function ($http) {

    var manageRoleAppfactory = {};

    manageRoleAppfactory.GetAllRoles = function () {
        return $http.get('/api/AspNetRoles')
    }

    manageRoleAppfactory.CreateRole = function (newRoleName) {
        return $http.post('/api/AspNetRoles?Name='+newRoleName)
    }

    manageRoleAppfactory.DeleteRole = function (Id) {
        return $http.delete('/api/AspNetRoles/'+Id)
    }

    return manageRoleAppfactory;

}])