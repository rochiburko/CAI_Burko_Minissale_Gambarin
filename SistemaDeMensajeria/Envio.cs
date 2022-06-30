namespace SistemaDeMensajeria
{
    public class Envio
    {
        public int numeroSeguimiento { get; set; }
        public string estado { get; set; }
        public string nombreUsuario { get; set; }
        public double peso { get; set; } 
        public Sucursal origen { get; set; }
        public Sucursal destino { get; set; }
        public int documentoReceptor { get; set; }
        public string prioridad { get; set; }
        public string correoElectronicoReceptor { get; set; }
        public double costo { get; set; }


        private string archivoDatosEnvios = "../../datos/envios.txt";
        private string archivoDatosClientes = @"../../datos/Cliente.txt";

        public Envio(string prioridad, string estado, string nombreUsuario, double peso, Sucursal origen, Sucursal destino, int documentoReceptor)
        {
            this.prioridad = prioridad;
            this.estado = estado;
            this.nombreUsuario = nombreUsuario;
            this.peso = peso;
            this.origen = origen;
            this.destino = destino;
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
                    + this.origen + ";"
                    + this.destino + ";"
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

        //Tarifas para calculo de costos
        /* Datos caso de prueba
                2kg
                urgente
                domicilio particular
                centro
                cordoba
                general roca
                italia 1430

                sucursal
                internacional
                asia
        */

        public void calcularCosto()
        {
            if (destino.nacion.Equals("Nacional"))
            {
                if (peso <= 0.5)
                {
                    if (origen.localidad.Equals(destino.localidad))
                    {
                        costo = 200;
                    }
                    else if (origen.provincia.Equals(destino.provincia))
                    {
                        costo = 400;
                    }
                    else if (origen.region.Equals(destino.region))
                    {
                        costo = 600;
                    }
                    else if (origen.nacion.Equals(destino.nacion))
                    {
                        costo = 800;
                    }
                }
                else if (peso <= 10)
                {
                    if (origen.localidad.Equals(destino.localidad))
                    {
                        costo = 1000;
                    }
                    else if (origen.provincia.Equals(destino.provincia))
                    {
                        costo = 1200;
                    }
                    else if (origen.region.Equals(destino.region))
                    {
                        costo = 1400;
                    }
                    else if (origen.nacion.Equals(destino.nacion))
                    {
                        costo = 1600;
                    }
                }
                else if (peso <= 20)
                {
                    if (origen.localidad.Equals(destino.localidad))
                    {
                        costo = 1800;
                    }
                    else if (origen.provincia.Equals(destino.provincia))
                    {
                        costo = 2000;
                    }
                    else if (origen.region.Equals(destino.region))
                    {
                        costo = 2200;
                    }
                    else if (origen.nacion.Equals(destino.nacion))
                    {
                        costo = 2400;
                    }
                }
                else if (peso <= 30)
                {
                    if (origen.localidad.Equals(destino.localidad))
                    {
                        costo = 2600;
                    }
                    else if (origen.provincia.Equals(destino.provincia))
                    {
                        costo = 2800;
                    }
                    else if (origen.region.Equals(destino.region))
                    {
                        costo = 3000;
                    }
                    else if (origen.nacion.Equals(destino.nacion))
                    {
                        costo = 3200;
                    }
                }
            }

            else if (destino.nacion.Equals("Internacional"))
            {
                if (peso <= 0.5)
                {
                    if (destino.pais.Equals("Paises Limitrofes"))
                    {
                        costo = 1000;
                    }
                    else if (destino.pais.Equals("Resto de America Latina"))
                    {
                        costo = 2000;
                    }
                    else if (destino.nacion.Equals("América del Norte"))
                    {
                        costo = 3000;
                    }
                    else if (destino.pais.Equals("Europa"))
                    {
                        costo = 4000;
                    }
                    else if (destino.pais.Equals("Asia"))
                    {
                        costo = 5000;
                    }
                }
                else if (peso <= 10)
                {
                    if (destino.pais.Equals("Paises Limitrofes"))
                    {
                        costo = 6000;
                    }
                    else if (destino.pais.Equals("Resto de America Latina"))
                    {
                        costo = 7000;
                    }
                    else if (destino.nacion.Equals("América del Norte"))
                    {
                        costo = 8000;
                    }
                    else if (destino.pais.Equals("Europa"))
                    {
                        costo = 9000;
                    }
                    else if (destino.pais.Equals("Asia"))
                    {
                        costo = 10000;
                    }
                }
                else if (peso <= 20)
                {
                    if (destino.pais.Equals("Paises Limitrofes"))
                    {
                        costo = 11000;
                    }
                    else if (destino.pais.Equals("Resto de America Latina"))
                    {
                        costo = 12000;
                    }
                    else if (destino.nacion.Equals("América del Norte"))
                    {
                        costo = 13000;
                    }
                    else if (destino.pais.Equals("Europa"))
                    {
                        costo = 14000;
                    }
                    else if (destino.pais.Equals("Asia"))
                    {
                        costo = 15000;
                    }
                }
                else if (peso <= 30)
                {
                    if (destino.pais.Equals("Paises Limitrofes"))
                    {
                        costo = 16000;
                    }
                    else if (destino.pais.Equals("Resto de America Latina"))
                    {
                        costo = 17000;
                    }
                    else if (destino.nacion.Equals("América del Norte"))
                    {
                        costo = 18000;
                    }
                    else if (destino.pais.Equals("Europa"))
                    {
                        costo = 19000;
                    }
                    else if (destino.pais.Equals("Asia"))
                    {
                        costo = 20000;
                    }
                }
            }

            if (prioridad.Equals("URGENTE")) { 
                double adicional;
                adicional = costo * 0.2;

                //Tope $2000
                if (adicional > 2000)
                {
                    adicional = 2000;
                }

                costo += adicional;
            }

            if (origen.direccion != null)
            {
                costo += 400;
            }

            if (destino.direccion != null)
            {
                costo += 400;
            }

        }
    }
}