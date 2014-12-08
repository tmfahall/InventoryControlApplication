angular.module('InventoryApp')
.controller('LoginController',
    ['$scope', '$http', '$q', '$location', 'AuthServices',
function ($scope, $http, $q, $location, AuthServices) {
    var vm = $scope;

    vm.isLoggedIn = AuthServices.isLoggedIn();
    vm.isLoginError = false;
    vm.isAdmin = AuthServices.isAdmin();
    vm.isGeneral = AuthServices.isGeneral();
    vm.loginEmail = AuthServices.userName();
    vm.userName = AuthServices.userName();
    vm.loginPassword = AuthServices.password();


    if (AuthServices.isLoggedIn()) {
        $location.path('/');
    }

    vm.processLogin = function () {
        AuthServices.processLogin(vm.loginEmail, vm.loginPassword);
    }

    vm.processLogout = function () {
        AuthServices.processLogout();
        vm.isLoginError = false;
    }

    vm.$on(AuthServices.eventLoginSuccess, function (event) {
        //alert('Logged in');
        vm.isLoggedIn = AuthServices.isLoggedIn();
        vm.isLoginError = false;
        vm.isAdmin = AuthServices.isAdmin();
        vm.isGeneral = AuthServices.isGeneral();
        vm.loginEmail = AuthServices.userName();

        $location.path('/');

    });


    vm.$on(AuthServices.eventLoginFail, function (event) {
        //alert('Log in failed');
        vm.isLoggedIn = AuthServices.isLoggedIn();
        vm.isLoginError = false;
        vm.isAdmin = AuthServices.isAdmin();
        vm.isGeneral = AuthServices.isGeneral();
        vm.loginEmail = AuthServices.userName();
    });


    vm.$on(AuthServices.eventLogoutSuccess, function (event) {
        //alert('Logout success');
        vm.isLoggedIn = AuthServices.isLoggedIn();
        vm.isLoginError = false;
        vm.isAdmin = AuthServices.isAdmin();
        vm.isGeneral = AuthServices.isGeneral();
        vm.loginEmail = AuthServices.userName();

        if (!AuthServices.isLoggedIn()) {
            $location.path('/login');
        }

    });


    vm.$on(AuthServices.eventLogoutFail, function (event) {
        //alert('Log out failed');
        vm.isLoggedIn = AuthServices.isLoggedIn();
        vm.isLoginError = false;
        vm.isAdmin = AuthServices.isAdmin();
        vm.isGeneral = AuthServices.isGeneral();
        vm.loginEmail = AuthServices.userName();
    });

}]);