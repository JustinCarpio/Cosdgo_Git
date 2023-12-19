internal class Program
{
    private static void Main(string[] args)
    {

        // Crear un pastel simple
        var pastelSimple = new Pastel_Composite("Pastel de Chocolate", 15.0);

        // Agregar ingredientes al pastel simple
        var chocolate = new Ingredientes("Chocolate", 5.0, 200, "gramos");
        var azucar = new Ingredientes("Azúcar", 1, 100, "gramos");
        var harina = new Ingredientes("Harina", 1.0, 200, "gramos");
        var huevo = new Ingredientes("Huevo", 0.15, 3, "unidades");
        var leche = new Ingredientes ("leche", 0.75,1,"Litro");

        pastelSimple.Add(chocolate);
        pastelSimple.Add(azucar);
        pastelSimple.Add(harina);
        pastelSimple.Add(huevo);
        pastelSimple.Add(leche);

        // Mostrar información sobre el pastel simple y sus ingredientes
        Console.WriteLine($"Nombre del Pastel: {pastelSimple.Nombre}");
        Console.WriteLine($"Costo del Pastel: {pastelSimple.CostoTotal:C}");

        Console.WriteLine("\nIngredientes:");

        foreach (var ingrediente in pastelSimple.GetIngredientes())
        {
            if (ingrediente.GetType() == typeof(Ingredientes))
            {
                Console.WriteLine($"{ingrediente.Nombre}: {((Ingredientes)ingrediente).Cantidad} {((Ingredientes)ingrediente).Unidad}");
            }
        }

        // Crear un pastel compuesto con un pastel simple e ingredientes adicionales
        var pastelCompuesto = new Pastel_Composite("Pastel de Cumpleaños");

        // Agregar el pastel simple y más ingredientes al pastel compuesto
        pastelCompuesto.Add(pastelSimple); // Agregando el pastel simple como ingrediente
        var fresas = new Ingredientes("Fresas", 3.0, 150, "gramos");
        pastelCompuesto.Add(fresas);

        // Mostrar información sobre el pastel compuesto y sus ingredientes
        Console.WriteLine($"\nNombre del Pastel Compuesto: {pastelCompuesto.Nombre}");
        Console.WriteLine($"Costo del Pastel Compuesto: {pastelCompuesto.CostoTotal:C}");

        Console.WriteLine("\nIngredientes del Pastel Compuesto:");

        foreach (var ingrediente in pastelCompuesto.GetIngredientes())
        {
            if (ingrediente.GetType() == typeof(Ingredientes))
            {
                Console.WriteLine($"{ingrediente.Nombre}: {((Ingredientes)ingrediente).Cantidad} {((Ingredientes)ingrediente).Unidad}");
            }
            else if (ingrediente.GetType() == typeof(Pastel_Composite))
            {
                Console.WriteLine($"Subpastel: {ingrediente.Nombre} - Costo: {((Pastel_Composite)ingrediente).CostoTotal:C}");
            }
        }
    }
}