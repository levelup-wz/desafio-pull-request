using FluentAssertions;

namespace Comex.Testes
{
    public class CategoriaTestes
    {

        [Fact]
        public void TestaCriacaoDeCategoria()
        {
            Categoria categoria = new Categoria("INFORM�TICA", "INATIVA");
            categoria.Id.Should().BeGreaterThan(0);
            categoria.Nome.Should().Be("INFORM�TICA");
            categoria.Status.Should().Be("INATIVA");
        }

        [Fact]
        public void TestaInformacoesDaCategoria()
        {
            Categoria categoria = new Categoria("INFORM�TICA", "INATIVA");
            categoria.Informacoes().Should().Be("INFORM�TICA (1 - INATIVA)");
        }
    }
}