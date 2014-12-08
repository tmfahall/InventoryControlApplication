angular.module('InventoryApp')
.controller('UserOrderController',
    ['$scope', '$q', '$location', '$routeParams', 'ItemServices', 'CartServices', 'AuthServices',      //add services names in single quotes
function ($scope, $q, $location, $routeParams, ItemServices, CartServices, AuthServices) {    //add service names as params

    var vm = $scope;

    AuthServices.AuthInit(AuthServices.roleGeneral);

    vm.items = [];

    ItemServices.getItemsAll();

    vm.$on(ItemServices.eventItemsAllReceived, function () {
        vm.items = ItemServices.Items();
    })

    vm.addToCart = function () {
        for (var i = 0; i < vm.items.length; i++) {

            if (vm.items[i].amountNeeded) {
                if (vm.items[i].amountNeeded > 0) {
                    CartServices.addCartItem(vm.items[i]);
                }
            }
        }
        $location.path('/usercart');
    }

    /*----------------------------------------------------
     vm.checkQuantityRangeObj

     Description
         check range of a number on an object

     Params
         item - object containing number
         field - string name of property for number
         min - min value
         max - max value
         defaultNaN - default value if number is not a number
         allowEmpty - allow the empty string for the value

     Example: place this as attribute on input element

        ng-change="checkQuantityRangeObj(iteml, 'quantityOnPallet', 1, item.quantityPerPallet, item.quantityPerPallet, true)"

    */
    vm.checkQuantityRangeObj = function (item, field, min, max, defaultNaN, allowEmpty) {
        var quantity = item[field];
        var quantityNum = quantity / 1;

        if (quantity == '' && allowEmpty) {
            item[field] = '';
        }
        else if (isNaN(quantityNum)) {
            item[field] = defaultNaN;
        }
        else if (quantityNum < min) {
            item[field] = min;
        }
        else if (quantityNum > max) {
            item[field] = max;
        }
    }

}]);