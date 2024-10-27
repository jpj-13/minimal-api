using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculosTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var veiculo = new Veiculo
        {
            Id = 1,
            Nome = "New Fiesta",
            Marca = "Ford",
            Ano = 2017
        };

        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("New Fiesta", veiculo.Nome);
        Assert.AreEqual("Ford", veiculo.Marca);
        Assert.AreEqual(2017, veiculo.Ano);

        Assert.AreNotEqual(2, veiculo.Id);
        Assert.AreNotEqual("Celta", veiculo.Nome);
        Assert.AreNotEqual("Wolks", veiculo.Marca);
        Assert.AreNotEqual(2010, veiculo.Ano);
    }
}