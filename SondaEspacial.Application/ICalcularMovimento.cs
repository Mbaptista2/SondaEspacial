using SondaEspacial.Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEspacial.Application
{
    public interface ICalcularMovimento
    {
        void Movimentar(Sonda sonda);
    }
}
