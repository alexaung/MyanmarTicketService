'use strict';
busApp.controller('busResultController', function ($scope, Azureservice, DataService) {
    // we will store all of our form data in this object
    $scope.criteria = DataService.criteria;

    getBuses();

    function getBuses() {
        Azureservice.invokeApi('bus', {
            method: 'get',
            body: null,
            parameters: { FromCity: criteria.fromCity.name, ToCity: criteria.toCity.name, DepartDate: criteria.departDate, ReturnDate: criteria.returnDate }
        })
        .then(function(response) {
            console.log('Here is my response object');
            console.log(response)
        }, function(err) {
            console.error('There was an error quering Azure ' + err);
        });
    }
});