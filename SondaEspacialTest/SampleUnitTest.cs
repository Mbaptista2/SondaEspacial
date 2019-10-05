using SondaEspacial.Application;
using SondaEspacial.Application.Enums;
using SondaEspacial.Application.ValueObjects;
using System;
using Xunit;

namespace CSharpTestProject
{
    public class SampleUnitTest
    {
        private Planalto planalto;      
        private ICalcularMovimento calcularMovimento;

        private Sonda IniciarSonda()
        {
            Sonda sonda = new Sonda();
            var coordenada = new Coordenada(5, 5);
            planalto = new Planalto();
            planalto.Criar(coordenada);
            calcularMovimento = new CalcularMovimento();            
            sonda.Explorar(planalto);

            return sonda;
        }


        [Fact]
        public void Teste_L_M_L_M_L_M_L_M_M()
        {
            Sonda sonda = IniciarSonda();

            var posicaoInicial = new PosicaoSonda(1, 2);
            var posicaoEsperada = new PosicaoSonda(1, 3);
            sonda.IniciarEm(posicaoInicial, eDirecao.Norte);

            //L M L M L M L M M
            sonda.Virar(eDirecaoMovimento.Esquerda);
            sonda.Mover(calcularMovimento);
            sonda.Virar(eDirecaoMovimento.Esquerda);
            sonda.Mover(calcularMovimento);
            sonda.Virar(eDirecaoMovimento.Esquerda);
            sonda.Mover(calcularMovimento);
            sonda.Virar(eDirecaoMovimento.Esquerda);
            sonda.Mover(calcularMovimento);
            sonda.Mover(calcularMovimento);
          
            Assert.Equal(posicaoEsperada, sonda.PosicaoAtual);
            Assert.Equal(eDirecao.Norte, sonda.DirecaoAtual);
        }
    }
}
