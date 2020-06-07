using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class MenuDispensacion
    {
        Dispensaciones dispensaciones = new Dispensaciones();
        enum Opciones
        {
           PRIMER_RETIRO=1,
           SEGUNDO_RETIRO,
           EFECTIVA

        }
        public void ImpirmirMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecciones una de las dispensaciones siguiente \n 1-200 y 1000 \n 2-100 y 500 \n3-Efectiva");
            int opcion = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (opcion)
                {
                    case (int)Opciones.PRIMER_RETIRO:
                        Console.Clear();
                        dispensaciones.Billetes200Y1000();
                        break;

                    case (int)Opciones.SEGUNDO_RETIRO:
                        Console.Clear();
                        dispensaciones.Billetes100Y500();
                        break;

                    case (int)Opciones.EFECTIVA:
                        Console.Clear();
                        dispensaciones.Eficiente();
                        break;

                    default:
                        Console.WriteLine("Seleccione una opcion correcta.");
                        Console.ReadKey();
                        ImpirmirMenu();
                        break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Seleccione una opcion correcta.");
                Console.ReadKey();
                ImpirmirMenu();
            }

        }
        
    }
}
