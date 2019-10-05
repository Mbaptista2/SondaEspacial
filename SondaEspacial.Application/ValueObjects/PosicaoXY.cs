using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEspacial.Application.ValueObjects
{
    public class PosicaoXY
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public PosicaoXY(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {

            var posicao = obj as PosicaoXY;
            return posicao != null &&
                   X == posicao.X &&
                   Y == posicao.Y;

        }
    }
}
