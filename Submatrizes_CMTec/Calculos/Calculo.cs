using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submatrizes_CMTec.Calculos
{
    public class Calculo
    {
        public int VerificaSubMatriz(string[][] matriz, string[][] submatriz)
        {
            int qnt = 0;
            int qntLinhas = submatriz.Length;
            int qntColunas = submatriz[0].Length;

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if((j+qntColunas) < matriz[i].Length)
                    {
                        var subMatrizSec = ConstroiMatriz(matriz, i, j, qntLinhas, qntColunas);
                        if (subMatrizSec.SequenceEqual(submatriz)) { qnt = qnt + 1; };
                    }

                }
            }
            return qnt;
        }

        public string[][] ConstroiMatriz(string[][] matriz, int linha, int coluna, int qntLinhas, int qntCol) 
        {
            var matrizSec = new string[qntLinhas][];
            for(int i = linha;i < qntLinhas; i++)
            {
                matrizSec[i] = (string[])matriz[i][coluna..(coluna + qntCol)].Clone();
            }
            return matrizSec;
        
        }

        public string[][] ObtemMatriz() 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Insira a matriz.");
                    Console.Write("Quantas linhas possui a sua matriz? ");
                    var qntLinhas = Int32.Parse(Console.ReadLine());
                    if (qntLinhas <= 1) throw new Exception("Por ser uma matriz quadrada, é necessário que possua pelo menos 2 linhas e 2 colunas.");

                    var linhas = new string[qntLinhas][];

                    for (int i = 0; i < qntLinhas; i++)
                    {
                        Console.Write($"{i + 1}ª Linha(Separe por virgulas): ");
                        var linha = Console.ReadLine().Split(',');
                        if (linha.Length != qntLinhas) throw new Exception("Por ser uma matriz quadrada, é necessário que a quantidade de colunas seja a mesma de linhas.");
                        linhas[i] = linha;
                    }
                    return linhas;
                }
                catch (Exception mt)
                {
                    Console.WriteLine(mt.Message);
                    continue;
                }

            }
        }
        public string[][] ObtemSubMatriz() 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Insira a submatriz.");
                    Console.Write("Quantas linhas possui a submatriz? ");
                    var qntLinhas = Int32.Parse(Console.ReadLine());
                    if (qntLinhas <= 1) throw new Exception("Por ser uma matriz quadrada, é necessário que possua pelo menos 2 linhas e 2 colunas.");

                    var linhas = new string[qntLinhas][];

                    for (int i = 0; i < qntLinhas; i++)
                    {
                        Console.Write($"{i + 1}ª Linha(Separe por virgulas): ");
                        var linha = Console.ReadLine().Split(',');
                        if (linha.Length != qntLinhas) throw new Exception("Por ser uma matriz quadrada, é necessário que a quantidade de colunas seja a mesma de linhas.");
                        linhas[i] = linha;
                    }
                    return linhas;
                }
                catch (Exception mt)
                {
                    Console.WriteLine(mt.Message);
                    continue;
                }

            }
        }

    }
}
