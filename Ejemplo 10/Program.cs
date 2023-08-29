using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double consumo, descuento, importe_a_pagar, impuesto,subtotal;
            Console.WriteLine("Ingrese el monto del consumo: ");
            consumo=double.Parse(Console.ReadLine());
            if (consumo <= 100)
            {
                descuento = consumo * 0.1;
            }
            else
            {
                descuento = consumo * 0.2;
            }
            subtotal = consumo-descuento;
            impuesto = subtotal * 0.18;
            importe_a_pagar = subtotal + impuesto;
            Console.WriteLine("El monto del descuento es:{0}", descuento);
            Console.WriteLine("El impuesto es:{0}", impuesto);
            Console.WriteLine("El subtotal es: {0}",subtotal);
            Console.WriteLine("El importe a pagar es: {0}", importe_a_pagar);
            Console.ReadKey();
        }
    }
}
