using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, num0, num; ;
            char aceptar = 'x';

            Console.WriteLine("---Este Programa tiene la habilidad de Adivinar el número en el que estás pensando---");
            Console.WriteLine("------------------------------¿Quieres comprobarlo?----------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            Console.Write("Ingresa el número de la opción que desees: \t");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
                {
                        Console.WriteLine("------------------------------Muy bien comencemos----------------------------");
                        Console.WriteLine("----------------(Te ayudará tener a la mano una calculadora)-----------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("Por favor piensa en un número y anótalo");
                        Console.WriteLine("Si ya lo anotaste por favor presiona cualquier tecla");
                        aceptar = Console.ReadKey().KeyChar;
                        Console.WriteLine("\n");
                        Console.WriteLine("Ahora bien, multiplica el numero que pensaste por 2");
                        Console.WriteLine("Si ya lo calculaste por favor presiona cualquier tecla");
                        aceptar = Console.ReadKey().KeyChar;
                        Console.WriteLine("\n");
                        Console.WriteLine("Al resultado que obtuviste súmale 8");
                        Console.WriteLine("Si ya lo calculaste por favor presiona cualquier tecla");
                        aceptar = Console.ReadKey().KeyChar;
                        Console.WriteLine("\n");
                        Console.WriteLine("El resultado de la suma multiplicalo por 5");
                        Console.WriteLine("Si ya lo calculaste por favor presiona cualquier tecla");
                        aceptar = Console.ReadKey().KeyChar;
                        Console.WriteLine("\n");
                        Console.WriteLine("Por favor ahora ingresa tu resultado final: \t ");
                        num0 = int.Parse(Console.ReadLine());
                        num0 = num0 / 10;
                        num = num0 - 4;
                        Console.WriteLine("\n");
                        Console.WriteLine("El número que estaba pensando es  {0}", num);
                    }
            if (opcion == 2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("¡En otra ocasión te esperamos para adivinar el numero en el que estás pensando!");
                aceptar = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
            }
        }
        
    }
}
