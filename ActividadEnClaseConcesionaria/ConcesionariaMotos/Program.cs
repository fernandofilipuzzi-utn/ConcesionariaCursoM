using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaMotos
{
class Program
{
    static void ImprimirMenu()
    {
        Console.Clear();
        Console.WriteLine("1- Entrar embarque");
        Console.WriteLine("2- Mostrar caja");
        Console.WriteLine("otro- salir");
    }

    static void Main(string[] args)
    {

        Concesionaria c = new Concesionaria();

        #region solicitar año actual
        Console.WriteLine("Ingrese el año actual");
        c.añoActual = Convert.ToInt32(Console.ReadLine());
        #endregion

        int op;
        do
        {
            //Caratula del menu
            ImprimirMenu();
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Console.Clear();

                        #region solicitar el número de embarque
                        Console.WriteLine("Ingrese el número de embarque");
                        int numeroEmbarque = Convert.ToInt32(Console.ReadLine());
                        #endregion

                        c.IniciarEmbarque(numeroEmbarque);

                        #region solicitar el año de fabricación de la moto
                        Console.WriteLine("Ingrese Año de fabricación de la moto a ingresar (0-corte)");
                        int añoFabricacion = Convert.ToInt32(Console.ReadLine());
                        #endregion
                        //xmoto

                        while (añoFabricacion > 0)
                        {
                            #region solicitar el monto de fabriación
                            Console.WriteLine("Ingrese el monto de fabricación");
                            double montoFabricacion = Convert.ToDouble(Console.ReadLine());
                            #endregion

                            c.RegistrarMoto(añoFabricacion, montoFabricacion);

                            #region ingrese año de fabricación
                            Console.WriteLine("Ingrese Año de fabricación (0-corte)");
                            añoFabricacion = Convert.ToInt32(Console.ReadLine());
                            #endregion
                        }
                                                        
                        Console.Clear();
                        Console.WriteLine("Monto del embarque ingresado: ${0:f2}", c.acumuladoXEmbarque);

                           
                        c.FinalizarEmbarque();

                           

                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();

                        Console.WriteLine("Monto de todos los embarques : ${0:f2}", c.acumuladoEmbarques);
                        Console.WriteLine("Cantidad de embarques: {0}", c.cantEmbarques);

                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                    }
                    break;
            }
        } while (op > 0 && op <= 2);

    }
}
  
}
