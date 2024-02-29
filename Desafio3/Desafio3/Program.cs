using System;

class Program
{
    static void Main(string[] args)
    {
        SumarEntradas();
    }

    public static void SumarEntradas()
    {
        try
        {
            Console.WriteLine("Escribe el primer numero:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el segundo numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 + num2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Uno de los valores escritos no es un numero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Uno de los numeros es demasiado grande o demasiado pequeño.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error desconocido: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("La operacion ha finalizado.");
        }
    }
}
