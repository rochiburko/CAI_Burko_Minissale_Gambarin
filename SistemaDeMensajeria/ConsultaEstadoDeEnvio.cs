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
        private string archivoDatosEnvios = "../../datos/envios.txt";

        public string consultar(List<int> envios)
        {
            listarEnvios(envios);
            int numeroIngresado = Utils.solicitarNumeroEnvioExistente(envios);
            return traerEstadoEnvio(numeroIngresado);

        }

        private void listarEnvios(List<int> envios)
        {

            Console.WriteLine("INGRESE EL NRO DE SEGUIMIENTO DLE ENVIO POR EL CUAL DESEA CONSULTAR");

            foreach (var envio in envios)
            {
                Console.WriteLine($"Envio con numero de seguimiento {envio}");
            }
        }

        private string traerEstadoEnvio(int numeroSeguimiento)
        {
            string estado = null;
            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (int.Parse(datos[0]).Equals(numeroSeguimiento))
                {
                    estado = datos[2];
                }
            }

            stream.Close();

            return estado;
        }

    }
}

