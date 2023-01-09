using Comex.Entidades;
using Comex.Exceptions;
using FluentAssertions;
using Microsoft.VisualBasic;

namespace Comex.Testes
{
    public class TestEstoque
    {

        private Estoque estoqueTeste = new Estoque();

        [Fact]
        public void TestaEstoqueInstancia()
        {
            Assert.Equal(1000, estoqueTeste.Capacidade);
        }

        [Theory]
        [InlineData("Notebook Sansung", 1000.00, 100, "INFORMATICA")]
        [InlineData("Vacina", 500.00, 10, "SAUDE")]
        [InlineData("Livro de testes", 10.00, 100, "LIVROS")]

        public void TestaEstoqueV�riasInst�ncias(string nome, double valor, int estoque, string categoria)
        {
            var tipoCategoria = new Categoria(categoria);
            var produto = new Produto(nome, valor, estoque, tipoCategoria);
            
            estoqueTeste.RegistrarEntrada(produto);

            Assert.Equal((1000 - produto.QuantidadeEstoque), estoqueTeste.Capacidade);
            Assert.Equal(estoque, estoqueTeste.Ocupacao);
            Assert.Equal(((decimal)produto.CalcularValorEstoque()), estoqueTeste.Montante);
        }

        [Fact]
        public void TestaRegistrarV�riasEntradas()
        {
            Categoria informatica = new Categoria("inform�tica");
            Categoria saude = new Categoria("sa�de");
            Categoria livros = new Categoria("livros");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);
            ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabe�a", 112.90, 5, livros);
            Produto macbook = new Produto("Macbook Pro", 20000.00, 15, informatica);

            Estoque novoEstoqueTeste = new Estoque();
            novoEstoqueTeste.RegistrarEntrada(vacina);
            novoEstoqueTeste.RegistrarEntrada(useACabeca);
            novoEstoqueTeste.RegistrarEntrada(macbook);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal((vacina.QuantidadeEstoque + useACabeca.QuantidadeEstoque + macbook.QuantidadeEstoque), novoEstoqueTeste.Ocupacao);
            Assert.Equal(((decimal)vacina.CalcularValorEstoque() + (decimal)useACabeca.CalcularValorEstoque() + (decimal)macbook.CalcularValorEstoque()),novoEstoqueTeste.Montante);
        }

        [Fact]
        public void TestaRegistrarSa�da()
        {
            Categoria saude = new Categoria("sa�de");
            Categoria livros = new Categoria("livros");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);
            ProdutoIsento useACabeca = new ProdutoIsento("Use a Cabe�a", 112.90, 5, livros);

            Estoque novoEstoqueTeste = new Estoque();
            novoEstoqueTeste.RegistrarEntrada(vacina);
            novoEstoqueTeste.RegistrarEntrada(useACabeca);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal((vacina.QuantidadeEstoque + useACabeca.QuantidadeEstoque), novoEstoqueTeste.Ocupacao);
            Assert.Equal(((decimal)vacina.CalcularValorEstoque() + (decimal)useACabeca.CalcularValorEstoque()), novoEstoqueTeste.Montante);

            novoEstoqueTeste.ResistrarSaida(vacina);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal((useACabeca.QuantidadeEstoque), novoEstoqueTeste.Ocupacao);
            Assert.Equal(((decimal)useACabeca.CalcularValorEstoque()), novoEstoqueTeste.Montante);
        }

        [Fact]
        public void TestaZerarEstoque()
        {
            Categoria saude = new Categoria("sa�de");

            ProdutoIsento vacina = new ProdutoIsento("Vacina", 250.00, 500, saude);

            Estoque novoEstoqueTeste = new Estoque();
            novoEstoqueTeste.RegistrarEntrada(vacina);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal((vacina.QuantidadeEstoque), novoEstoqueTeste.Ocupacao);
            Assert.Equal(((decimal)vacina.CalcularValorEstoque()), novoEstoqueTeste.Montante);

            novoEstoqueTeste.ResistrarSaida(vacina);

            Assert.Equal((1000 - novoEstoqueTeste.Ocupacao), novoEstoqueTeste.Capacidade);
            Assert.Equal(0, novoEstoqueTeste.Ocupacao);
            Assert.Equal(0, novoEstoqueTeste.Montante);
        }

        [Theory(DisplayName = "Teste para lan�amentos de exce��es na classe Estoque, Adicionar ao estoque")]
        [InlineData("produtoNomeEntrada", 100, 1001, "informatica")]
        public void TestaEstoqueEntradaExceptions(string productNameEntry, int valueEntry, int quantityEntry, string categoriaEntry)
        {
            var estoqueTesteException = new Estoque();
            var instanceCategory = new Categoria(categoriaEntry);
            var instanceProduct = new Produto(productNameEntry, valueEntry, quantityEntry, instanceCategory);

            var act = () => estoqueTesteException.RegistrarEntrada(instanceProduct);

            instanceCategory.Should().NotBeNull();
            instanceProduct.Should().NotBeNull();
            estoqueTesteException.Ocupacao.Should().Be(0);
            estoqueTesteException.Capacidade.Should().Be(1000);
            act.Should().Throw<LimiteDeEstoqueExcedidoException>()
                .WithMessage($"A quantidade do estoque: {instanceProduct.QuantidadeEstoque} do produto: {instanceProduct.Nome} � maior que a capacidade dispon�vel: {estoqueTesteException.Capacidade}.");
        }

        [Theory(DisplayName = "Teste para lan�amentos de exce��es na classe Estoque, Sa�da do estoque")]
        [InlineData("produtoNomeSaida", 100, 900, "informatica")]
        public void TestaEstoqueSaidaExceptions(string productNameEntry, int valueEntry, int quantityEntry, string categoriaEntry)
        {
            var estoqueTesteException = new Estoque();
            var instanceCategory = new Categoria(categoriaEntry);
            var instanceProduct = new Produto(productNameEntry, valueEntry, quantityEntry, instanceCategory);

            var act = () => estoqueTesteException.ResistrarSaida(instanceProduct);

            instanceCategory.Should().NotBeNull();
            instanceProduct.Should().NotBeNull();
            estoqueTesteException.Ocupacao.Should().Be(0);
            estoqueTesteException.Capacidade.Should().Be(1000);
            act.Should().Throw<LimiteDeEstoqueExcedidoException>()
                .WithMessage($"N�o foi poss�vel efetuar a sa�da do produto: {instanceProduct.Nome}, pois n�o existe no estoque.");
        }
    }
}