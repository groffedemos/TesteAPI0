using Microsoft.AspNetCore.Mvc;

namespace APISaudacao.Controllers;

[ApiController]
[Route("[controller]")]
public class SaudacoesController : ControllerBase
{
    private readonly ILogger<SaudacoesController> _logger;

    public SaudacoesController(ILogger<SaudacoesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<Saudacao> Get(string nome)
    {
        if (String.IsNullOrWhiteSpace(nome))
            return new BadRequestResult();

        return new Saudacao()
        {
            Mensagem = $"Olá {nome}",
            Horario = DateTime.UtcNow.AddHours(-3).ToString("HH:mm:ss")
        };
    }
}