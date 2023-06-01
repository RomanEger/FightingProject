namespace WindowsFormsApp2
{
    partial class FormChoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoice));
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.radioButtonAssasin = new System.Windows.Forms.RadioButton();
            this.radioButtonTank = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioButtonVampyre = new System.Windows.Forms.RadioButton();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDefault.ForeColor = System.Drawing.Color.Red;
            this.radioButtonDefault.Location = new System.Drawing.Point(11, 12);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(62, 20);
            this.radioButtonDefault.TabIndex = 0;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Боец";
            this.radioButtonDefault.UseVisualStyleBackColor = false;
            // 
            // radioButtonAssasin
            // 
            this.radioButtonAssasin.AutoSize = true;
            this.radioButtonAssasin.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAssasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAssasin.ForeColor = System.Drawing.Color.Red;
            this.radioButtonAssasin.Location = new System.Drawing.Point(11, 38);
            this.radioButtonAssasin.Name = "radioButtonAssasin";
            this.radioButtonAssasin.Size = new System.Drawing.Size(86, 20);
            this.radioButtonAssasin.TabIndex = 1;
            this.radioButtonAssasin.TabStop = true;
            this.radioButtonAssasin.Text = "Ассасин";
            this.radioButtonAssasin.UseVisualStyleBackColor = false;
            // 
            // radioButtonTank
            // 
            this.radioButtonTank.AutoSize = true;
            this.radioButtonTank.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTank.ForeColor = System.Drawing.Color.Red;
            this.radioButtonTank.Location = new System.Drawing.Point(11, 64);
            this.radioButtonTank.Name = "radioButtonTank";
            this.radioButtonTank.Size = new System.Drawing.Size(61, 20);
            this.radioButtonTank.TabIndex = 2;
            this.radioButtonTank.TabStop = true;
            this.radioButtonTank.Text = "Танк";
            this.radioButtonTank.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.Color.Red;
            this.btnNext.Location = new System.Drawing.Point(269, 211);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 28);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Вперед";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonVampyre
            // 
            this.radioButtonVampyre.AutoSize = true;
            this.radioButtonVampyre.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonVampyre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVampyre.ForeColor = System.Drawing.Color.Red;
            this.radioButtonVampyre.Location = new System.Drawing.Point(11, 90);
            this.radioButtonVampyre.Name = "radioButtonVampyre";
            this.radioButtonVampyre.Size = new System.Drawing.Size(81, 20);
            this.radioButtonVampyre.TabIndex = 4;
            this.radioButtonVampyre.TabStop = true;
            this.radioButtonVampyre.Text = "Вампир";
            this.radioButtonVampyre.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Black;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfo.ForeColor = System.Drawing.Color.Red;
            this.btnInfo.Location = new System.Drawing.Point(13, 211);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 28);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Инфо";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FormChoice
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 251);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.radioButtonVampyre);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.radioButtonTank);
            this.Controls.Add(this.radioButtonAssasin);
            this.Controls.Add(this.radioButtonDefault);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChoice";
            this.Text = "FormChoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChoice_FormClosing);
            this.Load += new System.EventHandler(this.FormChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.RadioButton radioButtonAssasin;
        private System.Windows.Forms.RadioButton radioButtonTank;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radioButtonVampyre;
        private System.Windows.Forms.Button btnInfo;
    }
}