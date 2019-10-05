using SondaEspacial.Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEspacial.Application.ValueObjects
{
    public class Sonda
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public Planalto Planalto { get; private set; }
        public PosicaoSonda PosicaoAtual { get; internal set; }
        public eDirecao DirecaoAtual { get; private set; }
               
        public Sonda()
        {            
        }

        public Sonda(string nome) 
        {            
            Nome = nome;
        }

        public void Explorar(Planalto planalto)
        {            
            Planalto = planalto;
        }

        public void IniciarEm(PosicaoSonda posicaoDesejada, eDirecao direcaoCardinalAtual)
        {                                       
            PosicaoAtual = posicaoDesejada;
            DirecaoAtual = direcaoCardinalAtual;
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
            movimento.Movimentar(this);
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
