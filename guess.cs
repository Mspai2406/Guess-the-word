using System;
using System.Windows.Forms;


namespace GuessWord
{
    public partial class Form1 : Form
    {
        string secretword;
        char guess;
        string[] solution;
        string stringsolution;
        int badguesscount;
        int goodguesscount;
        public Form1()
        {
            InitializeComponent();
            secretword = "karnataka";
            solution = new string[secretword.Length];
        }
         private void TextGuess_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MakeSolutionString();
        }
        public void MakeSolutionString()
        {
            string temp = " ";
            for (int i = 0; i < secretword.Length; i++)
            {
                solution[i] = "__" + " ";
                stringsolution = temp + solution[i];
                temp = stringsolution;
            }
            lb1secretword.Text = stringsolution;
        }
        public void CheckGuess()
        {
            int i;
            bool found = false;
            guess = textGuess.Text[0];
            string temp = " ";
            for (i = 0; i < secretword.Length; i++)
            {
                if (secretword[i].CompareTo(guess) == 0)
                {
                    solution[i] = guess.ToString();
                    goodguesscount++;
                    found = true;

                    if (goodguesscount == secretword.Length)
                        Label3EndGame.Text = "You  Win!";
                }


                stringsolution = temp + solution[i];

                temp = stringsolution;
                lb1secretword.Text = stringsolution;
            }
            if (found == false)
            {
                badguesscount++;
                if (badguesscount == 6)
                {
                    Label3EndGame.Text = "Sorry,you Lose";
                }
            }
            lb1secretword.Text = stringsolution;
        }
             private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CheckGuess();
        }
    }
}
