//Escribe una función recursiva que imprima los números pares del 1 al 100
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        PrintEvenNumbers(1);
//    }

//    static void PrintEvenNumbers(int n)
//    {
//        if (n > 100) return;
//        Console.WriteLine(n);
//        PrintEvenNumbers(n + 2);
//    }
//}
//Escribe una función recursiva que imprima la suma de los números del 1 al n en C#
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 5; // Puedes cambiar este valor según tu necesidad
//        Console.WriteLine("La suma de los números del 1 al " + n + " es: " + SumaRecursiva(n));
//    }

//    static int SumaRecursiva(int n) => (n == 1) ? 1 : n + SumaRecursiva(n - 1);
//}

//Escribe una función recursiva que imprima la pirámide de números del 1 al n
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        ImprimirPiramide(5);
//    }

//    static void ImprimirPiramide(int n, int currentRow = 1)
//    {
//        if (currentRow > n) return;
//        Console.WriteLine(new string(' ', n - currentRow) + string.Join("", new int[currentRow * 2 - 1].Select((_, i) => i < currentRow ? i + 1 : currentRow * 2 - i - 1)));
//        ImprimirPiramide(n, currentRow + 1);
//    }
//}
//Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        ImprimirPiramideInvertida(5);
//    }

//    static void ImprimirPiramideInvertida(int n, int currentRow = 1)
//    {
//        if (currentRow > n) return;

//        Console.WriteLine(new string(' ', currentRow - 1) + string.Join("", Enumerable.Range(n - currentRow + 1, currentRow).Reverse()));

//        ImprimirPiramideInvertida(n, currentRow + 1); // Llamada recursiva para la siguiente fila
//    }
//}
//Escribe una función recursiva que imprima la tabla de multiplicar del n
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        ImprimirTablaMultiplicar(5);
//    }

//    static void ImprimirTablaMultiplicar(int n, int multiplicador = 1)
//    {
//        if (multiplicador <= 10)
//        {
//            Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
//            ImprimirTablaMultiplicar(n, multiplicador + 1);
//        }
//    }
//}
//Crea una matriz de números reales
//using System;

//class Program
//{
//    static void Main()
//    {
//        double[,] matriz = {
//            {1.1, 2.2, 3.3},
//            {4.4, 5.5, 6.6},
//            {7.7, 8.8, 9.9}
//        };

//        Console.WriteLine("Matriz:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write(matriz[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//Crea una matriz de números complejos
//using System;
//using System.Numerics;

//class Program
//{
//    static void Main()
//    {
//        Complex[,] matriz = {
//            {new Complex(1, 2), new Complex(3, -4)},
//            {new Complex(-5, 6), new Complex(7, 8)}
//        };

//        Console.WriteLine("Matriz de números complejos:");
//        foreach (var numero in matriz)
//        {
//            Console.Write(numero + "\t");
//        }
//        Console.WriteLine();
//    }
//}
//Crea una matriz de matrices
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[][][] matriz = {
//            new int[][] {
//                new int[] {1, 2},
//                new int[] {3, 4}
//            },
//            new int[][] {
//                new int[] {5, 6, 7},
//                new int[] {8, 9, 10}
//            }
//        };

//        Console.WriteLine("Matriz de matrices:");
//        foreach (var fila in matriz)
//        {
//            foreach (var matrizInterna in fila)
//            {
//                foreach (var elemento in matrizInterna)
//                {
//                    Console.Write(elemento + " ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//    }
//}
//Accede al elemento central de una matriz
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matriz = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        int filaCentral = matriz.GetLength(0) / 2;
//        int columnaCentral = matriz.GetLength(1) / 2;

//        int elementoCentral = matriz[filaCentral, columnaCentral];

//        Console.WriteLine("El elemento central de la matriz es: " + elementoCentral);
//    }
//}
//Suma dos matrices de diferentes tamaños
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 } };
//        int[,] matriz2 = { { 7, 8 }, { 9, 10 } };

//        int filas = Math.Max(matriz1.GetLength(0), matriz2.GetLength(0));
//        int columnas = Math.Max(matriz1.GetLength(1), matriz2.GetLength(1));

//        int[,] sumaMatrices = new int[filas, columnas];

//        for (int i = 0; i < filas; i++)
//            for (int j = 0; j < columnas; j++)
//                sumaMatrices[i, j] = (i < matriz1.GetLength(0) && j < matriz1.GetLength(1) ? matriz1[i, j] : 0) +
//                                     (i < matriz2.GetLength(0) && j < matriz2.GetLength(1) ? matriz2[i, j] : 0);

//        Console.WriteLine("Matriz resultante de la suma:");
//        for (int i = 0; i < filas; i++)
//        {
//            for (int j = 0; j < columnas; j++)
//            {
//                Console.Write(sumaMatrices[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}
//Multiplica una matriz por un número
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//        int multiplicador = 2;

//        for (int i = 0; i < matriz.GetLength(0); i++)
//            for (int j = 0; j < matriz.GetLength(1); j++)
//                matriz[i, j] *= multiplicador;

//        Console.WriteLine("Matriz resultante:");
//        for (int i = 0; i < matriz.GetLength(0); i++)
//        {
//            for (int j = 0; j < matriz.GetLength(1); j++)
//                Console.Write(matriz[i, j] + "\t");

//            Console.WriteLine();
//        }
//    }
//}
//Calcula la media de los elementos de una matriz
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//        int sumaTotal = 0;
//        foreach (int elemento in matriz)
//        {
//            sumaTotal += elemento;
//        }

//        double media = (double)sumaTotal / (matriz.GetLength(0) * matriz.GetLength(1));

//        Console.WriteLine("La media de los elementos de la matriz es: " + media);
//    }
//}
//Crea una matriz de números aleatorios de tamaño 100x100
//using System;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int[,] matriz = new int[100, 100];

//        for (int i = 0; i < 100; i++)
//            for (int j = 0; j < 100; j++)
//                matriz[i, j] = random.Next(100); // Genera números aleatorios entre 0 y 99

//        Console.WriteLine("Matriz de números aleatorios (primeros 5x5 elementos):");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//                Console.Write(matriz[i, j] + "\t");

//            Console.WriteLine();
//        }

//        Console.WriteLine("Resto de la matriz...");
//    }
//}
//Calcula la media, la mediana y la desviación estándar de los elementos de una matriz
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[,] matriz = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        int[] elementos = matriz.Cast<int>().ToArray();
//        double media = elementos.Average();
//        double mediana = elementos.OrderBy(x => x).ToArray()[elementos.Length / 2];
//        double desviacionEstandar = Math.Sqrt(elementos.Select(x => Math.Pow(x - media, 2)).Average());

//        Console.WriteLine("Media: " + media);
//        Console.WriteLine("Mediana: " + mediana);
//        Console.WriteLine("Desviación estándar: " + desviacionEstandar);
//    }
//}
//Escribe una función que encuentre el elemento máximo de una matriz
//using System;

//class Program
//{
//    static int EncontrarMaximo(int[,] matriz)
//    {
//        int maximo = int.MinValue;
//        foreach (int elemento in matriz)
//        {
//            maximo = Math.Max(maximo, elemento);
//        }
//        return maximo;
//    }

//    static void Main()
//    {
//        int[,] matriz = { { 1, 2, 3 }, { 4, 9, 6 }, { 7, 8, 5 } };
//        int maximo = EncontrarMaximo(matriz);
//        Console.WriteLine("El máximo elemento de la matriz es: " + maximo);
//    }
//}
//Escribe una función que encuentre la submatriz de mayor suma de una matriz
