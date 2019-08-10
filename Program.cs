using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arr = {1,3,1,4,2,3,5,4};


            Console.WriteLine(EncontrarTiempo(5,arr));
            Console.ReadLine();


            int EncontrarTiempo(int X, int[]A) {

                bool[] hojasEnPosicion = new bool[X + 1];

                int posicionesOcupadas = 0;

                for (int i = 0; i < A.Length; i++)
                {

                    int posicion = A[i];

                    if (posicion<=X && !hojasEnPosicion[posicion])
                    {
                        hojasEnPosicion[posicion] = true;
                        posicionesOcupadas++;
                    }
                    if (posicionesOcupadas==X)
                    {
                        return i;
                    }

                }

                return -1;

            }
        }
    }
}
