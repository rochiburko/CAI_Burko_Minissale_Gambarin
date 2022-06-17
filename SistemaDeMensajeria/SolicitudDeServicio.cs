using System;
namespace SistemaDeMensajeria
{
	public class SolicitudDeServicio
	{
		public Cliente cliente { get; set; }

		public SolicitudDeServicio(Cliente cliente)
		{
			this.cliente = cliente;
		}
	}
}
