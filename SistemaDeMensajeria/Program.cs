using SistemaDeMensajeria;

string nombreUsuario = null;

bool usuarioValido = false;
bool esPrimerIntento = true;

while (!usuarioValido)
{
    if (!esPrimerIntento)
    {
        Console.WriteLine("El usuario ingresado es invalido, por favor vuelva a ingresar sus datos");
    }

    Console.WriteLine("Ingrese su usuario");
    nombreUsuario = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Ingrese su contraseña");
    string contraseña = Console.ReadLine();
    Console.Clear();

    Usuario usuarioIngresado = new Usuario(nombreUsuario, contraseña);

    usuarioValido = usuarioIngresado.validarUsuario();
    esPrimerIntento = false;
}

Console.WriteLine($"Los datos ingresados son correctos! Bienvenido {nombreUsuario}");

MenuPrincipal.mostrar();



