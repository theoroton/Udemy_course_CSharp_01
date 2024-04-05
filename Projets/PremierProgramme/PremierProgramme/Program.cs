using System;

namespace PremierProgramme
{
    internal class Program
    {
        static string AskName()
        {
            string name = "";

            while (name == "")
            {
                Console.WriteLine("Quel est votre prénom ?");
                name = Console.ReadLine();
                name = name.Trim();

                if (name == "")
                {
                    Console.WriteLine("Merci d'entrer un nom. Veuillez réessayer.");
                }
            }

            return name;
        }

        static int AskAge()
        {
            int age = 0;

            while (age <= 0)
            {
                Console.WriteLine("Quel est votre âge ?");
                try
                {
                    age = int.Parse(Console.ReadLine());

                    if (age <= 0)
                    {
                        Console.WriteLine("L'âge doit être supérieur à 0. Veuillez réessayer.");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur lors de la saisie de l'âge. Veuillez entrer un âge valide (entier positif).");
                }
            }

            return age;
        }

        static void showPersonInfos(string name, int age)
        {
            Console.WriteLine($"Bonjour {name}, vous avez {age} ans.");
            Console.WriteLine($"Vous aurez bientôt {age + 1} ans.");
        }

        static void Main(string[] args)
        {
            string name = AskName();
            int age = AskAge();

            showPersonInfos(name, age);
        }
    }
}