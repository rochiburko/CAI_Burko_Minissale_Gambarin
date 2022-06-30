using System;
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
            Console.WriteLine("5 - Volver al menu principal");
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
            Console.WriteLine("1 - Países Limitrofes");
            Console.WriteLine("2 - Resto de America Latina");
            Console.WriteLine("3 - América del Norte");
            Console.WriteLine("4 - Europa");
            Console.WriteLine("5 - Asia");
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

          
                //Region sucursal origen
                Console.WriteLine("ORIGEN - Seleccione region de origen");
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
            
            
            

            //Provincia sucursal origen
            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.region.Equals("Centro"))
            {
                Console.WriteLine("ORIGEN - Seleccione provincia de origen");
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

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.region.Equals("Metropolitana"))
            {
                Console.WriteLine("ORIGEN - Seleccione provincia de origen");
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

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.region.Equals("Norte"))
            {
                Console.WriteLine("ORIGEN - Seleccione provincia de origen");
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

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.region.Equals("Sur"))
            {
                Console.WriteLine("ORIGEN - Seleccione provincia de origen");
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
            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Cordoba"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
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

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Entre Rios"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
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

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("La Pampa"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
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

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Mendoza"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
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

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("San Luis"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
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

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Santa Fe"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
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


            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Buenos Aires"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesBuenosAires();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Lanus";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "La Plata";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Misiones"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesMisiones();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Guarani";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Iguazu";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }


            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("CABA"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesCABA();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 2);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "CABA";
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }



            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Catamarca"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesCatamarca();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Andalgala";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Belen";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Chaco"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesChaco();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Bermejo";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Maipu";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Corrientes"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesCorrientes();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "San Martin";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Santo Tome";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Formosa"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesFormosa();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Formosa";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Matacos";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Jujuy"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesJujuy();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Ledesma";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Rinconada";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("La Rioja"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesLaRioja();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Famatina";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Independencia";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Salta"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesSalta();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Cachi";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Cafayate";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }


            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("San Juan"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesSanJuan();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Cachi";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Cafayate";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Santiago Del Estero"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesSantiagoDelEstero();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Aguirre";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Figueroa";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Tucuman"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesTucuman();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Cruz Alta";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Leales";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }


            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Chubut"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesChubut();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Escalante";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Rawson";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Neuquen"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesNeuquen();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Zapala";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Minas";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Rio Negro"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesRioNegro();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "General Roca";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Bariloche";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Santa Cruz"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesSantaCruz();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Magallanes";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalOrigen.localidad = "Rio Chico";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalOrigen.nacion.Equals("Nacional") && sucursalOrigen.provincia.Equals("Tierra Del Fuego"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de origen");
                Sucursales.listarLocalidadesTierraDelFuego();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 2);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalOrigen.localidad = "Tierra del fuego";
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            return sucursalOrigen;

        }

        public static Sucursal cargarSucursalDestino(Cliente cliente)
        {
            Sucursal sucursalDestino = new Sucursal();
            int numeroIngresado = 0;

           Console.WriteLine("Seleccione el tipo de envio");
            Sucursales.listarTipoEnvio();
            numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

           switch (numeroIngresado)
            {
                case 1:
                    sucursalDestino.nacion = "Nacional";
                    Console.Clear();
                    break;
                case 2:
                    sucursalDestino.nacion = "Internacional";

                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    MenuPrincipal.mostrar(cliente);
                    break;
            }

            if (sucursalDestino.nacion.Equals("Nacional"))
            {

                Console.WriteLine("DESTINO - Seleccione region de destino");
                Sucursales.listarRegiones();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 5);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.region = "Centro";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.region = "Metropolitana";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalDestino.region = "Norte";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalDestino.region = "Sur";
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
                Console.WriteLine("DESTINO - Seleccione el pais de destino");
                Sucursales.listarPaisesInternacional();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 6);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.pais = "Paises Limitrofes";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.pais = "Resto de America Latina";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalDestino.pais = "América del Norte";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalDestino.pais = "Europa";
                        Console.Clear();
                        break;
                    case 5:
                        sucursalDestino.pais = "Asia";
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }
            
            //Provincia sucursal origen
            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.region.Equals("Centro"))
            {
                Console.WriteLine("DESTINO - Seleccione provincia de destino");
                Sucursales.listarProvinciasCentro();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 7);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.provincia = "Cordoba";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.provincia = "Entre Rios";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalDestino.provincia = "La Pampa";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalDestino.provincia = "Mendoza";
                        Console.Clear();
                        break;
                    case 5:
                        sucursalDestino.provincia = "San Luis";
                        Console.Clear();
                        break;
                    case 6:
                        sucursalDestino.provincia = "Santa Fe";
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }

            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.region.Equals("Metropolitana"))
            {
                Console.WriteLine("DESTINO - Seleccione provincia de destino");
                Sucursales.listarProvinciasMetropolitana();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.provincia = "Cordoba";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.provincia = "Entre Rios";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.region.Equals("Norte"))
            {
                Console.WriteLine("DESTINO - Seleccione provincia de destino");
                Sucursales.listarProvinciasNorte();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 12);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.provincia = "Catamarca";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.provincia = "Chaco";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalDestino.provincia = "Corrientes";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalDestino.provincia = "Formosa";
                        Console.Clear();
                        break;
                    case 5:
                        sucursalDestino.provincia = "Jujuy";
                        Console.Clear();
                        break;
                    case 6:
                        sucursalDestino.provincia = "La Rioja";
                        Console.Clear();
                        break;
                    case 7:
                        sucursalDestino.provincia = "Misiones";
                        Console.Clear();
                        break;
                    case 8:
                        sucursalDestino.provincia = "Salta";
                        Console.Clear();
                        break;
                    case 9:
                        sucursalDestino.provincia = "San Juan";
                        Console.Clear();
                        break;
                    case 10:
                        sucursalDestino.provincia = "Santiago del Estero";
                        Console.Clear();
                        break;
                    case 11:
                        sucursalDestino.provincia = "Tucuman";
                        Console.Clear();
                        break;
                    case 12:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.region.Equals("Sur"))
            {
                Console.WriteLine("DESTINO - Seleccione provincia de destino");
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
                        sucursalDestino.provincia = "Chubut";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.provincia = "Neuquen";
                        Console.Clear();
                        break;
                    case 3:
                        sucursalDestino.provincia = "Rio Negro";
                        Console.Clear();
                        break;
                    case 4:
                        sucursalDestino.provincia = "Santa Cruz";
                        Console.Clear();
                        break;
                    case 5:
                        sucursalDestino.provincia = "Tierra del Fuego";
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            // Localidad sucursal destino
            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Cordoba"))
            {
                Console.WriteLine("ORIGEN - Seleccione localidad de destino");
                Sucursales.listarLocalidadesCordoba();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "General Roca";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "San Justo";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Entre Rios"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesEntreRios();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Parana";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Tala";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("La Pampa"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesLaPampa();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Curaco";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Hucal";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Mendoza"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesMendoza();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Lavalle";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Las Heras";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("San Luis"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesSanLuis();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Ayacucho";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Belgrano";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Buenos Aires"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesBuenosAires();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Lanus";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "La Plata";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Misiones"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesMisiones();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Guarani";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Iguazu";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }


            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("CABA"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesCABA();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 2);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "CABA";
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }



            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Catamarca"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesCatamarca();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Andalgala";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Belen";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Chaco"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesChaco();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Bermejo";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Maipu";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Corrientes"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesCorrientes();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "San Martin";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Santo Tome";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Formosa"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesFormosa();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Formosa";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Matacos";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Jujuy"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesJujuy();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Ledesma";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Rinconada";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("La Rioja"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesLaRioja();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Famatina";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Independencia";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Salta"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesSalta();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Cachi";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Cafayate";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }


            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("San Juan"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesSanJuan();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Cachi";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Cafayate";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Santiago Del Estero"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesSantiagoDelEstero();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Aguirre";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Figueroa";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Tucuman"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesTucuman();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Cruz Alta";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Leales";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }


            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Chubut"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesChubut();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Escalante";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Rawson";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Neuquen"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesNeuquen();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Zapala";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Minas";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Rio Negro"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesRioNegro();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "General Roca";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Bariloche";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Santa Cruz"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesSantaCruz();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 3);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Magallanes";
                        Console.Clear();
                        break;
                    case 2:
                        sucursalDestino.localidad = "Rio Chico";
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }

            if (sucursalDestino.nacion.Equals("Nacional") && sucursalDestino.provincia.Equals("Tierra Del Fuego"))
            {
                Console.WriteLine("DESTINO - Seleccione localidad de destino");
                Sucursales.listarLocalidadesTierraDelFuego();
                numeroIngresado = Utils.solcitarNumeroEntre(1, 2);

                switch (numeroIngresado)
                {
                    case 1:
                        sucursalDestino.localidad = "Tierra del fuego";
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        MenuPrincipal.mostrar(cliente);
                        break;
                }
            }
            return sucursalDestino;

        }
    }
}
