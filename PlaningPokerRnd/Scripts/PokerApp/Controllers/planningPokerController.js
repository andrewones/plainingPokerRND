(function (app) {
    "use strict";

    app.controller("planningPokerController", [
        "$scope", "apiService",
        function ($scope, apiService) {

            function loadData() {
                apiService.get(application.config().getApiUrl("Poker/Rooms/"), null,
                    loadCompleted,
                    loadFailed);
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
        }
    ]);
})(angular.module("pokerApp"));
