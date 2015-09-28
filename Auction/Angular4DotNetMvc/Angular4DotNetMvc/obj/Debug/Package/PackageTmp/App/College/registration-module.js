//var registrationModule = angular.module("registrationModule", [ 'ngRoute', 'ngResource' ])
//    .config(function ($routeProvider, $locationProvider) {
//        //$routeProvider
//        //    .when('/Registration/Courses', { templateUrl: '/App/College/templates/courses.html', controller: 'CoursesController' })
//        //    /*.when('/Registration', { templateUrl: '/Registration/college/Index.cshtml', controller: 'RegistrationController' }) */ 
//        //    .when('/Registration/Instructors', { templateUrl: '/App/College/templates/instructors.html', controller: 'InstructorsController' })
//        //    .when('/Registration/CreateAccount', { templateUrl: '/App/College/templates/create-account.html', controller: 'AccountController' })
//        //    .otherwise({ redirectTo: '/Registration/'
//        //    });

//        $routeProvider.when('/Registration/Courses', { templateUrl: '/App/College/templates/courses.html', controller: 'CoursesController' })
//        $routeProvider.when('/Registration/Instructors', { templateUrl: '/App/College/templates/instructors.html', controller: 'InstructorsController' })
//        $routeProvider.when('/Registration/CreateAccount', { templateUrl: '/App/College/templates/create-account.html', controller: 'AccountController' })

//        $locationProvider.html5Mode(true);
//    });

var registrationModule = angular.module("registrationModule", ['ngRoute', 'ngResource'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Registration', { templateUrl: '/App/College/templates/courses.html', controller: 'CoursesController' });
        $routeProvider.when('/Registration/Courses', { templateUrl: '/App/College/templates/courses.html', controller: 'CoursesController' });
        $routeProvider.when('/Registration/Instructors', { templateUrl: '/App/College/templates/instructors.html', controller: 'InstructorsController' });
        $routeProvider.when('/Registration/CreateAccount', { templateUrl: '/App/College/templates/create-account.html', controller: 'AccountController' });
        $locationProvider.html5Mode(true);
    });