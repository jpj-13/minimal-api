using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;

namespace Test.Mocks;

public class VeiculoServicoMock : IVeiculoServico
{
    private static List<Veiculo> veiculos = [
        new Veiculo{
            Id = 1,
            Nome = "New Fiesta",
            Marca = "Ford",
            Ano = 2017
        }
    ];

    public void Apagar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }
    public void Atualizar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }
    public Veiculo? BuscaPorId(int id)
    {
        return veiculos.Find(a => a.Id == id);
    }
    public void Incluir(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }
    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        throw new NotImplementedException();
    }
}