using System.Text.Json.Serialization;

namespace EspacioUsuarios;

public class DireccionUsuario
{
    private string? calle;
    private string? departamento;
    private string? ciudad;
    private string? codigoPostal;
    private GeoUsuario? coordenadas;
    
    [JsonPropertyName("street")]
    public string? Calle { get => calle; set => calle = value; }
    [JsonPropertyName("suite")]
    public string? Departamento { get => departamento; set => departamento = value; }
    [JsonPropertyName("city")]
    public string? Ciudad { get => ciudad; set => ciudad = value; }
    [JsonPropertyName("zipcode")]
    public string? CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
    [JsonPropertyName("geo")]
    internal GeoUsuario? Coordenadas { get => coordenadas; set => coordenadas = value; }

}














