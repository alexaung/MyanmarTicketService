'use strict';
busApp.factory("DataService", function () {

    var criteria = { FromCity: "", ToCity: "", DepartDate: "", ReturnDate: "" }
    return { criteria: criteria };
});