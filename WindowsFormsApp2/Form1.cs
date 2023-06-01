using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form 
    {
        
        public Form1()
        {
            InitializeComponent();
            
            timer1 = new Timer();
            timer1.Start();
            timer1.Tick += timer1_Tick;

            nickName = formStart.NickName;

            
            player = new Player(formChoice.Choice);
            progressBar1.Maximum = player.HP;
            progressBar1.Value = player.HP;

            if (formChoice.Choice == 1)
                classFighter = "Боец";
            else if (formChoice.Choice == 2)
                classFighter = "Ассасин";
            else if (formChoice.Choice == 3)
                classFighter = "Танк";
            else
                classFighter = "Вампир";

            BtnWithoutBorder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstStep = rand.Next(0, 2);

            winner = 0;
            myConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            myConnection.Open();
            listBoxLogs.Items.Clear();
            
            if (firstStep == 1)
            {
                MessageBox.Show("Первым ходит босс");
            }
            else
                MessageBox.Show("Первым ходите Вы");
        }

        private void btnHitHead_Click(object sender, EventArgs e)
        {
            PlayerHit(btnHitHead);
        }

        private void btnHitBody_Click(object sender, EventArgs e)
        {
            PlayerHit(btnHitBody);
        }

        private void btnHitLeg_Click(object sender, EventArgs e)
        {
            PlayerHit(btnHitLeg);
        }

        private void btnBlockHead_Click(object sender, EventArgs e)
        {
            btnBlockPressed(btnBlockHead);
        }

        private void btnBlockBody_Click(object sender, EventArgs e)
        {
            btnBlockPressed(btnBlockBody);
        }

        private void btnBlockLeg_Click(object sender, EventArgs e)
        {
            btnBlockPressed(btnBlockLeg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step % 1 == 0)
            {
                textBoxStep.Text = $"{step}";
                if(progressBar1.Value > 70)
                    label1.ForeColor = Color.Lime;
                else if (progressBar1.Value >= 50 && progressBar1.Value <= 70)
                    label1.ForeColor = Color.GreenYellow;
                else if(progressBar1.Value > 30 && progressBar1.Value < 50)
                    label1.ForeColor = Color.Orange;
                else
                    label1.ForeColor = Color.Red;

                if (progressBar2.Value > 70)
                    label2.ForeColor = Color.Lime;
                else if (progressBar2.Value >= 50 && progressBar2.Value <= 70)
                    label2.ForeColor = Color.GreenYellow;
                else if (progressBar2.Value > 30 && progressBar2.Value < 50)
                    label2.ForeColor = Color.Orange;
                else
                    label2.ForeColor = Color.Red;

                label1.Text = progressBar1.Value.ToString();
                label2.Text = progressBar2.Value.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(winner == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из игры?\nЭто действие завершит работу программмы.", "Выход из игры", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    timer1.Stop();
                    myConnection.Close();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
