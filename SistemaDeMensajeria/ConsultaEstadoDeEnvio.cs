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

            Console.WriteLine("Por favor, ingrese el número de seguimiento del envio");
            string estadoEnvio = Console.ReadLine();
            // bool estadoDeEnvio = true;
            /* var stream = File.OpenRead(estadoEnvios);
             var reader = new StreamReader(stream);

             if (numeroSeguimiento != 123456)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("No se pudo encontrar dicha solicitud de envio");

             }
             else
             {
                 Console.WriteLine("El estado es: Lista para retirar en sucursarl");

             }*/

            // return estadoDeEnvio;

        }
    }
}

