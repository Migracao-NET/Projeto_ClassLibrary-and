using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinhaBiblioteca;

namespace Projeto_ClassLibrary.Tests
{
    [TestClass]
    public class MinhaClasseTests
    {
        [TestMethod]
        public void Saudacao_DeveRetornarMensagemCorreta_QuandoNomeForValido()
        {
            // Arrange
            var minhaClasse = new MinhaClasse();
            var nome = "João";
            var esperado = "Olá, João!";

            // Act
            var resultado = minhaClasse.Saudacao(nome);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Saudacao_DeveRetornarMensagemCorreta_QuandoNomeForVazio()
        {
            // Arrange
            var minhaClasse = new MinhaClasse();
            var nome = string.Empty;
            var esperado = "Olá, !";

            // Act
            var resultado = minhaClasse.Saudacao(nome);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void Saudacao_DeveRetornarMensagemCorreta_QuandoNomeForNulo()
        {
            // Arrange
            var minhaClasse = new MinhaClasse();
            string nome = null;
            var esperado = "Olá, !";

            // Act
            var resultado = minhaClasse.Saudacao(nome);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
