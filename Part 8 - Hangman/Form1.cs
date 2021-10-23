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
            lives = 4;
            lblLives.Text = "Lives: " + lives;
            btnPlayAgain.Visible = false;

            imgHangman1.Visible = true;
            imgHangman2.Visible = false;
            imgHangman3.Visible = false;
            imgHangman5.Visible = false;
            imgHangman4.Visible = false;


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
                lblLives.Text = "Lives: " + lives;

                if (lives == 0)
                {
                    lblWord.Text = "You Lost!!!";
                }
            }

            if (lives == 4)
            {
                imgHangman1.Visible = true;
                imgHangman2.Visible = false;
                imgHangman3.Visible = false;
                imgHangman5.Visible = false;
                imgHangman4.Visible = false;
            }
            else if (lives == 3)
            {
                imgHangman1.Visible = false;
                imgHangman2.Visible = true;
                imgHangman3.Visible = false;
                imgHangman5.Visible = false;
                imgHangman4.Visible = false;
            }
            else if (lives == 2)
            {
                imgHangman1.Visible = false;
                imgHangman2.Visible = false;
                imgHangman3.Visible = true;
                imgHangman5.Visible = false;
                imgHangman4.Visible = false;
            }
            else if (lives == 1)
            {
                imgHangman1.Visible = false;
                imgHangman2.Visible = false;
                imgHangman3.Visible = false;
                imgHangman5.Visible = true;
                imgHangman4.Visible = false;
            }
            else if (lives == 0)
            {
                imgHangman1.Visible = false;
                imgHangman2.Visible = false;
                imgHangman3.Visible = false;
                imgHangman5.Visible = false;
                imgHangman4.Visible = true;

            }


            if (lives == 0 || playerWord == word)
            {
                lblA.Visible = false;
                lblB.Visible = false;
                lblC.Visible = false;
                lblD.Visible = false;
                lblE.Visible = false;
                lblF.Visible = false;
                lblG.Visible = false;
                lblH.Visible = false;
                lblI.Visible = false;
                lblJ.Visible = false;
                lblK.Visible = false;
                lblL.Visible = false;
                lblM.Visible = false;
                lblN.Visible = false;
                lblO.Visible = false;
                lblP.Visible = false;
                lblQ.Visible = false;
                lblR.Visible = false;
                lblS.Visible = false;
                lblT.Visible = false;
                lblU.Visible = false;
                lblV.Visible = false;
                lblW.Visible = false;
                lblX.Visible = false;
                lblY.Visible = false;
                lblZ.Visible = false;

                btnPlayAgain.Visible = true;
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

        private void btnPlayAgain_Click_1(object sender, EventArgs e)
        {
            btnPlayAgain.Visible = false;
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
            lives = 4;
            lblLives.Text = "Lives: " + lives;

            lblA.Visible = true;
            lblB.Visible = true;
            lblC.Visible = true;
            lblD.Visible = true;
            lblE.Visible = true;
            lblF.Visible = true;
            lblG.Visible = true;
            lblH.Visible = true;
            lblI.Visible = true;
            lblJ.Visible = true;
            lblK.Visible = true;
            lblL.Visible = true;
            lblM.Visible = true;
            lblN.Visible = true;
            lblO.Visible = true;
            lblP.Visible = true;
            lblQ.Visible = true;
            lblR.Visible = true;
            lblS.Visible = true;
            lblT.Visible = true;
            lblU.Visible = true;
            lblV.Visible = true;
            lblW.Visible = true;
            lblX.Visible = true;
            lblY.Visible = true;
            lblZ.Visible = true;

            imgHangman1.Visible = true;
            imgHangman2.Visible = false;
            imgHangman3.Visible = false;
            imgHangman5.Visible = false;
            imgHangman4.Visible = false;
        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
