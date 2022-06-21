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
           
            numeroIngresado = solcitarNumeroEntre(0, 3);

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

