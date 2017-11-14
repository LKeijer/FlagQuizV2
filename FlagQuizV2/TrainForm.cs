using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagQuizV2
{
    
    public partial class TrainForm : Form
    {

        public TrainForm(int var1)
        {
            int c = var1;

            InitializeComponent();
            switch (c)
            {
                case 0:
                    pictureBox1.Image = null;
                break;
                case 1:
                    pictureBox1.Image = null;
                break;
                case 2:
                    pictureBox1.Image = null;
                break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Europe;
                break;
                case 4:
                    pictureBox1.Image = null;
                break;
                    
            }
        }

        private void TrainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
