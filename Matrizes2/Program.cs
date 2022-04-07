using System;

namespace Matrizes2{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Digite o número de linhas: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for(int i = 0; i < m; i++){

                string[] valores = Console.ReadLine().Split(" ");

                for(int j = 0; j < n; j++){
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine();

            Console.Write("Digite um valor da matriz: ");
            int resp = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++){

                for(int j = 0; j < n; j++){
                    if(matriz[i,j] == resp){
                        Console.WriteLine($"A posição do número é {i},{j}");
                        if(j > 0){
                            Console.WriteLine($"Esquerda {matriz[i, j-1]}");
                        }
                        if(j < n-1){
                            Console.WriteLine($"Direita {matriz[i, j+1]}");
                        }
                        if(i > 0){
                            Console.WriteLine($"Cima {matriz[i-1, j]}");
                        }
                        if(i < m-1){
                            Console.WriteLine($"Baixo {matriz[i+1, j]}");
                        }
                    }
                }
            }
        }
    }
}