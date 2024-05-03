using System;


double n1, n2, suma, resta, multiplicacion, division;
Console.Write("Ingrese el primer numero : ");
n1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero : ");
n2 = double.Parse(Console.ReadLine());
suma = n1 + n2;
resta = n1 - n2;
multiplicacion = n1 * n2;
Console.WriteLine("La suma es :" + suma);
Console.WriteLine("La resta es :" + resta);
Console.WriteLine("La multiplicacion es :" + multiplicacion);
if (n2 > 0)
{
    division = n1 / n2;
    Console.WriteLine("La division es :" + Math.Round(division, 2));
}
else
{
    Console.WriteLine("ERROR.No se pude dividir entre Cero.");

}
