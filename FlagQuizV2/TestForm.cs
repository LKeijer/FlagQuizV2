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
    public partial class TestForm : Form
    {
        Image[] picArray;
        int score;
        public TestForm(int var1)
        {
            InitializeComponent();
            picArray = new Image[5];
            picArray[0] = Properties.Resources.Denmark;
            picArray[1] = Properties.Resources.Finland;
            picArray[2] = Properties.Resources.Iceland;
            picArray[3] = Properties.Resources.Norway;
            picArray[4] = Properties.Resources.Sweden;
            pictureBox1.Image = picArray[0];
            
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == picArray[0] && denmarkBtn.Checked == true) //check of de juiste optie gekozen is
            {
                MessageBox.Show("Correct!");
                pictureBox1.Image = picArray[1];
                denmarkBtn.Checked = false;
                score = 1;
            }
            else if (pictureBox1.Image == picArray[1] && finlandBtn.Checked == true)
            {
                MessageBox.Show("Correct!" + score);
                pictureBox1.Image = picArray[2];
                score += 1;

            }
            else if (pictureBox1.Image == picArray[2] && icelandBtn.Checked == true)
            {
                MessageBox.Show("Correct!");
                pictureBox1.Image = picArray[3];
            }
            else if (pictureBox1.Image == picArray[3] && norwayBtn.Checked == true)
            {
                MessageBox.Show("Correct!");
                pictureBox1.Image = picArray[4];
            }
            else if (pictureBox1.Image == picArray[4] && swedenBtn.Checked == true)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong!");
            }
        }

        private void denmarkBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}