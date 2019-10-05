using System;

namespace SondaEspacial.Application
{
    public class Coordenada
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
