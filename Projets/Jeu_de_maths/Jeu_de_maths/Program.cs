using System;

namespace Jeu_de_maths
{
    class Program
    {
        enum Operator
        {
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
        }

        static bool AskQuestion(int min_int, int max_int)
        {
            // Init Random
            Random rand = new Random();

            // Choix aléatoire des entiers de la question
            int x = rand.Next(min_int, max_int + 1);
            int y = rand.Next(min_int, max_int + 1);

            // Choix aléatoire de l'opérateur
            Array operator_values = Enum.GetValues(typeof(Operator));
            Operator op = (Operator)operator_values.GetValue(rand.Next(operator_values.Length));

            // Initialisation réponse
            bool correct_answer = false;
            int expected_result = 0;

            // Choix de la question
            switch (op)
            {
                case Operator.Addition:
                    Console.Write($"{x} + {y} = ");
                    expected_result = x + y;
                    break;
                case Operator.Subtraction:
                    Console.Write($"{x} - {y} = ");
                    expected_result = x - y;
                    break;
                case Operator.Multiplication:
                    Console.Write($"{x} * {y} = ");
                    expected_result = x * y;
                    break;
            }

            // Réponse de l'utilisateur
            int user_answer = int.Parse(Console.ReadLine());

            // Si la réponse est correcte
            if (user_answer == expected_result)
            {
                correct_answer = true;
            }

            return correct_answer;
        }


        static void Main(string[] args)
        {
            // Définitions des constantes
            const int MIN_INT = 2; // Entier minimal utilisé dans les questions
            const int MAX_INT = 10; // Entier maximal utilisé dans les questions
            const int NB_QUESTIONS = 5; // Nombre de questions

            // Initialisation
            int question_number = 1;
            bool correct_answer;
            int points = 0;

            // Pour chaque question
            while (question_number <= NB_QUESTIONS) {
                Console.WriteLine($"Question n°{question_number}/{NB_QUESTIONS}");
                correct_answer = AskQuestion(MIN_INT, MAX_INT);

                // Si bonne réponse
                if (correct_answer)
                {
                    Console.WriteLine("Bonne réponse\n");
                    points++;
                } 
                else
                {
                    Console.WriteLine("Mauvaise réponse\n");
                }

                question_number++;
            }

            // Affichage résultat
            Console.WriteLine($"\nVous avez marqué {points} points sur {NB_QUESTIONS}.");
            switch (points)
            {
                case 0:
                    Console.WriteLine("Ptdrrrr");
                    break;
                case 1:
                    Console.WriteLine("Mdr");
                    break;
                case 2:
                    Console.WriteLine("Fais un effort");
                    break;
                case 3:
                    Console.WriteLine("C'et dans la moyenne");
                    break;
                case 4:
                    Console.WriteLine("Presque parfait");
                    break;
                case 5:
                    Console.WriteLine("BRAVO");
                    break;
            }
        }
    }
}
