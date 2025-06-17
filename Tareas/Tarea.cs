using System.Text.Json.Serialization;

namespace EspacioTarea;

public class Tarea
{
    int usuarioId;
    int id;
    string? titulo;
    bool completado;

    [JsonPropertyName("userId")]
    public int UsuarioId { get => usuarioId; set => usuarioId = value; }
    [JsonPropertyName("id")]
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("title")]
    public string? Titulo { get => titulo; set => titulo = value; }
    [JsonPropertyName("completed")]
    public bool Completado { get => completado; set => completado = value; }

}