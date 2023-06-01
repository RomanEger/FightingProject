using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormChoice : Form
    {
        int cl = 0;
        private static int choice;
        public int Choice
        {
            get { return choice; }
        }

        public FormChoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonAssasin.Checked)
                choice = 2;
            else if (radioButtonTank.Checked)
                choice = 3;
            else if(radioButtonVampyre.Checked)
                choice = 4;
            else
                choice = 1;
            Form1 form1 = new Form1();
            form1.Show();
            cl = 1;
            this.Close();
        }

        private void FormChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cl == 0)
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите закрыть игру?", "Закрыть игру", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                    Environment.Exit(0);
                else
                    e.Cancel = true;
            }
        }

        private void FormChoice_Load(object sender, EventArgs e)
        {
            btnInfo.FlatAppearance.BorderSize = 1;
            btnInfo.FlatAppearance.BorderColor = Color.Red;
            btnInfo.FlatStyle = FlatStyle.Flat;

            btnNext.FlatAppearance.BorderSize = 1;
            btnNext.FlatAppearance.BorderColor = Color.Red;
            btnNext.FlatStyle = FlatStyle.Flat;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }
    }
}
