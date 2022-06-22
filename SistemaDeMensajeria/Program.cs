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
     
    }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ingrese su usuario corporativo");
        nombreUsuario = Console.ReadLine();
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ingrese su contraseña");
        string contraseña = Console.ReadLine();
        Console.Clear();

    Usuario usuarioIngresado = new Usuario(nombreUsuario, contraseña);

    usuarioValido = usuarioIngresado.validarUsuario();
    esPrimerIntento = false;
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Los datos ingresados son correctos! Bienvenido {nombreUsuario}");

//Busco el cliente asociado al nombre de usuario ingresado
Cliente cliente = new Cliente().traerDatosCliente(nombreUsuario);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La direccion del cliente es: {cliente.direccion}");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Los envios del cliente son: {cliente.idEnvios}");

MenuPrincipal.mostrar(cliente);



