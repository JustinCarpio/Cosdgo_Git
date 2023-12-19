class Ingredientes : Componentes
{
    //Se refiere a los ingredientes que ingresan ejemplo 2 huevos, 0.5 de leche....
     public double Cantidad {get; set;}
     //se refiere a gramos, kg, litros etc...
    public string Unidad {get; set;} //se refiere a gramos, kg, litros etc...
    
    /*Es el contructor que se hereda de los ingredientes.
    y se le añade estos nuevos componentes como la unidad y cantidad.*/
    public Ingredientes(string Nombre, double Costo, double Cantidad, string Unidad) 
        : base(Nombre, Costo)
        {
            this.Cantidad = Cantidad;
            this.Unidad = Unidad;
        }
        
        
}