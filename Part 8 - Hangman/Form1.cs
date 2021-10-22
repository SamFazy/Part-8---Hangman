using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_8___Hangman
{
    public partial class frmHangMan : Form
    {
        List<string> Guess = new List<string>();
        List<string> RandomWords = new List<string>();
        Random generator = new Random();
        int randomWord;
        int lives;
        int wordlength;
        string word;
        string playerWord;


        public frmHangMan()
        {
            InitializeComponent();
        }

        private void frmHangMan_Load(object sender, EventArgs e)
        {
            RandomWords.Add("MINECRAFT");
            RandomWords.Add("TETRIS");
            RandomWords.Add("OVERWATCH");
            RandomWords.Add("BORDERLANDS");
            RandomWords.Add("POKEMON");
            RandomWords.Add("FALLOUT");
            RandomWords.Add("BATTLEFIELD");

            randomWord = generator.Next(0, 6);
            word = RandomWords[randomWord];
            wordlength = word.Length;
            string dash = new String('-', wordlength);
            playerWord = dash;
            lblWord.Text = playerWord;
            label1.Text = word;
            

        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void GuessLetter(string letter)
        {
            Guess.Add(letter);
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;

            if (word.IndexOf(letter) != -1)
            {
                int index = word.IndexOf(letter);
                label1.Text += index;
                playerWord = playerWord.Remove(index, 1);
                playerWord = playerWord.Insert(index, letter);
                lblWord.Text = (playerWord);

                int index2 = word.LastIndexOf(letter);
                playerWord = playerWord.Remove(index2, 1);
                playerWord = playerWord.Insert(index2, letter);
                lblWord.Text = (playerWord);

            }
            else
            {
                lives = lives - 1;
                if (lives == 0)
                {
                    lblWord.Text = "You Lost";
                }
            }
        }

        private void lblA_Click(object sender, EventArgs e)
        {
            GuessLetter("A");
            lblA.Visible = false;
            
        }

        private void lblB_Click(object sender, EventArgs e)
        {
            GuessLetter("B");
            lblB.Visible = false;
            
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            GuessLetter("C");
            lblC.Visible = false;
            
        }

        private void lblD_Click(object sender, EventArgs e)
        {
            GuessLetter("D");
            lblD.Visible = false;
           
        }

        private void lblE_Click(object sender, EventArgs e)
        {
            GuessLetter("E");
            lblE.Visible = false;

        }

        private void lblF_Click(object sender, EventArgs e)
        {
            GuessLetter("F");
            lblF.Visible = false;
           
        }

        private void lblG_Click(object sender, EventArgs e)
        {
            GuessLetter("G");
            lblG.Visible = false;
            
        }

        private void lblH_Click(object sender, EventArgs e)
        {
            GuessLetter("H");
            lblH.Visible = false;
            
        }

        private void lblI_Click(object sender, EventArgs e)
        {
            GuessLetter("I");
            lblI.Visible = false;
            
        }

        private void lblJ_Click(object sender, EventArgs e)
        {
            GuessLetter("J");
            lblJ.Visible = false;
           
        }

        private void lblK_Click(object sender, EventArgs e)
        {
            GuessLetter("K");
            lblK.Visible = false;
            
        }

        private void lblL_Click(object sender, EventArgs e)
        {
            GuessLetter("L");
            lblL.Visible = false;
           
        }

        private void lblM_Click(object sender, EventArgs e)
        {
            GuessLetter("M");
            lblM.Visible = false;
            
        }

        private void lblN_Click(object sender, EventArgs e)
        {
            GuessLetter("N");
            lblN.Visible = false;

        }

        private void lblO_Click(object sender, EventArgs e)
        {
            GuessLetter("O");
            lblO.Visible = false;
            
        }

        private void lblP_Click(object sender, EventArgs e)
        {
            GuessLetter("P");
            lblP.Visible = false;
            
        }

        private void lblQ_Click(object sender, EventArgs e)
        {
            GuessLetter("Q");
            lblQ.Visible = false;
           
        }

        private void lblR_Click(object sender, EventArgs e)
        {
            GuessLetter("R");
            lblR.Visible = false;
           
        }

        private void lblS_Click(object sender, EventArgs e)
        {
            GuessLetter("S");
            lblS.Visible = false;
            Guess.Add("S");
            
        }

        private void lblT_Click(object sender, EventArgs e)
        {
            GuessLetter("T");
            lblT.Visible = false;
            
        }

        private void lblU_Click(object sender, EventArgs e)
        {
            GuessLetter("U");
            lblU.Visible = false;
            
        }

        private void lblV_Click(object sender, EventArgs e)
        {
            GuessLetter("V");
            lblV.Visible = false;
            
        }

        private void lblW_Click(object sender, EventArgs e)
        {
            GuessLetter("W");
            lblW.Visible = false;
            
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            GuessLetter("X");
            lblX.Visible = false;
            
        }

        private void lblY_Click(object sender, EventArgs e)
        {
            GuessLetter("Y");
            lblY.Visible = false;
            
        }

        private void lblZ_Click(object sender, EventArgs e)
        {
            GuessLetter("Z");
            lblZ.Visible = false;
           
        }
    }
}
