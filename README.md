# AnkiToSuperMemoConverter
Simple C# application that allows converting exported to .txt Anki deck to SuperMemo cards. 

## Features 
Allows converting Q&A sets exported from Anki (.txt file) into .xml files that could be exported to SuperMemo UX as customized course. 

## Quick Start 
### Generating files 
- Clone source code and run the app 
- Export Anki deck to .txt file 
- Choose path to exported text file within the main window of the application 
- Choose destination path, to where you want to save created cards (make it a new folder, do not overwrite your current course!) 
- Click "Generate". 

### Adding new cards to a new SuperMemo course 
- Create a new course from SuperMemo interface 
- Find a directory where the course is stored 
- Copy and paste the result of file generation (overwrite course.xml) 

### Adding new cards to existing SuperMemo course 
- Find directory where the course is stored 
- Copy and paste card files (item*.xml) (IMPORTANT! Make sure NOT to overwrite any files)
- Open course.xml in the course. From generated course.xml copy all <element> tags and past the into current course.xml. 
Ensure that all id attributes are unique! 
