using System;

namespace Matriz{
    class Program{
        static void Main(string[] args){

            Console.Write("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];

            Console.WriteLine("Digite os valores da matriz.");

            for(int i = 0; i < n; i++){

                string[] valores = Console.ReadLine().Split(" ");

                for(int j = 0; j < n; j++){
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine(" ");

            //Imprimir a diagonal
            for(int i = 0; i < n; i++){
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            //Imprimir a quantiade de números negativos
            int count = 0;
            for(int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    if(matriz[i, j] < 0){
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}