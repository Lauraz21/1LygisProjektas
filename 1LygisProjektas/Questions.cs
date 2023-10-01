using System;
using System.Collections.Generic;
namespace _1LygisProjektas
{
    public static class Questions
    {
        public static Dictionary<string, char> GetScienceQuestions()
        {

            Dictionary<string, char> questionsAndAnswers = new();
            questionsAndAnswers.Add("1/3) Kuri Saulės sistemos planeta yra pirmoji, atrasta teleskopu? \n" +
                "\n1. Saturnas\n2. Jupiteris\n3. Marsas\n4. Uranas ", '4');

            questionsAndAnswers.Add("2/3) Kokia vidutinė Veneros paviršiaus temperatūra? \n"+
                "\n1. 980 °C\n2. 460 °C\n3. 170 °C\n4. -10 °C", '2');

            questionsAndAnswers.Add("3/3) Kiek elementų yra periodinėje lentelėje? \n" +
                "\n1. 118 \n2. 100 \n3. 115 \n4. 96", '1');

            return questionsAndAnswers;
        }


        public static Dictionary<string, char> GetArtQuestions()
        {
            Dictionary<string, char> questionsAndAnswers = new();
            questionsAndAnswers.Add("1/3) Ką Leonardo da Vinči paveiksle rankose laiko Mona Liza? \n" +
                "\n1. Gėlių puokštę \n2. Plunksną \n3. Skraistę \n4. Nieko", '4');

            questionsAndAnswers.Add("2/3) Kūrimo menas naudojant mažus spalvoto stiklo, akmens ar kitų medžiagų gabalėlius? \n" +
                " \n1. Origami\n2. Mozaika \n3. Keramika \n4. Tokio nera", '2');

            questionsAndAnswers.Add("3/3) Kuris menininkas yra žinomas dėl savo siurrealistinių paveikslų, įskaitant \n" +
                "„Atminties išlikimą“(The Persistence of Memory)?"+
                "\n1. Marc Chagall \n2. Michelangelo \n3. Salvador Dali \n4. Andy Warhol", '3');

            return questionsAndAnswers;
        }


        public static Dictionary<string, char> GetWordHistoryQuestions()
        {
            Dictionary<string, char> questionsAndAnswers = new();
            questionsAndAnswers.Add("1/3 Kada įkurta komunistinė Kinija? \n" +
               "\n1. 1942m. \n2. 1955m.\n3. 1949m.\n4. 1950m.", '1');

            questionsAndAnswers.Add("2/3 Kokioje šalyje yra pastatytas Koliziejus? \n" +
                "\n1. Graikija \n2. Šveicarija \n3. Australija \n4. Italija", '4');

            questionsAndAnswers.Add("3/3) Kiek metu truko simtametis karas tarp Anglijos ir Prancūzijos? \n" +
                "\n1. 116m. \n2. 100m. \n3. 98m. \n4. 50m.", '1');

            return questionsAndAnswers;
        }


        public static Dictionary<string, char> GetGeneralKnowledgeQuestions()
        {
            Dictionary<string, char> questionsAndAnswers = new();
            
            questionsAndAnswers.Add("2/3 Kokioje šalyje yra pastatytas Koliziejus? \n" +
                "\n1. Graikija \n2. Šveicarija \n3. Australija \n4. Italija", '4');

            questionsAndAnswers.Add("1/3) Kuri Saulės sistemos planeta yra pirmoji, atrasta teleskopu? \n" +
                "\n1. Saturnas\n2. Jupiteris\n3. Marsas\n4. Uranas ", '4');

            questionsAndAnswers.Add("1/3) Ką Leonardo da Vinči paveiksle rankose laiko Mona Liza? \n" +
                "\n1. Gėlių puokštę \n2. Plunksną \n3. Skraistę \n4. Nieko", '4');


            return questionsAndAnswers;
        }
    }
}
