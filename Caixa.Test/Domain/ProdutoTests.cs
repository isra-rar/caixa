using Caixa.Domain.Entities;
using Caixa.Domain.Enums;
using Caixa.Domain.Repositories;
using NSubstitute;
using Xunit;

namespace Caixa.Test.Domain
{
    public class ProdutoTests
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoTests()
        {
            _produtoRepository = Substitute.For<IProdutoRepository>();
        }

        [Fact]
        public void CreateProdutoSucess()
        {
            // Arrange
            var produto = new Produto("Pastel de Frango", 5, 10, ETipoProduto.SALGADO);

            // Act
            _produtoRepository.Create(produto);

            // Assert
            _produtoRepository.Received().Create(Arg.Any<Produto>());
            Assert.Equal("Pastel de Frango", produto.Nome);
            Assert.Equal(5, produto.Valor);
        }
    }
}
