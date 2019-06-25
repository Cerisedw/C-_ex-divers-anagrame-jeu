using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau_ex6
{
    class Program
    {

        public static Random rnd = new Random();

        static void RandomToArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 1001);
            }

        }

        static void TrierArray(int[] array)
        {
            int temp;
            int j = 0;

            while (j < array.Length)
            {
                for (int z = (array.Length - 1); z > j; z--)
                {
                    if (array[j] > array[z])
                    {
                        temp = array[j];
                        array[j] = array[z];
                        array[z] = temp;
                    }
                }
                j++;
            }

            for (int y = 0; y < array.Length; y++)
            {
                Console.Write(array[y] + " ");
            }
        }

        static void Comp2Array(int i1, int i2, int[] array1, int[] array2, int[] arrayTot)
        {
            int temp;
            if (array1[i1] < arrayTot[i2 - 1])
            {
                arrayTot[i2] = array1[i1];
                temp = arrayTot[i2];
                arrayTot[i2] = arrayTot[i2 - 1];
                arrayTot[i2 - 1] = temp;
                arrayTot[i2 + 1] = array2[i1];
            }
            else
            {
                arrayTot[i2] = array1[i1];
                arrayTot[i2 + 1] = array2[i1];
            }
        }

        static void Main(string[] args)
        {

            int TAILLE = 5;
            int j = 0;

            //tableau 1
            int[] tabNmb1 = new int[TAILLE];
            RandomToArray(tabNmb1);
            Console.WriteLine("Tableau 1");
            TrierArray(tabNmb1);

            // tableau 2
            int[] tabNmb2 = new int[TAILLE];
            RandomToArray(tabNmb2);
            Console.WriteLine("\nTableau 2");
            TrierArray(tabNmb2);

            // commencer le troisieme tableau
            int[] tabTot = new int[TAILLE * 2];
            int indTot = 0;

            for (int t = 0; t < TAILLE; t++)
            {
                // La première fois que l'on rentre dans la boucle
                if (t == 0)
                {
                    if (tabNmb1[t] > tabNmb2[t])
                    {
                        tabTot[indTot] = tabNmb2[t];
                        tabTot[indTot + 1] = tabNmb1[t];
                    }
                    else
                    {
                        tabTot[indTot] = tabNmb1[t];
                        tabTot[indTot + 1] = tabNmb2[t];
                    }
                }
                // Après la première rentrée dans la boucle
                else
                {
                    if (tabNmb1[t] > tabNmb2[t])
                    {
                        Comp2Array(t, indTot, tabNmb2, tabNmb1, tabTot);
                    }
                    else
                    {
                        Comp2Array(t, indTot, tabNmb1, tabNmb2, tabTot);
                    }
                    if (tabTot[indTot - 1] < tabTot[indTot - 2])
                    {
                        int temp;
                        temp = tabTot[indTot - 1];
                        tabTot[indTot - 1] = tabTot[indTot - 2];
                        tabTot[indTot - 2] = temp;
                    }
                }
                indTot += 2;
            }
            Console.WriteLine("");

            for (int y = 0; y < (TAILLE * 2); y++)
            {
                Console.Write(tabTot[y] + " | ");
            }





            Console.ReadLine();

        }
    }
}
