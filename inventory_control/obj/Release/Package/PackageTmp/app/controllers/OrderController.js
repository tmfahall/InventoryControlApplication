angular.module('InventoryApp')
.controller('OrderController',
    ['$scope', '$q', '$location', '$routeParams', 'OrderService', 'AuthServices',       //add services names in single quotes
function ($scope, $q, $location, $routeParams, OrderService, AuthServices) {    //add service names as params

    var vm = $scope;

    AuthServices.AuthInit(AuthServices.roleAdmin);

    vm.order = {};
    vm.workorder = {};

    vm.orderId = $routeParams.id;

    OrderService.getOrder(vm.orderId);

    vm.$on(OrderService.eventOrderReceived, function () {
        vm.order = OrderService.Order();

        if (vm.order.workOrder) {
            vm.workorder = vm.order.workOrder;
        }
    })

    vm.completeOrder = function () {
        vm.order.completeTimestamp = new Date();
        vm.order.isComplete = true;
        OrderService.updateOrder(vm.order);
    }

    vm.approveOrder = function () {
        vm.order.isDenied = false;
        vm.order.isApproved = true;

        vm.completeOrder();
    }

    vm.denyOrder = function () {
        vm.order.isDenied = true;
        vm.order.isApproved = false;
        vm.order.deniedReason = document.getElementById('denialReason').value;

        vm.completeOrder();
    }

    vm.approveUserDelete = function () {
        vm.order.adminConfirmedDelete = true;

        vm.completeOrder();
    }

    vm.modQtyOrdered = function () {
        document.getElementById('modQty').class = 'btn btn-danger hidden';
        document.getElementById('saveQty').class = 'btn btn-danger';
        document.getElementById('newQty').class = '';

    }

    vm.saveQtyOrdered = function (orderId) {
        var qty = document.getElementById('newQty');
        vm.order.orderQuantity = qty.value;

        document.getElementById('modQty').class = 'btn btn-danger ';
        document.getElementById('saveQty').class = 'btn btn-danger hidden';
        document.getElementById('newQty').class = 'hidden';

        OrderService.UpdateOrder(orderId);
    }

}]);