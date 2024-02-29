using System;

class Program
{
    static void Main(string[] args)
    {
        SolicitarIngresoYCalcular();
    }

    public static void SolicitarIngresoYCalcular()
    {
        Console.WriteLine("Por favor escriba un nombre y un apellido:");
        string nombre = Console.ReadLine();

        double suma = 0;
        int meses = 3;

        //Pedir los ingresos de los ultimos 3 meses
        for (int i = 1; i <= meses; i++)
        {
            Console.WriteLine($"Escriba los ingresos del mes {i}:");
            double ingresosMes;
            while (!double.TryParse(Console.ReadLine(), out ingresosMes))
            {
                Console.WriteLine("Escribe un numero valido.");
            }
            suma += ingresosMes;
        }
        //Calcular el promedio
        double promedio = suma / meses;

        //Mostrar el resultado
        Console.WriteLine($"Hola {nombre}, en total ganaste {suma} y promediaste {promedio}.");
    }
}