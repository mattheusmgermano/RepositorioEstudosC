using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpRefatoracao._1_CodeSmells
{
    class Motoboy
    {
        private int qtdeEntregasNoturnas;

        int GetAvaliacao()
        {
            return (qtdeEntregasNoturnas > 5) ? 2 : 1;
        }
    }
}