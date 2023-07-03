using Matrizes_CMTec.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes_CMTec.Calculos
{
    public class Calculo
    {
        public string[][] InverteDiagonais(string sentido, string[][] matriz)
        {
 
            var matrizSec = new string[matriz.Length][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matrizSec[i] = (string[])matriz[i].Clone();
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                matrizSec[i][i] = matriz[(matriz.Length - 1) - i][i];
                matrizSec[(matriz.Length - 1) - i][i] = matriz[i][i];
            }
            return matrizSec;
        }

        public int ObtemQntLinhas()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Insira a matriz quadrada.");
                    Console.Write("Quantas linhas possui a sua matriz? ");
                    var qntLinhas = Int32.Parse(Console.ReadLine());
                    if (qntLinhas <= 1) throw new MatrizesException("Por ser uma matriz quadrada, é necessário que possua pelo menos 2 linhas e 2 colunas.");
                    return qntLinhas;
                }
                catch (MatrizesException mt)
                {
                    Console.WriteLine(mt.Message);
                    continue;
                }
                
            }

        }

        public string[][] ObtemLinhas(int qntLinhas) 
        {
            while (true)
            {
                try
                {
                    var linhas = new string[qntLinhas][];
                    var calc = new Calculo();
                    for (int i = 0; i < qntLinhas; i++)
                    {
                        Console.Write($"{i + 1}ª Linha(Separe por virgulas): ");
                        var linha = Console.ReadLine().Split(',');
                        if (linha.Length != qntLinhas) throw new MatrizesException("Por ser uma matriz quadrada, é necessário que a quantidade de colunas seja a mesma de linhas.");
                        linhas[i] = linha;
                    }
                    return linhas;
                }
                catch (MatrizesException mt)
                {

                    Console.WriteLine(mt.Message);
                    continue;
                }
            }
        }

        public void ExibeMatriz(string[][] matriz) 
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                var linha = String.Empty;
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    linha += " " + matriz[i][j];
                }
                Console.WriteLine(linha);
            }
        }


    }
}
