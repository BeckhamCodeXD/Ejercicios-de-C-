//Ejercicio parte 01: 
//Operaciones Básicas: 
//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese dos números:");

        Console.Write("Número 1: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Número 2: ");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Suma: {numero1 + numero2}");
        Console.WriteLine($"Resta: {numero1 - numero2}");
        Console.WriteLine($"Multiplicación: {numero1 * numero2}");

        if (numero2 != 0)
        {
            Console.WriteLine($"División: {numero1 / numero2}");
        }
        else
        {
            Console.WriteLine("No es posible dividir por cero.");
        }
    }
}

//2) Solicita un número al usuario y determina si es par o impar. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese un número:");
//        if (!int.TryParse(Console.ReadLine(), out int numero))
//        {
//            Console.WriteLine("Error: Entrada no válida.");
//            return;
//        }

//        if (numero % 2 == 0)
//        {
//            Console.WriteLine(numero + " es par.");
//        }
//        else
//        {
//            Console.WriteLine(numero + " es impar.");
//        }
//    }
//}
//Área de un Triángulo: 
//3) Pide la base y la altura de un triángulo al usuario y calcula su área. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese la base del triángulo:");
//        double.TryParse(Console.ReadLine(), out double baseTriangulo);

//        Console.WriteLine("Ingrese la altura del triángulo:");
//        double.TryParse(Console.ReadLine(), out double alturaTriangulo);

//        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

//        Console.WriteLine("El área del triángulo es: " + areaTriangulo);
//    }
//}
//Calculadora de Factorial: 
//4) Crea una función que calcule la factorial de un número. 

//using System.Numerics;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese un número entero: ");
//        int numero = int.Parse(Console.ReadLine());

//        BigInteger factorial = 1;
//        for (int i = 2; i <= numero; i++)
//        {
//            factorial *= i;
//        }

//        Console.WriteLine("El factorial del número {0} es: {1}", numero, factorial);
//    }
//}
//Número Primo: 
//5) Verifica si un número ingresado por el usuario es primo o no.
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese un número entero positivo: ");
//        int n = int.Parse(Console.ReadLine());

//        bool esPrimo = EsPrimo(n);

//        Console.WriteLine("El número {0} {1} primo.", n, esPrimo ? "es" : "no es");
//    }

//    static bool EsPrimo(int numero)
//    {
//        if (numero <= 1)
//            return false;

//        for (int i = 2; i <= Math.Sqrt(numero); i++)
//        {
//            if (numero % i == 0)
//                return false;
//        }

//        return true;
//    }
//}
//Inversión de Cadena: 
//6) Toma una cadena de texto y muestra su inversión.

//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Ingrese una cadena de texto: ");
//        string texto = Console.ReadLine();
//        string textoInvertido = InvertirTexto(texto);
//        Console.WriteLine("La cadena invertida es: {0}", textoInvertido);
//    }

//    static string InvertirTexto(string texto)
//    {
//        char[] caracteres = texto.ToCharArray();
//        Array.Reverse(caracteres);
//        return new string(caracteres);
//    }
//}
//Suma de Números Pares: 
//7) Calcula la suma de los números pares en un rango especificado por el usuario.

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("====COMENCEMOS CON EL PROGRAMA====");
//        Console.Write("Ingrese un numero entero (Rango): ");
//        int n = int.Parse(Console.ReadLine());
//        int sumaPares = SumaNumerosPares(n);
//        Console.WriteLine("La sumatoria en el rango de los {0} primeros números pares es: {1}", n, sumaPares);
//    }

//    static int SumaNumerosPares(int n)
//    {
//        int suma = 0;
//        for (int i = 0; i <= n; i += 2)
//        {
//            suma += i;
//        }
//        return suma;
//    }
//}
//Lista de Cuadrados: 
//8) Crea una lista de los cuadrados de los primeros 10 números naturales.
//Console.WriteLine("====COMENCEMOS CON EL PROGRAMA====");
//List<int> listCudrados = new List<int>();
//for (int i = 1; i <= 10; i++)
//{
//    int cuadrado = i * i;
//    listCudrados.Add(cuadrado);
//}
//Console.WriteLine("El cuadrado de los 10 primeros numeros naturales es:");
//foreach (int num in listCudrados)
//{
//    Console.WriteLine(num + " ");
//}
//Console.WriteLine();
//Contador de Vocales: 
//9) Cuenta el número de vocales en una cadena de texto. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese un texto: ");
//        string texto = Console.ReadLine();
//        int contadorVocales = ContarVocales(texto);
//        Console.WriteLine("La cantidad de vocales es: {0}", contadorVocales);
//    }

//    static int ContarVocales(string texto)
//    {
//        int contadorVocales = 0;
//        foreach (char letra in texto.ToLower())
//        {
//            if ("aeiou".Contains(letra))
//            {
//                contadorVocales++;
//            }
//        }
//        return contadorVocales;
//    }
//}
//Números de la Serie Fibonacci: 
//10) Genera los primeros 10 números de la serie Fibonacci. 

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese un numero entero: ");
//        int n = int.Parse(Console.ReadLine());
//        ImprimirSerieFibonacci(n);
//    }

//    static void ImprimirSerieFibonacci(int n)
//    {
//        int a = 0;
//        int b = 1;
//        Console.WriteLine("Serie de Fibonacci hasta el término {0}:", n);
//        for (int i = 0; i <= n; i++)
//        {
//            Console.WriteLine(a);
//            int temp = a;
//            a = b;
//            b = temp + b;
//        }
//    }
//}
//Ordenamiento de Lista: 
//11) Ordena una lista de números ingresados por el usuario de menor a mayor. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese una lista de números separados por espacios:");
//        List<int> numeros = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
//        numeros.Sort();
//        Console.WriteLine("La lista ordenada de menor a mayor es: " + string.Join(" ", numeros));
//    }
//}
//Palíndromo:
//12) Verifica si una palabra ingresada por el usuario es un palíndromo. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese una palabra:");
//        string palabra = Console.ReadLine().ToLower();
//        Console.WriteLine("La palabra ingresada " + (EsPalindromo(palabra) ? "es un palíndromo." : "no es un palíndromo."));
//    }

//    static bool EsPalindromo(string palabra)
//    {
//        for (int i = 0; i < palabra.Length / 2; i++)
//        {
//            if (palabra[i] != palabra[palabra.Length - i - 1])
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}
//Generador de Tablas de Multiplicar: 
//13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
//        int numero = int.Parse(Console.ReadLine());

//        Console.WriteLine("Tabla de multiplicar del número " + numero + ":");

//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
//        }
//    }
//}
//Cálculo del Área de un Círculo: 
//14) Pide el radio de un círculo al usuario y calcula su área. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese el radio del círculo: ");
//        double radio = double.Parse(Console.ReadLine());

//        double area = CalcularAreaCirculo(radio);

//        Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
//    }

//    static double CalcularAreaCirculo(double radio)
//    {
//        double area = Math.PI * radio * radio;
//        return area;
//    }
//}
//Suma de Dígitos: 
//15) Toma un número entero y calcula la suma de sus dígitos. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese un número entero: ");
//        int numero = int.Parse(Console.ReadLine());

//        int sumaDigitos = CalcularSumaDigitos(numero);

//        Console.WriteLine("La suma de los dígitos del número " + numero + " es: " + sumaDigitos);
//    }

//    static int CalcularSumaDigitos(int numero)
//    {
//        int suma = 0;

//        numero = Math.Abs(numero);

//        while (numero > 0)
//        {
//            suma += numero % 10;
//            numero /= 10;
//        }

//        return suma;
//    }
//}
