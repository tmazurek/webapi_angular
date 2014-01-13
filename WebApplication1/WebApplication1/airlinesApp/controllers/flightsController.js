(function (app) 
{

    var flightsController = function ($scope, flightService, $timeout) {

        var onError = function () { alert("error") };
        var onFlights = function (flights) { $scope.flights = flights.data; };

        var init = function () {
            $scope.flights = flightService.getFlights().then(onFlights, onError);
        };


        $scope.selectedFlight = function (flight) {
            for (var i = 0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
            }
        
            flight.approved = !flight.approved;
            if (flightService.selectFlight(flight.id))
            {
                $scope.status = "yes u did";
                $timeout(function () {
                    $scope.status = null;
                }, 3000)
            };

        };
        
        init();

    };
    app.controller("flightsController", ["$scope", "flightService", "$timeout", flightsController]);
    

    
}(angular.module("airlineApp")));