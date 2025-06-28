
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using EspacioTarea;

List<Tarea> listTarea = await TareasService.ObtenerTareasAsin();
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

//Serializo listaTareaCompletas en formato Json y guardo el resultado en un archivo tareas.json donde se ejecuta la app
var option = new JsonSerializerOptions { WriteIndented = true };
string jsonString = JsonSerializer.Serialize(listTareaCompletas, option);
string pathArchivo = "C:\\repo-taller\\tl1-tp10-2025-fabricioclaudio1\\tareas.json";
if (!File.Exists(pathArchivo))
{
    File.WriteAllText(pathArchivo,jsonString);
}
