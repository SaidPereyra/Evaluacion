using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Char opcion;
            String continuar;

            do
            {
                Console.WriteLine("|**********************************************************|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*           1.-Suma de dos números           (x + y)     *|");
                Console.WriteLine("|*           2.-Resta de dos números          (x - y)     *|");
                Console.WriteLine("|*           3.-Multiplicación de dos números (x * y)     *|");
                Console.WriteLine("|*           4.-División de dos números       (x / y)     *|");
                Console.WriteLine("|*           5.-Mayor que                     (x > y)     *|");
                Console.WriteLine("|*           6.-Menor que                     (x < y)     *|");
                Console.WriteLine("|*           7.-Todas las operaciones                     *|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*           0.-Salir                                     *|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|**********************************************************|");
                Console.Write("\n");
                Console.Write("Dime una opción: ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '0' || opcion > '7');



                switch (opcion)
                {
                    case '0':
                        {
                            Environment.Exit(0);
                        }
                        break;

                    case '1':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY);

                            Console.WriteLine("El resultado de la suma es: " + op.opsuma().ToString());

                        }
                        break;
                    case '2':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY);

                            Console.WriteLine("El resultado de la resta es: " + op.opresta().ToString());

                        }
                        break;
                    case '3':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY);

                            Console.WriteLine("El resultado de la multiplicación es: " + op.opmultiplicar().ToString());

                        }
                        break;
                    case '4':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY);

                            Console.WriteLine("El resultado de la división es: " + op.opdividir().ToString());

                        }
                        break;
                    case '5':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY);

                            Console.WriteLine("El resultado de mayor que es       : " + op.mayorque().ToString());

                        }
                        break;
                    case '6':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY);

                            Console.WriteLine("El resultado de menor que es       : " + op.menorque().ToString());

                        }
                        break;
                    case '7':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese primer número  (x): ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo número (y): ");
                            double numeroY = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            ClassOp op = new ClassOp(numeroX, numeroY);

                            Console.WriteLine("El resultado de la suma es           : " + op.opsuma().ToString());
                            Console.WriteLine("El resultado de la resta es          : " + op.opresta().ToString());
                            Console.WriteLine("El resultado de la multiplicación es : " + op.opmultiplicar().ToString());
                            Console.WriteLine("El resultado de la división es       : " + op.opdividir().ToString());
                            Console.WriteLine("El resultado de mayor que es       : " + op.mayorque().ToString());
                            Console.WriteLine("El resultado de menor que es       : " + op.menorque().ToString());

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Escriba opciones válidas");
                        }
                        break;
                }

                Console.WriteLine("-------------------------------");
                Console.Write("¿Deseas continuar? y/n: ");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            }
            while (continuar != "n");

        }
    }
}
