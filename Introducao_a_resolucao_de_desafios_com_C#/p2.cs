/*
Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

Entrada
O arquivo de entrada contém 1 valor inteiro qualquer.

Saída
Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.
*/


using System; 
class minhaClasse {
        public static void Main() {
            
            int X;
            X = int.Parse(Console.ReadLine());
            //complete seu codigo
            for (int looping = 1; looping <= X; looping +=2) { //complete seu codigo

                Console.WriteLine("\n" + looping);
            }
            
            Console.ReadLine();
        }
}