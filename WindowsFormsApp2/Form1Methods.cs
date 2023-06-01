using System;
using System.Collections.Generic;
using System.Configuration;
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
        int firstStep;

        private static string classFighter;

        public string ClassFighter
        {
            get { return classFighter; }
        }

        private int nado = 0;

        private int lastPlayerHit = 0;
        public int LastPlayerHit
        {
            get { return lastPlayerHit; }
            set {
                if(value > 0 && value < 4)
                lastPlayerHit = value; }
        }
        
        private string playerLogs = string.Empty;

        private static int winner;
        public int Winner
        {
            get { return winner; }
        }

        OleDbConnection myConnection;

        private string nickName;

        Random rand = new Random();
        FormStart formStart = new FormStart();

        FormChoice formChoice = new FormChoice();
        Player player;
        Enemy enemy = new Enemy();

        private double step = 1;
        private int playerDamage;
        private int enemyDamage;

        private int enemyBlock;

        private int hitBtn;
        public int HitBtn
        {
            get { return hitBtn; }
        }

        private int blockBtn;
        public int BlockBtn
        {
            get { return blockBtn; }
        }

        private int enemyHit;
        public int GetEnemyHit
        {
            get { return enemyHit; }
        }

        


        /// <summary>
        /// Убирает рамки кнопки
        /// </summary>
        /// <param button="button"></param>
        //public void RemoveButtonBorders(Button button)
        //{
        //    button.FlatAppearance.BorderSize = 0;
        //    button.FlatStyle = FlatStyle.Flat;
        //}


        /// <summary>
        /// Игрок наносит удар
        /// </summary>
        /// <param name="Кнопка удара"></param>
        public void PlayerHit(Button hitButton)
        {
            if (step % 1 == 0 && (firstStep == 0 || step > 1))
            {
                if (hitButton.Name == "btnHitHead" && lastPlayerHit != 1)
                {
                    hitBtn = 1;
                    lastPlayerHit = 1;
                    step += 0.5;
                    nado = 0;
                }
                else if (hitButton.Name == "btnHitBody" && lastPlayerHit != 2)
                {
                    lastPlayerHit = 2;
                    hitBtn = 2;
                    step += 0.5;
                    nado = 0;
                }
                else if (hitButton.Name == "btnHitLeg" && lastPlayerHit != 3)
                {
                    hitBtn = 3;
                    lastPlayerHit = 3;
                    step += 0.5;
                    nado = 0;
                }
                else
                {
                    MessageBox.Show("Нельзя нанести урон в одну и ту же точку 2 раза подряд");
                    nado = 1;
                }
                if(nado == 0)
                {
                    playerDamage = player.DoDamage(hitButton);
                
                    EnemyBlocking();
                    playerDamage -= (int)Math.Ceiling(playerDamage / 100.0 * enemy.block);

                    player.Hill = playerDamage;

                    GenerateLogs(hitButton, playerDamage);

                }
            }
            else if(firstStep == 1)
            {
                MessageBox.Show("Первым ходит босс, выберите блок!");
            }
            else
            {
                MessageBox.Show("Вы уже выбрали удар, теперь выберите блок!");
            }
        }


        /// <summary>
        /// Бот наносит удар
        /// </summary>
        public void EnemyHit()
        {
            enemyDamage = enemy.DoDamage(out enemyHit);
            enemyDamage -= (int)Math.Ceiling(enemyDamage / 100.0 * player.MakeBlock(enemyHit, blockBtn));
            if(firstStep == 0 || step > 1)
                PrintLogs(enemyDamage);
            if (enemyDamage <= progressBar1.Value)
            {
                progressBar1.Value -= enemyDamage;
                if (progressBar1.Value == 0)
                    EnemyWin();
            }
            else if(winner != 1)
                EnemyWin();
        }

        /// <summary>
        /// Убирает рамки основных кнопок удара и блока, заменяет цвет текста на красный
        /// </summary>
        private void BtnWithoutBorder()
        {
            btnHitHead.FlatAppearance.BorderSize = 1;
            btnHitHead.FlatAppearance.BorderColor = Color.Red;
            btnHitHead.FlatStyle = FlatStyle.Flat;

            btnHitBody.FlatAppearance.BorderSize = 1;
            btnHitBody.FlatAppearance.BorderColor = Color.Red;
            btnHitBody.FlatStyle = FlatStyle.Flat;

            btnHitLeg.FlatAppearance.BorderSize = 1;
            btnHitLeg.FlatAppearance.BorderColor = Color.Red;
            btnHitLeg.FlatStyle = FlatStyle.Flat;

            btnBlockHead.FlatAppearance.BorderSize = 1;
            btnBlockHead.FlatAppearance.BorderColor = Color.Red;
            btnBlockHead.FlatStyle = FlatStyle.Flat;

            btnBlockBody.FlatAppearance.BorderSize = 1;
            btnBlockBody.FlatAppearance.BorderColor = Color.Red;
            btnBlockBody.FlatStyle = FlatStyle.Flat;

            btnBlockLeg.FlatAppearance.BorderSize = 1;
            btnBlockLeg.FlatAppearance.BorderColor = Color.Red;
            btnBlockLeg.FlatStyle = FlatStyle.Flat;
        }


        /// <summary>
        /// Игрок выбирает блок, обрабатывается условие победы
        /// </summary>
        /// <param name="Кнопка блока"></param>
        public void PlayerBlocking(Button blockButton)
        {
            if (blockButton.Name == "btnBlockHead")
                blockBtn = 1;
            else if (blockButton.Name == "btnBlockBody")
                blockBtn = 2;
            else
                blockBtn = 3;
            if (firstStep == 0 || step > 1)
                step += 0.5;
            else
                step++;
            if (playerDamage <= progressBar2.Value)
            {
                progressBar2.Value -= playerDamage;
                if (progressBar2.Value == 0)
                    PlayerWin();
            }
            else if (winner != 2)
                PlayerWin();
        }


        /// <summary>
        /// Бот выбирает блок, вызывает MakeBlock(,)
        /// </summary>
        public void EnemyBlocking()
        {
            enemyBlock = rand.Next(1, 4);
            enemy.block = enemy.MakeBlock(hitBtn, enemyBlock);
        }


        /// <summary>
        /// Срабатывает в случае победы игрока
        /// </summary>
        public void PlayerWin()
        {
            winner = 1;

            progressBar2.Value = 0;

            DialogResult dialogResult = MessageBox.Show("Вы победили!\nХотите посмотреть таблицу лучших результатов?", "Игра окончена!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormResults formResults = new FormResults((int)step, nickName);
                formResults.Show();
                this.Close();
            }
            else
            {
                myConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                myConnection.Open();

                string queryInsert = $"INSERT INTO NewTestTable (r_step, r_name, r_classFighter) VALUES ({step}, '{nickName}', '{classFighter}')";
                OleDbCommand commandInsert = new OleDbCommand(queryInsert, myConnection);
                commandInsert.ExecuteNonQuery();

                DialogResult dialogResultX = MessageBox.Show("Хотите сыграть еще раз?", "Рестарт", MessageBoxButtons.YesNo);
                if (dialogResultX == DialogResult.Yes)
                {
                    this.Close();
                    FormChoice formChoice = new FormChoice();
                    //progressBar1.Value = 100;
                    //progressBar2.Value = 100;
                    //step = 1;
                    formChoice.Show();
                }
                else
                    Environment.Exit(0);
                
            }

        }


        /// <summary>
        /// Срабатывает в случае победы бота
        /// </summary>
        public void EnemyWin()
        {
            winner = 2;

            progressBar1.Value = 0;
            DialogResult dialogResult = MessageBox.Show("Вы проиграли!\nХотите посмотреть таблицу лучших результатов?", "Игра окончена!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormResults formResults = new FormResults((int)step, nickName);
                formResults.Show();
                this.Close();
            }
            else
            {
                DialogResult dialogResultX = MessageBox.Show("Хотите сыграть еще раз?", "Рестарт", MessageBoxButtons.YesNo);
                if (dialogResultX == DialogResult.Yes)
                {
                    this.Close();
                    FormStart formStart = new FormStart();
                    formStart.Show();
                }
                else
                    Environment.Exit(0);
                //progressBar1.Value = 100;
                //progressBar2.Value = 100;
                //step = 1;
            }

        }


        /// <summary>
        /// Обработка нажатия на кнопку блока
        /// </summary>
        /// <param name="Кнопка блока"></param>
        public void btnBlockPressed(Button buttonBlock)
        {
            if (step % 1 != 0 || firstStep == 1)
            {
                PlayerBlocking(buttonBlock);

                if (step > 1)
                    EnemyHit();
                if(player.Choice == 4)
                {
                    if (player.Hill < progressBar1.Maximum - progressBar1.Value)
                        progressBar1.Value += player.Hill;
                    else
                        progressBar1.Value = player.HP;
                }

            }
            else
                MessageBox.Show("Сначала выберите удар!");
        }


        /// <summary>
        /// Создает логи боя (данные о игроке)
        /// </summary>
        /// <param name="Кнопка удара"></param>
        /// <param name="Нанесенный урон"></param>
        public void GenerateLogs(Button button, int dmg) 
        {
            if(button.Name == "btnHitHead" || button.Name == "btnHitBody" || button.Name == "btnHitLeg")
            {
                string onHit = string.Empty;
                string onBlock = string.Empty;
                if (button.Name == "btnHitHead")
                    onHit = "голове";
                else if (button.Name == "btnHitBody")
                    onHit = "телу";
                else if (button.Name == "btnHitLeg")
                    onHit = "ногам";
                if(enemyBlock == 1)
                    onBlock = "голове";
                else if (enemyBlock == 2)
                    onBlock = "телу";
                else if(enemyBlock == 3)
                    onBlock = "ногам";

                playerLogs = $"Шаг {textBoxStep.Text}:\t{nickName} нанес удар по {onHit}, Босс заблокировал удар по {onBlock}. Нанесенный урон = {dmg}";

            }
        }


        /// <summary>
        /// Выводит логи боя в listBox
        /// </summary>
        /// <param name="Нанесенный урон"></param>
        public void PrintLogs(int dmg)
        {
            string onHit = string.Empty;
            string onBlock = string.Empty;

            if (enemyHit == 1)
                onHit = "голове";
            else if (enemyHit == 2)
                onHit = "телу";
            else if (enemyHit == 3)
                onHit = "ногам";
            if (blockBtn == 1)
                onBlock = "голове";
            else if (blockBtn == 2)
                onBlock = "телу";
            else if (blockBtn == 3)
                onBlock = "ногам";

            listBoxLogs.Items.Insert(0, playerLogs);
            listBoxLogs.Items.Insert(0, $"Шаг {textBoxStep.Text}:\tБосс нанес удар по {onHit}, {nickName} заблокировал удар по {onBlock}. Нанесенный урон = {dmg}");
            listBoxLogs.Items.Insert(0, "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
