using Comex.Entidades;
using System.Security.Cryptography;

namespace Comex.Testes
{
    public class TestCliente
    {
        private Cliente cliente = new Cliente("Andre", "Sousa", "123456789-88", "77988124578", "Jo�o Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia");

        [Fact]
        public void TestaClienteInstancia()
        {
            Assert.Equal("Andre", cliente.Nome);
            Assert.Equal("Sousa", cliente.SobreNome);
            Assert.Equal("123456789-88", cliente.Cpf);
            Assert.Equal("77988124578", cliente.Telefone);
            Assert.Equal("Jo�o Alberto", cliente.Rua);
            Assert.Equal("12", cliente.NumeroEndereco);
            Assert.Equal("Bem querer", cliente.Complemento);
            Assert.Equal("Candeias", cliente.Bairro);
            Assert.Equal("Salvador", cliente.Cidade);
            Assert.Equal("Bahia", cliente.Estado);
        }

        [Theory]
        [InlineData("Andre", "Sousa", "123456789-88", "77988124578", "Jo�o Alberto", "12", "Bem querer", "Candeias", "Salvador", "Bahia")]
        [InlineData("Luis", "Jardim", "987654321-88", "77988526341", "Luis ALberto", "13", "Bnh", "Recreio", "Rio de Janeiro", "Rio de Janeiro")]
        [InlineData("Lara", "Jesus", "852963741-88", "77988025698", "Carlos Henrique", "14", "Inocoop", "Centro", "Belo Horizonte", "Minas Gerais")]
        public void TestaCriacaoClientes(string nome, string sobreNome, string cpf, string fone, string rua, string numeroEndereco,
            string complemento, string bairro, string cidade, string estado)
        {
            Cliente novoCliente = new Cliente(nome, sobreNome, cpf, fone, rua, numeroEndereco, complemento, bairro, cidade, estado);

            Assert.Equal(nome, novoCliente.Nome);
            Assert.Equal(sobreNome, novoCliente.SobreNome);
            Assert.Equal(cpf, novoCliente.Cpf);
            Assert.Equal(fone, novoCliente.Telefone);
            Assert.Equal(rua, novoCliente.Rua);
            Assert.Equal(numeroEndereco, novoCliente.NumeroEndereco);
            Assert.Equal(complemento, novoCliente.Complemento);
            Assert.Equal(bairro, novoCliente.Bairro);
            Assert.Equal(cidade, novoCliente.Cidade);
            Assert.Equal(estado, novoCliente.Estado);
        }

        [Fact]
        public void TestaClienteNomeCompleto()
        {
            var nomeCompleto = cliente.NomeCompleto();
            var result = cliente.Nome + " " + cliente.SobreNome;
            Assert.Equal(result, nomeCompleto);
        }

        [Fact]
        public void TestaClienteEnderecoCompleto()
        {
            var enderecoCompleto = cliente.EnderecoCompleto();
            var result = $"Rua: {cliente.Rua}, n� {cliente.NumeroEndereco}, complemento: {cliente.Complemento},\n" +
                $"bairro: {cliente.Bairro}, cidade: {cliente.Cidade}, estado: {cliente.Estado}";
            Assert.Equal(result, enderecoCompleto);
        }

        [Fact]
        public void TestaClienteListarCliente()
        {
            var listarCliente = cliente.ListarCliente();
            var result = ($"***** C�digo do Cliente n� {cliente.Id} *****\n" +
                $"Nome: {cliente.NomeCompleto()}\n" +
                $"Endere�o: {cliente.EnderecoCompleto()}");
            Assert.Equal(result, listarCliente);
        }

    }
}