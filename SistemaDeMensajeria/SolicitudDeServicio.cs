using System;
namespace SistemaDeMensajeria
{
	public static class SolicitudDeServicio
	{
        private static string INGRESADO_EN_SISTEMA = "Ingresado en sistema";
        private static string RECIBIDO = "Recibido";
        private static string LISTO_DESPACHAR = "Listo para despachar";
        private static string EN_PROCESO = "En proceso de envio";
        private static string ENVIADO = "Enviado";

        //       public Cliente clienteEmisor { get; set; } //Estos datos se obtienen en forma automática del archivo
        //       public Cliente clienteReceptor { get; set; } //Datos del Receptor
        //      public Envio envio { get; set; }

        //       public SolicitudDeServicio(Cliente cliente)
        //		{
        //			this.clienteEmisor = cliente;
        //		}

        public static Envio cargarDatos(Cliente cliente)
        {
            int numeroIngresado;
            string sucursalOrigen = null;
            string sucursalDestino = null;

            Console.WriteLine(" ");

            //PESO
            Console.WriteLine("INGRESE EL PESO DEL PAQUETE (KG)");
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

            string nombreUsuario = cliente.nombreUsuario;
            Envio envio = new Envio(
                INGRESADO_EN_SISTEMA,
                nombreUsuario, peso,
                sucursalOrigen,
                sucursalDestino,
                documentoReceptor
                );
            envio.asignarNumeroDeSeguimiento();
            envio.cargarEnvioEnTXTEnvios();
            envio.cargarEnvioEnTXTClientes(cliente.nombreUsuario,envio.numeroSeguimiento);

            return envio;
        }

        public static void mostrarResumen(Envio envio)
        {
            Console.WriteLine("RESUMEN DE SU SOLICITUD");
            Console.WriteLine($"Numero de seguimiento: {envio.numeroSeguimiento}");
            Console.WriteLine($"El peso declarado es: {envio.peso}");
            Console.WriteLine($"La sucursal de origen es: {envio.sucursalOrigen}");
            Console.WriteLine($"La sucursal de destino es: {envio.sucursalDestino}");
            Console.WriteLine($"El DNI del receptor es: {envio.documentoReceptor}");
        }
    }
}
