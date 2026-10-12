namespace CatalogoJogos.Api.Dtos;

public class RelatorioEstoquePlataformaDto
{
    public string Plataforma { get; set; } = null!;
    public int QuantidadeTitulos { get; set; }
    public decimal ValorTotalInventario { get; set; }
}