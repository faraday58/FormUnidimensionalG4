
using System;

namespace FormUnidimensionalG4
{
    class Matriz
    {
        //n definie el tamaño del arreglo
        private int n;
        public float[] A;
        private int indice;
        public Matriz(int n)
        {
            N = n;
            A = new float[N];
        }

        public int N {
            get => n;
            set
            {
                if( value < 2  )
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }
                
            }
        }

        public int Indice { get => indice;

            set
            {

                if (value < 0 || value >= N)
                {
                    indice = 0;
                }
                else
                {
                indice = value;
            }
            }
        }

        public void Agregar(float elemento, int indice)
        {
            A[indice] = elemento;

        }



    }
}
