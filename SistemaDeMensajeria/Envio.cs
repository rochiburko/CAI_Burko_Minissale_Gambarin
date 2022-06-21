namespace SistemaDeMensajeria
{
    public class Envio
    {
        public int numeroSeguimiento { get; set; }
        public string tipoEnvio { get; set; } 
        public double peso { get; set; } //Si es correspondencia no se solicitara el peso
        public Sucursal sucursalOrigen { get; set; }
        public string direccionDestino { get; set; }
        private string archivoDatosSucursales = "../../datos/envios.txt";
        
        public Envio()
        {
        }

        public int asignarNumeroDeSeguimiento()
        {
            int numeroSeguimiento = 0;
            var stream = File.OpenRead(archivoDatosSucursales);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (int.Parse(datos[0]) > numeroSeguimiento) {
                    //Obtengo el ultimo numero de seguimiento asignado a un pedido
                    numeroSeguimiento = (int.Parse(datos[0]));
                }
            }

            stream.Close();

            return numeroSeguimiento + 1;
        }
    }
}