using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMensajeria
{
    class ConsultaEstadoDeEnvio

    {
        public int numeroSeguimiento { get; set; }
        private string estadoEnvios = "../../datos/estadoEnvios.txt";
        public Cliente idEnvios;
        string estadoEnvio = null;
       

        public ConsultaEstadoDeEnvio(Cliente idEnvios)
       {
           this.idEnvios = idEnvios;
       }


        public void mostrarEstado()
        {

            Console.WriteLine("Por favor, ingrese el número de seguimiento del envio:");
            string estadoEnvio = Console.ReadLine();
            Console.Clear();

             if (estadoEnvio == "1234")
             {
                Console.WriteLine("Su envio se encuentra listo  para retirar en sucursarl");
            }
             else
             {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Número de seguimiento invalido. No se pudo encontrar dicha solicitud de envio");
                
            }

        }
    }
}

