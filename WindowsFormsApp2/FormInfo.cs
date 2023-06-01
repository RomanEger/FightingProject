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
    public partial class FormInfo : Form
    {
        //string generalStats = " Блок поглощает 70-100%, шанс крит. урона: 30%\n";
        //string defaultPerson = "Боец:\t100 ХП, урон в голову: 10-12, урон в тело: 8-10, урон в ноги: 6-8.";
        //string assasin = "Ассасин:\t80 ХП, урон в голову: 12-14, урон в тело: 10-12, урон в ноги: 8-10.";
        //string tank = "Танк:\t110 ХП, урон в голову: 9-10, урон в тело: 7-9, урон в ноги: 6-8";
        //string vampyre = "Вампир:\t85 ХП, урон в голову: 10-12, урон в тело: 8-10, урон в ноги: 6-8. Восстановление здоровья: 10% от нанесенного урона";

        public FormInfo()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
