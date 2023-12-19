class Pastel_Composite : Componentes
{
    // Lista para almacenar los ingredientes del pastel (puede ser otro Pastel_Composite o un componente simple)
    private List<Componentes> ingredientes = new List<Componentes>();

    // Propiedad para obtener el costo total del pastel, considerando los costos de todos los ingredientes
    public double CostoTotal
    {
        get
        {
            // Variable para almacenar el costo total del pastel
            double costo = 0;

            // Iterar a través de cada elemento en la lista de ingredientes
            foreach (var oElemento in ingredientes)
            {
                // Verificar si el elemento es un Pastel_Composite
                if (oElemento.GetType().Name == "Pastel_Composite")
                    // Si es un Pastel_Composite, agregar su costo total al costo total del pastel
                    costo += ((Pastel_Composite)oElemento).CostoTotal;
                else
                    // Si no es un Pastel_Composite, agregar su costo al costo total del pastel
                    costo += oElemento.Costo;
            }

            // Devolver el costo total del pastel
            return costo;
        }
    }

    // Método para agregar un componente (ingrediente) al pastel
    public void Add(Componentes oElemento)
    {
        ingredientes.Add(oElemento);
    }

    // Método para remover un componente (ingrediente) del pastel
    public void Remove(Componentes oElemento)
    {
        ingredientes.Remove(oElemento);
    }

    // Método para obtener la lista de ingredientes del pastel
    public List<Componentes> GetIngredientes()
    {
        return ingredientes;
    }

    // Constructor de la clase Pastel_Composite que recibe el nombre y el costo (por defecto, el costo es 0)
    public Pastel_Composite(string Nombre, double Costo = 0) : base(Nombre, Costo)
    {
    }
}