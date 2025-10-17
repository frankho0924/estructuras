using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_contro_l3147912
{
    internal class Program
    {
        private const float V = 0.2f;

        static void Main(string[] args)// punto de partida
        {
            //tipos de datos


            //estructura de control
            //Console.WriteLine("Ingrese su edad: .");
            //int numero = int.Parse(Console.ReadLine()); //para leer la entrda de datos

            //Console.WriteLine($"su edad es: "+numero);
            //Console.WriteLine($"su edad es:  {numero}");


            //Console.WriteLine("ingrese 3 notas");
            //float n1 = int.Parse(Console.ReadLine());
            //float n2 = int.Parse(Console.ReadLine());
            //float n3 = int.Parse(Console.ReadLine());
            //if (n1 < 0 | n1 >5 | n2 < 0 | n2 > 5 | n3 < 0 | n3 > 5) ;
            //float promedioes = (n1 * 0.2f) + (n2 * 0.3f) + (n3 * 0.5f);
            //if(promedioes>=3)
            //{
            //    Console.WriteLine("aprobado");
            //}
            //else
            //{
            //    Console.WriteLine("desaprobado");
            //}

            //Console.WriteLine("Ingrese el precio del producto:");
            //float product = float.Parse(Console.ReadLine());

            //if (product >= 100000)
            //{
            //    float discount = product * 0.20f; // 20% de descuento
            //    float finalPrice = product - discount;
            //    Console.WriteLine($"Se le aplica un 20% de descuento, el precio final es: {finalPrice}");
            //}
            //else
            //{
            //    Console.WriteLine($"No se aplica descuento, el precio es: {product}");
            //}
            //Console.WriteLine("Ingrese el monto del préstamo: ");
            //float monto = float.Parse(Console.ReadLine());

            //float interesAnual = monto * 0.05f;  // 5% anual
            //float interesTrimestre = interesAnual / 4;  // 4 trimestres por año
            //float interesMes = interesAnual / 12;       // 12 meses por año

            //float totalPagar = monto + (interesAnual * 5);  // total en 5 años

            //Console.WriteLine("Interés pagado en un año: " + interesAnual);
            //Console.WriteLine("Interés pagado en el tercer trimestre: " + interesTrimestre);
            //Console.WriteLine("Interés pagado en el primer mes: " + interesMes);
            //Console.WriteLine("Total a pagar incluyendo intereses: " + totalPagar);

            ////primer paso
            //Console.WriteLine("=== colilla de pago ===\n");


            //Console.Write("Nombre del empleado: ");
            //string nombre = Console.ReadLine();

            //Console.Write("Salario del empleado: ");
            //double salario = Convert.ToDouble(Console.ReadLine());

            //double neto = salario;

            //Console.WriteLine("\n--- COLILLA DE PAGO ---");
            //Console.WriteLine("Empleado: " + nombre);
            //Console.WriteLine("Salario: $" + neto);

            //Console.WriteLine("\nPresione una tecla para salir...");
            //Console.ReadKey();


            ////segundaparte
            //Console.WriteLine("===colilla de pago ===\n");

            //Console.Write("Nombre del empleado: ");
            //string nombre = Console.ReadLine();

            //Console.Write("Salario del empleado: ");
            //double salario = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Ahorro mensual programado: ");
            //double ahorro = Convert.ToDouble(Console.ReadLine());

            //double salarioNeto = salario - ahorro;

            //Console.WriteLine("\n--- pago ---");
            //Console.WriteLine("Empleado: " + nombre);
            //Console.WriteLine("Salario bruto: $" + salario);
            //Console.WriteLine("Ahorro mensual: $" + ahorro);
            //Console.WriteLine("Salario neto a recibir: $" + salarioNeto);

            //Console.WriteLine("\nPresione una tecla para salir...");
            //Console.ReadKey();
           
            
            Console.WriteLine("=== COLILLA DE PAGO ===\n");

            Console.Write("Nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Salario del empleado: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ahorro mensual programado: ");
            double ahorro = Convert.ToDouble(Console.ReadLine());

         
            double descuentoEPS = salario * 0.125; 
            double salarioNeto = salario - ahorro - descuentoEPS;

            Console.WriteLine("\n--- COLILLA DE PAGO ---");
            Console.WriteLine("Empleado: " + nombre);
            Console.WriteLine("Salario bruto: $" + salario);
            Console.WriteLine("Ahorro mensual: $" + ahorro);
            Console.WriteLine("Descuento EPS (12.5%): $" + descuentoEPS);
            Console.WriteLine("Salario neto a recibir: $" + salarioNeto);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();

        }
    }
}
