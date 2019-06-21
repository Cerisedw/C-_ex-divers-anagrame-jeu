using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrame
{
    class Program
    {
        static void Main(string[] args)
        {


            string rejouer = "Y";

            while (rejouer.ToUpper() == "Y")
            {
                bool recommence = false;


                string mot = TakeWord();

                //Console.WriteLine(mot);

                char[] m_char = mot.ToCharArray();

                string rand_word = RandomWord(m_char);

                while (rand_word == mot)
                {
                    rand_word = RandomWord(m_char);
                }

                while (!recommence)
                {
                    Console.WriteLine("Devinez le mot de base : {0}", rand_word);
                    string reponse = Console.ReadLine();

                    if (reponse.ToUpper() == mot)
                    {
                        Console.WriteLine("Gagné");
                        recommence = true;

                    }
                    else
                    {
                        Console.WriteLine("Perdu");
                    }
                }

                Console.WriteLine("Voulez-vous rejouer ? Y/N");
                rejouer = Console.ReadLine();
            }
            Console.WriteLine("Merci d'avoir joué !");

            Console.ReadLine();

        }

        public static string TakeWord()
        {
            Random random = new Random();

            StreamReader file = new StreamReader("mots.txt");


            string mot = "";
         
            int rand = random.Next(1, 800);

            for (int j = 0; j < rand; j++)
            {
                mot = file.ReadLine();
            }
            return mot;
        }

        public static string RandomWord(char[] arr_char)
        {
            Random random = new Random();

            string final_word = "";

            int longueur = arr_char.Count();
            List<int> temp = new List<int>();

            for (int i = 0; i < longueur; i++)
            {
                if (i == 0)
                {
                    int r = random.Next(0, longueur);
                    final_word += arr_char[r];
                    temp.Add(r);
                }
                else
                {
                    int r = random.Next(0, longueur);
                    while (temp.Contains(r))
                    {
                        r = random.Next(0, longueur);
                    }
                    final_word += arr_char[r];
                    temp.Add(r);
                }
            }
            return final_word;
        }

    }
}
