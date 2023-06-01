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
    public partial class FormStart : Form
    {
        private static string nickName;

        public string NickName
        {   get { return nickName; } 
            set { 
                if(value.Length > 2)
                    nickName = value;
                }
        }


        public FormStart()
        {
            InitializeComponent();
            textBox1.Text = nickName;
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            btnStart.FlatAppearance.BorderSize = 1;
            btnStart.FlatAppearance.BorderColor = Color.Red;
            btnStart.FlatStyle = FlatStyle.Flat;

            btnExit.FlatAppearance.BorderSize = 1;
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            NickName = textBox1.Text;
            if (NickName != null)
            {
                MessageBox.Show("Сначала выбирается удар, после чего блок.\n" +
                    "При достижении 0 хп у Вас или противника, вы получите соответсвующее сообщение.\n" +
                    "В случае победы, данные о бое (Ваш игровой ник и количество ходов) будут записаны в рекорды. Посмотреть рекорды можно после боя.", 
                    "Правила игры");

                FormChoice formChoice = new FormChoice();
                formChoice.Show();
                //Form1 form1 = new Form1();
                //form1.Show();
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти из игры?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length < 3)
                errorProvider1.SetError(textBox1, "Никнейм должен содержать не менее 3 символов!");
            else
                errorProvider1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnStart_Click(this, new EventArgs());
            }
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResultX = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResultX == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
                e.Cancel = true;
        }
    }
}
