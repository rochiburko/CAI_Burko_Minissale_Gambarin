﻿using System;
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
                    Console.WriteLine("Usted selecciono SOLICITAR SERVICIO");
                    Envio solicitudEnvio = SolicitudDeServicio.cargarDatos(cliente);
                    Console.Clear();
                    SolicitudDeServicio.mostrarResumen(solicitudEnvio);
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
                    Console.WriteLine($"El estado de su pedido es {estado}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa");
                    break;
            }

        }
      
    }

}

