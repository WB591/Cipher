using System;
using System.Linq;
using System.Windows.Forms;

namespace Cipher
{
    public partial class Cipher : Form
    {
        public Cipher()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputTextTextBox.Clear();
            OutputTextBox.Clear();
            secetWordTextBox.Clear();
            secetWordTextBox.Focus();
        }

        private void TranslateTextButton_Click(object sender, EventArgs e)
        {
            string secretWord = secetWordTextBox.Text;

            string[,] alphabet = new string[5, 5];

            string letters = "abcdefghijklmnopqrstuvwxy";
            int count = 0;

            //append secret word to letters.
            string newLetters = secretWord + letters;

            //check for duplicates in newLetters string
            char[] secretWordArray = newLetters.ToCharArray();

            secretWordArray = newLetters.Distinct().ToArray();

            //this is a 5X5 array with the secret word and no duplicate letters with the alphabet
            for (int m = 0; m < 5; m++)
            {
                for (int n = 0; n < 5; n++)
                {
                    alphabet[m, n] = secretWordArray[count].ToString();
                    count = count + 1;
                }
            }
            //get the input message 
            string inputText = InputTextTextBox.Text;

            string outputText = "";
            // take the input text and find the spot in the new array where the letters go.
            for (int i = 0; i < inputText.Length; i++)
            {
                for (int m = 0; m < 5; m++)
                {
                    for (int n = 0; n < 5; n++)
                    {
                        //How to account for the spaces in the input text?
                        if (inputText[i].ToString() == alphabet[m, n])
                        {
                            int y = m;
                            int x = n;
                            outputText += alphabet[x, y];
                        }
                    }
                }
            }
            OutputTextBox.Text = outputText;
        }
    }
}
