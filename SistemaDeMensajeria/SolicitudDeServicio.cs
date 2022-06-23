using System;
namespace SistemaDeMensajeria
{
	public class SolicitudDeServicio
	{
        private static string CARGADO = "cargado";
        private static string LISTO_DESPACHAR = "Listo para despachar";
        private static string EN_PROCESO = "En proceso de envio";
        private static string ENVIADO = "Enviado";

        public Cliente clienteEmisor { get; set; } //Estos datos se obtienen en forma automática del archivo
        public Cliente clienteReceptor { get; set; } //Datos del Receptor
        public Envio envio { get; set; }

        public SolicitudDeServicio(Cliente cliente)
		{
			this.clienteEmisor = cliente;
		}

        public void cargarDatos()
        {
            int numeroIngresado;
            string sucursalOrigen = null;
            string sucursalDestino = null;

            Console.WriteLine(" ");

            //PESO
            Console.WriteLine("Ingrese el peso del paquete, el mismo debe estar expresado en KG");
            double peso = Utils.solicitarPeso();
            Console.Clear();

            //SUCURSAL DE ORIGEN
            Console.WriteLine("DATOS DESTINO Y ORIGEN");
            Console.WriteLine("Seleccione sucursal de destino");
            Console.WriteLine("1 - CABA");
            Console.WriteLine("2 - Catamarca");
            Console.WriteLine("3 - Chaco");

            numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

            switch (numeroIngresado)
            {
                case 1:
                    sucursalOrigen = "CABA";
                    break;
                case 2:
                    sucursalOrigen = "Catamarca";
                    break;
                case 3:
                    sucursalOrigen = "Chaco";
                    break;
            }

            //SUCURSAL DE DESTINO
            Console.WriteLine("Seleccione sucursal de origen");
            Console.WriteLine("1 - CABA");
            Console.WriteLine("2 - Catamarca");
            Console.WriteLine("3 - Chaco");

            numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

            Console.Clear();

            switch (numeroIngresado)
            {
                case 1:
                    sucursalDestino = "CABA";
                    break;
                case 2:
                    sucursalDestino = "Catamarca";
                    break;
                case 3:
                    sucursalDestino = "Chaco";
                    break;
            }

            Console.Clear();

            //CLIENTE RECEPTOR
            Console.WriteLine("DATOS CLIENTE RECEPTOR");
            Console.WriteLine("Ingrese el nombre de quien va a recibir el paquete");
            string nombreReceptor = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido de quien va a recibir el paquete");
            string apellidoReceptor = Console.ReadLine();

            Console.WriteLine("Ingrese el documento de quien va a recibir el paquete");
            int documentoReceptor = Utils.solicitarDocumento();

            Envio envio = new Envio(CARGADO, peso, sucursalOrigen, sucursalDestino, documentoReceptor);
            envio.asignarNumeroDeSeguimiento();
            envio.cargarEnvio();
        }
    }
}
