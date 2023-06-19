using Microsoft.VisualStudio.TestTools.UnitTesting;
using interface_api.Servicos;
using interface_api.Database;
using interface_api.Entidades;

namespace tests.Servicos;

[TestClass]
public class ValidacoesTest
{
    [TestMethod]
    public void TestarComCpfInvalido()
    {
        // Arrange
        bool valido = false;

        // Act
        valido = Validacaoes.isCpf("23432123432");

        // Assert
        Assert.IsFalse(valido);
    }

    [TestMethod]
    public void TestarComCpfInvalidoComPonto()
    {
        // Arrange
        bool valido = false;

        // Act
        valido = Validacaoes.isCpf("234.321.234-32");

        // Assert
        Assert.IsFalse(valido);
    }

    [TestMethod]
    public void TestarComCpfValido()
    {
        // Arrange
        bool valido = false;

        // Act
        valido = Validacaoes.isCpf("995.743.900-63");

        // Assert
        Assert.IsTrue(valido);
    }

    [TestMethod]
    public void TestarComCpfValidoSemPonto()
    {
        // Arrange
        bool valido = false;

        // Act
        valido = Validacaoes.isCpf("99574390063");

        // Assert
        Assert.IsTrue(valido);
    }

    [TestMethod]
    public void TestarComCpfNull()
    {
        // Arrange
        bool valido = false;

        // Act
        valido = Validacaoes.isCpf(null);

        // Assert
        Assert.IsFalse(valido);
    }

    [TestMethod]
    public void TestarComCpfEmpty()
    {
        // Arrange
        bool valido = false;

        // Act
        valido = Validacaoes.isCpf("");

        // Assert
        Assert.IsFalse(valido);
    }
}