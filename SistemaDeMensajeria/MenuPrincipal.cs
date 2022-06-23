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
            Console.WriteLine("3 - Cerrar sesion");
            Console.WriteLine("4 - Salir del programa");

            int numeroIngresado;
           
            numeroIngresado = Utils.solcitarNumeroEntre(0, 4);

            Console.Clear();

            switch (numeroIngresado)
            {
                case 1:
                    Console.WriteLine("Usted selecciono SOLICITAR SERVICIO");
                    Envio solicitudEnvio = SolicitudDeServicio.cargarDatos(cliente);
                    Console.Clear();
                    SolicitudDeServicio.mostrarResumen(solicitudEnvio, cliente);
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
                case 2:
                    Console.WriteLine("Usted selecciono CONSULTAR ESTADO DE ENVIO");
                    if (cliente.idEnvios == null)
                    {
                        Console.WriteLine("Usted no tiene envios para mostrar");
                        break;
                    }
                    List<int> envios = Utils.parsearEnvios(cliente.idEnvios);
                    ConsultaEstadoDeEnvio consulta = new ConsultaEstadoDeEnvio();
                    string estado = consulta.consultar(envios);
                    Console.Clear();
                    Console.WriteLine($"EL ESTADO DE SU ENVIO ES: {estado}");
                    Console.WriteLine("Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
                case 3:
                    Console.WriteLine("CERRANDO SESION");
                    Console.Clear();
                    MenuInicial.mostrar();
                    break;
                case 4:
                    Console.WriteLine("SALIENDO DEL PROGRAMA");
                    break;
            }

        }
      
    }

}

