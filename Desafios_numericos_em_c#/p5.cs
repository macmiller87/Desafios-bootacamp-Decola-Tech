/*
Desafio
Você terá desafio de escrever um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

Entrada
O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

Saída
Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, conforme exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.
*/

using System;
    class Program {
        static void Main(string[] args) {
          
            string[] vet = Console.ReadLine().Split(' ');
           
            //complete o código com sua solução
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            for (int looping = 1; looping <= Y; looping++) {
              
                Console.Write(looping);
                
                if (looping % X == 0) {
                  
                    Console.WriteLine("");
                    
                } else {
                  
                    Console.Write(" ");
                    
                }
            }
        }
    }