angular.module('InventoryApp')
.controller('UserController',
    ['$scope', '$q', '$location', '$routeParams', 'UserServices', 'AuthServices',      //add services names in single quotes
function ($scope, $q, $location, $routeParams, UserServices, AuthServices) {    //add service names as params

    var vm = $scope;

    AuthServices.AuthInit(AuthServices.roleAdmin);

    vm.user = {};
    vm.departments = [];

    vm.userId = $routeParams.id;

    if (vm.userId == 0)  //if a new user
    {
        vm.user = UserServices.NewUser();
        UserServices.getDepartments();
    }
    else {
        UserServices.getUser(vm.userId);
    }

    vm.$on(UserServices.eventUserReceived, function () {
        vm.user = UserServices.User();
        vm.departments = UserServices.Departments();
    })

    vm.$on(UserServices.eventDepartmentsReceived, function () {
        vm.user.departmentId = 0;
        vm.departments = UserServices.Departments();
    })

    vm.saveUser = function () {
        UserServices.postUser(vm.user);
    }

    vm.cancelUpdateUser = function () {
        $location.path('/users');
    }

}]);