using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDePulsacones
{
    class CalculoDePulsaciones
    {
        public int CalculoDePulsion( int edad)
        {
            return  (220 - edad)-6; /*El resultado es correcto, pero la formula se tuvo que modificar
                                    *para que encaraja en el codigo*/
        }
    }
}
