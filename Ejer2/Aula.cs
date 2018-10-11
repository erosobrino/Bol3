using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    enum asignaturas
    {
        Empresa = 0,
        Intefaces = 1,
        Moviles = 2,
        Servicios = 3
    }

    class Aula
    {
        public string[] alumnos = { "Ero", "Miguel", "Julio", "Dani", "Ero", "Miguel", "Julio", "Dani", "Ero", "Miguel", "Julio", "Dani"};
        public int[,] notas = crearNotasAleatorias();
        public int this[int x,int y]
        {
            set
            {
                notas = crearNotasAleatorias();
            }
            get
            {
                return notas[x, y];
            }
        }

        public Aula()
        {
            int[,] notas = crearNotasAleatorias();
        }

        public double mediaGlobal()
        {
            double mediaGlobal;
            int sumaTotal = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    sumaTotal += notas[i,j];
                }
            }
            mediaGlobal = (double)sumaTotal / (notas.GetLength(0) * notas.GetLength(1));
            return mediaGlobal;
        }
        
        public double mediaAlumno(int idAlumno)
        {
            int sumaNota = 0;
            double mediaAlumno;

            for (int i = 0; i < notas.GetLength(1); i++)
            {
                sumaNota += notas[idAlumno,i];
            }
            mediaAlumno = (double)sumaNota / notas.GetLength(1);

            return mediaAlumno;
        }

        public double mediaMateria(int idMateria)
        {
            int sumaNota = 0;
            double mediaMateria;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                sumaNota += notas[i,idMateria];
            }
            mediaMateria = (double)sumaNota / notas.GetLength(0);

            return mediaMateria;
        }

        public void verTabla()
        {
            Console.Write("{0,9}"," ");
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                Console.Write("{0,10} ",(asignaturas)i);
            }
            Console.WriteLine();
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                Console.Write("{0,7} ",alumnos[i]);
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.Write("{0,9} ",notas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        public static int[,] crearNotasAleatorias()
        {
            Random rand = new Random();
            int[,] notas = new int[12, 4];
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    int aleatorio = rand.Next(0, 100);
                    int nota = -1;
                    //Console.WriteLine(aleatorio);
                    switch (aleatorio)
                    {
                        case int n when n < 5:
                            nota = 0;
                            break;
                        case int n when (n >= 5 && n < 10):
                            nota = 1;
                            break;
                        case int n when (n >= 10 && n < 15):
                            nota = 2;
                            break;
                        case int n when (n >= 15 && n < 25):
                            nota = 3;
                            break;
                        case int n when (n >= 25 && n < 40):
                            nota = 4;
                            break;
                        case int n when (n >= 40 && n < 55):
                            nota = 5;
                            break;
                        case int n when (n >= 55 && n < 70):
                            nota = 6;
                            break;
                        case int n when (n >= 70 && n < 80):
                            nota = 7;
                            break;
                        case int n when (n >= 80 && n < 90):
                            nota = 8;
                            break;
                        case int n when (n >= 90 && n < 95):
                            nota = 9;
                            break;
                        case int n when (n >= 95 && n < 100):
                            nota = 10;
                            break;
                    }
                    notas[i, j] = nota;
                }
            }
            return notas;
        }
    }
}
