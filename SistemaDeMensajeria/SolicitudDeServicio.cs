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
            string sucursalDestino = null;

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

            //SUCURSAL ORIGEN
            Sucursales.cargarSucursalOrigen(cliente);

            //CLIENTE RECEPTOR
            Console.WriteLine("DATOS DEL DESTINATARIO");

            //nombre
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE EL NOMBRE DEL DESTINATARIO");
            string nombreReceptor;
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
            envio.cargarEnvioEnTXTClientes(cliente.nombreUsuario, envio.numeroSeguimiento);

            return envio;
        }

    }

    public static void mostrarResumen(Envio envio, Cliente cliente)
    {
        Console.WriteLine("RESUMEN DE SU SOLICITUD");
        Console.WriteLine($"Numero de seguimiento: {envio.numeroSeguimiento}");
        Console.WriteLine($"El peso declarado es: {envio.peso}");
        Console.WriteLine($"La sucursal de origen es: {envio.sucursalOrigen.localidad}");
        Console.WriteLine($"La sucursal de destino es: {envio.sucursalDestino.localidad}");
        Console.WriteLine($"El DNI del receptor es: {envio.documentoReceptor}");
        Console.WriteLine($"El costo del envio es ${envio.costo}");
        Console.WriteLine(" ");
    }
}
