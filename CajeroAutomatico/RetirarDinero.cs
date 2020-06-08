using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    class RetirarDinero

    {
        Dispensaciones dispensaciones = new Dispensaciones();
        public void Retiro()

        {
            if(Personalizacion.ModoDispension > 0) 
            {
                switch (Personalizacion.ModoDispension)
                {
                    case OpcionesDispension.PRIMER_RETIRO:
                        Console.Clear();
                        
                        dispensaciones.Billetes200Y1000();
                        break;

                    case OpcionesDispension.SEGUNDO_RETIRO:
                        Console.Clear();
                        dispensaciones.Billetes100Y500();
                        break;

                    case OpcionesDispension.EFECTIVA:
                        Console.Clear();
                      

                        dispensaciones.Eficiente();
                        break;
                }
            }
            else
            {
                Console.Clear();

               
                dispensaciones.Eficiente();
                
            }
            
        }
    }
}
