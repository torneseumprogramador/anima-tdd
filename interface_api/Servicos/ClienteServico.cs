using interface_api.Database;
using interface_api.Entidades;

namespace interface_api.Servicos;

public class ClienteServico
{
    public ClienteServico(DatabaseContexto dbContexto)
    {
        this.dbContexto = dbContexto;
    }

    private DatabaseContexto dbContexto;
    private static List<Cliente> clientes = new List<Cliente>();

    public List<Cliente> Todos()
    {
        return ClienteServico.clientes;
    }

    public void Salvar(Cliente cliente)
    {
        ClienteServico.clientes.Add(cliente);
    }
}