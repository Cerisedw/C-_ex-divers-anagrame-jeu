using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eplucheurPatate
{
    class Program
    {

        static void InitRecipient(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = "_";
            }
        }

        static void AffichageTab(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(@"\_" + tab[i] + "_/ ");
            }
            Console.WriteLine("\n");
        }

        static void AffichageGeneral(string[] seau, string[] marmite, string eplucheur)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n=====SEAU=====");
            AffichageTab(seau);
            Console.WriteLine("\n=====EPLUCHEUR=====");
            Console.WriteLine(@"->" + eplucheur + "<- ");
            Console.WriteLine("\n=====MARMITE=====");
            AffichageTab(marmite);

        }

        static void RemplirSeau(string[] tabSeau)
        {
            for (int i = 0; i < tabSeau.Length; i++)
            {
                tabSeau[i] = "0";
            }

        }

        static bool EstPlein(string[] tab)
        {
            bool plein = true;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == "_")
                {
                    plein = false;
                }
                else
                {
                    plein = true;
                }
            }
            return plein;
        }

        static string PrendrePatate(string[] tabSeau)
        {
            string temp;
            int j = 0;
            while (tabSeau[j] != "0")
            {
                j++;
            }
            temp = tabSeau[j];
            tabSeau[j] = "_";
            return temp;
        }

        static string Eplucher()
        {
            string temp;
            temp = "1";
            return temp;
        }

        static string DeposerPatate(string[] tab, string eplu)
        {
            int y = 0;
            while ( tab[y] == "1")
            {
                y++;
            }
            tab[y] = eplu;
            eplu = "_";
            return eplu;
        }

        static void Main(string[] args)
        {
            int TAILLES = 6;
            int TAILLEM = 15;
            string[] seau = new string[TAILLES];
            string[] marmite = new string[TAILLEM];

            string eplucheur = "_";

            InitRecipient(seau);
            InitRecipient(marmite);

            while (!EstPlein(marmite))
            {
                if (EstPlein(seau))
                {
                    if (eplucheur != "_")
                    {
                        if (eplucheur == "0")
                        {
                            eplucheur = Eplucher();
                        }
                        else
                        {
                            eplucheur = DeposerPatate(marmite, eplucheur);
                        }
                    }
                    else
                    {
                        eplucheur = PrendrePatate(seau);
                    }
                }
                else
                {
                    RemplirSeau(seau);
                }
                AffichageGeneral(seau, marmite, eplucheur);
                Console.ReadLine();
            }

            Console.WriteLine("Votre marmite est pleine. Bon appétit !");
            AffichageTab(marmite);

            Console.ReadLine();
        }
    }
}
