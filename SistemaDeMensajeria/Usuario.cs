using System;
namespace SistemaDeMensajeria
{
    class Usuario
    {
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        private string archivoDatosUsuarios = "../../datos/usuarios.txt";

        public Usuario(string nombreUsuario, string contraseña)
        {
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

                if (datos[0].Equals(nombreUsuario) && datos[1].Equals(contraseña))
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