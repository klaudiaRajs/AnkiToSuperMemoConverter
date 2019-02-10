using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnkiToSuperMemoConverter {
    class AnkiFieldsExtractor {

        private string questionsAnswersText; 

        public AnkiFieldsExtractor(string questionsAnswers) {
            questionsAnswersText = questionsAnswers; 
        }

        public ArrayList getQuestionsAndAnswersPair() {
            ArrayList questionsAnswersPairs = new ArrayList(); 
            Array questionsAndAnswers = getArrayWithQuestionsAndAnswers(); 
            foreach( string qa in questionsAndAnswers) {
                string betterQa = removeUnwantedCharacters(qa);
                ArrayList qas = removeEmptyFields(Regex.Split(betterQa, "\t"));
                questionsAnswersPairs.Add(qas); 
            }
            return questionsAnswersPairs;
        }

        private string removeUnwantedCharacters(string qa) {
            string betterQa = qa; 
            while( betterQa.IndexOf("&nbsp") != -1) {
                betterQa = qa.Replace("&nbsp", "");
            }
            while( betterQa.IndexOf("<div>") != -1) {
                betterQa = betterQa.Replace("<div>", "");
            }
            while (betterQa.IndexOf("</div>") != -1) {
                betterQa = betterQa.Replace("</div>", "");
            }
            while (betterQa.IndexOf("<br />") != -1) {
                betterQa = betterQa.Replace("<br />", "");
            }
            while (betterQa.IndexOf(";") != -1) {
                betterQa = betterQa.Replace(";", "");
            }
            return betterQa; 
        }

        private ArrayList removeEmptyFields(string[] questionsAnswers) {
            ArrayList questionsAndAnswersWithoutEmptyFields = new ArrayList(); 
            foreach( string qa in questionsAnswers) {
                if( qa.Length != 0) {
                    questionsAndAnswersWithoutEmptyFields.Add(qa); 
                }
            }
            return questionsAndAnswersWithoutEmptyFields; 
        }

        private Array getArrayWithQuestionsAndAnswers() {
            string[] lines = Regex.Split(questionsAnswersText, "\n"); 
            if( lines.Count() != 0) {
                return lines; 
            }
            return null;
        }
    }
}
