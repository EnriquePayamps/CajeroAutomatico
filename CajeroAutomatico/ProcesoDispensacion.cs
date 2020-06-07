using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class ProcesoDispensacion
    {

        public void CajaRegistradora(int cantidad, int[] billetes)
        {
            
            int[] resultado = new int[billetes.Length];

            for (int i = 0; i < billetes.Length; i++)
            {
                var billete = billetes[i];

                if (cantidad >= billete)
                {
                    resultado[i] = ConseguirCambioPorBillete(billete, ref cantidad);
                }
            }


            if (cantidad == 0)
            {
                for (int i = 0; i < billetes.Length; i++)
                {
                    if (resultado[i] > 0) Console.WriteLine($"Tiene {resultado[i]} Billetas de {billetes[i]}");
                }

                return;
            }

            Console.WriteLine($"Los sentimos solo trabajamos con numeros enteros");
        }

        public int ConseguirCambioPorBillete(int billete, ref int cantidad)
        {
            var cantidadBilletes = 0;
            while (cantidad >= billete)
            {
                cantidad -= billete;
                cantidadBilletes += 1;
            }

            return cantidadBilletes;
        }
    }
}

