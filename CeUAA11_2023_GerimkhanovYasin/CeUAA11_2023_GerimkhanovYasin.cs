using System;

namespace CeUAA11_2023_GerimkhanovYasin
{
    class Program
    {
        static void Main(string[] args)
        {
            string phClaire;
            string choix;
            string phClef;
            string MatVigenere;
            int a;
            int b;
            string matAffine;

            Console.WriteLine("Menu : \n 1) Cryptage Vigenere  \n 2) Cryptage Affine \n ");
            choix = Console.ReadLine();
            Methodeprogramme mesOutils = new Methodeprogramme();
            if (choix=="1")

            {
                Console.WriteLine("donner la phrase a crypter");
                phClaire = Console.ReadLine();
                Console.WriteLine("donner la clef a cryptage");
                phClef = Console.ReadLine();

                mesOutils.CryptVigenere(phClaire,phClef,out MatVigenere);
            }
            if (choix == "2")

            {
                Console.WriteLine("donner la phrase a crypter");
                phClaire = Console.ReadLine();
                Console.WriteLine("donner le nombre pour a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("donner le nombre pour b");
                b = int.Parse(Console.ReadLine());

                mesOutils.CryptAffine(phClaire,a,b);

            }


        }
    }
}
