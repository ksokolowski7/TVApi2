﻿'use strict';
app.controller('moviesController', ['$scope', '$location', 'moviesService', function ($scope, $location, moviesService) {

    $scope.movies = [];

    moviesService.getPopularMovies().then(function (results) {

        $scope.movies = results.data;

    }, function (error) {
        alert(error.data.message);
    });

    $scope.showComments = function (title) {

        $location.path('/comments/' + title);
    };
}]);