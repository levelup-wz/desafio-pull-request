using FluentAssertions;

namespace Comex.Testes
{
    public class CategoriaTestes
    {
        [Fact]
        public void TestaCriacaoDeCategoria()
        {
            Categoria categoria = new Categoria(1, "INFORM�TICA", "INATIVA");
            categoria.Id.Should().Be(1);
            categoria.Nome.Should().Be("INFORM�TICA");
            categoria.Status.Should().Be("INATIVA");
        }

        [Fact]
        public void TestaInformacoesDaCategoria()
        {
            Categoria categoria = new Categoria(1, "INFORM�TICA", "INATIVA");
            categoria.Informacoes().Should().Be("INFORM�TICA (1 - INATIVA)");
        }
    }
}