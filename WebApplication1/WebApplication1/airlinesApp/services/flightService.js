(function (app) {

    var testData = [
                {
                    id:1,
                    airline: "united",
                    flightNumber: 207,
                    startTime: "12:00",
                    endTime: "13:00",
                    totalDuration: 2,
                    price: 400,
                    date: "12/1/2012",
                    cities: ["ORG", "WAS"],
                    approved: false

                },
                {
                    id:2,
                    airline: "lot",
                    flightNumber: 233,
                    startTime: "15:00",
                    endTime: "17:00",
                    totalDuration: 2,
                    price: 500,
                    date: "12/1/2012",
                    cities: ["ORG", "WAS"],
                    approved: false
                },
    ];

    var flightService = function ()
    {
        var flightFactory = {};

        flightFactory.getFlights = function ()
        {
        return testData;         
        };

        flightFactory.selectFlight = function ()
        {
            //
            // $http.put("/flights/select/3", id);
            //
            return true;
        };

        return flightFactory;
    };

    app.factory("flightService", flightService);

}(angular.module("airlineApp")));