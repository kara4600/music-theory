using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppChords
{
    public partial class FormChordFinder : Form
    {

        public FormChordFinder()
        {
            InitializeComponent();
        }

        private void textBoxEnterChordNotes_Enter(object sender, EventArgs e)
        {
            if (e.Equals(Keys.Enter))
            {
                string stringNotes = textBoxEnterChordNotes.Text;
                textBoxChordResult.Text = "HELLO";
                
            }
        }

        private string findChord(string s)
        {
            string userInput = s.ToUpper();
            char temp;
            string result = "";

            // Turns user input into a string of notes
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] != ' ' && userInput[i] != ',')
                {
                    temp = userInput[i];
                    result += temp;
                }
            }

            return result;
        }

        private void textBoxEnterChordNotes_KeyDown(object sender, KeyEventArgs e)
        {
            string notesString;

            if (e.KeyCode == Keys.Enter)
            {
                notesString = textBoxEnterChordNotes.Text; 
                notesString = notesString.Trim();
                textBoxChordResult.Text = findChord(notesString);
            }

        }
        private void buttonFindChord_Click(object sender, EventArgs e)
        {
            string notesString;

            notesString = textBoxEnterChordNotes.Text;
            notesString = notesString.Trim();
            textBoxChordResult.Text = findChord(notesString);
        }
    }
}
