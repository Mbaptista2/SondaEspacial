using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEspacial.Application.ValueObjects
{
    public class PosicaoSonda
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public PosicaoSonda(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
