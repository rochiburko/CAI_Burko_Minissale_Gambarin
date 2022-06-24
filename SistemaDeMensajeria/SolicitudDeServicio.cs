using System;
namespace SistemaDeMensajeria
{
	public static class SolicitudDeServicio
	{
        private static string INGRESADO_EN_SISTEMA = "Ingresado en sistema";

        public static Envio cargarDatos(Cliente cliente)
        {
            int numeroIngresado;
            double peso;
            string prioridadPedido = null;
            string sucursalOrigen = null;
            string sucursalDestino = null;

            Console.WriteLine(" ");

            //PESO
            Console.WriteLine("INGRESE EL PESO DEL PAQUETE (KG)");
            peso = Utils.solicitarPeso();
            Console.Clear();

            //RAPIDEZ DE ENVIO
            Console.WriteLine("INGRESE LA PRIORIDAD DE SU PEDIDO, si es NORMAL o URGENTE");
            Console.WriteLine("1 - Normal");
            Console.WriteLine("2 - Urgente");
            numeroIngresado = Utils.solcitarNumeroEntre(1, 2);
            switch (numeroIngresado)
            {
                case 1:
                    prioridadPedido = "NORMAL";
                    break;
                case 2:
                    prioridadPedido = "URGENTE";
                    break;
            }

            Console.Clear();

            //SUCURSAL DE ORIGEN
            Console.WriteLine("INGRESE LA SUCURSAL DE ORIGEN");
            solicitarSucursal();
           
            numeroIngresado = Utils.solcitarNumeroEntre(1, 23);

            switch (numeroIngresado)
            {
                case 1:
                    sucursalOrigen = "Ciudad de Buenos Aires";
                    Console.Clear();
                    break;
                case 2:
                    sucursalOrigen = "Catamarca";
                    Console.Clear();
                    break;
                case 3:
                    sucursalOrigen = "Chaco";
                    Console.Clear();
                    break;
                case 4:
                    sucursalOrigen = "Chubut";
                    Console.Clear();
                    break;
                case 5:
                    sucursalOrigen = "Cordoba";
                    Console.Clear();
                    break;
                case 6:
                    sucursalOrigen = "Corrientes";
                    Console.Clear();
                    break;
                case 7:
                    sucursalOrigen = "Entre Rios";
                    Console.Clear();
                    break;
                case 8:
                    sucursalOrigen = "Formosa";
                    Console.Clear();
                    break;
                case 9:
                    sucursalOrigen = "Jujuy";
                    Console.Clear();
                    break;
                case 10:
                    sucursalOrigen = "La Pampa";
                    Console.Clear();
                    break;
                case 11:
                    sucursalOrigen = "La Rioja";
                    Console.Clear();
                    break;
                case 12:
                    sucursalOrigen = "Mendoza";
                    Console.Clear();
                    break;
                case 13:
                    sucursalOrigen = "Misiones";
                    Console.Clear();
                    break;
                case 14:
                    sucursalOrigen = "Neuquen";
                    Console.Clear();
                    break;
                case 15:
                    sucursalOrigen = "Rio Negro";
                    Console.Clear();
                    break;
                case 16:
                    sucursalOrigen = "Salta";
                    Console.Clear();
                    break;
                case 17:
                    sucursalOrigen = "San Juan";
                    Console.Clear();
                    break;
                case 18:
                    sucursalOrigen = "San Luis";
                    Console.Clear();
                    break;
                case 19:
                    sucursalOrigen = "Santa Cruz";
                    Console.Clear();
                    break;
                case 20:
                    sucursalOrigen = "Santa fe";
                    Console.Clear();
                    break;
                case 21:
                    sucursalOrigen = "Santiago del Estero";
                    Console.Clear();
                    break;
                case 22:
                    sucursalOrigen = "Tierra del Fuego";
                    Console.Clear();
                    break;
                case 23:
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
            }

            Console.Clear();

            //SUCURSAL DE DESTINO
            Console.WriteLine("INGRESE SUCURSAL DESTINO");
            solicitarSucursal();

            numeroIngresado = Utils.solcitarNumeroEntre(1, 23);

            switch (numeroIngresado)
            {
                case 1:
                    sucursalDestino = "Ciudad de Buenos Aires";
                    Console.Clear();
                    break;
                case 2:
                    sucursalDestino = "Catamarca";
                    Console.Clear();
                    break;
                case 3:
                    sucursalDestino = "Chaco";
                    Console.Clear();
                    break;
                case 4:
                    sucursalDestino = "Chubut";
                    Console.Clear();
                    break;
                case 5:
                    sucursalDestino = "Cordoba";
                    Console.Clear();
                    break;
                case 6:
                    sucursalDestino = "Corrientes";
                    Console.Clear();
                    break;
                case 7:
                    sucursalDestino = "Entre Rios";
                    Console.Clear();
                    break;
                case 8:
                    sucursalDestino = "Formosa";
                    Console.Clear();
                    break;
                case 9:
                    sucursalDestino = "Jujuy";
                    Console.Clear();
                    break;
                case 10:
                    sucursalDestino = "La Pampa";
                    Console.Clear();
                    break;
                case 11:
                    sucursalDestino = "La Rioja";
                    Console.Clear();
                    break;
                case 12:
                    sucursalDestino = "Mendoza";
                    Console.Clear();
                    break;
                case 13:
                    sucursalDestino = "Misiones";
                    Console.Clear();
                    break;
                case 14:
                    sucursalDestino = "Neuquen";
                    Console.Clear();
                    break;
                case 15:
                    sucursalDestino = "Rio Negro";
                    Console.Clear();
                    break;
                case 16:
                    sucursalDestino = "Salta";
                    Console.Clear();
                    break;
                case 17:
                    sucursalDestino = "San Juan";
                    Console.Clear();
                    break;
                case 18:
                    sucursalDestino = "San Luis";
                    Console.Clear();
                    break;
                case 19:
                    sucursalDestino = "Santa Cruz";
                    Console.Clear();
                    break;
                case 20:
                    sucursalDestino = "Santa fe";
                    Console.Clear();
                    break;
                case 21:
                    sucursalDestino = "Santiago del Estero";
                    Console.Clear();
                    break;
                case 22:
                    sucursalDestino = "Tierra del Fuego";
                    Console.Clear();
                    break;
                case 23:
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
            }

            Console.Clear();

            //CLIENTE RECEPTOR
            Console.WriteLine("DATOS DEL DESTINATARIO");

            //nombre
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE EL NOMBRE DEL DESTINATARIO");
            string nombreReceptor ;
            bool primerIntento = true;
            do
            {
                if (!primerIntento)
                {
                    Console.WriteLine("Por favor, ingrese un nombre valido ");
                }
                nombreReceptor = Console.ReadLine();
                primerIntento = false;
            }
            while (String.IsNullOrWhiteSpace(nombreReceptor));

            //apellido
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE EL APELLIDO DEL DESTINATARIO");
            string apellidoReceptor;
            primerIntento = true;
            do
            {
                if (!primerIntento)
                {
                    Console.WriteLine("Por favor, ingrese un apellido valido ");
                }
                apellidoReceptor = Console.ReadLine();
                primerIntento = false;
            }
            while (String.IsNullOrWhiteSpace(apellidoReceptor));

            //documento
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE EL DOCUMENTO DEL RECEPTOR");
            int documentoReceptor = Utils.solicitarDocumento();

            string nombreUsuario = cliente.nombreUsuario;
            Envio envio = new Envio(
                INGRESADO_EN_SISTEMA,
                nombreUsuario,
                peso,
                sucursalOrigen,
                sucursalDestino,
                documentoReceptor
                );

            envio.calcularCosto();
            envio.asignarNumeroDeSeguimiento();
            envio.cargarEnvioEnTXTEnvios();
            envio.cargarEnvioEnTXTClientes(cliente.nombreUsuario,envio.numeroSeguimiento);

            return envio;
        }

        public static void mostrarResumen(Envio envio, Cliente cliente)
        {
            Console.WriteLine("RESUMEN DE SU SOLICITUD");
            Console.WriteLine($"Numero de seguimiento: {envio.numeroSeguimiento}");
            Console.WriteLine($"El peso declarado es: {envio.peso}");
            Console.WriteLine($"La sucursal de origen es: {envio.sucursalOrigen}");
            Console.WriteLine($"La sucursal de destino es: {envio.sucursalDestino}");
            Console.WriteLine($"El DNI del receptor es: {envio.documentoReceptor}");
            Console.WriteLine($"El costo del envio es ${envio.costo}");
            Console.WriteLine(" ");
        }

        private static void solicitarSucursal()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Ciudad de Buenos Aires");
            Console.WriteLine("2 - Catamarca");
            Console.WriteLine("3 - Chaco");
            Console.WriteLine("4 - Chubut");
            Console.WriteLine("5 - Cordoba");
            Console.WriteLine("6 - Corrientes");
            Console.WriteLine("7 - Entre Rios");
            Console.WriteLine("8 - Formosa");
            Console.WriteLine("9 - Jujuy");
            Console.WriteLine("10 - La Pampa");
            Console.WriteLine("11 - La Rioja");
            Console.WriteLine("12 - Mendoza");
            Console.WriteLine("13 - Misiones");
            Console.WriteLine("14 - Neuquen");
            Console.WriteLine("15 - Rio Negro");
            Console.WriteLine("16 - Salta");
            Console.WriteLine("17 - San Juan");
            Console.WriteLine("18 - San Luis");
            Console.WriteLine("19 - Santa Cruz");
            Console.WriteLine("20 - Santa Fe");
            Console.WriteLine("21 - Santiago Del Estero");
            Console.WriteLine("22 - Tierra del Fuego");
            Console.WriteLine("23 - Volver al menu principal");
        }
    }
}
