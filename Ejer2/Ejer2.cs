using Ejer2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol3
{
    class Ejer2
    {

        static void Main(string[] args)
        {
            Aula aula = new Aula();
            Ejer2 ejer = new Ejer2();
            int eleccion = -1;
            do
            {
                Console.WriteLine("1.Calcular la media de notas de toda la tabla");
                Console.WriteLine("2.Media de un alumno");
                Console.WriteLine("3.Media de una asignatura");
                Console.WriteLine("4.Visualizar notas de un alumno");
                Console.WriteLine("5.Visualizar notas de una asignatura");
                Console.WriteLine("6.Nota máxima y mínima de un alumno");
                Console.WriteLine("7.Visualizar tabla completa");
                Console.WriteLine("8.Salir");
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
                        Console.WriteLine("La media es: {0:N3}\n", aula.mediaGlobal());
                        break;
                    case 2:
                        int idAlumno;
                        do
                        {
                            Console.WriteLine("Introduce el ID del alumno, (1-{0})", aula.alumnos.Length);
                            idAlumno = ejer.pedirNumero(aula.alumnos.Length);
                        } while (idAlumno == -1);
                        idAlumno--;
                        Console.WriteLine("La media de {0} es: {1:N3}\n", aula.alumnos[idAlumno], aula.mediaAlumno(idAlumno));
                        break;
                    case 3:
                        int idMateria;
                        do
                        {
                            Console.WriteLine("Introduce el ID de materia, (1-{0})", aula.notas.GetLength(1));
                            idMateria = ejer.pedirNumero(aula.notas.GetLength(1));
                        } while (idMateria == -1);
                        idMateria--;
                        Console.WriteLine("La media de {0} es: {1:N3}\n", (asignaturas)idMateria, aula.mediaMateria(idMateria));
                        break;
                    case 4:
                        int idAlumno2;
                        do
                        {
                            Console.WriteLine("Introduce el ID del alumno, (1-{0})", aula.alumnos.Length);
                            idAlumno2 = ejer.pedirNumero(aula.alumnos.Length);
                        } while (idAlumno2 == -1);
                        idAlumno2--;
                        Console.Write("{0,9}", " ");
                        for (int i = 0; i < aula.notas.GetLength(1); i++)
                        {
                            Console.Write("{0,10} ", (asignaturas)i);
                        }
                        Console.WriteLine();
                        Console.Write("{0,7} ", aula.alumnos[idAlumno2]);
                        for (int i = 0; i < aula.notas.GetLength(1); i++)
                        {
                            Console.Write("{0,9} ", aula[idAlumno2, i]);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        int idMateria2;
                        do
                        {
                            Console.WriteLine("Introduce el ID de materia, (1-{0})", aula.notas.GetLength(1));
                            idMateria2 = ejer.pedirNumero(aula.notas.GetLength(1));
                        } while (idMateria2 == -1);
                        idMateria2--;
                        Console.Write("{0,9}", " ");
                        Console.WriteLine((asignaturas)idMateria2);
                        for (int i = 0; i < aula.notas.GetLength(0); i++)
                        {
                            Console.WriteLine("{0,7} {1,7}", aula.alumnos[i], aula[i, idMateria2]);
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        //Max y min alumnofalla
                        int idAlumno3;
                        do
                        {
                            Console.WriteLine("Introduce el ID del alumno, (1-{0})", aula.alumnos.Length);
                            idAlumno3 = ejer.pedirNumero(aula.alumnos.Length);
                        } while (idAlumno3 == -1);
                        idAlumno3--;
                        int notaMax = 0;
                        int notaMin = 10;
                        for (int i = 0; i < aula.notas.GetLength(1); i++)
                        {
                            int nota = aula[idAlumno3, i];
                            if (nota > notaMax)
                            {
                                notaMax = nota;
                            }
                            if (nota < notaMin)
                            {
                                notaMin = nota;
                            }
                        }
                        Console.WriteLine("{0} Max: {1} Min: {2}\n", aula.alumnos[idAlumno3],
                            notaMax, notaMin);
                        break;
                    case 7:
                        aula.verTabla();
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Fuera de rango\n");
                        break;
                }


            } while (eleccion != 8);
        }

        public int pedirNumero(int max)
        {
            int eleccion = -1;
            try
            {
                eleccion = Convert.ToInt32(Console.ReadLine());
                if (eleccion<1 || eleccion > max)
                {
                    Console.WriteLine("El valor no esta en el rango");
                    eleccion = -1;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Debes introducir un valor valido\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor es demasiado alto");
            }
            return eleccion;
        }
    }
}
