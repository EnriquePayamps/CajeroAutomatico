using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class MenuPrincipal
    {
        MenuDispensacion menuDispensacion = new MenuDispensacion();
        Dispensaciones dispensaciones = new Dispensaciones();

        enum Opciones
        {
           DISPENSACION =1,
           RETIRAR_DINERO
           

        }
        public void ImprimirMenu() 

        {
            Console.WriteLine("Bienvenido al cajero automatico");
            Console.WriteLine("Seleciona una de las opcines siguientes. \n1-Modo dispensacion \n2-Retirar dinero");
            int opcion = Convert.ToInt32 (Console.ReadLine());

            try
            {
                switch (opcion)
                {
                    case (int)Opciones.DISPENSACION:
                        menuDispensacion.ImpirmirMenu();
                        break;

                    case (int)Opciones.RETIRAR_DINERO:
                        dispensaciones.Eficiente();
                        break;

                    

                    default:
                        Console.WriteLine("Seleccione una opcion correcta.");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Seleccione una opcion correcta.");
                Console.ReadKey();
                ImprimirMenu();
            }

            
        }
    }
}
