using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkiToSuperMemoConverter {
    class SuperMemoCardBuilder {
        private string xmlString; 
        string xmlStartTag = "<?xml version=\"1.0\" encoding=\"utf-8\"?><item xmlns=\"http://www.supermemo.net/2006/smux\"><lesson-title>Lekcje</lesson-title><chapter-title>Lekcje </chapter-title><question-title>Przetlumacz<br/><br/></question-title><question>";
        string answerStart = "<br/><br/><spellpad correct=\"";
        string answerEnd = "\"/>.</question><modified>2016-05-28</modified><template-id> 8 </template-id></item>"; 

        public string getXmlString(string question, string answer) {
            xmlString = xmlStartTag + question + answerStart + answer + answerEnd; 
            return xmlString;
        }

        public string getCourseXmlString(int numberOfFiles) {
            string startingElements = "<?xml version=\"1.0\" encoding=\"utf-8\"?><course xmlns=\"http://www.supermemo.net/2006/smux\"><guid>8e3c197c-f8c3-4a19-9bcc-00f1d7627b6d</guid><title>Lekcje</title><created>2017-08-20</created><modified>2017-08-20</modified><language-of-instruction>en</language-of-instruction><language-taught>en</language-taught><default-items-per-day>10</default-items-per-day><default-template-id>1</default-template-id><type>regular</type><sorting>default</sorting><version>1.0.1</version>";
            string endingElement = "</course>";
            string elementStart = "<element id=\"";
            string elementEnd = "\" type =\"exercise\" name =\"Pregunta\"/>";
            string courseXmlString = startingElements;
            for( int i = 1; i <= numberOfFiles; i++) {
                courseXmlString += elementStart + i + elementEnd; 
            }
            courseXmlString += endingElement; 
            return courseXmlString; 
        }
    }
}
