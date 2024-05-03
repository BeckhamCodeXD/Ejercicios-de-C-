//Ejercicio parte 01: 
//Operaciones Básicas: 
//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.
//using System;


//double a, b, suma, resta, multiplicacion, division;
//Console.Write("Ingrese el primer numero : ");
//a = double.Parse(Console.ReadLine());
//Console.Write("Ingrese el segundo numero : ");
//b = double.Parse(Console.ReadLine());
//suma = a + b;
//resta = a - b;
//multiplicacion = a * b;
//Console.WriteLine("La suma es :" + suma);
//Console.WriteLine("La resta es :" + resta);
//Console.WriteLine("La multiplicacion es :" + multiplicacion);
//if (b > 0)
//{
//    division = a / b;
//    Console.WriteLine("La division es :" + Math.Round(division, 2));
//}
//else
//{
//    Console.WriteLine("ERROR.No se pude dividir entre Cero.");

//}
//Verificación de Número Par o Impar: 
//2) Solicita un número al usuario y determina si es par o impar. 

//using System;

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
//using System;

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

using system;

class program
{
    static void main(string[] args)
    {
        console.writeline("ingrese un número para calcular su factorial:");
        if (int.tryparse(console.readline(), out int numero))
        {
            long factorial = calcularfactorial(numero);
            console.writeline("el factorial de " + numero + " es: " + factorial);
        }
        else
        {
            console.writeline("error: entrada no válida.");
        }
    }

    static long calcularfactorial(int n)
    {
        if (n < 0)
        {
            throw new argumentexception("el factorial no está definido para números negativos.");
        }
        return (n == 0 || n == 1) ? 1 : n * calcularfactorial(n - 1);
    }
}

