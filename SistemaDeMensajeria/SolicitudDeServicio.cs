using System;
namespace SistemaDeMensajeria
{
	public static class SolicitudDeServicio
	{
        private static string INGRESADO_EN_SISTEMA = "Ingresado en sistema";

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

            //RAPIDEZ DE ENVIO
            Console.WriteLine("INGRESE LA PRIORIDAD DE SU PEDIDO, si es NORMAL o URGENTE");
            string rapidez = Console.ReadLine();
            Console.Clear();


            //SUCURSAL DE ORIGEN
            Console.WriteLine("INGRESE LA SUCURSAL DE ORIGEN");
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


            numeroIngresado = Utils.solcitarNumeroEntre(1, 23);

            switch (numeroIngresado)
            {
                case 1:
                    sucursalOrigen = "Ciudad de Buenos Aires";
                    break;
                case 2:
                    sucursalOrigen = "Catamarca";
                    break;
                case 3:
                    sucursalDestino = "Chaco";
                    break;
                case 4:
                    sucursalDestino = "Chubut";
                    break;
                case 5:
                    sucursalDestino = "Cordoba";
                    break;
                case 6:
                    sucursalDestino = "Corrientes";
                    break;
                case 7:
                    sucursalDestino = "Entre Rios";
                    break;
                case 8:
                    sucursalDestino = "Formosa";
                    break;
                case 9:
                    sucursalDestino = "Jujuy";
                    break;
                case 10:
                    sucursalDestino = "La Pampa";
                    break;
                case 11:
                    sucursalDestino = "La Rioja";
                    break;
                case 12:
                    sucursalDestino = "Mendoza";
                    break;
                case 13:
                    sucursalDestino = "Misiones";
                    break;
                case 14:
                    sucursalDestino = "Neuquen";
                    break;
                case 15:
                    sucursalDestino = "Rio Negro";
                    break;
                case 16:
                    sucursalDestino = "Salta";
                    break;
                case 17:
                    sucursalDestino = "San Juan";
                    break;
                case 18:
                    sucursalDestino = "San Luis";
                    break;
                case 19:
                    sucursalDestino = "Santa Cruz";
                    break;
                case 20:
                    sucursalDestino = "Santa fe";
                    break;
                case 21:
                    sucursalDestino = "Santiago del Estero";
                    break;
                case 22:
                    sucursalDestino = "Tierra del Fuego";
                    break;
                case 23:
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
            }


            Console.Clear();

            //SUCURSAL DE DESTINO
            Console.WriteLine("INGRESE SUCURSAL DESTINO");
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

            numeroIngresado = Utils.solcitarNumeroEntre(1, 23);

            Console.Clear();


            switch (numeroIngresado)
            {
                case 1:
                    sucursalOrigen = "Ciudad de Buenos Aires";
                    break;
                case 2:
                    sucursalOrigen = "Catamarca";
                    break;
                case 3:
                    sucursalDestino = "Chaco";
                    break;
                case 4:
                    sucursalDestino = "Chubut";
                    break;
                case 5:
                    sucursalDestino = "Cordoba";
                    break;
                case 6:
                    sucursalDestino = "Corrientes";
                    break;
                case 7:
                    sucursalDestino = "Entre Rios";
                    break;
                case 8:
                    sucursalDestino = "Formosa";
                    break;
                case 9:
                    sucursalDestino = "Jujuy";
                    break;
                case 10:
                    sucursalDestino = "La Pampa";
                    break;
                case 11:
                    sucursalDestino = "La Rioja";
                    break;
                case 12:
                    sucursalDestino = "Mendoza";
                    break;
                case 13:
                    sucursalDestino = "Misiones";
                    break;
                case 14:
                    sucursalDestino = "Neuquen";
                    break;
                case 15:
                    sucursalDestino = "Rio Negro";
                    break;
                case 16:
                    sucursalDestino = "Salta";
                    break;
                case 17:
                    sucursalDestino = "San Juan";
                    break;
                case 18:
                    sucursalDestino = "San Luis";
                    break;
                case 19:
                    sucursalDestino = "Santa Cruz";
                    break;
                case 20:
                    sucursalDestino = "Santa fe";
                    break;
                case 21:
                    sucursalDestino = "Santiago del Estero";
                    break;
                case 22:
                    sucursalDestino = "Tierra del Fuego";
                    break;
                case 23:
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
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

        public static void mostrarResumen(Envio envio, Cliente cliente)
        {
            Console.WriteLine("RESUMEN DE SU SOLICITUD");
            Console.WriteLine($"Numero de seguimiento: {envio.numeroSeguimiento}");
            Console.WriteLine($"El peso declarado es: {envio.peso}");
            Console.WriteLine($"La sucursal de origen es: {envio.sucursalOrigen}");
            Console.WriteLine($"La sucursal de destino es: {envio.sucursalDestino}");
            Console.WriteLine($"El DNI del receptor es: {envio.documentoReceptor}");
            Console.WriteLine(" ");
        }
    }
}
