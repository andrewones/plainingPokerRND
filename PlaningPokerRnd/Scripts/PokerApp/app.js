(function () {
    'use strict';

    angular.module('pokerApp', ['common.core'])
        .config(['$routeProvider', function($routeProvider){}])
        .run(['$rootScope', '$http',  function ($rootScope, $http) { }]);
})();
