using System;

namespace Ejercicio_10_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaracion de variables
            decimal numero1;
            decimal numero2;
            decimal resultado;
            bool salir = false;
            #endregion

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una operación: ");
                resultado = 0;
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("\nIntroduzca el primer número: ");
                        numero1 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduzca el segundo número: ");
                        numero2 = Convert.ToDecimal(Console.ReadLine());
                        resultado = numero1 + numero2;
                        Console.WriteLine("\nEl resultado de la suma es: " + resultado);
                        Console.Write("\n\nPulse enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("\nIntroduzca el primer número: ");
                        numero1 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduzca el segundo número: ");
                        numero2 = Convert.ToDecimal(Console.ReadLine());
                        resultado = numero1 - numero2;
                        Console.Write("\nEl resultado de la resta es: " + resultado);
                        Console.Write("\n\nPulse enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Write("\nIntroduzca el primer número: ");
                        numero1 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduzca el segundo número: ");
                        numero2 = Convert.ToDecimal(Console.ReadLine());
                        resultado = numero1 * numero2;
                        Console.Write("\nEl resultado de la multiplicación es: " + resultado);
                        Console.Write("\n\nPulse enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Write("\nIntroduzca el primer número: ");
                        numero1 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduzca el segundo número: ");
                        numero2 = Convert.ToDecimal(Console.ReadLine());
                        resultado = numero1 / numero2;
                        Console.Write("\nEl resultado de la división es: " + Math.Round(resultado, 2));
                        Console.Write("\n\nPulse enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Write("\n¿Está seguro de que desea salir? S/N : ");
                        string stringSalir = Console.ReadLine();

                        if (stringSalir.Equals("s") || stringSalir.Equals("S"))
                        {
                            salir = true;
                        }

                        else
                        {
                            Console.Write("\nPulse enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;

                    default:
                        Console.WriteLine("La operación no es correcta.");
                        Console.Write("\nPulse enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

            while (salir != true);

        }
    }
}
