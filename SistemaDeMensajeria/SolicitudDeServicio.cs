using System;
namespace SistemaDeMensajeria
{
	public class SolicitudDeServicio
	{
		public Cliente clienteEmisor { get; set; } //Estos datos se obtienen en forma automática del archivo
		public bool seDebePasarARetirar { get; set; } //Este campo debe ser un check box que indique si el repartidor debe pasar a retirar el paquete por el domicilio del cliente.
        public bool seRetiraPorSucursal { get; set; }
        public Cliente clienteReceptor { get; set; } //Datos del Receptor
		public string centroDeAlmacenamiento { get; set; } //Nombre del centro donde se almcenara el producto (ARMAR CLASE CENTRO ALMACENAMIENTO)
		public string direccionDestino { get; set; } //Puede ser domicilio del cliente receptor o de una sucursal

        public Cliente idEnvios { get; set; } 


        public SolicitudDeServicio(Cliente cliente)
		{
			this.clienteEmisor = cliente;
		}

      

        public void cargarDatos()
        {

              this.seDebePasarARetirar = validarInputSiNO();
              this.seRetiraPorSucursal = validarInputSiNO();
           
                Console.WriteLine(" ");
                Console.WriteLine("INGRESE EL NUMERO DEL TIPO DE ENVIO");
                Console.WriteLine("1 - Encomienda");
                Console.WriteLine("2 - correspondencia");
                Console.WriteLine("3 - Salir del programa");

                int numeroIngresado;

                numeroIngresado = solcitarNumeroEntre(0, 3);

                Console.Clear();

                switch (numeroIngresado)
                {
                    case 1:
                        Console.WriteLine("Usted selecciono Solicitar envio. Elija el tipo de envio");

                        break;
                    case 2:
                        Console.WriteLine("Usted selecciono Consultar estado de envio");
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

        public bool validarInputSiNO()
        {
            string valorIngresado;
            bool esPrimerIntento = true;

            do {
                if (!esPrimerIntento)
                {
                    Console.Clear();
                    Console.WriteLine("Recuerde que debe responder con 'SI' o 'NO'");
                }
                valorIngresado = Console.ReadLine().ToUpper();
                esPrimerIntento = false;
            } while (!valorIngresado.Equals("SI") && !valorIngresado.Equals("NO"));

            Console.Clear();

            if (valorIngresado.Equals("SI"))
            {
                return true;
            }

            return false;
        }
    }
}
