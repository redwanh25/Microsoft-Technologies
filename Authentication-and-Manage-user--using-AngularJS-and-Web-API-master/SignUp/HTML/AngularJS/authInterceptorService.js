/// <reference path="angular.js" />

'use strict';

var AuthApp = angular.module('AuthApp',[]);

AuthApp.factory('authInterceptorService', ['$q', '$injector', '$window', 'localStorageService', function ($q, $injector, $window, localStorageService) {

    var authInterceptorServiceFactory = {};

    authInterceptorServiceFactory.request = function (config) {

        config.headers = config.headers || {};

        var authData = localStorageService.get('authorizationData');
        if (authData) {
            config.headers.Authorization = 'Bearer ' + authData.token;
        }

        return config;
    }

    authInterceptorServiceFactory.responseError = function (rejection) {
        if (rejection.status === 401) {
            var authService = $injector.get('authService');
            var authData = localStorageService.get('authorizationData');
            //authService.logOut();

        }
        return $q.reject(rejection);
    };

    return authInterceptorServiceFactory;

}]);


AuthApp.factory('authService', ['$http', '$q', 'localStorageService', function ($http, $q, localStorageService) {
    var authServiceFactory = {};

    var _authentication = {
        isAuth: false,
        userName: ""
    };

    authServiceFactory.saveRegistration = function (registration) {

        //authServiceFactory.logOut();

        return $http.post('/api/account/register', registration)
    };

    authServiceFactory.login = function (loginData) {

        var data = "grant_type=password&username=" + loginData.userName + "&password=" + loginData.password;

        var deferred = $q.defer();

        $http.post('/token', data, {
            header: { 'Content-Type': 'application/x-www-form-urlencoded' }
        }).success(function (response) {
            localStorageService.set('authorizationData', { token: response.access_token, userName: response.userName });

            _authentication.isAuth = true;
            _authentication.userName = loginData.userName;

            deferred.resolve(response);
        }).error(function (err) {
            //_logOut();
            deferred.reject(err);
        });

        return deferred.promise;
    };

    authServiceFactory.logOut = function () {

        localStorageService.remove('authorizationData');

        _authentication.isAuth = false;
        _authentication.userName = "";
    };

    authServiceFactory.fillAuthData = function () {
        var authData = localStorageService.get('authorizationData');
        if (authData) {
            _authentication.isAuth = true;
        }
        else {
            _authentication.isAuth = false;
        }
    };

    authServiceFactory.changePassword = function (passwordData) {

        return $http.post('/api/Manage/ChangePassword', passwordData)

    };

    return authServiceFactory;
}]);