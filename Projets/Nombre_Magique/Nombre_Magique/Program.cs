using System;

namespace Nombre_Magique
{
    /*
     * Jeu du juste prix
     */
    class Program
    {
        static int AskNumber(int min, int max)
        {
            bool number_valid = false;
            int given_number = 0;
            Console.WriteLine($"Entrez un nombre (entier compris entre {min} & {max}) :");

            while (!number_valid)
            {
                {
                    try
                    {
                        given_number = int.Parse(Console.ReadLine());

                        // Si l'entier donné est entre min et max
                        if (given_number >= min && given_number <= max)
                        {
                            number_valid = true;
                        }
                        // Sinon
                        else
                        {
                            Console.WriteLine($"\nLe nombre donné doit être un entier positif entre {min} & {max}. Veuillez réessayer :");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nErreur lors de la saisie. Veuillez réessayer :");
                    }
                }
            }

            return given_number;
        }


        static void Main(string[] args)
        {
            // Définition des bornes min et max
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;
            // Définition du nombre de vies
            int lives = 6;
            // Définition du nombre cible
            Random rand = new Random();
            int GOAL_NUMBER = rand.Next(MIN_NUMBER, MAX_NUMBER + 1);

            Console.WriteLine($"Vous devez trouver le bon nombre compris entre {MIN_NUMBER} et {MAX_NUMBER}.\n");

            // Tant qu'il reste des vies
            while (lives > 0)
            {
                Console.WriteLine("-----------------------------------------------\n");
                Console.WriteLine($"Il vous reste {lives} essais.\n\n");


                // Récupération du nombre donné par l'utilisateur
                int given_number = AskNumber(MIN_NUMBER, MAX_NUMBER);

                Console.WriteLine("\n");

                //// Affichage résultats
                // Si c'est le bon nombre
                if (given_number == GOAL_NUMBER)
                {
                    Console.WriteLine("-----------------------------------------------\n");
                    Console.WriteLine("Bravo, vous avez trouvé le bon nombre !");
                    break;
                } 
                // Si le nombre donné est plus grand
                else if (given_number >= GOAL_NUMBER)
                {
                    Console.WriteLine("Le nombre est plus petit");
                }
                // Si le nombre donné est plus petit
                else
                {
                    Console.WriteLine("Le nombre est plus grand");
                }

                // Enlève une vie si pas trouvé
                lives--;
            }

            // Si plus de vie
            if (lives == 0)
            {
                Console.WriteLine("-----------------------------------------------\n");
                Console.WriteLine($"Vous avez perdu. Le nom cible était : {GOAL_NUMBER}.");
            }
        }
    }
}