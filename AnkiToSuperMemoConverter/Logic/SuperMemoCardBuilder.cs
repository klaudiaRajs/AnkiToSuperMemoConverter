namespace AnkiToSuperMemoConverter {
    class SuperMemoCardBuilder {
        private string _xmlString;
        public string GetXmlString(string question, string answer) {
            _xmlString = Consts.SuperMemoXmlStartingTag + question + Consts.SuperMemoXmlAnswerStart + answer + Consts.SuperMemoXmlAnswerEnd; 
            return _xmlString;
        }

        public string GetCourseXmlString(int numberOfFiles) {
            string startingElements = Consts.SuperMemoCourseXmlStringStartingElements;
            string endingElement = Consts.SuperMemoCourseXmlStringEndingElement;
            string elementStart = Consts.SuperMemoElementStart;
            string elementEnd = Consts.SuperMemoElementEnd;
            
            string courseXmlString = startingElements;
            for( int i = 1; i <= numberOfFiles; i++) {
                courseXmlString += elementStart + i + elementEnd; 
            }
            courseXmlString += endingElement; 
            return courseXmlString; 
        }
    }
}
