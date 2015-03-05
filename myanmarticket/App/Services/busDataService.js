'use strict';
busApp.factory("DataService", function () {

    var criteria = { fromCity: "", toCity: "", departDate: "", returnDate: "" }
    return { criteria: criteria };
});