using System;

public class OperacionesBasicas
{
    public static int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("No se puede dividir por cero.");
            return 0;
        }
        return num1 / num2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Suma: " + Sumar(35, 6));
        Console.WriteLine("Resta: " + Restar(60, 13));
        Console.WriteLine("Multiplicacion: " + Multiplicar(9, 7));
        Console.WriteLine("Division: " + Dividir(1000, 56));
    }
}