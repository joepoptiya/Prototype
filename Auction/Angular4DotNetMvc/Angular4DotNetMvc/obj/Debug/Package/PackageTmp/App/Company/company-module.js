
var companyModule = angular.module("companyModule", ['ngRoute', 'ngResource'])
//var registrationModule = angular.module("registrationModule", ['ngRoute', 'ngResource'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/Company', { templateUrl: '/App/Company/Home/templates/home.html', controller: 'CompanyHomeController' });
        //$routeProvider.when('/Company/Account/Register/login', { templateUrl: '/App/Company/Account/templates/create-account.html', controller: 'UserRegistrationController' });
        $routeProvider.when('/Company/Account/Register', { templateUrl: '/App/Company/Account/templates/create-account.html', controller: 'UserRegistrationController' });
        $routeProvider.when('/Company/Login', { templateUrl: '/App/Company/Account/templates/login.html', controller: 'UserLoginController' });

        $routeProvider.when('/Company/Account/Home', { templateUrl: '/App/Company/Account/templates/account-home.html', controller: 'AccountHomeController' });

        $routeProvider.when('/Company/Organization/Home', { templateUrl: '/App/Company/Organization/templates/organization.html', controller: 'OrganizationHomeController' });
        $routeProvider.when('/Company/Organization/Register', { templateUrl: '/App/Company/Organization/templates/register-org.html', controller: 'OrganizationHomeController' });


        $locationProvider.html5Mode(true);
    });