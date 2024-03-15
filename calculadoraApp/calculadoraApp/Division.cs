using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraApp
{
    internal class Division : operacion
    {
        public Division()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.resultados = 0;
        }
        public override double calcular()
        {
            resultados = (n1 / n2);
            return resultados;
        }
    }
}
