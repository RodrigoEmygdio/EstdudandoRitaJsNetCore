'use strict';
var rita = require('rita');

var rgGramar = new rita.RiGrammar();
var result;

rgGramar.addRule('<start>', 'The <N> <V>', 1);
rgGramar.addRule('<N>', 'dog | cat | unicorn');
rgGramar.addRule('<V>', 'barks | mewos| twllips');

for (var i = 1; i <= 100; ++i) {
    result = rgGramar.expand();
    console.log(result);
}


