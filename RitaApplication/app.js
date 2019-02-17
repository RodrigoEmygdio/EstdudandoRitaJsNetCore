'use strict';
var rita = require('rita');

var result;

var gramar = {
    "<start>": 'Subj V Det N AdjS',
    "Subj": "Pron",
    "Pron": "Você",
    "V": "é",
    "Det": "uma",
    "N": "pessoa",
    "AdjS": "Adj_1 e Adj_2| Adj_1, Adj_2 e Adj_3 ",
    "Adj_1": "forte",
    "Adj_2": "determinada",
    "Adj_3": "autoconfiante"
};

var rgGramar = new rita.RiGrammar(gramar);

    result = rgGramar.expand();
    console.log(result);





