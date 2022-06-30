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
            Sucursal sucursalOrigen = new Sucursal();
            Sucursal sucursalDestino = new Sucursal();
            Boolean esSucursalOrigen = false;
            Boolean esSucursalDestino = false;
            bool primerIntento = true;

            Console.WriteLine(" ");

            //PESO
            Console.WriteLine("INGRESE EL PESO DEL PAQUETE (KG)");
            peso = Utils.solicitarPeso();
            Console.Clear();

            //PRIORIDAD DE ENVIO
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

            //ENVIO A DOMICILIO O A SUCURSAL
            Console.WriteLine("Seleccione si el origen del envio es una sucursal o domicilio particular");
            Console.WriteLine("1 - Domicilio particular");
            Console.WriteLine("2 - Sucursal");
            numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

            switch (numeroIngresado)
            {
                case 1:
                    esSucursalOrigen = false;
                    Console.Clear();
                    break;
                case 2:
                    esSucursalOrigen = true;
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
            }

            //ORIGEN
            sucursalOrigen = Sucursales.cargarSucursalOrigen(cliente);
            
            //Si el origen es un domicilio particular
            if (!esSucursalOrigen)
            {
                Console.WriteLine("Por favor indique la direccion (Calle y numeración) por la que debemos pasar a retirar el paquete");
                string direccion;
                primerIntento = true;
                do
                {
                    if (!primerIntento)
                    {
                        Console.WriteLine("Por favor, ingrese una direccion valida");
                    }
                    direccion = Console.ReadLine();
                    primerIntento = false;
                }
                while (String.IsNullOrWhiteSpace(direccion));

                sucursalOrigen.direccion = direccion;
            }
            Console.Clear();

            // DESTINO
            //ENVIO A DOMICILIO O A SUCURSAL
            Console.WriteLine("Seleccione si el destino del envio es una sucursal o domicilio particular");
            Console.WriteLine("1 - Domicilio particular");
            Console.WriteLine("2 - Sucursal");
            numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

            switch (numeroIngresado)
            {
                case 1:
                    esSucursalDestino = false;
                    Console.Clear();
                    break;
                case 2:
                    esSucursalDestino = true;
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
            }

            sucursalDestino = Sucursales.cargarSucursalDestino(cliente);

            //Si el destino es un domicilio particular
            if (!esSucursalDestino)
            {
                Console.WriteLine("Por favor indique la direccion (Calle y numeración) del destinatario");
                string direccion;
                primerIntento = true;
                do
                {
                    if (!primerIntento)
                    {
                        Console.WriteLine("Por favor, ingrese una direccion valida");
                    }
                    direccion = Console.ReadLine();
                    primerIntento = false;
                }
                while (String.IsNullOrWhiteSpace(direccion));

                sucursalDestino.direccion = direccion;
            }
            Console.Clear();

            //CLIENTE RECEPTOR
            Console.WriteLine("DATOS DEL DESTINATARIO");

            //nombre
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE EL NOMBRE DEL DESTINATARIO");
            string nombreReceptor;
            primerIntento = true;
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
            envio.calcularEnvioInternacional();
            envio.calcularEnvioNacional();
            envio.asignarNumeroDeSeguimiento();
            envio.cargarEnvioEnTXTEnvios();
            envio.cargarEnvioEnTXTClientes(cliente.nombreUsuario, envio.numeroSeguimiento);

            return envio;
        }

        public static void mostrarResumen(Envio envio, Cliente cliente)
        {
            Console.WriteLine("RESUMEN DE SU SOLICITUD");
            Console.WriteLine($"Numero de seguimiento: {envio.numeroSeguimiento}");
            Console.WriteLine($"El peso declarado es: {envio.peso} kg");
            Console.WriteLine($"El DNI del receptor es: {envio.documentoReceptor}");
            Console.WriteLine($"El costo del envio es ${envio.costo}");

            if (envio.sucursalOrigen.localidad == null)
            {
                Console.WriteLine($"La sucursal de origen es: {envio.sucursalOrigen.pais}");
            } else
            {
                Console.WriteLine($"La sucursal de origen es: {envio.sucursalOrigen.provincia}, {envio.sucursalOrigen.localidad}");
            }

            if (envio.sucursalDestino.localidad == null)
            {
                Console.WriteLine($"La sucursal de destino es: {envio.sucursalDestino.pais}");
            }
            else
            {
                Console.WriteLine($"La sucursal de destino es: {envio.sucursalDestino.provincia}, {envio.sucursalDestino.localidad}");
            }

            Console.WriteLine(" ");
        }

    }
}
