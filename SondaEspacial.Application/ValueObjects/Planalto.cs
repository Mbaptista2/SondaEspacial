using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEspacial.Application
{
    public class Planalto
    {
        public Coordenada _coordenada { get; private set; }

        public void Criar(Coordenada coordenada)
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
