// script.js

// create the module and name it scotchApp
// also include ngRoute for all our routing needs
 
var sbabuApp = angular.module('sbabuApp', ['ngRoute']);

// configure our routes
sbabuApp.config(function ($routeProvider) {
    $routeProvider
        // route for the home page
        .when('/',
        {
            title: "Home",
            controller: 'portfolioController'
        })
        // route for the about page
        .when('/about',
        {
            title: "About",
           
            controller: 'portfolioController'
        });


});

// create the controller and inject Angular's $scope
sbabuApp.controller('portfolioController',
    function ($scope) {
        // create a message to display in our view
        alert('ka cha');
        $scope.data ="ka cha";
       // $scope.portfolios = getPhotos($http);

    });


sbabuApp.run(['$rootScope', function ($rootScope) {
    $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {
        $rootScope.title = current.$$route.title;

    });
}]);