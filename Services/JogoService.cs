using CatalogoJogos.Api.Models;
using CatalogoJogos.Api.Repositories;

namespace CatalogoJogos.Api.Services;

public class JogoService
{
    private readonly IJogoRepository _repository;

    public JogoService(IJogoRepository repository)
    {
        _repository = repository;
    }

    // ===== Parte do Gustavo =====

    public async Task<List<Jogo>> ObterTodosAsync()
    {
        return await _repository.ObterTodosAsync();
    }

    public async Task<Jogo?> ObterPorIdAsync(string id)
    {
        return await _repository.ObterPorIdAsync(id);
    }

    public async Task<Jogo> CriarAsync(Jogo jogo)
    {
        return await _repository.CriarAsync(jogo);
    }
}