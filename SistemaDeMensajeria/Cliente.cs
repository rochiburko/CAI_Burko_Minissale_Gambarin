using System;
namespace SistemaDeMensajeria
{
    public class Cliente
	{
        public string nombreUsuario { get; set; }
        public int dni { get; set; }
        public int cuit { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int nroCelular { get; set; }
        public string correoElectronico { get; set; }
        public string idEnvios { get; set; }

        private string archivoDatosClientes = @"../../datos/Cliente.txt";

        public Cliente()
		{
		}

        public Cliente traerDatosCliente(String nombreUsuario)
        {
            var stream = File.OpenRead(archivoDatosClientes);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (datos[0].Equals(nombreUsuario))
                {
                    this.direccion = datos[1];
                    this.idEnvios = datos[2];
                    break;
                }
            }

            stream.Close();
            return this;
        }
    }
}


