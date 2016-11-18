(function (app) {
    "use strict";

    app.controller("planningPokerController", [
        "$scope", "apiService", "$http",
        function ($scope, apiService, $http) {

            

            function loadData() {

                $http.get("api/Poker/Rooms/")
                    .then(function (result) {
                        $scope.rooms = result.data;
                        console.log(resul.data);
                    });
            }

            function loadCompleted(result) {
                $scope.data = result.data;
                $scope.origmodel = angular.copy(result.data);
                $scope.loading = false;
            }

            function loadFailed() {
                return;
            }

            loadData();
              
            $scope.joinRoom = function() {
                $http.get();
            };
        }
    ]);
})(angular.module("pokerApp"));
