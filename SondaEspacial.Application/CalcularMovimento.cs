using System;
using System.Collections.Generic;
using System.Text;
using SondaEspacial.Application.Enums;
using SondaEspacial.Application.ValueObjects;

namespace SondaEspacial.Application
{
    public class CalcularMovimento : ICalcularMovimento
    {
        public void Movimentar(Sonda sonda)
        {
            switch (sonda.DirecaoAtual)
            {
                case eDirecao.Norte:
                    sonda.PosicaoAtual = new PosicaoXY(sonda.PosicaoAtual.X, sonda.PosicaoAtual.Y + 1);
                    break;
                case eDirecao.Leste:
                    sonda.PosicaoAtual = new PosicaoXY(sonda.PosicaoAtual.X + 1, sonda.PosicaoAtual.Y);
                    break;
                case eDirecao.Sul:
                    sonda.PosicaoAtual = new PosicaoXY(sonda.PosicaoAtual.X, sonda.PosicaoAtual.Y - 1);
                    break;
                case eDirecao.Oeste:
                    sonda.PosicaoAtual = new PosicaoXY(sonda.PosicaoAtual.X - 1, sonda.PosicaoAtual.Y);
                    break;
            }
        }
    }
}
