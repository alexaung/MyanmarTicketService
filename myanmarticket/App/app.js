var busApp = angular.module('BusTicketApp', ['ngAnimate', 'ui.router', 'ui.bootstrap', 'ui.bootstrap.datetimepicker', 'ui.bootstrap.typeahead']);

busApp.config(function ($stateProvider, $urlRouterProvider) {
    
    $stateProvider
    
        // route to show our basic form (/form)
        .state('bus', {
            url: '/bus',
            templateUrl: '/app/views/bus/bus.html',
            controller: 'busController'
        })
        
        // nested states 
        // each of these sections will have their own view
        // url will be nested (/form/profile)
        .state('bus.search', {
            url: '/search',
            templateUrl: '/app/views/bus/bus-search.html'
        })
        
        // url will be /form/interests
        .state('bus.result', {
            url: '/result',
            templateUrl: '/app/views/bus/bus-result.html'
        })
        
        // url will be /form/payment
        .state('bus.payment', {
            url: '/payment',
            templateUrl: '/app/views/bus/bus-payment.html'
        });
       
    // catch all route
    // send users to the form page 
    $urlRouterProvider.otherwise('/bus/search');
})