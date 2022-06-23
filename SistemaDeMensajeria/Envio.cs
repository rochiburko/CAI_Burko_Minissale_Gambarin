namespace SistemaDeMensajeria
{
    public class Envio
    {
        public int numeroSeguimiento { get; set; }
        public string estado { get; set; }
        public double peso { get; set; } 
        public string sucursalOrigen { get; set; }
        public string sucursalDestino { get; set; }
        public int documentoReceptor { get; set; }
        private string archivoDatosEnvios = "../../datos/envios.txt";


        public Envio()
        {
        }

        public Envio(string estado, double peso, string sucursalOrigen, string sucursalDestino, int documentoReceptor)
        {
            this.estado = estado;
            this.peso = peso;
            this.sucursalOrigen = sucursalOrigen;
            this.sucursalDestino = sucursalDestino;
            this.documentoReceptor = documentoReceptor;
        }

        public void asignarNumeroDeSeguimiento()
        {
            int numeroSeguimiento = 0;
            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (int.Parse(datos[0]) > numeroSeguimiento)
                {
                    //Obtengo el ultimo numero de seguimiento asignado a un pedido
                    numeroSeguimiento = (int.Parse(datos[0]));
                }
            }

            stream.Close();

            this.numeroSeguimiento = numeroSeguimiento + 1;
        }

        public void cargarEnvio()
        {

            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            List<string> lineas = new List<string>();


            if (new FileInfo(archivoDatosEnvios).Length != 0)
            {
                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    lineas.Add(linea);
                }
            }

            stream.Close();


            using (StreamWriter writer = new StreamWriter(archivoDatosEnvios))
            {
                foreach (string linea in lineas)
                {
                    writer.WriteLine(linea);
                }
                writer.WriteLine(this.numeroSeguimiento + ";"
                    + this.estado + ";"
                    + this.peso + ";"
                    + this.sucursalOrigen + ";"
                    + this.sucursalDestino + ";"
                    + this.documentoReceptor);

                writer.Close();
            }

        }

        public void consultarEnvio()
        {
            int numeroSeguimiento = 0;
            var stream = File.OpenRead(archivoDatosEnvios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (int.Parse(datos[0]) > numeroSeguimiento)
                {
                    //Obtengo el ultimo numero de seguimiento asignado a un pedido
                    numeroSeguimiento = (int.Parse(datos[0]));
                }
            }

            stream.Close();

            this.numeroSeguimiento = numeroSeguimiento + 1;
        }

    }
}