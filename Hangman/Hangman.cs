using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        private string word;
        private char[] wordArr;
        private char[] solution;
        private int state = 0;
        private int timesWrong = 0;


        public Hangman()
        {
            InitializeComponent();
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (tbWord.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please choose a word");
                return;
            }

            word = tbWord.Text.ToUpper();
            wordArr = tbWord.Text.ToUpper().ToCharArray();

            solution = new char[wordArr.Length];

            for (int i = 0; i < wordArr.Length; i++)
            {
                solution[i] = '_';
                lblWordToGuess.Text += $"{solution[i]} ";
            }

            tbWord.Visible = false;
            tbWord.Text = "";
            lstGuessed.Visible = true;
            lstGuessed.Focus();
            pbHangmanErr1.Visible = true;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void LstGuessed_KeyDown(object sender, KeyEventArgs e)
        {
            char charChck = (char)e.KeyCode;

            for (int i = 0; i < wordArr.Length; i++)
            {
                if (wordArr[i].Equals(charChck))
                {
                    solution[i] = wordArr[i];
                    state = 0;
                }
            }

            if (state.Equals(0) && !lstGuessed.Items.Contains(charChck))
            {
                lstGuessed.Items.Add(charChck);
                lblWordToGuess.Text = "";

                foreach (char ch in solution)
                {
                    lblWordToGuess.Text += $"{ch} ";

                    if (ch.Equals('_'))
                    {
                        state--;
                    }
                    else
                    {
                        state++;
                    }
                }
            }
            else if (!lstGuessed.Items.Contains(charChck))
            {
                lstGuessed.Items.Add(charChck);
                timesWrong++;

                pbHangmanErr1.Image = Image.FromFile(@"..\..\Resources\Hangman " + (timesWrong + 1) + ".png");

                pbHangmanErr1.Refresh();
            }
            else
            {
                MessageBox.Show("This letter has already been used. Please try another");
            }

            if (state == solution.Length)
            {
                MessageBox.Show("You have succesfully guessed the word");

                Reset();
            }
            else if (timesWrong == 11)
            {
                MessageBox.Show($"You died. The word was: {word}");

                Reset();
            }

        }

        private void Reset()
        {
            tbWord.Text = "";
            tbWord.Visible = true;
            lblWordToGuess.Text = "";
            lstGuessed.Items.Clear();
            lstGuessed.Visible = false;
            timesWrong = 0;
            state = 0;
            pbHangmanErr1.Visible = false;
            pbHangmanErr1.Image = Image.FromFile(@"..\..\Resources\Hangman " + (timesWrong + 1) + ".png");
        }
    }
}