using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Colas.Negocio
{
    class Colas
    {
        int[] vector;
        int primero;
        int ultimo;
        int tamano;

        public int[] Vector
        {
            get
            {
                return vector;
            }

            set
            {
                vector = value;
            }
        }

        public int Primero
        {
            get
            {
                return primero;
            }

            set
            {
                primero = value;
            }
        }

        public int Ultimo
        {
            get
            {
                return ultimo;
            }

            set
            {
                ultimo = value;
            }
        }

        public int Tamano
        {
            get
            {
                return tamano;
            }

            set
            {
                tamano = value;
            }
        }

        public Colas(int n)
        {
            primero = ultimo = -1;
            tamano = n;
            vector = new int[tamano];
        }

        public bool esta_llena()
        {
            if (ultimo >= tamano - 1)
                return true;
            return false;
        }

        public bool esta_vacia()
        {
            if (primero == -1)
                return true;
            return false;
        }

        public bool agregar(int dato)
        {
            if (!esta_llena())
            {
                vector[++ultimo] = dato;
                if (ultimo == 0)
                    primero = 0;
                return true;
            }
            return false;
        }

        public bool extraer(ref int dato)
        {
            //ESTA VRIABLE SE USARA PARA MOVER EL DATO 1 al 0, el 2 al 1, el 3 al 2 ...
            int var = 1;

            //SI LA PILA NO ESTA VACIA:
            if (!esta_vacia())
            {
                //ENTONCES SACAMOS EL PRIMER DATO (P[O])
                dato = vector[primero];

                for (int i = 0; i < vector.Length; i++)
                {
                    //SE PREGUNTA SI var ES MENOR A LA LONGITUD DEL ARREGLO, ESTO SE HACE DEBIDO A QUE var LLEGA A UN VALOR
                    //SUPERIOR A LA LONGITUD DEL ARREGLO
                    if (var < vector.Length)
                    {
                        //PASAMOS EL DATO DE UNA POSICION A OTRA
                        //EJEMPLO: vec[0]=vec[1] EL DATO EN LA POSICION 1 SE PASA A LA POSICION 0 Y ASI HASTA LA LONGITUD DEL ARREGLO
                        vector[i] = vector[var];
                        var++;
                    }
                }

                //AHORA LA VARIABLE QUE SE IRA MOVIENDO SERA u, YA QUE EL PRIMERO SIEMPRE SERA EL ELEMENTO 0
                if (ultimo == primero)
                {
                    primero = ultimo = -1;
                }
                else
                    //DECREMENTAMOS u YA QUE QUIERE DECIR QUE "HAY UN DATO MENOS EN LA COLA", EN REALIDAD EL DATO SIGUE ALLI
                    ultimo--;
                return true;
            }
            return false;
        }
    }
}
