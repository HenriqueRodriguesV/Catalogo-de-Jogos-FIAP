using CatalogoJogos.Api.Dtos;
using CatalogoJogos.Api.Models;
using CatalogoJogos.Api.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CatalogoJogos.Api.Repositories;

public class JogoRepository : IJogoRepository
{
    private readonly IMongoCollection<Jogo> _jogos;

    public JogoRepository(IMongoDatabase database, IOptions<MongoDbSettings> options)
    {
        _jogos = database.GetCollection<Jogo>(options.Value.JogosCollectionName);
    }

    // ===== Parte do Gustavo =====

    public async Task<List<Jogo>> ObterTodosAsync()
    {
        return await _jogos.Find(_ => true).ToListAsync();
    }

    public async Task<Jogo?> ObterPorIdAsync(string id)
    {
        return await _jogos.Find(j => j.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Jogo> CriarAsync(Jogo jogo)
    {
        jogo.Id = null; // garante que o Mongo gere o Id
        await _jogos.InsertOneAsync(jogo);
        return jogo;
    }

    // ===== Parte do Henrique (placeholders para o projeto compilar) =====

    public Task<bool> AtualizarAsync(string id, Jogo jogo)
        => throw new NotImplementedException();

    public Task<bool> RemoverAsync(string id)
        => throw new NotImplementedException();

    public Task<List<Jogo>> BuscarPorPlataformaEPrecoAsync(string plataforma, decimal precoMaximo)
        => throw new NotImplementedException();

    public Task<List<RelatorioEstoquePlataformaDto>> ObterRelatorioEstoqueAsync()
        => throw new NotImplementedException();
}