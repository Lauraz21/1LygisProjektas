using System;
using System.Collections.Generic;
namespace _1LygisProjektas
{
    public static class Questions
    {
        public static Dictionary<string, char> GetScienceQuestions()
        {
            Dictionary<string, char> questionsAndAnswers = new();
            questionsAndAnswers.Add("1/4) Kuri Saulės sistemos planeta yra pirmoji, atrasta teleskopu? " +
                "\n1. Saturnas\n2. Jupiteris\n3. Marsas\n4. Uranas ", '4');

            questionsAndAnswers.Add("1/2 Kokia vidutinė Veneros paviršiaus temperatūra?" +
                "\n1. 980 °C\n2. 460 °C\n3. 170 °C\n4. -10 °C\n", '2');
            return questionsAndAnswers;
        }
    }
}
