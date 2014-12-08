angular.module('InventoryApp')
.controller('LocationItemsController',
    ['$scope', '$q', '$location', '$routeParams', 'LocationItemServices', 'AuthServices',       //add services names in single quotes
function ($scope, $q, $location, $routeParams, LocationItemServices, AuthServices) {    //add service names as params

    var vm = $scope;

    AuthServices.AuthInit(AuthServices.roleAdmin);

    vm.locations = [];

    LocationItemServices.getLocationsAll();

    vm.$on(LocationItemServices.eventLocationsAllReceived, function () {
        vm.locations = LocationItemServices.Locations();
    })

    vm.getLocationItem = function (locationId) {
        $location.path('locitem/' + locationId);
    }

}]);