using System.Net.Sockets;
using System.Text.Json.Serialization;
namespace EspacioUsuarios;

public class Usuario
{
    private int id;
    private string? nombre;
    private string? nombreDeUsuario;
    private string? correo;
    private DireccionUsuario? direccion;
    private string? telefono;
    private string? sitioWeb;
    private CompaniaUsuario? compania;

    [JsonPropertyName("id")]
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("name")]
    public string? Nombre { get => nombre; set => nombre = value; }
    [JsonPropertyName("username")]
    public string? NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
    [JsonPropertyName("email")]
    public string? Correo { get => correo; set => correo = value; }
    [JsonPropertyName("address")]
    public DireccionUsuario? Direccion { get => direccion; set => direccion = value; }
    [JsonPropertyName("phone")]
    public string? Telefono { get => telefono; set => telefono = value; }
    [JsonPropertyName("website")]
    public string? SitioWeb { get => sitioWeb; set => sitioWeb = value; }
    [JsonPropertyName("company")]
    public CompaniaUsuario? Compania { get => compania; set => compania = value; }

}
