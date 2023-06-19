using Microsoft.VisualStudio.TestTools.UnitTesting;
using interface_api.Servicos;
using interface_api.Database;
using interface_api.Entidades;

namespace tests.Servicos;

[TestClass]
public class ClienteServicoTest
{
    [TestMethod]
    public void TestarContrutorDaClasse()
    {
        // Arrange
        ClienteServico clienteServico;

        // Act
        clienteServico = new ClienteServico(new DatabaseContexto());

        // Assert
        Assert.IsNotNull(clienteServico);
    }


    [TestMethod]
    public void TestarMetodoTodos()
    {
        // Arrange
        List<Cliente> clientes;
        ClienteServico clienteServico;

        // Act
        clienteServico = new ClienteServico(new DatabaseContexto());
        clientes = clienteServico.Todos();

        // Assert
        Assert.IsNotNull(clientes);
        Assert.AreEqual(0, clientes.Count);
    }


    [TestMethod]
    public void TestarCriacaoDeNovoCliente()
    {
        // Arrange
        var cliente = new Cliente(){ Id = 1, Nome = "João" };
        ClienteServico clienteServico;

        // Act
        clienteServico = new ClienteServico(new DatabaseContexto());
        clienteServico.Salvar(cliente);
        var clientes = clienteServico.Todos();

        // Assert
        Assert.IsNotNull(clientes);
        Assert.AreEqual(1, clientes.Count);
        Assert.AreEqual("João", clientes[0].Nome);
    }
}