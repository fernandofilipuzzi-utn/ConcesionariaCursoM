using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaMotos
{
class Program
{
    static void Main(string[] args)
    {
            
        #region motor
        int añoFabricacion = 0;
        double montoFabricacion = 0;
        double porcentajeDepreciacion = 10d/100;
        double montoActual;
        #endregion
        #region XEmbarque
        int numeroEmbarque =0;
        double acumuladoXEmbarque = 0;
        double cantEmbarques = 0;
        #endregion
        #region todos
        int añoActual = 0;
        double acumuladoEmbarques = 0;
        #endregion

        #region solicitar año actual
        Console.WriteLine("Ingrese el año actual");
        añoActual=Convert.ToInt32( Console.ReadLine() );
        #endregion

        //todos

        #region solicitar el número de embarque
        Console.WriteLine("Ingrese el número de embarque");
        numeroEmbarque = Convert.ToInt32(Console.ReadLine());
        #endregion

        acumuladoEmbarques = 0;
        while (numeroEmbarque>0)
        {
            #region inicilizar variables
            acumuladoXEmbarque = 0;
            #endregion

            #region solicitar el año de fabricación de la moto
            Console.WriteLine("Ingrese Año de fabricación de la moto a ingresar (0-corte)");
            añoFabricacion = Convert.ToInt32(Console.ReadLine());
            #endregion
            //xmoto
              
            while (añoFabricacion>0)
            {
                #region solicitar el monto de fabriación
                Console.WriteLine("Ingrese el monto de fabricación");
                montoFabricacion = Convert.ToDouble(Console.ReadLine());
                #endregion

                #region ingrese año de fabricación
                montoActual = montoFabricacion * Math.Pow(1-porcentajeDepreciacion, añoActual - añoFabricacion);
                #endregion

                acumuladoXEmbarque += montoActual;

                #region ingrese año de fabricación
                Console.WriteLine("Ingrese Año de fabricación (0-corte)");
                añoFabricacion = Convert.ToInt32(Console.ReadLine());
                #endregion


            }
            Console.Clear();
            Console.WriteLine("Monto del embarque ingresado: ${0:f2}",acumuladoXEmbarque);

            acumuladoEmbarques += acumuladoXEmbarque;

            Console.WriteLine("Presione una tecla para continuar con el siguiente embarque....");
            Console.ReadKey();

            #region solicitar el número de embarque
            Console.WriteLine("Ingrese el número de embarque");
            numeroEmbarque = Convert.ToInt32(Console.ReadLine());
            #endregion

            cantEmbarques++;
        }

        Console.Clear();
        Console.WriteLine("Monto de todos los embarques : ${0:f2}", acumuladoEmbarques);
        Console.WriteLine("Cantidad de embarques: ${0}", cantEmbarques);

        Console.WriteLine("Presione una tecla para terminar....");
        Console.ReadKey();
    }
        
}
}
