namespace AnkiToSuperMemoConverter;

public static class Consts
{
    public const string SuperMemoXmlStartingTag =
        "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
            "<item xmlns=\"http://www.supermemo.net/2006/smux\">" +
                "<lesson-title>Lekcje</lesson-title>" +
                    "<chapter-title>Lekcje</chapter-title>" +
                        "<question-title>Przetlumacz<br/><br/></question-title><question>";
    public const string SuperMemoXmlAnswerStart = "<br/><br/><spellpad correct=\"";
    public const string SuperMemoXmlAnswerEnd = "\"/>.</question><modified>2016-05-28</modified><template-id> 8 </template-id></item>";
    public const string SuperMemoCourseXmlStringStartingElements =
        "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
            "<course xmlns=\"http://www.supermemo.net/2006/smux\">" +
            "<guid>8e3c197c-f8c3-4a19-9bcc-00f1d7627b6d</guid>" +
            "<title>Lekcje</title>" +
            "<created>2017-08-20</created>" +
            "<modified>2017-08-20</modified>" +
            "<language-of-instruction>en</language-of-instruction>" +
            "<language-taught>en</language-taught>" +
            "<default-items-per-day>10</default-items-per-day>" +
            "<default-template-id>1</default-template-id>" +
            "<type>regular</type>" +
            "<sorting>default</sorting>" +
        "<version>1.0.1</version>";
    public const string SuperMemoCourseXmlStringEndingElement = "</course>";
    public const string SuperMemoElementStart = "<element id=\"";
    public const string SuperMemoElementEnd = "\" type =\"exercise\" name =\"Pregunta\"/>";
    public const string ErrorOnlyTxtFiles = "You can only use files with TXT extension."; 
    public const string ErrorNoDestinationPath = "You have not provided destination path.";
    public const string AllowedExtension = ".txt";
    public const string CourseFileName = "\\course.xml";
    public const string SuperMemoFileExtension = ".xml";
    public const string SuperMemoItemFileName = "\\item";
    public const string TabCharacter = "\t";
    public const string NewLineCharacter = "\n";
    public const string Semicolon = ";"; 
    public const string SpaceCharacter = "&nbsp";
    public const string HtmlLineCharacter = "<br />"; 
    public const string HtmlDivStartCharacter = "<div>";
    public const string HtmlDivEndCharacter = "</div>";
    
}