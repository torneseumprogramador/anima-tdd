using Microsoft.AspNetCore.Mvc;
using interface_api.Entidades;
using interface_api.Servicos;

namespace interface_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientesController : ControllerBase
{
    [HttpGet(Name = "clientes")]
    public Cliente Index(string cpf)
    {
        var cliente = new Cliente();
        cpf = validar(cpf);
        cliente.Cpf = cpf;

        return cliente;
    }

    private string validar(string cpf)
    {
        if(Validacaoes.isCpf(cpf))
            return $"{cpf} - validado";
        
        return $"{cpf} - invalidado";
    }
}
