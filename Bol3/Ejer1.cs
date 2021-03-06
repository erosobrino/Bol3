﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bol3
{
    class Ejer1
    {
        //Validado
        static void Main(string[] args)
        {
            Hashtable equipos = new Hashtable();
            //equipos.Add("192.168.0.21", 8);
            //equipos.Add("192.168.201.210", 4);
            //equipos.Add("192.168.0.2", 12);
            //equipos.Add("192.168.200.1", 6);

            int eleccion = -1;
            Ejer1 ejer1 = new Ejer1();
            do
            {
                Console.WriteLine("1.Introducir datos");
                Console.WriteLine("2.Ver todos");
                Console.WriteLine("3.Ver un elemento");
                Console.WriteLine("4.Salir");
                Console.WriteLine("Escribe la opcion elegida");
                try
                {
                    eleccion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debes introducir un valor valido\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El valor es demasiado alto");
                }

                switch (eleccion)
                {
                    case 1:
                        equipos = ejer1.IntroducirDatos(equipos);
                        break;
                    case 2:
                        ejer1.visualizarDatos(equipos);
                        break;
                    case 3:
                        ejer1.visualizarElemento(equipos);
                        break;
                    case 4:
                        break;
                }

            } while (eleccion != 4);
        }

        public Hashtable IntroducirDatos(Hashtable equipos)
        {
            string ip = "";
            int cantidad = 0;
            do
            {
                ip = pedirIP(equipos, true);
            } while (ip.Length == 0);
            do
            {
                try
                {
                    Console.WriteLine("Introduce la cantidad de memoria, en GB");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    if (cantidad < 0)
                    {
                        Console.WriteLine("Memoria invalida");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debes introducir un valor valido");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El valor es demasiado alto");
                }
            } while (cantidad == 0);
            equipos.Add(ip, cantidad);
            Console.WriteLine("Se ha añadido la ip: " + ip + " con una memoria de " + cantidad + " GB");
            Console.WriteLine();
            return equipos;
        }

        public void visualizarDatos(Hashtable datos)
        {
            foreach (DictionaryEntry entry in datos)
            {
                Console.WriteLine("IP: {0,15} Memoria: {1,2} GB", entry.Key, entry.Value);
            }
            Console.WriteLine("Hay " + datos.Count);
            Console.WriteLine();
        }

        public void visualizarElemento(Hashtable datos)
        {
            if (datos.Keys.Count > 0)
            {
                String ip = pedirIP(datos, false);
                if (datos.Contains(ip))
                {
                    foreach (DictionaryEntry entry in datos)
                    {
                        if (entry.Key.Equals(ip))
                        {
                            Console.WriteLine("IP: {0,15} Memoria: {1,2} GB\n", entry.Key, entry.Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No existe\n");
                }
            }
            else
            {
                Console.WriteLine("No hay elementos\n");
            }
        }

        public string pedirIP(Hashtable datos, bool comprobarDuplicado)
        {
            Console.WriteLine("Introduce la ip");
            String ip = Console.ReadLine();
            bool banderaIp = IPAddress.TryParse(ip, out System.Net.IPAddress address);
            //Console.WriteLine(banderaIp);
            if (!banderaIp || ip.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length != 4)
            {
                Console.WriteLine("Ip invalida\n");
                ip = "";
            }
            else
            {
                ip = address.ToString();
                if (comprobarDuplicado)
                {
                    if (datos.Contains(ip))
                    {
                        Console.WriteLine("No puede haber IPs duplicadas\n");
                        throw new Exception("IP duplicada");
                    }
                }
            }
            return ip;
        }
    }
}
