using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suite_exercices
{
    class Program
    {
        public enum JourSemaine { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche }


        static void Main(string[] args)
        {

            #region ex methode ref
            //string phrase = MaConcat("Comment", "ça", "va ?");

            //Console.WriteLine(phrase);


            //double a = 2.5;
            //Console.WriteLine("Avant : {0}", a);

            //MethodeRef(a);
            //Console.WriteLine("Après : {0}", a);

            //MethodeRef2(ref a);
            //Console.WriteLine("Après : {0}", a);
            #endregion

            #region equation ex structure

            //Equation equa;

            //double? X1, X2;

            //equa.A = 2.2;
            //equa.B = 13;
            //equa.C = 0;

            //bool b = equa.Resoudre(out X1, out X2);

            //string end = (b) ? "Une réponse a été trouvée." : "Une réponse n'a pas été trouvée.";

            //if (b)
            //{
            //    Console.WriteLine(end);
            //    Console.WriteLine("X1 = {0} | X2 = {1}", X1, X2);

            //}
            //else
            //{
            //    Console.WriteLine(end);
            //    Console.WriteLine("X1 = null | X2 = null");

            //}

            #endregion


            //foreach (string s in Enum.GetNames(typeof(JourSemaine)))
            //{
            //    Console.WriteLine(s);
            //}

            //JourSemaine jour_sem = JourSemaine.Lundi;

            //Console.WriteLine(jour_sem);

            //Console.WriteLine((int)jour_sem);

            //string j = "Dimanche";
            //JourSemaine jsem;


            //if (Enum.TryParse<JourSemaine>(j, out jsem)){
            //    Console.WriteLine(jsem);
            //    Console.WriteLine((int)jsem);

            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}



            #region Anagrame EX



            #endregion

            Console.ReadLine();

        }


        public static string MaConcat(params string[] lesMots)
        {
            string phrase = "";
            foreach (string m in lesMots)
            {
                phrase += m + " ";
            }

            return phrase;
        }


        public static void MethodeRef(double nb)
        {
            nb += 42;
        }
        public static void MethodeRef2(ref double nb)
        {
            nb += 42;
        }




        public struct Equation
        {
            public double A, B, C;

            public bool Resoudre(out double? X1, out double? X2)
            {
                bool retour = true;
                double delta = (Math.Pow(B, 2)) - (4 * A * C);
                if (delta > 0)
                {
                    X1 = ((-B) + Math.Sqrt(delta)) / (2 * A);
                    X2 = ((-B) - Math.Sqrt(delta)) / (2 * A);
                }
                else if (delta == 0)
                {
                    X1 = (-B) / (2 * A);
                    X2 = X1;
                }
                else
                {
                    X1 = null;
                    X2 = null;
                    retour = false;
                }
                return retour;
            }

        }


    }
}
