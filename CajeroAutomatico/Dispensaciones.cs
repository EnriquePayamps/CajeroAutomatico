using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class Dispensaciones
    {
        ProcesoDispensacion procesoDispensacion = new ProcesoDispensacion();

        public void Billetes200Y1000()
        {
            Console.Clear();
            int cantidad = 0;
            Console.WriteLine("Ingrese la cantidad que desea retirar");
            cantidad = Convert.ToInt32( Console.ReadLine());
            var Billetes = new int[] { 1000, 200 };
            procesoDispensacion.CajaRegistradora(cantidad, Billetes);
            Console.ReadKey();
        }

        public void Billetes100Y500()
        {
            int cantidad = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese la cantidad que desea retirar");
                cantidad = Convert.ToInt32(Console.ReadLine());
                var Billetes = new int[] { 100, 500 };
                procesoDispensacion.CajaRegistradora(cantidad, Billetes);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se pueden colocar numeros");
                throw;
            }
            
        }

        public void Eficiente()
        {
            Console.Clear();
            int cantidad = 0;
            Console.WriteLine("Ingrese la cantidad que desea retirar");
            cantidad = Convert.ToInt32(Console.ReadLine());
            var Billetes = new int[] { 1000,500, 200,100 };
            procesoDispensacion.CajaRegistradora(cantidad, Billetes);
            Console.ReadKey();
        }
    }
}
