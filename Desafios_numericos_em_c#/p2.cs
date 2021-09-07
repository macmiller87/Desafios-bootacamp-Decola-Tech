/*
Desafio
Desenvolva um programa capaz de ler três valores e apresentar o maior deles e adicionar a mensagem “ eh o maior”. Use a seguinte forma como base:

MAIORAB =(A + B = ABS(A - B))/2

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido pela mensagem " eh o maior".
*/

using System;

    class Program {
        static void Main(string[] args) {
          
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis
            
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);
            int maior = 0;
            
            if(A >= B && A >= C) {
              
              maior = A;
              Console.WriteLine($"{maior} eh o maior");
              
            }else if(B >= A && B >= C) {
              
              maior = B;
              Console.WriteLine($"{maior} eh o maior");
              
            }else {
              
              maior = C;
              Console.WriteLine($"{maior} eh o maior");
              
            }
        }
    }