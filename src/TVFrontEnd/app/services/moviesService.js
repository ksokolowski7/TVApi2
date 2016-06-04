'use strict'
app.factory('moviesService', ['$http', function ($http) {

    var serviceBase = 'http://localhost:7620/';
    var moviesServiceFactory = {};

    var _getPopularMovies = function () {
        return $http.get(serviceBase + "movies/popular").then(function (results) {
            return results;
        });
    };

    var _getComments = function (title) {
        return $http.get(serviceBase + "movies/comments?title=" + title).then(function (results) {
            return results;
        });
    };

    // COMMENT !!!
    // This way isn't in use because exist problem with string with special character sending in route parameter 

    //var _getComments = function (title) {
    //    title = encodeURIComponent(title);
    //    return $http.get(serviceBase + "movies/" + title + "/comments").then(function (results) {
    //        return results;
    //    });
    //};

    moviesServiceFactory.getPopularMovies = _getPopularMovies;
    moviesServiceFactory.getComments = _getComments;

    return moviesServiceFactory;

}]);