angular.module('InventoryApp')
.controller('OrdersController',
    ['$scope', '$q', '$location', '$routeParams', 'OrderService', 'AuthServices',       //add services names in single quotes
function ($scope, $q, $location, $routeParams, OrderService, AuthServices) {    //add service names as params

    var vm = $scope;

    vm.completeCheckBox = false;

    AuthServices.AuthInit(AuthServices.roleAdmin);

    vm.orders = [];

    OrderService.getOrdersAll();

    vm.$on(OrderService.eventOrdersAllReceived, function () {
        vm.orders = OrderService.Orders();
    })

    vm.getOrder = function (orderId) {
        $location.path('ordera/' + orderId);
    }

    vm.onlyIncomplete = function (order) {
        if (vm.completeCheckBox == false) {
            return order.isComplete == false;
        }
        else {
            return order.isComplete == true;
        }
    }
}]);