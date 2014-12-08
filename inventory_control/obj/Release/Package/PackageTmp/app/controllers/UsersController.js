angular.module('InventoryApp')
.controller('UsersController',
    ['$scope', '$q', '$location', '$routeParams', 'UserServices', 'AuthServices',       //add services names in single quotes
function ($scope, $q, $location, $routeParams, UserServices, AuthServices) {    //add service names as params

    var vm = $scope;

    AuthServices.AuthInit(AuthServices.roleAdmin);

    vm.users = [];

    UserServices.getUsersAll();

    vm.$on(UserServices.eventUsersAllReceived, function () {
        vm.users = UserServices.Users();
    })

    vm.getUser = function (userId) {
        $location.path('user/' + userId);
    }

    vm.newUser = function () {
        $location.path('user/0');
    }

}]);