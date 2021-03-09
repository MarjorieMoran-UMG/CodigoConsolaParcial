using System;

namespace Cumpleaños
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado = "01406", dia, mes;
            int cantdenum = resultado.Length;
            char aceptar = 'x', opcion;
            const int anio = 365;

            Console.WriteLine("--------Este Programa tiene la habilidad de Adivinar una fecha de Cumpleaños---------");
            Console.WriteLine("------------------------------¿Quieres comprobarlo?----------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            Console.Write("Ingresa el número de la opción que desees: \t");
            opcion = Console.ReadKey().KeyChar;

            int largo = resultado.Length;

            if (opcion == 1)
            {
                Console.WriteLine("------------------------------Muy bien comencemos----------------------------");
                Console.WriteLine("----------------(Te ayudará tener a la mano una calculadora)-----------------");
                Console.WriteLine("\n");
                Console.WriteLine("Por favor piensa en la fecha de tu cumpleaños (solamente del día) y anótala");
                Console.WriteLine("Si ya la anotaste por favor presiona cualquier tecla");
                aceptar = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                Console.WriteLine("Ahora bien, multiplica la fecha por 20");
                Console.WriteLine("Si ya lo calculaste por favor presiona cualquier tecla");
                Console.WriteLine("\n");
                Console.WriteLine("Luego súmale 73");
                Console.WriteLine("Si ya lo sumaste por favor presiona cualquier tecla");
                aceptar = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                Console.WriteLine("Al resultado que obtuviste multiplicalo por 5");
                Console.WriteLine("Si ya lo calculaste por favor presiona cualquier tecla");
                aceptar = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                Console.WriteLine("Ahora suma el mes de tu cumpleaños");
                Console.WriteLine("Si ya lo sumaste por favor presiona cualquier tecla");
                aceptar = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                Console.WriteLine("Por favor ahora ingresa tu resultado final: \t ");
                resultado = Console.ReadLine();
                var resp1 = Convert.ToInt32(resultado);
                int rfinal;
                rfinal = resp1 - anio;
                resultado = Convert.ToString(rfinal);
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                dia = resultado.Substring(0, 1);
                mes = resultado.Substring(2, cantdenum - 1);
                Console.WriteLine($"Su fecha de nacimiento es ={dia} del mes = {mes}");
            }
            if (opcion == 2)
            {
                Console.ReadKey();
            }
        }
    }

}
