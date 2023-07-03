// See https://aka.ms/new-console-template for more information
using Submatrizes_CMTec.Calculos;
var qnt = 0;
Calculo calc = new Calculo();
var matriz = calc.ObtemMatriz();
var subMatriz = calc.ObtemSubMatriz();

qnt = calc.VerificaSubMatriz(matriz, subMatriz);

Console.WriteLine(qnt);