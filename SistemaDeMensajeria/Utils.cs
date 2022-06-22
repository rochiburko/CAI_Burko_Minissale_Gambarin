using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMensajeria
{
    public static class Utils
    {
        public static int solcitarNumeroEntre(int numero1, int numero2)
        {
            int nroIngresado;
            Boolean esNroEntero;

            do
            {
                esNroEntero = int.TryParse(Console.ReadLine(), out nroIngresado);
            }
            while (nroIngresado < numero1 || nroIngresado > numero2 || esNroEntero == false);

            return nroIngresado;
        }

        public static bool validarInputSiNO()
        {
            string valorIngresado;
            bool esPrimerIntento = true;

            do
            {
                if (!esPrimerIntento)
                {
                    Console.Clear();
                    Console.WriteLine("Recuerde que debe responder con 'SI' o 'NO'");
                }
                valorIngresado = Console.ReadLine().ToUpper();
                esPrimerIntento = false;
            } while (!valorIngresado.Equals("SI") && !valorIngresado.Equals("NO"));

            Console.Clear();

            if (valorIngresado.Equals("SI"))
            {
                return true;
            }

            return false;
        }

    }

}

