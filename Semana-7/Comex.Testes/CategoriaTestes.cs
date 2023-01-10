using Comex.Models;
using FluentAssertions;

namespace Comex.Testes
{
    public class CategoriaTestes
    {

        [Fact]
        public void TestaCriacaoDeCategoria()
        {
            Categoria categoria = new Categoria("INFORMÁTICA", "INATIVA");
            categoria.Id.Should().BeGreaterThan(0);
            categoria.Nome.Should().Be("INFORMÁTICA");
            categoria.Status.Should().Be("INATIVA");
        }

        [Fact]
        public void TestaInformacoesDaCategoria()
        {
            Categoria categoria = new Categoria("INFORMÁTICA", "INATIVA");
            categoria.Informacoes().Should().Be("INFORMÁTICA (1 - INATIVA)");
        }
    }
}