using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTest
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTest()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContarCaracteres()
        {
            //Arrange
            string texto = "Ola";

            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);
        }
    }
}