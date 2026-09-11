using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmessageBoxForm : Form
    {
        public frmessageBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is message box");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is message box","the main title ");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "Confirm ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Pressed Suscceful ");

            }
            else
            {
                MessageBox.Show("Failed Press  ");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure", "Confirm ", MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MessageBox.Show("Pressed Suscceful ");

            }
            else
            {
                MessageBox.Show("Failed Press  ");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure", "Confirm ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Pressed Suscceful ");

            }
            else
            {
                MessageBox.Show("Failed Press  ");

            }
        }
    }
}
