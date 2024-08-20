using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Seleccione la operación que desea realizar:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el primer número:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"El resultado de la suma es: {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"El resultado de la resta es: {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"El resultado de la división es: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir por cero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("¿Desea continuar? (S/N)");
                string respuesta = Console.ReadLine().ToUpper();

                if (respuesta != "S")
                {
                    continuar = false;
                }
            }
        }
    }
}



