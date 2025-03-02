using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AnkiToSuperMemoConverter
{
    class AnkiFieldsExtractor
    {
        private readonly string _questionsAnswersText;

        public AnkiFieldsExtractor(string questionsAnswers)
        {
            _questionsAnswersText = questionsAnswers;
        }

        public List<List<string>> GetQuestionsAndAnswersPair()
        {
            List<List<string>> questionsAnswersPairs = new List<List<string>>();
            string[] questionsAndAnswers = GetArrayWithQuestionsAndAnswers();
            foreach (string qa in questionsAndAnswers)
            {
                string betterQa = RemoveUnwantedCharacters(qa);
                List<string> qas = RemoveEmptyFields(Regex.Split(betterQa, Consts.TabCharacter));
                questionsAnswersPairs.Add(qas);
            }

            return questionsAnswersPairs;
        }

        private string RemoveUnwantedCharacters(string qa)
        {
            string[] unwantedCharacters =
            {
                Consts.SpaceCharacter,
                Consts.HtmlDivStartCharacter,
                Consts.HtmlDivEndCharacter,
                Consts.HtmlLineCharacter,
                Consts.Semicolon
            };

            string betterQa = qa;
            foreach (string character in unwantedCharacters)
            {
                betterQa = betterQa.Replace(character, string.Empty);
            }

            return betterQa;
        }

        private List<string> RemoveEmptyFields(string[] questionsAnswers)
        {
            List<string> questionsAndAnswersWithoutEmptyFields = new List<string>();
            foreach (string qa in questionsAnswers)
            {
                if (qa.Length != 0)
                {
                    questionsAndAnswersWithoutEmptyFields.Add(qa);
                }
            }

            return questionsAndAnswersWithoutEmptyFields;
        }

        private string[] GetArrayWithQuestionsAndAnswers()
        {
            string[] lines = Regex.Split(_questionsAnswersText, Consts.NewLineCharacter);
            return lines.Length != 0 ? lines : Array.Empty<string>();
        }
    }
}