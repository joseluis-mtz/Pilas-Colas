using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_Colas.Negocio
{
    class Pilas
    {
        private string[] datosPila;
        private int posicionPila;
        private const int maxPila = 200;

        public int PosicionPila
        {
            get
            {
                return posicionPila;
            }

            set
            {
                posicionPila = value;
            }
        }

        public static int MaxPila
        {
            get
            {
                return maxPila;
            }
        }

        public string[] DatosPila
        {
            get
            {
                return datosPila;
            }

            set
            {
                datosPila = value;
            }
        }

        public Pilas()
        {
            posicionPila = 0;
            DatosPila = new string[maxPila];
        }

        // Añadir a la pila: Apilar
        public void Apilar(string nuevoDato)
        {
            if (posicionPila == maxPila)
                MessageBox.Show("Pila llena.");
            else
            {
                DatosPila[posicionPila] = nuevoDato;
                posicionPila++;
            }
        }

        // Extraer de la pila: Desapilar
        public string Desapilar()
        {
            if (posicionPila <= 0)
                MessageBox.Show("Pila vacía.");
            else
            {
                posicionPila--;
                return DatosPila[posicionPila];
            }
            return null;
        }
    }
}
