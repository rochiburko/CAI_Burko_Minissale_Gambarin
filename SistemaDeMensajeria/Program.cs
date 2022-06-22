using SistemaDeMensajeria;

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
    //1234; rosarioburko; hola2022
    //2345; juandominguez; hola2021

    Console.WriteLine("Ingrese su numero de cliente corporativo");
    string numeroCorporativo = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Ingrese su usuario");
    nombreUsuario = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Ingrese su contraseña");
    string contraseña = Console.ReadLine();
    Console.Clear();

    Usuario usuarioIngresado = new Usuario(numeroCorporativo,nombreUsuario, contraseña);

    usuarioValido = usuarioIngresado.validarUsuario();
    esPrimerIntento = false;
}

Console.WriteLine($"Bienvenido {nombreUsuario}");

//Busco el cliente asociado al nombre de usuario ingresado
Cliente cliente = new Cliente().traerDatosCliente(nombreUsuario);

if (cliente.idEnvios != null)
{
    //Console.WriteLine($"La direccion del cliente es: {cliente.direccion}");
    Console.WriteLine($"Por el momento, usted cuenta con los siguientes envios: {cliente.idEnvios}");
}

MenuPrincipal.mostrar(cliente);



