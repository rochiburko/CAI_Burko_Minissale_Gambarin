using System;
namespace SistemaDeMensajeria
{
	public static class MenuPrincipal
	{
        public static void mostrar(Cliente cliente)
        {
            Console.WriteLine(" ");
            Console.WriteLine("INGRESA UN NUMERO PARA NAVEGAR EN EL MENU");
            Console.WriteLine("1 - Solicitar envio");
            Console.WriteLine("2 - Consultar estado de envio");
            Console.WriteLine("3 - Salir del programa");

            int numeroIngresado;
           
            numeroIngresado = Utils.solcitarNumeroEntre(0, 3);

            Console.Clear();

            switch (numeroIngresado)
            {
                case 1:
                    Console.WriteLine("Usted selecciono Solicitar envio. Elija el tipo de envio");
                    SolicitudDeServicio solicitud = new SolicitudDeServicio(cliente);
                    solicitud.cargarDatos();
                    break;
                case 2:
                    Console.WriteLine("Usted selecciono Consultar estado de servicio");
                    ConsultaEstadoDeEnvio estadoEnvio = new ConsultaEstadoDeEnvio(cliente);
                    estadoEnvio.mostrarEstado();
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa");
                    break;
            }

        }
      
    }

}

