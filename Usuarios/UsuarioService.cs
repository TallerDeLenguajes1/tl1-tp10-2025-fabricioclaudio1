using System.Text.Json;

namespace EspacioUsuarios;

public static class UsuarioService
{
    public static async Task<List<Usuario>> ObtenerListaUsuarioAsinc()
    {
        HttpClient client = new HttpClient();

        string url = "https://jsonplaceholder.typicode.com/users/";
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();

        List<Usuario>? listUsuario = JsonSerializer.Deserialize<List<Usuario>>(responseBody);

        return listUsuario;
    }
}
