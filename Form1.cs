using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoldStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text; // This line gets input from user
            string[] words = input.Split(' '); // This line splits the input string into individual words and stores them in a string array called "words"
            // The split() method also takes a delimeter character which in this case is a space (' ')
            var output = new StringBuilder();// This Line creates a new StringBuilder object named output, we will use it below to construct the output.
            foreach (string word in words) // This Line starts a loop that will iterate over each word in the words array.
            {
                string boldword = "";
                if (word.Length >= 3) // Makes the first 3 letters bold
                {
                    boldword = string.Format(@"\b {0}\b0 {1}", word.Substring(0, 3), word.Substring(3));
                }
                else // Makes the first letter bold only
                {
                    boldword = string.Format(@"\b {0}\b0 {1}", word[0], word.Substring(1)); // this if statement processes each word in the loop. 
                } // if the word has 3 or more letters the first 3 letters are emphasided in bold by the RFT tags \b and \b0 and if it has fewer than 3 enphasise first letter only.
                output.Append(boldword).Append(" ");// this line will append the emphasided word followed by a space to the stringbuilder named output.
            } // the append method will add the string to the String Builder.

            rtbProcessedTxt.Rtf = @"{\rtf1\ansi " + output.ToString() + "}"; // This line of code sets the RTF property of the RichTextBox named "rtbProcessedTxt.Rtf"
        } // to the processed string wrapped in the RTF header and footer and i used tostring method to get the final output string from the stringbuilder.
        // because i am using a richtextbox, the rtf format must be used to allow us to specify the font style for specific parts of the text.
        // in this case \b tag to start the bold text and \b0 to end it.
        private void clearButton_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}
