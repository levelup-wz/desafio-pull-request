using Comex.Comex.Models;
using Comex.Modelos.Categorias;
using Comex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Comex.Testes
{
    internal class TestaItensDoPedido
    {
        public void CalcularTotalDoPedido()
        {
            //Arrange - Set up the conditions for your test: creating objects, setting up variables...
            var itensDoPedido = new ItensDoPedido(new Produto("Livro Toefl", "Livro Preparatório", 100, 20, "Livros", "Azul"), 2);

            //Act - Cover the main thing to be tested: calling a function or method, calling a REST API, or interacting with a web page.
            decimal totalPedido = itensDoPedido.Total;

            //Assert - Verify that the code you’re testing behaves as expected.
            Assert.Equal(20000, totalPedido);

        }
    }
}
