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
		

		public SolicitudDeServicio(Cliente cliente)
		{
			this.clienteEmisor = cliente;
		}

        public void cargarDatos()
        {

            Console.WriteLine("Desea que pasemos a retirar el paquete por su domicilio? SI | NO");
            this.seDebePasarARetirar = validarInputSiNO();

            Console.WriteLine("El paquete sera retirado por una sucursal? SI | NO");
            this.seRetiraPorSucursal = validarInputSiNO();

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
