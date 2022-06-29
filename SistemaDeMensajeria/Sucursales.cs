﻿using System;
namespace SistemaDeMensajeria
{
    public static class Sucursales
    {
        private static void listarTipoEnvio()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Nacional");
            Console.WriteLine("2 - Internacional");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarRegiones()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Centro");
            Console.WriteLine("2 - Metropolitana");
            Console.WriteLine("3 - Norte");
            Console.WriteLine("4 - Sur");
            Console.WriteLine("5 - Internacional");
            Console.WriteLine("6 - Volver al menu principal");
        }

        private static void listarProvinciasCentro()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Cordoba");
            Console.WriteLine("2 - Entre Rios");
            Console.WriteLine("3 - La Pampa");
            Console.WriteLine("4 - Mendoza");
            Console.WriteLine("5 - San Luis");
            Console.WriteLine("6 - Santa Fe");
            Console.WriteLine("7 - Volver al menu principal");
        }

        private static void listarProvinciasMetropolitana()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Buenos Aires");
            Console.WriteLine("2 - CABA");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarProvinciasNorte()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Catamarca");
            Console.WriteLine("2 - Chaco");
            Console.WriteLine("3 - Corrientes");
            Console.WriteLine("4 - Formosa");
            Console.WriteLine("5 - Jujuy");
            Console.WriteLine("6 - La Rioja");
            Console.WriteLine("7 - Misiones");
            Console.WriteLine("8 - Salta");
            Console.WriteLine("9 - San Juan");
            Console.WriteLine("10 - Santiago del Estero");
            Console.WriteLine("11 - Tucuman");
            Console.WriteLine("12 - Volver al menu principal");
        }

        private static void listarProvinciasSur()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Chubut");
            Console.WriteLine("2 - Neuquen");
            Console.WriteLine("3 - Rio Negro");
            Console.WriteLine("4 - Santa Cruz");
            Console.WriteLine("5 - Tierra del Fuego");
            Console.WriteLine("6 - Volver al menu principal");
        }

        private static void listarPaisesInternacional()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Brasil");
            Console.WriteLine("2 - Bolivia");
            Console.WriteLine("3 - Colombia");
            Console.WriteLine("4 - Paraguay");
            Console.WriteLine("5 - Uruguay");
            Console.WriteLine("6 - Volver al menu principal");
        }


        private static void listarLocalidadesCordoba()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - General Roca");
            Console.WriteLine("2 - San Justo");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesEntreRios()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Parana");
            Console.WriteLine("2 - Tala");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesLaPampa()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Curaco");
            Console.WriteLine("2 - Hucal");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesMendoza()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Lavalle");
            Console.WriteLine("2 - Las Heras");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesSanLuis()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Ayacucho");
            Console.WriteLine("2 - Belgrano");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesSantaFe()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Garay");
            Console.WriteLine("2 - Rosario");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesBuenosAires()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Lanus");
            Console.WriteLine("2 - La Plata");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesCABA()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - CABA");
            Console.WriteLine("2 - Volver al menu principal");
        }

        private static void listarLocalidadesCatamarca()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Andalgala");
            Console.WriteLine("2 - Belen");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesChaco()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Bermejo");
            Console.WriteLine("2 - Maipu");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesCorrientes()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - San Martin");
            Console.WriteLine("2 - Santo Tome");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesFormosa()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Formosa");
            Console.WriteLine("2 - Matacos");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesJujuy()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Ledesma");
            Console.WriteLine("2 - Rinconada");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesLaRioja()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Famatina");
            Console.WriteLine("2 - Independencia");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesMisiones()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Guarani");
            Console.WriteLine("2 - Iguazu");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesSalta()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Cachi");
            Console.WriteLine("2 - Cafayate");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesSanJuan()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Angaco");
            Console.WriteLine("2 - Pocito");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesSantiagoDelEstero()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Aguirre");
            Console.WriteLine("2 - Figueroa");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesTucuman()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Cruz Alta");
            Console.WriteLine("2 - Leales");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesChubut()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Escalante");
            Console.WriteLine("2 - Rawson");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesNeuquen()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Zapala");
            Console.WriteLine("2 - Minas");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesRioNegro()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - General Roca");
            Console.WriteLine("2 - Bariloche");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesSantaCruz()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Magallanes");
            Console.WriteLine("2 - Rio Chico");
            Console.WriteLine("3 - Volver al menu principal");
        }

        private static void listarLocalidadesTierraDelFuego()
        {
            Console.WriteLine(" ");
            Console.WriteLine("1 - Tierra del fuego");
            Console.WriteLine("2 - Volver al menu principal");
        }

        public static Sucursal cargarSucursalOrigen(Cliente cliente)
        {
            Sucursal sucursalOrigen = new Sucursal();
            int numeroIngresado = 0;

            //SUCURSAL DE ORIGEN
            //Tipo envio
            Console.WriteLine("Seleccione el tipo de envio");
            Sucursales.listarTipoEnvio();
            numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

            switch (numeroIngresado)
            {
                case 1:
                    sucursalOrigen.nacion = "Nacional";
                    Console.Clear();
                    break;
                case 2:
                    sucursalOrigen.nacion = "Internacional";
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
            }

            if (sucursalOrigen.nacion.Equals("Nacional"))
            {
                //Region sucursal origen
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione region de origen");
                Sucursales.listarRegiones();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 5);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.region = "Centro";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.region = "Metropolitana";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalOrigen.region = "Norte";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalOrigen.region = "Sur";
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }
            else
            {
                //Pais de envio
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione pais de origen");
                Sucursales.listarPaisesInternacional();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 6);

                Console.WriteLine("1 - Brasil");
                Console.WriteLine("2 - Bolivia");
                Console.WriteLine("3 - Colombia");
                Console.WriteLine("4 - Paraguay");
                Console.WriteLine("5 - Uruguay");
                Console.WriteLine("6 - Volver al menu principal");


                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.pais = "Brasil";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.pais = "Bolivia";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalOrigen.pais = "Colombia";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalOrigen.pais = "Paraguay";
                        Console.Clear();
                        break;
                    case 5:
                        sucursalOrigen.pais = "Uruguay";
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            //Provincia sucursal origen
            if (sucursalOrigen.region.Equals("Centro"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione provincia de origen");
                Sucursales.listarProvinciasCentro();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 7);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.provincia = "Cordoba";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.provincia = "Entre Rios";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalOrigen.provincia = "La Pampa";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalOrigen.provincia = "Mendoza";
                        Console.Clear();
                        break;
                    case 5:
                        sucursalOrigen.provincia = "San Luis";
                        Console.Clear();
                        break;
                    case 6:
                        sucursalOrigen.provincia = "Santa Fe";
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }

            }

            if (sucursalOrigen.region.Equals("Metropolitana"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione provincia de origen");
                Sucursales.listarProvinciasMetropolitana();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.provincia = "Cordoba";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.provincia = "Entre Rios";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.region.Equals("Norte"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione provincia de origen");
                Sucursales.listarProvinciasNorte();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 12);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.provincia = "Catamarca";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.provincia = "Chaco";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalOrigen.provincia = "Corrientes";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalOrigen.provincia = "Formosa";
                        Console.Clear();
                        break;
                    case 5:
                        sucursalOrigen.provincia = "Jujuy";
                        Console.Clear();
                        break;
                    case 6:
                        sucursalOrigen.provincia = "La Rioja";
                        Console.Clear();
                        break;
                    case 7:
                        sucursalOrigen.provincia = "Misiones";
                        Console.Clear();
                        break;
                    case 8:
                        sucursalOrigen.provincia = "Salta";
                        Console.Clear();
                        break;
                    case 9:
                        sucursalOrigen.provincia = "San Juan";
                        Console.Clear();
                        break;
                    case 10:
                        sucursalOrigen.provincia = "Santiago del Estero";
                        Console.Clear();
                        break;
                    case 11:
                        sucursalOrigen.provincia = "Tucuman";
                        Console.Clear();
                        break;
                    case 12:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.region.Equals("Sur"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione provincia de origen");
                Sucursales.listarProvinciasSur();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 6);

                Console.WriteLine("1 - Chubut");
                Console.WriteLine("2 - Neuquen");
                Console.WriteLine("3 - Rio Negro");
                Console.WriteLine("4 - Santa Cruz");
                Console.WriteLine("5 - Tierra del Fuego");
                Console.WriteLine("6 - Volver al menu principal");

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.provincia = "Chubut";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.provincia = "Neuquen";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalOrigen.provincia = "Rio Negro";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalOrigen.provincia = "Santa Cruz";
                        Console.Clear();
                        break;
                    case 5:
                        sucursalOrigen.provincia = "Tierra del Fuego";
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            // Localidad sucursal origen
            if (sucursalOrigen.provincia.Equals("Cordoba"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesCordoba();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "General Roca";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "San Justo";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.provincia.Equals("Entre Rios"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesEntreRios();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Parana";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Tala";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.provincia.Equals("La Pampa"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesLaPampa();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Curaco";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Hucal";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.provincia.Equals("Mendoza"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesMendoza();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Lavalle";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Las Heras";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.provincia.Equals("San Luis"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesSanLuis();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Ayacucho";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Belgrano";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.provincia.Equals("Santa Fe"))
            {
                Console.WriteLine("SUCURSAL ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesSantaFe();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Garay";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Rosario";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            return sucursalOrigen;

        }
    }
}
