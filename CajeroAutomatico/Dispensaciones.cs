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
            try
            {
                Console.Clear();
                int cantidad = 0;
                Console.WriteLine("Usted seleciona la opcioen de 200 y 1000 billetes");
                Console.WriteLine("Ingrese la cantidad que desea retirar");
                cantidad = Convert.ToInt32(Console.ReadLine());
                var Billetes = new int[] { 1000, 200 };
                procesoDispensacion.CajaRegistradora(cantidad, Billetes);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se pueden colocar numeros");
                Console.ReadKey();
                Billetes200Y1000();
                
                throw;
            }
        }

        public void Billetes100Y500()
        {
            int cantidad = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("Usted seleciona la opcioen de 100 y 500 billetes");
                Console.WriteLine("Ingrese la cantidad que desea retirar");
                cantidad = Convert.ToInt32(Console.ReadLine());
                var Billetes = new int[] { 500, 100 };
                procesoDispensacion.CajaRegistradora(cantidad, Billetes);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se pueden colocar numeros");
                Console.ReadKey();
                Billetes100Y500();
                throw;
            }
            
        }

        public void Eficiente()
        {
            try
            {
                Console.Clear();
                int cantidad = 0;
                Console.WriteLine("Dispensacion eficiente");
                Console.WriteLine("Ingrese la cantidad que desea retirar");
                cantidad = Convert.ToInt32(Console.ReadLine());
                var Billetes = new int[] { 1000, 500, 200, 100 };
                procesoDispensacion.CajaRegistradora(cantidad, Billetes);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se pueden colocar numeros");
                Console.ReadKey();
                Eficiente();
                throw;
            }
        }
    }
}
