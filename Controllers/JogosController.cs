using CatalogoJogos.Api.Models;
using CatalogoJogos.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoJogos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JogosController : ControllerBase
{
	private readonly JogoService _service;

	public JogosController(JogoService service)
	{
		_service = service;
	}

	// ===== Parte do Gustavo =====

	[HttpGet]
	public async Task<ActionResult<List<Jogo>>> ObterTodos()
	{
		var jogos = await _service.ObterTodosAsync();
		return Ok(jogos);
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Jogo>> ObterPorId(string id)
	{
		var jogo = await _service.ObterPorIdAsync(id);

		if (jogo is null)
			return NotFound();

		return Ok(jogo);
	}

	[HttpPost]
	public async Task<ActionResult<Jogo>> Criar(Jogo jogo)
	{
		var criado = await _service.CriarAsync(jogo);
		return CreatedAtAction(nameof(ObterPorId), new { id = criado.Id }, criado);
	}
}