using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaMotos
{
    class Concesionaria
    {
        #region motor
       
        double porcentajeDepreciacion = 10d / 100;
        #endregion
        #region XEmbarque
        int numeroEmbarque = 0;
        public double acumuladoXEmbarque = 0;
        public double cantEmbarques = 0;
        #endregion
        #region todos
        public int añoActual = 0;
        public double acumuladoEmbarques = 0;
        #endregion

        public void IniciarEmbarque(int numeroEmbarque)
        {
            acumuladoXEmbarque = 0;
            this.numeroEmbarque = numeroEmbarque;
        }

        public double RegistrarMoto(int añoFabricacion, double montoFabricacion)
        {
            #region ingrese año de fabricación
            double montoActual = montoFabricacion * Math.Pow(1 - porcentajeDepreciacion, añoActual - añoFabricacion);
            #endregion
            acumuladoXEmbarque += montoActual;

            return montoActual;
        }

        public void FinalizarEmbarque()
        {
            acumuladoEmbarques += acumuladoXEmbarque;
            cantEmbarques++;
        }
    }
}
