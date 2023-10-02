namespace _1LygisProjektas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAUROS PROTMUSIS");
            Console.WriteLine();
            Dictionary<string, int> namesSurnamesAndScores = new();

            bool showLogIn = true;

            while (showLogIn)
            {

                Console.WriteLine("Iveskite varda ir pavarde: ");
                string currentUser = Console.ReadLine();
                Console.Clear();

                if (namesSurnamesAndScores.ContainsKey(currentUser))
                {
                    Console.WriteLine("Vartotojo paskyra jau egzistuoja");
                }
                else
                {
                    namesSurnamesAndScores.Add(currentUser, 0);
                    Console.WriteLine($"Sveiki atvyke, {currentUser} !");
                }

                bool showMenu = true;

                while (showMenu)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("1. Zaidimo taisykles");
                    Console.WriteLine("2. PRADETI ZAIDIMA");
                    Console.WriteLine("3. Zaidimo rezultatai");
                    Console.WriteLine("4. Atsijungimas");
                    Console.WriteLine("q. Isejimas is zaidimo");
                    Console.WriteLine("------------------------------------");

                    char choice = Console.ReadKey().KeyChar;
                    Console.Clear();


                    switch (choice)
                    {
                        case '1':
                            GameRules(currentUser);
                            break;

                        case '2':
                            GameLogic(currentUser, namesSurnamesAndScores);
                            break;

                        case '3':
                            HighScore(currentUser, namesSurnamesAndScores);
                            break;

                        case '4':
                            showMenu = false;
                            Console.Clear();
                            Console.WriteLine("Atsijungete");
                            break;

                        case 'q':
                            showMenu = false;
                            showLogIn = false;
                            break;
                    }
                }
            }
        }
        public static void GameRules(string currentUser)
        {
            Console.WriteLine(currentUser);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Sveikiname prisijungus prie LAUROS PROTMUSIO zaidimo!");
            Console.WriteLine("\nSis protmusis Jums leidzia pasirinkti is 4 klausimu kategoriju." +
            "\nPasirinkus kategoriją pradėsite žaidimą ir turėsite pasirinkti \n1 is 4 " +
            "galimų variantų, kuris yra teisingas atsakymas.");
            Console.WriteLine();
            Console.WriteLine("Grįžti atgal (q)");
            Console.WriteLine("------------------------------------------------------------------");
           

            while (true)
            {
                char choice = Console.ReadKey().KeyChar;
                if (choice == 'q')
                {
                    break;
                }
            }
            Console.Clear();
        }
        public static void GameLogic(string currentUser, Dictionary<string, int> namesSurnamesAndScores)
        {
            Console.WriteLine(currentUser);
            Console.WriteLine();
            Console.WriteLine("Pasirinkite klausimu kategorija " +
                "\n\n1.MOKSLAS \n2.PASAULIO ISTORIJA \n3.MENAS \n4.BENDROS ZINIOS");
            

            char choice = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (choice)
            {
                case '1':
                    AskQuestions(Questions.GetScienceQuestions(), currentUser, namesSurnamesAndScores);
                    break;

                case '2':
                    AskQuestions(Questions.GetWordHistoryQuestions(), currentUser, namesSurnamesAndScores);
                    break;

                case '3':
                    AskQuestions(Questions.GetArtQuestions(), currentUser, namesSurnamesAndScores);
                    break;

                case '4':
                    AskQuestions(Questions.GetGeneralKnowledgeQuestions(), currentUser, namesSurnamesAndScores);
                    break;
            }
        }


        public static void AskQuestions(Dictionary<string, char> questionsAndAnswers, string currentUser, Dictionary<string, int> namesSurnamesAndScores)
        {
            namesSurnamesAndScores[currentUser] = 0;

            foreach (KeyValuePair<string, char> questionAndAnswer in questionsAndAnswers)
            {
                Console.WriteLine(currentUser);
                Console.WriteLine();
                Console.WriteLine(questionAndAnswer.Key);
                char choice = Console.ReadKey().KeyChar;
                Console.Clear();

                if (choice == questionAndAnswer.Value)
                {
                    Console.WriteLine("Teisingas atsakymas");
                    namesSurnamesAndScores[currentUser] += 1;
                }
                else
                {
                    Console.WriteLine("Neteisingas atsakymas"); 
                }
                Console.WriteLine();
                Console.WriteLine("Taskai: " + namesSurnamesAndScores[currentUser] + "/" + questionsAndAnswers.Count);
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Zaidimas baigesi"+
                "\nAciu, kad dalyvavote");
            Console.ReadKey();
            Console.Clear();
        }
        public static void HighScore(string currentUser, Dictionary<string, int> scores)
        {
            Console.WriteLine(currentUser);
            Console.WriteLine();
            

            foreach (KeyValuePair<string, int> score in scores)
            {
                string name = score.Key;
                int playerScore = score.Value;
                Console.WriteLine(name + " - " + playerScore + " taskai");
            }

            Console.WriteLine();
            Console.WriteLine("Grįžti atgal (q)");

            while (true)
            {
                char choice = Console.ReadKey().KeyChar;
                if (choice == 'q')
                {
                    break;
                }
            }
            Console.Clear();
        }
    }
}
