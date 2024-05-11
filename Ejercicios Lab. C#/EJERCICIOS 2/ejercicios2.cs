//Escribe una función recursiva que imprima los números pares del 1 al 100
using System;

class Program
{
    static void Main(string[] args)
    {
        PrintEvenNumbers(1);
    }

    static void PrintEvenNumbers(int n)
    {
        if (n > 100) return;
        Console.WriteLine(n);
        PrintEvenNumbers(n + 2);
    }
}
