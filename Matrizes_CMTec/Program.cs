// See https://aka.ms/new-console-template for more information
using Matrizes_CMTec.Calculos;

var calc = new Calculo();


var qntLinhas = calc.ObtemQntLinhas();
var linhas = calc.ObtemLinhas(qntLinhas);
calc.ExibeMatriz(linhas);
var matriz = calc.InverteDiagonais("direita", linhas);
calc.ExibeMatriz(matriz);
