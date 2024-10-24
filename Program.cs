using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            // Entrada: Preencher a matriz com valores fornecidos pelo usuário
            
            int n = int.Parse(Console.ReadLine());// Declarando a varíavel "n" e fazendo a leitura dela

            int[,] mat = new int[n, n];// Definir o tamanho da matriz "n" por "n" e instanciando ela na memória!

            for (int i = 0; i < n; i++) //Criar um "for" pra percorrer as linhas 
            {
                string[] values = Console.ReadLine().Split(' ');//Declarar um vetor de "string" chamdo "values" e vai receber uma leitura com um "Split"

                for (int j = 0; j < n; j++) //Criar outro "for" pra percorer as colunas
                { 
                    mat[i, j] = int.Parse(values[j]); //Percorrer o vetor "values"
                }
            }

            Console.WriteLine("Main diagonal: ");// Entrada de Linha pra ler o diagonal principal

            for (int i = 0; i < n; i++)// Criar um "for" pra percorrer a linha diagonal da Matriz
            { 
                Console.Write(mat[i,i] + " ");// Chando a variavel "mat" que foi definda pro tamanho da Matriz "n, n"
            }
            Console.WriteLine();// Uma quebra de linha

            
             int count = 0;// Criando uma variavel contagem pros números negativos "count" 


            for (int i = 0; i < n; i++)// Estrutura base pra se percorrer uma matriz inteira com a linhas
            {
                for (int j = 0; j < n; j++)// Estrutura base pra percorrer a matriz com as colunas
                {
                    if (mat[i,j] < 0)// Criando uma condição pra cosidera a contagem "negativo"
                    {
                        count++;// Retornado a variavel 
                    }
                }
            }
            
            Console.WriteLine("Negative numbers: "+ count);//Saída pra imprimir na tela       
        }
    }
}