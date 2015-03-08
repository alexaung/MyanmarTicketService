'use strict';

var busApp = angular.module('BusTicketApp', ['ngAnimate', 'ui.router', 'ui.bootstrap', 'ui.bootstrap.typeahead', 'mgcrea.ngStrap', 'azure-mobile-service.module']);

busApp.config(function ($stateProvider, $urlRouterProvider) {

    $stateProvider

        // route to show our basic form (/form)
        .state('bussearch', {
            url: '/bussearch',
            templateUrl: '/app/views/bus/bus-search.html',
            controller: 'busController'
        })

        // route to show our basic form (/form)
        .state('airportshuttle', {
            url: '/airportshuttle',
            templateUrl: '/app/views/bus/bus-result.html',
            controller: 'busController'
        })

        // route to show our basic form (/form)
        .state('bus', {
            url: '/bus',
            templateUrl: '/app/views/bus/bus.html',
            controller: 'busController'
        })
        // nested states 
        // each of these sections will have their own view
        // url will be nested (/bus/select)
        .state('bus.select', {
            url: '/select',
            templateUrl: '/app/views/bus/bus-select.html',
            controller: 'busResultController'
        })

        // url will be /bus/custinfo
        .state('bus.custinfo', {
            url: '/custinfo',
            templateUrl: '/app/views/bus/bus-custinfo.html'
        })

        // url will be /bus/payment
        .state('bus.payment', {
            url: '/payment',
            templateUrl: '/app/views/bus/bus-payment.html'
        })
        

    // catch all route
    // send users to the form page 
    $urlRouterProvider.otherwise('/bussearch');
});
////'https://myanmarticket.azure-mobile.net/',
busApp.constant('AzureMobileServiceClient', {
    API_URL: 'http://localhost:50770/',
    API_KEY: 'sCIAeXGjWNEZkskobCEsOuAKEZFsXs62'
});