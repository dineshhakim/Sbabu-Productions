// script.js

// create the module and name it scotchApp
// also include ngRoute for all our routing needs
var uraApp = angular.module('uraApp', ['ngRoute']);

// configure our routes
uraApp.config(function ($routeProvider) {
    $routeProvider

        // route for the home page
        .when('/', {
            title: "Home",
            templateUrl: 'partialpages/home.html',
            controller: 'mainController'
        })
        .when('/home', {
            title: "Home",
            templateUrl: 'partialpages/home.html',
            controller: 'mainController'
        })
        // route for the about page
        .when('/about', {
            title: "About",
            templateUrl: 'partialpages/about.html',
            controller: 'aboutController'
        })

        // route for the contact page
        .when('/contact', {
            title: "Contact",
            templateUrl: 'partialpages/contact.html',
            controller: 'contactController'
        })
        .when('/education', {
            title: "Education",
            templateUrl: 'partialpages/education.html',
            controller: 'educationController'
        })
        .when('/experience', {
            title: "experience",
            templateUrl: 'partialpages/experience.html',
            controller: 'experienceController'
        })
        .when('/work', {
            title: "experience",
            templateUrl: 'partialpages/work.html',
            controller: 'experienceController'
        })
        .when('/blog', {
            title: "experience",
            templateUrl: 'partialpages/blog.html',
            controller: 'experienceController'
        });
});

// create the controller and inject Angular's $scope
uraApp.controller('mainController', function ($scope, $sce) {
    // create a message to display in our view
    $scope.data = getAboutMe($sce);
    
});

uraApp.controller('aboutController', function ($scope) {
    $scope.message = 'Look! I am an about page.';
});

uraApp.controller('contactController', function ($scope, $sce) {
   
    $scope.data = getAboutMe($sce);
});
uraApp.controller('educationController', function ($scope) {
    $scope.educations = getEducationData();
});
uraApp.controller('experienceController', function ($scope) {
    $scope.experiences = getexperienceData();
});
uraApp.controller('socialNetworksController', function ($scope, $sce) {
    // create a message to display in our view
    $scope.data = getAboutMe($sce);
   $scope.socialnetworks = getSocialNetworksData();
});
uraApp.run(['$rootScope', function ($rootScope) {
    $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {
        $rootScope.title = current.$$route.title;
    });
}]);