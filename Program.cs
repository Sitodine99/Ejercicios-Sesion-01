using System;

namespace EJERCICIO_1_y_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1:");
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es " + nombre);
            Console.WriteLine("Escribe la hora: ");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Son las " + hora);
            if (hora <= 12)
            {
                Console.WriteLine("Aún es mañanica");
            } else
            {
                Console.WriteLine("Es ya tardecico");
            }
        }
    }
}
