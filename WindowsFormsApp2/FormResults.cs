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
    public partial class FormResults : Form
    {
        private int step;
        private string nickName;
        Form1 form1 = new Form1();
        public FormResults(int step, string nickName)
        {
            InitializeComponent();
            this.step = step;
            this.nickName = nickName;
        }

        private OleDbConnection myConnection;


        /// <summary>
        /// При загрузке формы выполняются запросы на вставку в бд результатов и выборку, сортируя по минимальному кол-ву ходов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormResults_Load(object sender, EventArgs e)
        {
            btnPlayAgain.FlatAppearance.BorderSize = 1;
            btnPlayAgain.FlatAppearance.BorderColor = Color.Red;
            btnPlayAgain.BackColor = Color.Black;
            btnPlayAgain.FlatStyle = FlatStyle.Flat;

            myConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            myConnection.Open();
            if (form1.Winner == 1)
            {
                string queryInsert = $"INSERT INTO NewTestTable (r_step, r_name, r_classFighter) VALUES ({step}, '{nickName}', '{form1.ClassFighter}')";
                OleDbCommand commandInsert = new OleDbCommand(queryInsert, myConnection);
                commandInsert.ExecuteNonQuery();
            }
            string querySelect = $"SELECT * FROM NewTestTable ORDER BY r_step";

            OleDbCommand command = new OleDbCommand(querySelect, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();

            listBox1.Items.Add("Кол-во ходов\tИгровой ник\tКласс бойца");
            while(reader.Read()) 
                listBox1.Items.Add($"\t{reader[1]}\t{reader[2]}\t\t{reader[3]}");

            reader.Close();

        }

        private void FormResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            DialogResult dialogResult = MessageBox.Show("Хотите сыграть еще раз?", "Рестарт", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                FormStart formStart = new FormStart();
                formStart.Show();
            }
            else
                Environment.Exit(0);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
