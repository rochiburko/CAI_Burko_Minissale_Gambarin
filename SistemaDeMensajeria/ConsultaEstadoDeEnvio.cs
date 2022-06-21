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
        public string usuario { get; set; }
        public string estado { get; set; }
        public int dni { get; set; }
        public string localidad { get; set; }
        public string codigoPostal { get; set; }

        private string estadoEnvios = "../../datos/estadoEnvios.txt";
        private string archivoDatosSucursales = "../../datos/sucursales.txt";



     /*   public Estado(int numeroSeguimiento)
        {
            this.numeroSeguimiento = numeroSeguimiento;
        }*/


        public bool mostrarEstado()
        {
            bool estadoDeEnvio = true;
            var stream = File.OpenRead(estadoEnvios);
            var reader = new StreamReader(stream);

            if (numeroSeguimiento != 123456)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se pudo encontrar dicha solicitud de envio");

            }
            else
            {

                Console.WriteLine("El estado es: Lista para retirar en sucursarl");

            }



            var stream_sucursales = File.OpenRead(archivoDatosSucursales);
            var reader_sucursales = new StreamReader(stream_sucursales);


            if (new FileInfo(archivoDatosSucursales).Length != 0)
            {
                while (!reader_sucursales.EndOfStream)
                {
                    var linea = reader_sucursales.ReadLine();
                    string[] valores = linea.Split(';');

                }
            }

            return estadoDeEnvio;

        }
    }
}

