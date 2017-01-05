﻿'use strict';

angular.module('mediaApp.ingestTelemetryView', [])

.controller('ingestController', ['$scope', '$http', '$interval', 'APP_CONFIG', 'params',
    function ($scope, $http, $interval, APP_CONFIG, params) {

        $scope.channel = params.channel;
        $scope.account = params.account;
    refreshView();
    $scope.refreshViewCount = 1;
    var timer = $interval(refreshView, APP_CONFIG.REFRESH_TIME);
    $scope.$on("modal.closing", function () {
        $interval.cancel(timer);
    });

    function refreshView() {
        $scope.refreshViewCount = $scope.refreshViewCount + 1;
        var url = getIngestUrl();

        $http.get(url).success(function (data) {
            $scope.metricGroups = data;
            $scope.lastRefreshTime = new Date();
        }).error(function (data) {
            $scope.error = data;
        });
    }

    function getIngestUrl() {
        return APP_CONFIG.apiUrl + "/Accounts/" + $scope.account.Name + "/ingestTelemetry/" + $scope.channel.Id;
    }
    
}]);