using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CharactersAndStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAboutChar_Click(object sender, EventArgs e)
        {
            char x ='G'; //a char literal
            rtbDisplay.Text = "'A' is a char literal. It is displayed as " + x;
            rtbDisplay.AppendText("\nA char variable stores one and only one unicode character");
            //to find out a char's unicode number
            rtbDisplay.AppendText("\nThe unicode number of 'A' is " + Convert.ToUInt16(x).ToString());
            //char y = 'AB'; //ERROR
            //char z = ' '; //ERROR            
        }
        private void btnReverseString_Click(object sender, EventArgs e)
        {
            //to convert a string into an array of characters
            char[] x = txtInput.Text.ToArray();
            //char[] x = "Hello".ToArray(); //string literal okay, variable okay
            string y = " ";
            //using a FOR loop to add characters to string y
            //for (int i=0; i<x.Length; i++)
            //{
            //    y += x[i] + y;
            //}
            //x[0] = 'X';
            for (int i = x.Length-1; i>=0; i--)
            {
                y += x[i];
            }
            rtbDisplay.Text = "Reversing user input and you get \n" + y;
        }

        private void btnCharString_Click(object sender, EventArgs
            e)
        {
            rtbDisplay.Clear();
            string s = txtInput.Text;
            if (s.Length > 0)
                for (int i = 0; i < s.Length; i++)
                    //use indec t access a character in a string
                    rtbDisplay.AppendText(s[i] + Environment.NewLine);
            else
            {
                rtbDisplay.Text = "No user input, yet.";
                txtInput.Focus();
                return;
            }
            rtbDisplay.AppendText(
                "\nWhen accessing characters, a string works like an array. But it is NOT!");
            //because string is not mutable, a new string must be created
            //s{0]='B'; //see what happens if this line is uncommented
        }

        private void btnIsLetterChar_Click(object sender, EventArgs e)
        {
            string x = txtInput.Text;
            List<char> allLetter = new List<char>();
            List<char> allDigits = new List<char>();
            List<char> allLetterDigits = new List<char>();
            List<char> allUpper = new List<char>();
            List<char> allLower = new List<char>();
            List<char> allPunctuation = new List<char>();
            for (int i=0; i< x.Length; i++)
            {
                char current = x[i];
                if (char.IsLetter(current)) allLetter.Add(current);
                if (char.IsDigit(current)) allDigits.Add(current);
                if (char.IsLetterOrDigit(current)) allLetterDigits.Add(current);
                if (char.IsUpper(current)) allUpper.Add(current);
                if (char.IsLower(current)) allLower.Add(current);
                if (char.IsPunctuation(current)) allPunctuation.Add(current);
            }
            rtbDisplay.Text = "Retreiving from " + x +
                "\nall Letters: " + string.Concat(allLetter) +
                "\nall digits: " + string.Concat(allDigits) +
                "\nall letters and digits: " + string.Concat(allLetterDigits) +
                "\nall upper case letters: " + string.Concat(allUpper) +
                "\nall lower case letters: " + string.Concat(allLower) +
                "\nall punctuation: " + string.Concat(allPunctuation);

        }
    

        private void btnOneParameterSubstring_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length == 0)
            {
                return;
            }
            string x = txtInput.Text;
            string userInput = Interaction.InputBox(
                "please type an integer number for the substring's index");
            int i; //to store the index
            if (int.TryParse(userInput, out i))
            {
                rtbDisplay.Text = Environment.NewLine + "you have tyed " + userInput + " for your substring's index: ";
                if (i < x.Length)
                {
                    rtbDisplay.AppendText(
                        Environment.NewLine + "here is your substring: " + x.Substring(i));
                }
                else
                {
                    rtbDisplay.AppendText(
                        Environment.NewLine + i.ToString() + " is out of range. Try a smaller number.");
                }
            }
            else
            {
                MessageBox.Show("That's not a legitimate input. Try again.");
            }
        }

        private void btnTwoParameterSubstring_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            string x = txtInput.Text;
            string userInput = Interaction.InputBox(@"Now type two integers separated by a coma:
            the first integer for the substring's index, 
the second integer for the substring's length");
            string[] stringArray = userInput.Split(',');
            int i, n;
            if (int.TryParse(stringArray[0], out i) && int.TryParse(stringArray[1], out n))
            {
                rtbDisplay.Text = "you have selected " + i.ToString() + " for the substring's index and " +
                    n.ToString() + " for its total number of characters. Here is your substring: \n";
                if (i + n <= x.Length)
                {
                    rtbDisplay.AppendText(Environment.NewLine + x.Substring(i, n));
                }
                else
                {
                    rtbDisplay.AppendText(Environment.NewLine + "out of range. Try again.");
                }
            }
            else
            {
                MessageBox.Show("That's not a legitimate input. Try again");
            }
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length == 0)
            { return; } //exit if no user input
            string x = txtInput.Text;
            rtbDisplay.Text = "User has entered the following: " + Environment.NewLine +
                x + Environment.NewLine + Environment.NewLine;

            //asking to type a string to determine if it is a substring of x
            string searchedString = Interaction.InputBox("What substring are you looking for?");

            //passing searched substring to IndexOf method
            //int i = x.IndexOf(searchedString); //
            x.IndexOf('i'); //accepts two parameters
            int i = x.LastIndexOf('i');
            if (i != -1) //searched string is not a substring if i is -1
            {
                rtbDisplay.Text = "\"" + searchedString + "\" is a substring of \""
                    + x + "\" and its index is " + 1.ToString() + ".";
            }
        
            else
            {
                rtbDisplay.Text = "\"" + searchedString 
                    + "\" is not a substring of \"" + x + "\".";
            }
            //use substring method with one parameter
        }

        private void rtbRemove_Click(object sender, EventArgs e)
        {
            //string quoteEmmerson = "ssaasdsdasdasdsd2 * 1 * sss";
            //char X = 'x';
            //foreach (char ch in x)
            //{
            //    if (!char.IsDigit(ch))
            //    X += c;
            //}
            //rtbDisplay.Text = x + " with digits removed \n" + newX;

        }

        private void btnQuiz3_Click(object sender, EventArgs e)
        {
            string quoteEmerson = "For every mnute you remain angry, you give up sity second of peace of mind.";
            int totalLetters = 0;
            for (int x =0; x < quoteEmerson.Length; x++)
            {
                if (char.IsLetter(quoteEmerson[x]))
                {
                    totalLetters++;
                }
                //foreach (char x in quoteEmerson)
                //{
                //    if (char.IsLetter(x))
                //        totalLetters++;
                //}
                
            }
            MessageBox.Show("There are " + totalLetters.ToString() + " letters.");
        }
    }
}
