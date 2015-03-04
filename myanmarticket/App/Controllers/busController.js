'use strict';
busApp.controller('busController', function ($scope, Azureservice) {
    // we will store all of our form data in this object
    $scope.formData = {};

    // function to process the form
    $scope.processForm = function () {
        alert('awesome!');
    };
    
    $scope.selected = undefined;
    //$scope.cities = ['Alabama', 'Alaska', 'Arizona', 'Arkansas', 'California', 'Colorado', 'Connecticut', 'Delaware', 'Florida', 'Georgia', 'Hawaii', 'Idaho', 'Illinois', 'Indiana', 'Iowa', 'Kansas', 'Kentucky', 'Louisiana', 'Maine', 'Maryland', 'Massachusetts', 'Michigan', 'Minnesota', 'Mississippi', 'Missouri', 'Montana', 'Nebraska', 'Nevada', 'New Hampshire', 'New Jersey', 'New Mexico', 'New York', 'North Dakota', 'North Carolina', 'Ohio', 'Oklahoma', 'Oregon', 'Pennsylvania', 'Rhode Island', 'South Carolina', 'South Dakota', 'Tennessee', 'Texas', 'Utah', 'Vermont', 'Virginia', 'Washington', 'West Virginia', 'Wisconsin', 'Wyoming'];
    $scope.cities = [];

    $scope.datepicker = {};

    getCities();

    function getCities() {
        Azureservice.query('City', {})
        .then(function (items) {
            // Assigin the results to a $scope variable 
            $scope.cities = items;

        }, function (err) {
            console.error('There was an error quering Azure ' + err);
        });
    }
});