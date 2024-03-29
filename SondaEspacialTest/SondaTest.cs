using SondaEspacial.Application;
using SondaEspacial.Application.Enums;
using SondaEspacial.Application.ValueObjects;
using System;
using Xunit;

namespace CSharpTestProject
{
    public class SondaTest
    {
        private Planalto planalto;             

        private Sonda IniciarSonda()
        {          
            var posicaoXY = new PosicaoXY(5, 5);
            planalto = new Planalto(posicaoXY);           
            Sonda sonda = new Sonda(planalto);                          
            return sonda;
        }


        [Fact]
        public void Teste_L_M_L_M_L_M_L_M_M()
        {
            Sonda sonda = IniciarSonda();

            var posicaoInicial = new PosicaoXY(1, 2);
            var posicaoFinal = new PosicaoXY(1, 3);
            sonda.IniciarPercurso(posicaoInicial, eDirecao.Norte);

            //L M L M L M L M M
            sonda.Virar(eDirecaoMovimento.Esquerda);
            sonda.Mover();
            sonda.Virar(eDirecaoMovimento.Esquerda);
            sonda.Mover();
            sonda.Virar(eDirecaoMovimento.Esquerda);
            sonda.Mover();
            sonda.Virar(eDirecaoMovimento.Esquerda);
            sonda.Mover();
            sonda.Mover();
          
            Assert.Equal(posicaoFinal, sonda.PosicaoAtual);
            Assert.Equal(eDirecao.Norte, sonda.DirecaoAtual);
        }

        [Fact]

        public void Teste_M_M_R_M_M_R_M_R_R_M()
        {
            Sonda sonda = IniciarSonda();

            var posicaoInicial = new PosicaoXY(3, 3);
            var posicaoFinal = new PosicaoXY(5, 1);
            sonda.IniciarPercurso(posicaoInicial, eDirecao.Leste);

            //M_M_R_M_M_R_M_R_R_M
            sonda.Mover();
            sonda.Mover();
            sonda.Virar(eDirecaoMovimento.Direita);
            sonda.Mover();
            sonda.Mover();
            sonda.Virar(eDirecaoMovimento.Direita);
            sonda.Mover();
            sonda.Virar(eDirecaoMovimento.Direita);
            sonda.Virar(eDirecaoMovimento.Direita);
            sonda.Mover();
           
            Assert.Equal(posicaoFinal, sonda.PosicaoAtual);
            Assert.Equal(eDirecao.Leste, sonda.DirecaoAtual);
        }
    }
}
