using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonctionExercice1_cor
{
    internal class Program
    {
        // déclarations globales
        static char reponse;

        // Fonction de saisie d’une réponse type O/N avec contrôle de saisie
        static void choix()
        {
            do
            {
                Console.Write("Avez-vous un prix à saisir ? (O/N) : ");
                reponse = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (reponse != 'O' && reponse != 'N');
            //return reponse;
        }

        static void Main(string[] args)
        {
            // Déclarations globales 
            float prix, total = 0;

            // Saisie d’une réponse type O/N avec contrôle de saisie
            choix();

            // Boucle sur la saisie des prix et le cumul
            while (reponse == 'O')
            {
                // saisie d’un nouveau prix
                Console.Write("Entrez un prix = ");
                prix = float.Parse(Console.ReadLine());
                // cumul
                total = total + prix;
                // demande si un nouveau prix est à saisir
                choix();
            }
            // Affichage du total
            Console.WriteLine(" total des prix = " + total);
            Console.ReadLine();
        }
    }
}
