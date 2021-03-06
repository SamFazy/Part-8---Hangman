namespace Part_8___Hangman
{
    partial class frmHangMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lstGuessed = new System.Windows.Forms.ListBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.imgHangman5 = new System.Windows.Forms.PictureBox();
            this.imgHangman4 = new System.Windows.Forms.PictureBox();
            this.imgHangman3 = new System.Windows.Forms.PictureBox();
            this.imgHangman2 = new System.Windows.Forms.PictureBox();
            this.imgHangman1 = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(309, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hang Man";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(131, 64);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(557, 29);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Try to guess the word by guessing all of the letters";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(668, 9);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(152, 49);
            this.lblLives.TabIndex = 3;
            this.lblLives.Text = "Lives: 4";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(211, 449);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(406, 69);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "_ _ _ _ _ _ _ _";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(287, 150);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(39, 38);
            this.lblA.TabIndex = 5;
            this.lblA.Text = "A";
            this.lblA.Click += new System.EventHandler(this.lblA_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(333, 150);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(39, 38);
            this.lblB.TabIndex = 6;
            this.lblB.Text = "B";
            this.lblB.Click += new System.EventHandler(this.lblB_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(376, 150);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(41, 38);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "C";
            this.lblC.Click += new System.EventHandler(this.lblC_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(419, 150);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(41, 38);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "D";
            this.lblD.Click += new System.EventHandler(this.lblD_Click);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(461, 150);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(39, 38);
            this.lblE.TabIndex = 9;
            this.lblE.Text = "E";
            this.lblE.Click += new System.EventHandler(this.lblE_Click);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(505, 150);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(37, 38);
            this.lblF.TabIndex = 10;
            this.lblF.Text = "F";
            this.lblF.Click += new System.EventHandler(this.lblF_Click);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(312, 190);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(43, 38);
            this.lblG.TabIndex = 11;
            this.lblG.Text = "G";
            this.lblG.Click += new System.EventHandler(this.lblG_Click);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(355, 190);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(41, 38);
            this.lblH.TabIndex = 12;
            this.lblH.Text = "H";
            this.lblH.Click += new System.EventHandler(this.lblH_Click);
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(397, 190);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(25, 38);
            this.lblI.TabIndex = 13;
            this.lblI.Text = "I";
            this.lblI.Click += new System.EventHandler(this.lblI_Click);
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ.Location = new System.Drawing.Point(428, 190);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(34, 38);
            this.lblJ.TabIndex = 14;
            this.lblJ.Text = "J";
            this.lblJ.Click += new System.EventHandler(this.lblJ_Click);
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK.Location = new System.Drawing.Point(464, 190);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(39, 38);
            this.lblK.TabIndex = 15;
            this.lblK.Text = "K";
            this.lblK.Click += new System.EventHandler(this.lblK_Click);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(499, 228);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(43, 38);
            this.lblQ.TabIndex = 21;
            this.lblQ.Text = "Q";
            this.lblQ.Click += new System.EventHandler(this.lblQ_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(461, 229);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(39, 38);
            this.lblP.TabIndex = 20;
            this.lblP.Text = "P";
            this.lblP.Click += new System.EventHandler(this.lblP_Click);
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(419, 228);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(43, 38);
            this.lblO.TabIndex = 19;
            this.lblO.Text = "O";
            this.lblO.Click += new System.EventHandler(this.lblO_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(376, 228);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(41, 38);
            this.lblN.TabIndex = 18;
            this.lblN.Text = "N";
            this.lblN.Click += new System.EventHandler(this.lblN_Click);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(333, 228);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(44, 38);
            this.lblM.TabIndex = 17;
            this.lblM.Text = "M";
            this.lblM.Click += new System.EventHandler(this.lblM_Click);
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL.Location = new System.Drawing.Point(293, 228);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(35, 38);
            this.lblL.TabIndex = 16;
            this.lblL.Text = "L";
            this.lblL.Click += new System.EventHandler(this.lblL_Click);
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(484, 267);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(39, 38);
            this.lblV.TabIndex = 26;
            this.lblV.Text = "V";
            this.lblV.Click += new System.EventHandler(this.lblV_Click);
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU.Location = new System.Drawing.Point(441, 267);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(41, 38);
            this.lblU.TabIndex = 25;
            this.lblU.Text = "U";
            this.lblU.Click += new System.EventHandler(this.lblU_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(397, 267);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(37, 38);
            this.lblT.TabIndex = 24;
            this.lblT.Text = "T";
            this.lblT.Click += new System.EventHandler(this.lblT_Click);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(355, 267);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(39, 38);
            this.lblS.TabIndex = 23;
            this.lblS.Text = "S";
            this.lblS.Click += new System.EventHandler(this.lblS_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(312, 267);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(41, 38);
            this.lblR.TabIndex = 22;
            this.lblR.Text = "R";
            this.lblR.Click += new System.EventHandler(this.lblR_Click);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(453, 306);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(37, 38);
            this.lblZ.TabIndex = 30;
            this.lblZ.Text = "Z";
            this.lblZ.Click += new System.EventHandler(this.lblZ_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(413, 306);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(39, 38);
            this.lblY.TabIndex = 29;
            this.lblY.Text = "Y";
            this.lblY.Click += new System.EventHandler(this.lblY_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(379, 306);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(39, 38);
            this.lblX.TabIndex = 28;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(335, 306);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(48, 38);
            this.lblW.TabIndex = 27;
            this.lblW.Text = "W";
            this.lblW.Click += new System.EventHandler(this.lblW_Click);
            // 
            // lstGuessed
            // 
            this.lstGuessed.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuessed.FormattingEnabled = true;
            this.lstGuessed.ItemHeight = 35;
            this.lstGuessed.Location = new System.Drawing.Point(577, 126);
            this.lstGuessed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstGuessed.Name = "lstGuessed";
            this.lstGuessed.Size = new System.Drawing.Size(243, 249);
            this.lstGuessed.TabIndex = 31;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(309, 370);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(227, 57);
            this.btnPlayAgain.TabIndex = 33;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click_1);
            // 
            // imgHangman5
            // 
            this.imgHangman5.Image = global::Part_8___Hangman.Properties.Resources._3_5;
            this.imgHangman5.Location = new System.Drawing.Point(12, 126);
            this.imgHangman5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgHangman5.Name = "imgHangman5";
            this.imgHangman5.Size = new System.Drawing.Size(243, 274);
            this.imgHangman5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangman5.TabIndex = 37;
            this.imgHangman5.TabStop = false;
            // 
            // imgHangman4
            // 
            this.imgHangman4.Image = global::Part_8___Hangman.Properties.Resources._4;
            this.imgHangman4.Location = new System.Drawing.Point(12, 126);
            this.imgHangman4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgHangman4.Name = "imgHangman4";
            this.imgHangman4.Size = new System.Drawing.Size(243, 274);
            this.imgHangman4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangman4.TabIndex = 36;
            this.imgHangman4.TabStop = false;
            // 
            // imgHangman3
            // 
            this.imgHangman3.Image = global::Part_8___Hangman.Properties.Resources._3;
            this.imgHangman3.Location = new System.Drawing.Point(12, 126);
            this.imgHangman3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgHangman3.Name = "imgHangman3";
            this.imgHangman3.Size = new System.Drawing.Size(243, 274);
            this.imgHangman3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangman3.TabIndex = 35;
            this.imgHangman3.TabStop = false;
            // 
            // imgHangman2
            // 
            this.imgHangman2.Image = global::Part_8___Hangman.Properties.Resources._2;
            this.imgHangman2.Location = new System.Drawing.Point(12, 126);
            this.imgHangman2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgHangman2.Name = "imgHangman2";
            this.imgHangman2.Size = new System.Drawing.Size(243, 274);
            this.imgHangman2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangman2.TabIndex = 34;
            this.imgHangman2.TabStop = false;
            // 
            // imgHangman1
            // 
            this.imgHangman1.Image = global::Part_8___Hangman.Properties.Resources._1;
            this.imgHangman1.Location = new System.Drawing.Point(12, 126);
            this.imgHangman1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgHangman1.Name = "imgHangman1";
            this.imgHangman1.Size = new System.Drawing.Size(243, 274);
            this.imgHangman1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangman1.TabIndex = 0;
            this.imgHangman1.TabStop = false;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(12, 485);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 32);
            this.btnDone.TabIndex = 38;
            this.btnDone.Text = "Close";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click_1);
            // 
            // frmHangMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(832, 528);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.imgHangman5);
            this.Controls.Add(this.imgHangman4);
            this.Controls.Add(this.imgHangman3);
            this.Controls.Add(this.imgHangman2);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lstGuessed);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblJ);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgHangman1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHangMan";
            this.Text = "Hang Man";
            this.Load += new System.EventHandler(this.frmHangMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangman1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHangman1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.ListBox lstGuessed;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.PictureBox imgHangman2;
        private System.Windows.Forms.PictureBox imgHangman3;
        private System.Windows.Forms.PictureBox imgHangman4;
        private System.Windows.Forms.PictureBox imgHangman5;
        private System.Windows.Forms.Button btnDone;
    }
}
