'use strict';
busApp.controller('busResultController', function ($scope, Azureservice, DataService) {
    // we will store all of our form data in this object
    $scope.criteria = DataService.criteria;
    $scope.searchCriteria = { FromCity: $scope.criteria.FromCity.name, ToCity: $scope.criteria.ToCity.name, DepartDate: $scope.criteria.DepartDate, ReturnDate: $scope.criteria.ReturnDate }
    $scope.buses =[];
    getBuses();

    function getBuses() {
        Azureservice.invokeApi('bus', {
            method: 'get',
            body: 'Content-Type: "application/json; charset=UTF-8',
            parameters: $scope.searchCriteria 
        })
        .then(function(response) {
            console.log('Here is my response object');
            console.log(response);
            $scope.buses = response;
            var bus = $scope.buses[0];

        }, function(err) {
            console.error('There was an error quering Azure ' + err);
        });
    }
});