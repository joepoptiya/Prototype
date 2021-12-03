companyModule.controller("OrganizationHomeController", function ($scope) {
    $scope.message = 'Welcome to Organization Management.';
    $scope.userinfo = { "username": "joepop", "firstname": "Akber", "lastname": "Poptiya", "email": "akber.poptiya@gmail.com" };

    $scope.organizationlist =
        [
              { "id": 1001, "name": "Organization name 1", "description": "Some description...", "status": "Draft", "class": "" }
            , { "id": 1002, "name": "Organization name 2", "description": "Some description...", "status": "Active", "class": "active" }
            , { "id": 1003, "name": "Organization name 3", "description": "Some description...", "status": "Review", "class": "info" }
            , { "id": 1004, "name": "Organization name 4", "description": "Some description...", "status": "Critical", "class": "danger" }
            , { "id": 1005, "name": "Organization name 5", "description": "Some description...", "status": "Warning", "class": "warning" }
            , { "id": 1007, "name": "Organization name 6", "description": "Some description...", "status": "Active", "class": "active" }
        ];
});
