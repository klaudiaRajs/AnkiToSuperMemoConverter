using System;
using System.Collections;
 using System.Linq;
using System.Text.RegularExpressions;

namespace AnkiToSuperMemoConverter {
    class AnkiFieldsExtractor {

        private readonly string _questionsAnswersText; 

        public AnkiFieldsExtractor(string questionsAnswers) {
            _questionsAnswersText = questionsAnswers; 
        }

        public ArrayList GetQuestionsAndAnswersPair() {
            ArrayList questionsAnswersPairs = new ArrayList(); 
            Array questionsAndAnswers = GetArrayWithQuestionsAndAnswers(); 
            foreach( string qa in questionsAndAnswers) {
                string betterQa = RemoveUnwantedCharacters(qa);
                ArrayList qas = RemoveEmptyFields(Regex.Split(betterQa, Consts.TabCharacter));
                questionsAnswersPairs.Add(qas); 
            }
            return questionsAnswersPairs;
        }

        private string RemoveUnwantedCharacters(string qa) {
            string betterQa = qa; 
            while( betterQa.IndexOf(Consts.SpaceCharacter, StringComparison.Ordinal) != -1) {
                betterQa = qa.Replace(Consts.SpaceCharacter, string.Empty);
            }
            while( betterQa.IndexOf(Consts.HtmlDivCharacter, StringComparison.Ordinal) != -1) {
                betterQa = betterQa.Replace(Consts.HtmlDivCharacter, string.Empty);
            }
            while (betterQa.IndexOf(Consts.HtmlDivEndCharacter, StringComparison.Ordinal) != -1) {
                betterQa = betterQa.Replace(Consts.HtmlDivEndCharacter, string.Empty);
            }
            while (betterQa.IndexOf(Consts.HtmlLineCharacter, StringComparison.Ordinal) != -1) {
                betterQa = betterQa.Replace(Consts.HtmlLineCharacter, string.Empty);
            }
            while (betterQa.IndexOf(Consts.Semicolon, StringComparison.Ordinal) != -1) {
                betterQa = betterQa.Replace(Consts.Semicolon, string.Empty);
            }
            return betterQa; 
        }

        private ArrayList RemoveEmptyFields(string[] questionsAnswers) {
            ArrayList questionsAndAnswersWithoutEmptyFields = new ArrayList(); 
            foreach( string qa in questionsAnswers) {
                if( qa.Length != 0) {
                    questionsAndAnswersWithoutEmptyFields.Add(qa); 
                }
            }
            return questionsAndAnswersWithoutEmptyFields; 
        }

        private Array GetArrayWithQuestionsAndAnswers() {
            string[] lines = Regex.Split(_questionsAnswersText, Consts.NewLineCharacter); 
            if( lines.Count() != 0) {
                return lines; 
            }
            return null;
        }
    }
}
