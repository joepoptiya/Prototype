var registrationModule = angular.module("registrationModule", [])
    .config(function ($routeProvider, $locationProvider) {

        $routeProvider
            .when('/Registration/Courses', { templateUrl: '/templates/college/courses.html', controller: 'CoursesController' })
            .when('/Registration', { templateUrl: '/Registration/college/Index.cshtml', controller: 'RegistrationController' })
            .when('/Registration/Instructors', { templateUrl: '/templates/college/instructors.html', controller: 'InstructorsController' })
            .otherwise({
                redirectTo: '/Registration/'
        });
        $locationProvider.html5Mode(true);
    });