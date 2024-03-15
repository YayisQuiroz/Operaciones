using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraApp
{
    internal class operacion
    {
        protected double n1, n2;
        protected double resultados;

        #region Propiedades
        public double N1
        {
            get { return n1; }
            set { n1 = value; }
        }
        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }
        public double Resultado
        {
            get { return resultados; }
        }
        #endregion
        #region Constructores
        public operacion()
        {
            n1 = 0;
            n2 = 0;
            resultados = 0;
        }
        public operacion(int n1,int n2, int resultados)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.resultados = resultados;
        }
        #endregion
        #region metodos
        public virtual double calcular()
        {
            return resultados;
        }
        #endregion

    }
}
