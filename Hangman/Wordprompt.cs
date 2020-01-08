using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Wordprompt : Form
    {
        public Wordprompt()
        {
            InitializeComponent();
        }

        private void Wordprompt_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Wordprompt form2 = new Wordprompt();
            form2.Close();

            Hangman form = new Hangman();
            form.Show();
            
        }
    }
}
