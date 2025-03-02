using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace AnkiToSuperMemoConverter {
    public partial class AnkiToSuperMemo : Form {
        private string _file;
        private string _path;
        private readonly SuperMemoCardBuilder _superMemo;

        public AnkiToSuperMemo() {
            InitializeComponent();
            _superMemo = new SuperMemoCardBuilder();
        }

        private void PickFileButton_Click(object sender, EventArgs e) {
            DialogResult result = getFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                _file = getFileDialog.FileName;
                if( !_file.Contains(Consts.AllowedExtension) ) {
                    Confirmation confirmation = new Confirmation(0, Consts.ErrorOnlyTxtFiles);
                    confirmation.Show();
                    return;
                }
                fileNameText.Text = _file;
                return;
            }
            _file = null;
        }

        private void BasedOnTextCreateAFile() {
            if( _path == null) {
                Confirmation confirmation = new Confirmation(0, Consts.ErrorNoDestinationPath);
                confirmation.Show();
                return; 
            }
            int i = Directory.GetFiles(_path).Length;
            if (_file != null) {
                try {
                    string text = File.ReadAllText(_file);
                    AnkiFieldsExtractor extractor = new AnkiFieldsExtractor(text);
                    ArrayList qandAs = extractor.GetQuestionsAndAnswersPair();
                    foreach (ArrayList el in qandAs) {
                        if (el.Count >= 2) {
                            string xmlCardText = _superMemo.GetXmlString((string)el[0], (string)el[1]);
                            string fileName = GetValidFileName(i);
                            File.WriteAllText(fileName, xmlCardText);
                            i++;
                        }
                    }
                    GenerateCourseFile(i);
                }
                catch (IOException) {

                }
                Confirmation confirmation = new Confirmation(i);
                confirmation.Show();
            }
        }

        private void GenerateCourseFile(int numberOfFiles) {
            string courseString = _superMemo.GetCourseXmlString(numberOfFiles);
            string fileName = _path + Consts.CourseFileName;
            File.WriteAllText(fileName, courseString);
        }

        private string GetValidFileName(int i) {
            string fullFileName = _path + Consts.SuperMemoItemFileName;
            string number = i.ToString();
            int numberOfDigits = number.Length;
            int numberOfZeroes = 5 - numberOfDigits;
            for (int j = 0; j < numberOfZeroes; j++) {
                fullFileName = fullFileName + "0";
            }
            fullFileName = fullFileName + i + Consts.SuperMemoFileExtension;
            return fullFileName;
        }

        private void DestinationFolderButton_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) {
                string selectedPath = folderBrowserDialog.SelectedPath;
                pathBox.Text = selectedPath;
                _path = selectedPath;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e) {
            BasedOnTextCreateAFile();
        }
    }
}
