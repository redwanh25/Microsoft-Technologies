var manageUserRoleApp = angular.module('manageUserRoleApp', ['LocalStorageModule', 'AuthApp']);


manageUserRoleApp.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

manageUserRoleApp.controller('manageUserRoleController', ['$scope', 'manageUserRoleService', function ($scope, manageUserRoleService) {

    $scope.init = function () {
        manageUserRoleService.GetAllUsers().then(function (response) {
            $scope.Users = response.data;
        }, function () {
            alert("Failed to recieve data.");
        });
    };

    $scope.init();

    $scope.GetRoles = function (user) {
        $scope.SelectedUser = angular.copy(user);
        $scope.selection = [];

        manageUserRoleService.GetAllRoles().then(function (response) {
            $scope.Roles = response.data;

            if ($scope.SelectedUser.Roles != null) {
                for (var i = 0; i < $scope.SelectedUser.Roles.length; i++) {
                    $scope.selection.push($scope.SelectedUser.Roles[i].RoleId)
                }
            }

        }, function () {
            alert("Failed");
        })
    }

    $scope.selection = [];
    // toggle selection for a given employee by name
    $scope.toggleSelection = function toggleSelection(roleId) {
        //alert(role);
        var idx = $scope.selection.indexOf(roleId);

        // is currently selected
        if (idx > -1) {
            $scope.selection.splice(idx, 1);
        }

            // is newly selected
        else {
            $scope.selection.push(roleId);
        };
        console.log($scope.selection);
    };

    $scope.UpdateUserRoles = function () {
        manageUserRoleService.AddUpdateToRoles($scope.SelectedUser.Id, $scope.selection).then(function () {
            $scope.init();
            alert("User roles added successfully.");
        }, function () {
            alert("Failed to add roles.Please try again.");
        });
    };

}]);


manageUserRoleApp.factory('manageUserRoleService', ['$http', function ($http) {

    var manageUserRoleServiceFactory = {};
    
    manageUserRoleServiceFactory.GetAllUsers = function () {
        return $http.get("/api/Users/GetAll")
    };
    manageUserRoleServiceFactory.GetAllRoles = function (userId) {
        return $http.get("/api/Roles/GetAll")
    };
    manageUserRoleServiceFactory.AddUpdateToRoles = function (userId, roles) {
        return $http.post("/api/AspNetUserRoles?userId=" + userId, roles)
    };

    return manageUserRoleServiceFactory;

}]);