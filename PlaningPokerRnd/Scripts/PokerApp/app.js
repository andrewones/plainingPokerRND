(function () {
    'use strict';

    angular.module('catalogApp', ['common.core', 'slick'])
        .config(['$routeProvider', '$locationProvider', function($routeProvider, $locationProvider){}])
        .run(['$rootScope', '$location', '$http',  function ($rootScope, $location, $http) { }]);
})();
