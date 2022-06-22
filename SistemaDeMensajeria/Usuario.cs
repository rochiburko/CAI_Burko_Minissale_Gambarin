using System;
namespace SistemaDeMensajeria
{
    class Usuario
    {
        public string numeroCorporativo { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        private string archivoDatosUsuarios = "../../datos/usuarios.txt";

        public Usuario(string numeroCorporativo,string nombreUsuario, string contraseña)
        {
            this.numeroCorporativo = numeroCorporativo;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }

        public bool validarUsuario()
        {
            bool usuarioValido = false;
            var stream = File.OpenRead(archivoDatosUsuarios);
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();

                string[] datos = linea.Split(';');

                if (datos[0].Equals(numeroCorporativo) &&
                    datos[1].Equals(nombreUsuario) &&
                    datos[2].Equals(contraseña))
                {
                    usuarioValido = true;
                    break;
                }
            }

            stream.Close();
            return usuarioValido;
        }
    }
}