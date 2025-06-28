using System.Text.Json.Serialization;

namespace EspacioUsuarios;

public class GeoUsuario
{
    private string? latitud;
    private string? longitud;

    [JsonPropertyName("lat")]
    public string? Latitud { get => latitud; set => latitud = value; }
    [JsonPropertyName("lng")]
    public string? Longitud { get => longitud; set => longitud = value; }
}






