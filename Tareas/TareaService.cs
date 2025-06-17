
using System.Text.Json;
using EspacioTarea;

public static class TareasService
{

  public static async Task<List<Tarea>> ObtenerTareasAsing()
  {
    HttpClient client = new HttpClient();

    string url = "https://jsonplaceholder.typicode.com/todos/";
    HttpResponseMessage response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();
    string responseBody = await response.Content.ReadAsStringAsync();
    List<Tarea>? listTarea = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
    return listTarea;
  }


}