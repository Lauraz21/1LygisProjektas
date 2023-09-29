namespace _1LygisProjektas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda ir pavarde");
            string currentUser = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Sveiki atvyke {currentUser}");

            Console.WriteLine();
            Console.WriteLine("1. Zaidimo taisykles");
            Console.WriteLine("2. Pradeti zaidima");
            Console.WriteLine("3. Zaidimo rezultatai ir dalyviu perziura");
            Console.WriteLine("4. Atsijungimas");
            Console.WriteLine("q. Isejimas is zaidimo");

            char choice = Console.ReadKey().KeyChar;  //readkey grazina objekta, viduje yra char
            Console.Clear();

            // q back
            switch (choice)
            {
                case '1':
                    GameRules();
                    break;

                case '2':
                    GameLogic();
                    break;

                case '3':
                    HighScore();
                    break;

                case '4':
                    Console.WriteLine("Atsijungete");
                    break;

                case 'q':
                    Console.WriteLine("ESC");
                    break;
            }
        }
        public static void GameRules()
        {
            Console.WriteLine("Taisykles");
        }
        public static void GameLogic()
        {
            Console.WriteLine("Pasirinkite klausimu kategorija " +
                "\n\n1.MOKSLAS \n2.PASAULIO ISTORIJA \n3.MENAS \n4.GYVUNIJA \n5.BENDROS ZINIOS");
            //bendros zinios

            char choice = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (choice)
            {
                case '1':
                    Console.WriteLine("Pasirinkote moksla");

                    AskQuestions(Questions.GetScienceQuestions());
                    break;
            }
        }


        public static void AskQuestions(Dictionary<string, char> questionsAndAnswers)
        {
            foreach (KeyValuePair<string, char> questionAndAnswer in questionsAndAnswers)
            {
                Console.WriteLine(questionAndAnswer.Key);
                char choice = Console.ReadKey().KeyChar;
                Console.Clear();

                if (choice == questionAndAnswer.Value)
                {
                    Console.WriteLine("Teisingas atsakymas");
                }
                else
                {
                    Console.WriteLine("Neteisingas atsakymas");
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
        public static void HighScore()
        {
            Console.WriteLine("TOP zaidejai");
        }
    }
}
