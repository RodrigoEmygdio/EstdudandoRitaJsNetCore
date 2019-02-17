'use strict';
var rita = require('rita');


module.exports = function (callback, grammar) {
    console.log("Recebendo gramatica!", JSON.stringify(grammar));
    var rgGramar = new rita.RiGrammar(grammar);
    callback(null, rgGramar.expand());
};





