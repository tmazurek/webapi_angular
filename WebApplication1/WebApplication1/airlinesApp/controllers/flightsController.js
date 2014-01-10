(function (app) {

    var flightsController = function ($scope) {

        
        $scope.selectedFlight = function (flight) {
            for (var f in $scope.flights) {
                $scope.flights[f].approved = false;
            }
            flight.approved = true;
        };

                                            
        $scope.flights = 

            [
                {
                airline: "united",
                flightNumber: 207,
                startTime: "12:00",
                endTime: "13:00",
                totalDuration: 2,
                price: 400,
                date: "12/1/2012",
                cities: ["ORG", "WAS"],
                approved:false

                },
                {
                airline: "lot",
                flightNumber: 233,
                startTime: "15:00",
                endTime: "17:00",
                totalDuration: 2,
                price: 500,
                date: "12/1/2012",
                cities: ["ORG", "WAS"],
                approved:false
                },
            ]
        };


app.controller("flightsController", ["$scope",flightsController]);

}(angular.module("airlineApp")));