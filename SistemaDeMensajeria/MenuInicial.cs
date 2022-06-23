using System;
namespace SistemaDeMensajeria
{
	public static class MenuInicial
    { 
        public static void mostrar()
        {
            Cliente cliente = MenuLogueo();
            MenuPrincipal.mostrar(cliente);
        }

        static Cliente MenuLogueo()
        {

            string nombreUsuario = null;

            bool usuarioValido = false;
            bool esPrimerIntento = true;

            while (!usuarioValido)
            {
                if (!esPrimerIntento)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El usuario ingresado es invalido, por favor vuelva a ingresar sus datos");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                //Usuarios de prueba:
                //30657863676; rosarioburko; hola2022
               // 30657863676; pedrogomez; hola2021
                Console.WriteLine("INGRESE SU NUMERO  DE CUIT");
                string numeroCuit = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("INGRESE SU USUARIO");
                nombreUsuario = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("INGRESE SU CONTRASEÑA");
                string contraseña = Console.ReadLine();
                Console.Clear();

                Usuario usuarioIngresado = new Usuario(numeroCuit, nombreUsuario, contraseña);

                usuarioValido = usuarioIngresado.validarUsuario();
                esPrimerIntento = false;
            }

            Console.WriteLine($"BIENVENIDO {nombreUsuario}");

            //Busco el cliente asociado al nombre de usuario ingresado
            Cliente cliente = new Cliente();
            cliente.traerDatosCliente(nombreUsuario);

            return cliente;
        }
    }
}

