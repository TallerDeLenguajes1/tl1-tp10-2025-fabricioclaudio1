using System.Text.Json.Serialization;

namespace EspacioUsuarios;

public class CompaniaUsuario
{
    private string? nombre;
    private string? eslogan;
    private string? vision;

    [JsonPropertyName("name")]
    public string? Nombre { get => nombre; set => nombre = value; }
    [JsonPropertyName("catchPhrase")]
    public string? Eslogan { get => eslogan; set => eslogan = value; }
    [JsonPropertyName("bs")]
    public string? Vision { get => vision; set => vision = value; }
}