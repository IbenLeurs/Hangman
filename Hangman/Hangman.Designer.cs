namespace Hangman
{
    partial class Hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.tbWord = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbHangmanErr1 = new System.Windows.Forms.PictureBox();
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.lstGuessed = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangmanErr1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(25, 62);
            this.tbWord.MaxLength = 17;
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(100, 20);
            this.tbWord.TabIndex = 0;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(35, 31);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(78, 28);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Woord";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(81, 88);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // pbHangmanErr1
            // 
            this.pbHangmanErr1.Image = ((System.Drawing.Image)(resources.GetObject("pbHangmanErr1.Image")));
            this.pbHangmanErr1.InitialImage = null;
            this.pbHangmanErr1.Location = new System.Drawing.Point(152, 11);
            this.pbHangmanErr1.Name = "pbHangmanErr1";
            this.pbHangmanErr1.Size = new System.Drawing.Size(100, 102);
            this.pbHangmanErr1.TabIndex = 4;
            this.pbHangmanErr1.TabStop = false;
            this.pbHangmanErr1.Visible = false;
            // 
            // lblWordToGuess
            // 
            this.lblWordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToGuess.Location = new System.Drawing.Point(20, 152);
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(330, 45);
            this.lblWordToGuess.TabIndex = 6;
            // 
            // lstGuessed
            // 
            this.lstGuessed.FormattingEnabled = true;
            this.lstGuessed.Location = new System.Drawing.Point(258, 19);
            this.lstGuessed.Name = "lstGuessed";
            this.lstGuessed.Size = new System.Drawing.Size(92, 95);
            this.lstGuessed.TabIndex = 7;
            this.lstGuessed.Visible = false;
            this.lstGuessed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstGuessed_KeyDown);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 227);
            this.Controls.Add(this.lstGuessed);
            this.Controls.Add(this.lblWordToGuess);
            this.Controls.Add(this.pbHangmanErr1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.tbWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.pbHangmanErr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbHangmanErr1;
        private System.Windows.Forms.Label lblWordToGuess;
        private System.Windows.Forms.ListBox lstGuessed;
    }
}