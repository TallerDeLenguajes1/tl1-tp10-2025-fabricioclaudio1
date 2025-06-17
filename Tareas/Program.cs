
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;
using EspacioTarea;

List<Tarea> listTarea = await TareasService.ObtenerTareasAsing();
List<Tarea> listTareaCompletas = new List<Tarea>();

foreach (var item in listTarea)
{
    if (item.Completado == false)
    {
        Console.WriteLine($"Titulo: {item.Titulo}, Completado: {item.Completado}");
    }
    else
    {
        listTareaCompletas.Add(item);
    }
}

foreach (var item in listTareaCompletas)
{
    if (item.Completado == true)
    {
        Console.WriteLine($"Titulo: {item.Titulo}, Completado: {item.Completado}");
    }
}

