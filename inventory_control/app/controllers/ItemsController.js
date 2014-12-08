angular.module('InventoryApp')
.controller('ItemsController',
    ['$scope', '$q', '$location', '$routeParams', 'ItemServices', 'AuthServices',       //add services names in single quotes
function ($scope, $q, $location, $routeParams, ItemServices, AuthServices) {    //add service names as params

    var vm = $scope;

    AuthServices.AuthInit(AuthServices.roleAdmin);

    vm.items = [];

    ItemServices.getItemsAll();

    vm.$on(ItemServices.eventItemsAllReceived, function () {
        vm.items = ItemServices.Items();
        for (var x in vm.items) {
            vm.items[x].qtyTilOrder = vm.items[x].quantityInStock - vm.items[x].minQuantity;
        }
    })

    vm.getItem = function (itemId) {
        $location.path('item/' + itemId);
    }

}]);