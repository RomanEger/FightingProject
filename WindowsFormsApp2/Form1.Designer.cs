namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHitHead = new System.Windows.Forms.Button();
            this.textBoxHit = new System.Windows.Forms.TextBox();
            this.btnHitBody = new System.Windows.Forms.Button();
            this.btnHitLeg = new System.Windows.Forms.Button();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.btnBlockLeg = new System.Windows.Forms.Button();
            this.btnBlockBody = new System.Windows.Forms.Button();
            this.btnBlockHead = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHitHead
            // 
            this.btnHitHead.BackColor = System.Drawing.Color.Black;
            this.btnHitHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHitHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHitHead.ForeColor = System.Drawing.Color.Red;
            this.btnHitHead.Location = new System.Drawing.Point(272, 239);
            this.btnHitHead.Name = "btnHitHead";
            this.btnHitHead.Size = new System.Drawing.Size(88, 23);
            this.btnHitHead.TabIndex = 0;
            this.btnHitHead.Text = "Голова";
            this.btnHitHead.UseVisualStyleBackColor = false;
            this.btnHitHead.Click += new System.EventHandler(this.btnHitHead_Click);
            // 
            // textBoxHit
            // 
            this.textBoxHit.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxHit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHit.ForeColor = System.Drawing.Color.Red;
            this.textBoxHit.Location = new System.Drawing.Point(272, 204);
            this.textBoxHit.Name = "textBoxHit";
            this.textBoxHit.ReadOnly = true;
            this.textBoxHit.Size = new System.Drawing.Size(88, 22);
            this.textBoxHit.TabIndex = 1;
            this.textBoxHit.Text = "Удар";
            this.textBoxHit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHitBody
            // 
            this.btnHitBody.BackColor = System.Drawing.Color.Black;
            this.btnHitBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHitBody.ForeColor = System.Drawing.Color.Red;
            this.btnHitBody.Location = new System.Drawing.Point(272, 268);
            this.btnHitBody.Name = "btnHitBody";
            this.btnHitBody.Size = new System.Drawing.Size(88, 23);
            this.btnHitBody.TabIndex = 2;
            this.btnHitBody.Text = "Тело";
            this.btnHitBody.UseVisualStyleBackColor = false;
            this.btnHitBody.Click += new System.EventHandler(this.btnHitBody_Click);
            // 
            // btnHitLeg
            // 
            this.btnHitLeg.BackColor = System.Drawing.Color.Black;
            this.btnHitLeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHitLeg.ForeColor = System.Drawing.Color.Red;
            this.btnHitLeg.Location = new System.Drawing.Point(272, 297);
            this.btnHitLeg.Name = "btnHitLeg";
            this.btnHitLeg.Size = new System.Drawing.Size(88, 23);
            this.btnHitLeg.TabIndex = 3;
            this.btnHitLeg.Text = "Ноги";
            this.btnHitLeg.UseVisualStyleBackColor = false;
            this.btnHitLeg.Click += new System.EventHandler(this.btnHitLeg_Click);
            // 
            // textBoxBlock
            // 
            this.textBoxBlock.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBlock.ForeColor = System.Drawing.Color.Red;
            this.textBoxBlock.Location = new System.Drawing.Point(417, 204);
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.ReadOnly = true;
            this.textBoxBlock.Size = new System.Drawing.Size(88, 22);
            this.textBoxBlock.TabIndex = 4;
            this.textBoxBlock.Text = "Блок";
            this.textBoxBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBlockLeg
            // 
            this.btnBlockLeg.BackColor = System.Drawing.Color.Black;
            this.btnBlockLeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockLeg.ForeColor = System.Drawing.Color.Red;
            this.btnBlockLeg.Location = new System.Drawing.Point(417, 297);
            this.btnBlockLeg.Name = "btnBlockLeg";
            this.btnBlockLeg.Size = new System.Drawing.Size(88, 23);
            this.btnBlockLeg.TabIndex = 7;
            this.btnBlockLeg.Text = "Ноги";
            this.btnBlockLeg.UseVisualStyleBackColor = false;
            this.btnBlockLeg.Click += new System.EventHandler(this.btnBlockLeg_Click);
            // 
            // btnBlockBody
            // 
            this.btnBlockBody.BackColor = System.Drawing.Color.Black;
            this.btnBlockBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBlockBody.ForeColor = System.Drawing.Color.Red;
            this.btnBlockBody.Location = new System.Drawing.Point(417, 268);
            this.btnBlockBody.Name = "btnBlockBody";
            this.btnBlockBody.Size = new System.Drawing.Size(88, 23);
            this.btnBlockBody.TabIndex = 6;
            this.btnBlockBody.Text = "Тело";
            this.btnBlockBody.UseVisualStyleBackColor = false;
            this.btnBlockBody.Click += new System.EventHandler(this.btnBlockBody_Click);
            // 
            // btnBlockHead
            // 
            this.btnBlockHead.BackColor = System.Drawing.Color.Black;
            this.btnBlockHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBlockHead.ForeColor = System.Drawing.Color.Red;
            this.btnBlockHead.Location = new System.Drawing.Point(417, 239);
            this.btnBlockHead.Name = "btnBlockHead";
            this.btnBlockHead.Size = new System.Drawing.Size(88, 23);
            this.btnBlockHead.TabIndex = 5;
            this.btnBlockHead.Text = "Голова";
            this.btnBlockHead.UseVisualStyleBackColor = false;
            this.btnBlockHead.Click += new System.EventHandler(this.btnBlockHead_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(538, 12);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(233, 23);
            this.progressBar2.TabIndex = 9;
            this.progressBar2.Value = 100;
            // 
            // textBoxStep
            // 
            this.textBoxStep.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStep.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxStep.Location = new System.Drawing.Point(337, 12);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.ReadOnly = true;
            this.textBoxStep.Size = new System.Drawing.Size(110, 20);
            this.textBoxStep.TabIndex = 10;
            this.textBoxStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(535, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBoxLogs.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.HorizontalScrollbar = true;
            this.listBoxLogs.Location = new System.Drawing.Point(24, 356);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(747, 95);
            this.listBoxLogs.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(538, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 201);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnBlockLeg);
            this.Controls.Add(this.btnBlockBody);
            this.Controls.Add(this.btnBlockHead);
            this.Controls.Add(this.textBoxBlock);
            this.Controls.Add(this.btnHitLeg);
            this.Controls.Add(this.btnHitBody);
            this.Controls.Add(this.textBoxHit);
            this.Controls.Add(this.btnHitHead);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperPuperMegaUltra Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHitHead;
        private System.Windows.Forms.TextBox textBoxHit;
        private System.Windows.Forms.Button btnHitBody;
        private System.Windows.Forms.Button btnHitLeg;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.Button btnBlockLeg;
        private System.Windows.Forms.Button btnBlockBody;
        private System.Windows.Forms.Button btnBlockHead;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

