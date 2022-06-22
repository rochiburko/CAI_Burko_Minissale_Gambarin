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

        public static void elegirTipoEnvio()
        {
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE EL NUMERO DEL TIPO DE ENVIO");
            Console.WriteLine("1 - Encomienda");
            Console.WriteLine("2 - correspondencia");
            Console.WriteLine("3 - Salir del programa");

            int numeroIngresado;

            numeroIngresado = solcitarNumeroEntre(0, 3);

            Console.Clear();

            switch (numeroIngresado)
            {
                case 1:
                    Console.WriteLine("Usted selecciono Solicitar envio. Elija el tipo de envio que desea realizar");
                    break;
                case 2:
                    Console.WriteLine("Usted selecciono Consultar estado de envio");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa");
                    break;
            }

        }

        public static int solcitarNumeroEntre(int numero1, int numero2)
        {
            int nroIngresado;
            Boolean esNroEntero;

            do
            {
                esNroEntero = int.TryParse(Console.ReadLine(), out nroIngresado);
            }
            while (nroIngresado < numero1 || nroIngresado > numero2 || esNroEntero == false);

            return nroIngresado;
        }
     
    }
}