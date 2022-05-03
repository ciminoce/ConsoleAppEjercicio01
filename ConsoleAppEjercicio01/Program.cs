using System;

namespace ConsoleAppEjercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int suma;
            Console.Title = "Suma de 2 números";
            Console.Write("Ingrese el primer número:");
            numero1 =int.Parse( Console.ReadLine());

            Console.Write("Ingrese el segundo valor:");
            numero2 = int.Parse(Console.ReadLine());

            suma = numero1 + numero2;
            Console.WriteLine($"La suma es {suma}");
            //Console.WriteLine("La suma es {0}",suma);
            Console.ReadLine();

        }
    }
}
