#define inicializacion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    class Ejer3
    {
        static void Main(string[] args)
        {
            Ejer3 ejer = new Ejer3();
            int eleccion = -1;
            List<Juego> Juegos = new List<Juego>();
#if inicializacion
            Juego juego1 = new Juego("AoE", 1997, 1, "Microsoft");
            Juego juego2 = new Juego("TrackMania", 2007, 2, "Nadeo");
            Juego juego3 = new Juego("GTA 5", 2013, 3, "Rockstar");
            Juego juego4 = new Juego("Fortnite", 2016, 3, "Epic Games");
            Juegos.Add(juego1);
            Juegos.Add(juego2);
            Juegos.Add(juego3);
            Juegos.Add(juego4);
            Juego juego5 = new Juego("AoE", 1997, 4, "Microsoft");
            Juego juego6 = new Juego("TrackMania", 2007, 2, "Nadeo");
            Juego juego7 = new Juego("GTA 5", 2013, 3, "Rockstar");
            Juego juego8 = new Juego("Fortnite", 2016, 3, "Epic Games");
            Juegos.Add(juego5);
            Juegos.Add(juego6);
            Juegos.Add(juego7);
            Juegos.Add(juego8);
            Juego juego9 = new Juego("AoE", 1997, 1, "Microsoft");
            Juego juego10 = new Juego("TrackMania", 2007, 2, "Nadeo");
            Juego juego11 = new Juego("GTA 5", 2013, 3, "Rockstar");
            Juego juego12 = new Juego("Fortnite", 2016, 3, "Epic Games");
            Juegos.Add(juego9);
            Juegos.Add(juego10);
            Juegos.Add(juego11);
            Juegos.Add(juego12);
#endif

            do
            {
                Console.WriteLine("1.Insertar juego");
                Console.WriteLine("2.Eliminar juego");
                Console.WriteLine("3.Confirmar si exite un juego");
                Console.WriteLine("4.Visualizar lista juegos");
                Console.WriteLine("5.Visualizar juegos de un año y estilo");
                Console.WriteLine("6.Modificar juego");
                Console.WriteLine("7.Borrar lista de juegos");
                Console.WriteLine("8.Salir");
                try
                {
                    eleccion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error al introducir un numero\n");
                }
                switch (eleccion)
                {
                    case 1:
                        Juegos = ejer.introducirJuego(Juegos, true);
                        break;
                    case 2:
                        ejer.borrarElemento(Juegos);
                        break;
                    case 3:
                        ejer.comprobarJuego(Juegos);
                        break;
                    case 4:
                        ejer.muestraBiblioteca(Juegos);
                        break;
                    case 5:
                        ejer.juegoporAño(Juegos);
                        break;
                    case 6:
                        ejer.modificarJuego(Juegos);
                        break;
                    case 7:
                        ejer.borraTodosElementos(Juegos);
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (eleccion != 8);
        }


        public List<Juego> introducirJuego(List<Juego> Juegos, bool introducir)
        {
            try
            {
                Juego juego = new Juego();
                Console.WriteLine("Introduce el nombre del juego");
                juego.Nombre = Console.ReadLine();
                Console.WriteLine("Introduce el año");
                juego.año = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el Estilo");
                Console.WriteLine(" Otro = 0, Arcade = 1,VideoAventura = 2,Shootemup = 3,Estrategia = 4,Deportivo = 5");
                juego.estilo = (Estilo)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el fabricante");
                juego.Fabricante = Console.ReadLine();
                if (introducir)
                {
                    if (Juegos.Count() > 0)
                    {
                        Console.WriteLine("Pulsa 1 para ponerlo en el inicio, otro para ponerlo en el final");
                        int eleccion = Convert.ToInt32(Console.ReadLine());
                        if (eleccion == 1)
                        {
                            Juegos.Insert(0, juego);
                        }
                        else
                        {
                            Juegos.Add(juego);
                        }
                    }
                    else
                    {
                        Juegos.Add(juego);
                    }
                }
                else
                {
                    Juegos.Add(juego);
                }
            }
            catch
            {
                Console.WriteLine("Se ha producido un error al introducir los datos");
            }
            Console.WriteLine();
            return Juegos;
        }

        private void borrarElemento(List<Juego> Juegos)
        {
            int borrado = -1;
            bool bandera;
            if (Juegos.Count() > 0)
            {
                do
                {
                    Console.WriteLine("Escribe el id del juego a borrar (1-" + Juegos.Count() + ")");
                    try
                    {
                        borrado = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    catch
                    {
                        Console.WriteLine("Error al introducir un numero\n");
                    }
                    if (borrado < 0 || borrado >= Juegos.Count())
                    {
                        bandera = true;
                        Console.WriteLine("Opcion invalida");
                    }
                    else
                    {
                        bandera = false;
                    }
                } while (bandera);
                Juegos.RemoveAt(borrado);
            }
            else
            {
                Console.WriteLine("No hay juegos");
            }
            Console.WriteLine();
        }

        private void borraTodosElementos(List<Juego> Juegos)
        {
            if (Juegos.Count() > 0)
            {
                Console.WriteLine("Estas seguro de que deseas borralos");
                Console.WriteLine("Pulsa 0 para borrarlo, otro para cancelar");
                int confirmacion = -1;
                try
                {
                    confirmacion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error al introducir un numero\n");
                }
                if (confirmacion == 0)
                {
                    Juegos.Clear();
                }
            }
            else
            {
                Console.WriteLine("No hay juegos");
            }
        }

        public List<Juego> modificarJuego(List<Juego> Juegos)
        {
            Console.WriteLine("Introduce el id a modificar (1-" + Juegos.Count() + ")");
            int eleccion = -1;
            try
            {
                eleccion = Convert.ToInt32(Console.ReadLine()) - 1;
                Juegos[eleccion] = introducirJuego(Juegos, false)[Juegos.Count() - 1];
            }
            catch
            {
                Console.WriteLine("Debes introducir un valor valido");
            }
            return Juegos;
        }

        public void muestraBiblioteca(List<Juego> Juegos)
        {
            int cont = 0;
            int cont2 = 0;
            foreach (Juego juego in Juegos)
            {
                cont++;
                cont2++;
                if (cont2 >= 11)
                {
                    Console.WriteLine("Pulsa una tecla para continuar");
                    Console.ReadKey(true);
                    cont2 = 0;
                }
                Console.WriteLine("{0,2} Titulo:{1,12} Año:{2,5} Estilo: {3,14} Fabricante:{4,10}", cont, juego.Nombre, juego.año, juego.estilo, juego.Fabricante);
            }
            Console.WriteLine("Hay " + Juegos.Count() + " juegos\n");
        }

        public void comprobarJuego(List<Juego> Juegos)
        {
            if (Juegos.Count() > 0)
            {
                int cont = 0;
                Console.WriteLine("Que juego deseas comprobar, se puede escribir un trozo del nombre");
                String comprobarNombre = Console.ReadLine().Trim().ToUpper();
                foreach (Juego juego in Juegos)
                {
                    String nombreJuego = juego.Nombre;
                    if (nombreJuego.StartsWith(comprobarNombre))
                    {
                        cont++;
                        Console.WriteLine("{0} Titulo:{1,8} Año:{2,5} Estilo:{3,8} Fabricante:{4,8}\n", cont, juego.Nombre, juego.año, juego.estilo, juego.Fabricante);
                    }
                }
                Console.WriteLine("Hay " + cont + " juegos\n");
            }
            else
            {
                Console.WriteLine("No hay juegos en la coleccion\n");
            }
        }

        private void juegoporAño(List<Juego> Juegos)
        {
            if (Juegos.Count() > 0)
            {
                int cont = 0;
                int añoComprobar = -1;
                Console.WriteLine("Introduce el año a comprobar el juego");
                try
                {
                    añoComprobar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el Estilo");
                    Console.WriteLine(" Otro = 0, Arcade = 1,VideoAventura = 2,Shootemup = 3,Estrategia = 4,Deportivo = 5");
                    Estilo estilo = (Estilo)Convert.ToInt32(Console.ReadLine());
                    foreach (Juego juego in Juegos)
                    {
                        if (añoComprobar == juego.año && estilo == juego.estilo)
                        {
                            cont++;
                            Console.WriteLine("{0} Titulo:{1,8} Año:{2,5} Estilo:{3,8} Fabricante:{4,8}\n", cont, juego.Nombre, juego.año, juego.estilo, juego.Fabricante);
                        }
                    }
                    Console.WriteLine("Hay " + cont + " juegos");
                }
                catch
                {
                    Console.WriteLine("Error al introducir un numero\n");
                }
            }
            else
            {
                Console.WriteLine("No hay juegos en la coleccion");
            }
        }
    }
}
