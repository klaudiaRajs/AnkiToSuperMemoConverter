using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace AnkiToSuperMemoConverter {
    public partial class AnkiToSuperMemo : Form {
        private string file;
        private string path;
        SuperMemoCardBuilder superMemo;

        public AnkiToSuperMemo() {
            InitializeComponent();
            superMemo = new SuperMemoCardBuilder();
        }

        private void pickFileButton_Click(object sender, EventArgs e) {
            DialogResult result = getFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                file = getFileDialog.FileName;
                if( !file.Contains(".txt") ) {
                    Confirmation confirmation = new Confirmation(0, "You can only use files with TXT extension.");
                    confirmation.Show();
                    return;
                }
                fileNameText.Text = file;
                return;
            }
            file = null;
        }

        private void basedOnTextCreateAFile() {
            if( path == null) {
                Confirmation confirmation = new Confirmation(0, "You have not provided destination path.");
                confirmation.Show();
                return; 
            }
            int i = Directory.GetFiles(path).Length;
            if (file != null) {
                try {
                    string text = File.ReadAllText(file);
                    AnkiFieldsExtractor extractor = new AnkiFieldsExtractor(text);
                    ArrayList QandAs = extractor.getQuestionsAndAnswersPair();
                    foreach (ArrayList el in QandAs) {
                        if (el.Count >= 2) {
                            string xmlCardText = superMemo.getXmlString((string)el[0], (string)el[1]);
                            string fileName = getValidFileName(i);
                            File.WriteAllText(fileName, xmlCardText);
                            i++;
                        }
                    }
                    generateCourseFile(i);
                }
                catch (IOException) {

                }
                Confirmation confirmation = new Confirmation(i);
                confirmation.Show();
            }
        }

        private void generateCourseFile(int numberOfFiles) {
            string courseString = superMemo.getCourseXmlString(numberOfFiles);
            string fileName = path + "\\course.xml";
            File.WriteAllText(fileName, courseString);
        }

        private string getValidFileName(int i) {
            string fullFileName = path + "\\item";
            string number = i.ToString();
            int numberOfDigits = number.Length;
            int numberOfZeroes = 5 - numberOfDigits;
            for (int j = 0; j < numberOfZeroes; j++) {
                fullFileName = fullFileName + "0";
            }
            fullFileName = fullFileName + i + ".xml";
            return fullFileName;
        }

        private void destinationFolderButton_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) {
                string selectedPath = folderBrowserDialog.SelectedPath;
                pathBox.Text = selectedPath;
                path = selectedPath;
            }
        }

        private void generateButton_Click(object sender, EventArgs e) {
            basedOnTextCreateAFile();
        }
    }
}
