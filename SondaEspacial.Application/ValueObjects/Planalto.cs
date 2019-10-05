using SondaEspacial.Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEspacial.Application
{
    public class Planalto
    {
        public PosicaoXY _coordenada { get; private set; }

        public void Criar(PosicaoXY coordenada)
        {
            this._coordenada = coordenada;
        }

        public int PosicaoX()
        {
            return _coordenada.X;
        }
        public int PosicaoY()
        {
            return _coordenada.Y;
        }
    }
}
