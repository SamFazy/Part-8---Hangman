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

        public frmHangMan()
        {
            InitializeComponent();
        }

        private void frmHangMan_Load(object sender, EventArgs e)
        {

        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void GuessLetter(string letter)
        {
            
        }

        private void lblA_Click(object sender, EventArgs e)
        {
            GuessLetter("A");
            lblA.Visible = false;
            Guess.Add("A");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblB_Click(object sender, EventArgs e)
        {
            GuessLetter("B");
            lblB.Visible = false;
            Guess.Add("B");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            GuessLetter("C");
            lblC.Visible = false;
            Guess.Add("C");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblD_Click(object sender, EventArgs e)
        {
            GuessLetter("D");
            lblD.Visible = false;
            Guess.Add("D");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;

        }

        private void lblE_Click(object sender, EventArgs e)
        {
            GuessLetter("E");
            lblE.Visible = false;
            Guess.Add("E");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblF_Click(object sender, EventArgs e)
        {
            GuessLetter("F");
            lblF.Visible = false;
            Guess.Add("F");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblG_Click(object sender, EventArgs e)
        {
            GuessLetter("G");
            lblG.Visible = false;
            Guess.Add("G");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblH_Click(object sender, EventArgs e)
        {
            GuessLetter("H");
            lblH.Visible = false;
            Guess.Add("H");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblI_Click(object sender, EventArgs e)
        {
            GuessLetter("I");
            lblI.Visible = false;
            Guess.Add("I");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblJ_Click(object sender, EventArgs e)
        {
            GuessLetter("J");
            lblJ.Visible = false;
            Guess.Add("J");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblK_Click(object sender, EventArgs e)
        {
            GuessLetter("K");
            lblK.Visible = false;
            Guess.Add("K");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblL_Click(object sender, EventArgs e)
        {
            GuessLetter("L");
            lblL.Visible = false;
            Guess.Add("L");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblM_Click(object sender, EventArgs e)
        {
            GuessLetter("M");
            lblM.Visible = false;
            Guess.Add("M");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblN_Click(object sender, EventArgs e)
        {
            GuessLetter("N");
            lblN.Visible = false;
            Guess.Add("N");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblO_Click(object sender, EventArgs e)
        {
            GuessLetter("O");
            lblO.Visible = false;
            Guess.Add("O");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblP_Click(object sender, EventArgs e)
        {
            GuessLetter("P");
            lblP.Visible = false;
            Guess.Add("P");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblQ_Click(object sender, EventArgs e)
        {
            GuessLetter("Q");
            lblQ.Visible = false;
            Guess.Add("Q");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblR_Click(object sender, EventArgs e)
        {
            GuessLetter("R");
            lblR.Visible = false;
            Guess.Add("R");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblS_Click(object sender, EventArgs e)
        {
            GuessLetter("S");
            lblS.Visible = false;
            Guess.Add("S");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblT_Click(object sender, EventArgs e)
        {
            GuessLetter("T");
            lblT.Visible = false;
            Guess.Add("T");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblU_Click(object sender, EventArgs e)
        {
            GuessLetter("U");
            lblU.Visible = false;
            Guess.Add("U");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblV_Click(object sender, EventArgs e)
        {
            GuessLetter("V");
            lblV.Visible = false;
            Guess.Add("V");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblW_Click(object sender, EventArgs e)
        {
            GuessLetter("W");
            lblW.Visible = false;
            Guess.Add("W");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            GuessLetter("X");
            lblX.Visible = false;
            Guess.Add("X");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblY_Click(object sender, EventArgs e)
        {
            GuessLetter("Y");
            lblY.Visible = false;
            Guess.Add("Y");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }

        private void lblZ_Click(object sender, EventArgs e)
        {
            GuessLetter("Z");
            lblZ.Visible = false;
            Guess.Add("Z");
            lstGuessed.DataSource = null;
            lstGuessed.DataSource = Guess;
        }
    }
}
