using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CatalogoJogos.Api.Models;

public class Jogo
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("titulo")]
    public string Titulo { get; set; } = null!;

    [BsonElement("plataforma")]
    public string Plataforma { get; set; } = null!;

    [BsonElement("genero")]
    public string Genero { get; set; } = null!;

    [BsonElement("preco")]
    [BsonRepresentation(BsonType.Decimal128)]
    public decimal Preco { get; set; }

    [BsonElement("anoLancamento")]
    public int AnoLancamento { get; set; }

    [BsonElement("estoque")]
    public int Estoque { get; set; }
}