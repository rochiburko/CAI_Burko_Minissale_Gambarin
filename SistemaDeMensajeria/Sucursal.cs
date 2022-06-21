namespace SistemaDeMensajeria
{
    public class Sucursal
    {
        public string region;
        public string localidad;
        public string provincia;
        public string codigoPostal;
        private string archivoDatosSucursales = "../../datos/sucursales.txt";

        public Sucursal()
        {
        }

        public bool obtenerDatosDeSucursal(string localidad)
        {
            bool sucursalValida = false;
            var stream = File.OpenRead(archivoDatosSucursales);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (datos[0].Equals(localidad))
                {
                    region = datos[1];
                    provincia = datos[2];
                    codigoPostal = datos[3];
                    sucursalValida = true;
                    break;
                }
            }

            stream.Close();
            return sucursalValida;
        }

        public List<string> obtenerLocalidadesSucursales()
        {
            List<string> sucursales = new List<string>();

            var stream = File.OpenRead(archivoDatosSucursales);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                sucursales.Add(datos[0]);
            }

            stream.Close();

            return sucursales;
        }
    }
}