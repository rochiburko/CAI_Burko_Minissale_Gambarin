namespace SistemaDeMensajeria
{
    public class Envio
    {
        public int numeroSeguimiento { get; set; }
        public string estado { get; set; }
        public string nombreUsuario { get; set; }
        public double peso { get; set; } 
        public Sucursal sucursalOrigen { get; set; }
        public Sucursal sucursalDestino { get; set; }
        public int documentoReceptor { get; set; }
        public string prioridad { get; set; }
        public string correoElectronicoReceptor { get; set; }
        public double costo { get; set; }


        private string archivoDatosEnvios = "../../datos/envios.txt";
        private string archivoDatosClientes = @"../../datos/Cliente.txt";

        public Envio(string estado, string nombreUsuario, double peso, Sucursal sucursalOrigen, Sucursal sucursalDestino, int documentoReceptor)
        {
            this.estado = estado;
            this.nombreUsuario = nombreUsuario;
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

        public void cargarEnvioEnTXTEnvios()
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
                    + this.nombreUsuario + ";"
                    + this.estado + ";"
                    + this.peso + ";"
                    + this.sucursalOrigen + ";"
                    + this.sucursalDestino + ";"
                    + this.documentoReceptor + ";"
                    + this.costo);

                writer.Close();
            }

        }

        public void cargarEnvioEnTXTClientes(string nombreUsuario, int numeroSeguimientoNuevoEnvio)
        {

            string estado = null;
            var stream = File.OpenRead(archivoDatosClientes);
            var reader = new StreamReader(stream);
            int lineToEdit = 1;

            //Datos a sobreescribir
            string usuario = null;
            string direccion = null;
            string idEnvios = null;

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (datos[0].Equals(nombreUsuario))
                {
                    usuario = datos[0];
                    direccion = datos[1];
                    idEnvios = datos[2];
                    break;
                }

                lineToEdit++;
            }
            stream.Close();
            Utils.lineChanger($"{usuario};{direccion};{idEnvios}|{numeroSeguimientoNuevoEnvio}", archivoDatosClientes, lineToEdit);
            
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

        public void calcularCosto()
        {
            costo = peso * 100;
            if (this.prioridad == "URGENTE")
            {
                costo = costo * 1.3;
            }
        }

    }
}