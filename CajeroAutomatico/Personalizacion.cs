using System;
using System.Collections.Generic;
using System.Text;

namespace CajeroAutomatico
{
    public enum OpcionesDispension
    {
        PRIMER_RETIRO = 1,
        SEGUNDO_RETIRO,
        EFECTIVA
    }

    class Personalizacion
    {
        public static OpcionesDispension ModoDispension;
    }
}
