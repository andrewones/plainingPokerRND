(function (app) {
    "use strict";

    app.controller("planningPokerController", [
        "$scope", "apiService",
        function ($scope, apiService, $http) {

            

            (function (app) {
                'use strict';

                app.factory('apiService', [
                    '$http', '$location', '$rootScope',
                    function ($http, $location, $rootScope) {
                        var service = {
                            get: get,
                            post: post,
                            remove: remove
                        };

                        function get(url, config, success, failure) {
                            return $http.get(url, config)
                                .then(function (result) {
                                    success(result);
                                }, function (error) {
                                    if (error.status == '401') {
                                        $rootScope.previousState = $location.path();
                                        $location.path('/login');
                                    } else if (failure != null) {
                                        failure(error);
                                    }
                                });
                        }

                        function post(url, data, success, failure) {
                            return $http.post(url, data)
                                .then(function (result) {
                                    success(result);
                                }, function (error) {
                                    if (error.status == '401') {
                                        $rootScope.previousState = $location.path();
                                        $location.path('/login');
                                    } else if (failure != null) {
                                        failure(error);
                                    }
                                });
                        }

                        function remove(url, success, failure) {
                            return $http.delete(url)
                                .then(function (result) {
                                    success(result);
                                }, function (error) {
                                    if (error.status == '401') {
                                        $rootScope.previousState = $location.path();
                                        $location.path('/login');
                                    } else if (failure != null) {
                                        failure(error);
                                    }
                                });
                        }

                        return service;
                    }
                ]);

            })(angular.module('common.core'));
            $scope.joinRoom = function() {
                $http.get()
            };
        }
    ]);
})(angular.module("pokerApp"));
