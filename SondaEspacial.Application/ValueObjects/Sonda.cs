using SondaEspacial.Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEspacial.Application.ValueObjects
{
    public class Sonda
    {        
        public Planalto Planalto { get; private set; }
        public PosicaoXY PosicaoAtual { get; internal set; }
        public eDirecao DirecaoAtual { get; private set; }

        public Sonda()
        {
        }
       
        public void Explorar(Planalto planalto)
        {
            Planalto = planalto;
        }

        public void IniciarPercurso(PosicaoXY posicaoInicial, eDirecao direcaoAtual)
        {
            try
            {
                if (posicaoInicial == null)
                    throw new Exception("É necessário informar a posição inicial da sonda.");


                if (posicaoInicial.X > Planalto.PosicaoX() || posicaoInicial.Y > Planalto.PosicaoY())
                    throw new Exception("Posição fora do planalto");


                PosicaoAtual = posicaoInicial;
                DirecaoAtual = direcaoAtual;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Virar(eDirecaoMovimento movimento)
        {
            if (movimento == eDirecaoMovimento.Direita)
                VirarParaDireta();
            else
                VirarParaEsquerda();
        }

        public void Mover(ICalcularMovimento movimento)
        {
            try
            {
                movimento.Movimentar(this);

                if (PosicaoAtual.X > Planalto.PosicaoX() || PosicaoAtual.Y > Planalto.PosicaoY())
                    throw new Exception("Posição fora do planalto");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void VirarParaEsquerda()
        {
            switch (DirecaoAtual)
            {
                case eDirecao.Norte:
                    {
                        DirecaoAtual = eDirecao.Oeste;
                        break;
                    }
                case eDirecao.Oeste:
                    {
                        DirecaoAtual = eDirecao.Sul;
                        break;
                    }
                case eDirecao.Sul:
                    {
                        DirecaoAtual = eDirecao.Leste;
                        break;
                    }
                case eDirecao.Leste:
                    {
                        DirecaoAtual = eDirecao.Norte;
                        break;
                    }
                default:
                    break;
            }
        }

        private void VirarParaDireta()
        {
            switch (DirecaoAtual)
            {
                case eDirecao.Norte:
                    {
                        DirecaoAtual = eDirecao.Leste;
                        break;
                    }
                case eDirecao.Leste:
                    {
                        DirecaoAtual = eDirecao.Sul;
                        break;
                    }
                case eDirecao.Sul:
                    {
                        DirecaoAtual = eDirecao.Oeste;
                        break;
                    }
                case eDirecao.Oeste:
                    {
                        DirecaoAtual = eDirecao.Norte;
                        break;
                    }
                default:
                    break;
            }


        }

    }
}
