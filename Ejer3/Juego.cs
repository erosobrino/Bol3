using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    enum Estilo
    {
        Otro=0,
        Arcade = 1,
        VideoAventura = 2,
        Shootemup=3,
        Estrategia=4,
        Deportivo=5
    }
    class Juego
    {
        public int año;
        public Estilo estilo;

        public Juego()
        {
            Nombre = "Nombre";
            this.año = 0000;
            this.estilo = 0;
            Fabricante = "Fabricante";
        }

        public Juego(String nombre, int año, int estilo, String fabricante)
        {
            Nombre = nombre;
            this.año = año;
            this.estilo = (Estilo)estilo;
            Fabricante = fabricante;
        }
        private string nombre;
        public string Nombre
        {
            set
            {
                nombre = value.Trim().ToUpper();
            }
            get
            {
                return nombre;
            }
        }
        private string fabricante;
        public string Fabricante
        {
            set
            {
                fabricante = value.Trim().ToUpper();
            }
            get
            {
                return fabricante;
            }
        }

       
    }
}
