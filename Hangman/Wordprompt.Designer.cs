namespace Hangman
{
    partial class Wordprompt
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
            this.tbWoord = new System.Windows.Forms.TextBox();
            this.lblWoord = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWoord
            // 
            this.tbWoord.Location = new System.Drawing.Point(95, 80);
            this.tbWoord.Name = "tbWoord";
            this.tbWoord.Size = new System.Drawing.Size(178, 20);
            this.tbWoord.TabIndex = 0;
            // 
            // lblWoord
            // 
            this.lblWoord.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoord.Location = new System.Drawing.Point(32, 9);
            this.lblWoord.Name = "lblWoord";
            this.lblWoord.Size = new System.Drawing.Size(306, 68);
            this.lblWoord.TabIndex = 1;
            this.lblWoord.Text = "Typ een woord in:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(95, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 38);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Wordprompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 169);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWoord);
            this.Controls.Add(this.tbWoord);
            this.Name = "Wordprompt";
            this.Load += new System.EventHandler(this.Wordprompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWoord;
        private System.Windows.Forms.Label lblWoord;
        private System.Windows.Forms.Button btnStart;
    }
}

