using System;

enum Nombre
{

    deux,
    trois,
    quatre,
    cinq,
    six,
    sept,
    huit,
    neuf,
    dix,
    valet,
    reine,
    roi,
    onze,

}
enum Sorte
{
    coeur,
    pique,
    carreau,
    trefle,
}
namespace ConsoleApp1
{

    class Program
    {
        private static int valeurCarte;

        static int afficherCarte()

        {
            //VARIBALES SORTES
            Sorte sorteCarte = 0;
            Nombre c = 0;

            //VARIABLES
            int afficherCartes = 0;



            c = (Nombre)(new Random()).Next(0, 13);
            switch (c)
            {

                case Nombre.deux:
                    Console.WriteLine("Deux");
                    valeurCarte = 2;
                    break;
                case Nombre.trois:
                    Console.WriteLine("Trois");
                    valeurCarte = 3;
                    break;
                case Nombre.quatre:
                    Console.WriteLine("Quatre");
                    valeurCarte = 4;
                    break;
                case Nombre.cinq:
                    Console.WriteLine("Cinq");
                    valeurCarte = 5;
                    break;
                case Nombre.six:
                    Console.WriteLine("Six");
                    valeurCarte = 6;
                    break;
                case Nombre.sept:
                    Console.WriteLine("Sept");
                    valeurCarte = 7;
                    break;
                case Nombre.huit:
                    Console.WriteLine("Huit");
                    valeurCarte = 8;
                    break;
                case Nombre.neuf:
                    Console.WriteLine("Neuf");
                    valeurCarte = 9;
                    break;
                case Nombre.dix:
                    Console.WriteLine("Dix");
                    valeurCarte = 10;
                    break;
                case Nombre.valet:
                    Console.WriteLine("Valet");
                    valeurCarte = 10;
                    break;
                case Nombre.reine:
                    Console.WriteLine("Reine");
                    valeurCarte = 10;
                    break;
                case Nombre.roi:
                    Console.WriteLine("Roi");
                    valeurCarte = 10;
                    break;
                case Nombre.onze:
                    Console.WriteLine("As");
                    valeurCarte = 11;
                    break;

            }

            sorteCarte = (Sorte)(new Random()).Next(0, 4);
            switch (sorteCarte)
            {
                case Sorte.coeur:
                    Console.WriteLine(" de coeur");
                    break;
                case Sorte.pique:
                    Console.WriteLine(" de pique");
                    break;
                case Sorte.carreau:
                    Console.WriteLine(" de carreau");
                    break;
                case Sorte.trefle:
                    Console.WriteLine(" de trèfle");
                    break;
            }
            return afficherCartes;
        }
        private static int valeurCarte2;
        static int afficherCarte1()

        {
            //VARIBALES SORTES
            Sorte sorteCarte = 0;
            Nombre c = 0;

            //VARIABLES
            int afficherCartes2 = 0;



            c = (Nombre)(new Random()).Next(0, 13);
            switch (c)
            {

                case Nombre.deux:

                    valeurCarte2 = 2;
                    break;
                case Nombre.trois:

                    valeurCarte2 = 3;
                    break;
                case Nombre.quatre:

                    valeurCarte2 = 4;
                    break;
                case Nombre.cinq:

                    valeurCarte2 = 5;
                    break;
                case Nombre.six:

                    valeurCarte2 = 6;
                    break;
                case Nombre.sept:

                    valeurCarte2 = 7;
                    break;
                case Nombre.huit:

                    valeurCarte2 = 8;
                    break;
                case Nombre.neuf:

                    valeurCarte2 = 9;
                    break;
                case Nombre.dix:

                    valeurCarte2 = 10;
                    break;
                case Nombre.valet:

                    valeurCarte2 = 10;
                    break;
                case Nombre.reine:

                    valeurCarte2 = 10;
                    break;
                case Nombre.roi:

                    valeurCarte2 = 10;
                    break;
                case Nombre.onze:

                    valeurCarte2 = 11;
                    break;

            }

            sorteCarte = (Sorte)(new Random()).Next(0, 4);
            switch (sorteCarte)
            {
                case Sorte.coeur:

                    break;
                case Sorte.pique:

                    break;
                case Sorte.carreau:

                    break;
                case Sorte.trefle:

                    break;
            }
            return afficherCartes2;
        }
        static void Main(string[] args)
        {
            //VARIABLES
            int jetons = 100;
            int choix = 0;
            int resteJetons = 0;
            int miseJetons = 0;
            int carte1 = 0;
            int carte2 = 0;
            int carte3 = 0;
            int cartebot1 = 0;
            int cartebot2 = 0;
            int cartebot3 = 0;
            int totalJ1 = 0;
            int totalIa2 = 0;
            int totalfnj = 0;
            int totalfnia = 0;

            while (jetons > 0)
            {


                Console.WriteLine("Veuillez entrer le nombre de jetons que vous aller miser ?(Maximum 100 jetons)");
                miseJetons = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");

                resteJetons = jetons - miseJetons;
                Console.WriteLine("Vous avez miser " + miseJetons);
                Console.WriteLine("");
                Console.WriteLine("Il vous reste " + resteJetons);
                Console.WriteLine("");
                Console.WriteLine("Appuyer sur n'importe quel touche pour commencer.(Triche non toléré)");
                Console.ReadLine();

                if (miseJetons > 100)
                {
                    return;
                }
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Votre première carte");
                Console.WriteLine("");
                carte1 = afficherCarte();
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Votre deuxième carte");
                Console.WriteLine("");
                carte2 = afficherCarte();
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Appuyer sur n'importe quel touche pour voir les cartes de l'adversaire");
                Console.ReadLine();
                Console.WriteLine("La première carte de l'adversaire");
                Console.WriteLine("");
                cartebot1 = afficherCarte();
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("La deuxième carte de l'adversaire est caché");
                Console.WriteLine("");
                cartebot2 = afficherCarte1();
                Console.WriteLine("---------------------------------------------------------------------");


                carte1 = valeurCarte;
                carte2 = valeurCarte;
                cartebot1 = valeurCarte2;
                cartebot2 = valeurCarte2;
                totalJ1 = carte1 + carte2;
                totalIa2 = cartebot1 + cartebot2;

                if (totalIa2 == 21)
                {
                    Console.WriteLine("Black Jack pour l'adversaire, vous avez perdu");
                    Console.WriteLine("---------------------------------------------------------------------");

                }
                else if (totalJ1 == 21)
                {
                    Console.WriteLine("Black Jack, vous avez gagné");
                    Console.WriteLine("---------------------------------------------------------------------");

                }

                Console.WriteLine("");
                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine("");
                Console.WriteLine("1-Recevoir une nouvelle carte");
                Console.WriteLine("");
                Console.WriteLine("2-Arrêter");
                Console.WriteLine("---------------------------------------------------------------------");
                choix = Convert.ToInt32(Console.ReadLine());



                if (choix == 1)
                {

                    Console.WriteLine("---------------------------------------------------------------------");
                    carte3 = afficherCarte();
                    Console.WriteLine("---------------------------------------------------------------------");
                    carte3 = valeurCarte;
                    totalfnj = totalJ1 + carte3;
                }
                else if (choix == 2)
                {
                    Console.WriteLine("Appuyer sur une touche pour continuer");
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.ReadLine();
                }



                if (totalIa2­ < 17)
                {
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("L'adeversaire a pigé une autre carte ");
                    Console.WriteLine("---------------------------------------------------------------------");
                    cartebot3 = afficherCarte();
                    Console.WriteLine("---------------------------------------------------------------------");
                    cartebot3 = valeurCarte;
                    totalfnia = totalIa2 + cartebot3;
                }
                else if (totalfnj > 21)
                {

                }


                NewMethod(totalfnj, totalfnia);
            }










        }

        private static void NewMethod(int totalfnj, int totalfnia)
        {
            if (totalfnia > 22)
            {
                Console.WriteLine("");
                Console.WriteLine("L'adversaire a BUSTEDDDDDDDDDDDDDD");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");

            }
            else if (totalfnia == 21)
            {
                Console.WriteLine("Black Jack pour l'adversaire, vous avez perdu");
                Console.WriteLine("---------------------------------------------------------------------");
            }
            else if (totalfnj > 22)
            {
                Console.WriteLine("");
                Console.WriteLine("BUSTEDDDDDDDDDDDDDDDD");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");

            }
            else if (totalfnia > totalfnj && totalfnia <= 20)
            {
                Console.WriteLine("");
                Console.WriteLine("L'adversaire a eu un plus grand nombre vous avez perdu");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");
            }
            else if (totalfnia == totalfnj)
            {
                Console.WriteLine("Égalité");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");
            }
            else if (totalfnj == 21)
            {
                Console.WriteLine("");
                Console.WriteLine("Black jack vous avez gagné");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");
            }
            else if (totalfnj > totalfnia && totalfnj <= 20)
            {
                Console.WriteLine("");
                Console.WriteLine("Vous avez eu un plus grand nombre que l'adversaire vous avez gagné");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("");
            }
        }
    }
}
