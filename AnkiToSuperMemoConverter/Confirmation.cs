using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnkiToSuperMemoConverter {
    public partial class Confirmation : Form {
        public Confirmation(int i, string errorMessage = null) {
            InitializeComponent();
            String text = label1.Text + ". You have created " + (i + 1) + " files";
            if ( errorMessage != null) {
                text = errorMessage;
            }
            label1.Text = text;
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
