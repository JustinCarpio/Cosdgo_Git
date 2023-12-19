using System;
using System.Collections.Generic;
abstract class Componentes
{
    /*Generamos los componentes pricipales para la elaboracion de un pastel
    que se fabricaria al Costo */

    /*Colocamos el nonbre del pastel */
    public string Nombre {get; set;}
    /*Colocamos el costo en que sale el pastel por sus ingredientes*/
    public double Costo {get; set;}

//El contructor para poder utilizarlo en otras clases.
    protected Componentes(string Nombre, double Costo)
        {
            this.Nombre = Nombre;
            this.Costo = Costo;
        }
}