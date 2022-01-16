using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_fondue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fromageBase = 800;
            double eauBase = 2.0;
            double ailBase = 2.0;
            int painBase = 400;

            int quantiteDeBaseFromage = fromageBase / 4;
            double quantitedeBaseEau = eauBase / 4;
            double quantiteDeBaseAil = ailBase / 4;
            int quantiteDeBasePain = painBase / 4;

            Console.WriteLine("Entrez le nombre de personne(s) invitée(s) à la fondue : ");
            string nbc;
            int nbConvives;
            nbc = Console.ReadLine();
            nbConvives = Convert.ToInt32(nbc);

            int nouvelleQuantiteFromage = quantiteDeBaseFromage * nbConvives;
            double nouvelleQuantiteEau = quantitedeBaseEau * nbConvives;
            double nouvelleQuantiteAil = quantiteDeBaseAil * nbConvives;
            int nouvelleQuantitePain = quantiteDeBasePain * nbConvives;

            Console.WriteLine("Pour faire une fondue fribourgeoise pour " + nbConvives + " personne(s), il vous faut : ");
            Console.WriteLine("- " + nouvelleQuantiteFromage + " gr de Vacherin fribourgeois");
            Console.WriteLine("- " + nouvelleQuantiteEau + " dl d'eau");
            Console.WriteLine("- " + nouvelleQuantiteAil + " gousse(s) d'ail");
            Console.WriteLine("- " + nouvelleQuantitePain + " gr de pain");
            Console.WriteLine("- " + "du poivre à volonté");
            Console.WriteLine("- Arrosez le tout de préférence avec une (ou plusieurs) bouteille(s) de Johannisberg ou de Fendant du Valais, évidement !");

            Console.ReadLine();
        }
    }
}
