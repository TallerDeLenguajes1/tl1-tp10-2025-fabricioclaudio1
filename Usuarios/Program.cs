using EspacioUsuarios;
using System.Runtime.Serialization;
using System.Text.Json;

List<Usuario> usu = await UsuarioService.ObtenerListaUsuarioAsinc();

Console.WriteLine("Primeros 5 USUARIOS");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"[{i + 1}]{usu[i].Nombre}, {usu[i].Correo}, {usu[i].Direccion?.Calle}");
}

//Serializo usu en formato Json y guardo el resultado en un archivo tareas.json donde se ejecuta la app
string pathArchivo = "C:\\repo-taller\\tl1-tp10-2025-fabricioclaudio1\\Usuarios\\usuario.json";
var option = new JsonSerializerOptions { WriteIndented = true };
string jsonString = JsonSerializer.Serialize(usu, option);
if (!File.Exists(pathArchivo))
{
    File.WriteAllText(pathArchivo, jsonString);
}

