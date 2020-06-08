using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class MenuDispensacion
    {
        
        
        public void ImpirmirMenu()
        {
            MenuPrincipal menu = new MenuPrincipal();

            Console.Clear();
            Console.WriteLine("Selecciones una de las dispensaciones siguiente \n 1-200 y 1000 \n 2-100 y 500 \n3-Efectiva");
            int opcion = Convert.ToInt32(Console.ReadLine());
            try
            {
                Personalizacion.ModoDispension = (OpcionesDispension) opcion;
                Console.WriteLine("Metodo de dispensacion elegido.");
                Console.ReadKey();
                menu.ImprimirMenu();

            }
            catch (Exception )
            {
                Console.WriteLine("Seleccione una opcion correcta.");
                Console.ReadKey();
                ImpirmirMenu();
            }
        }
    }
}
