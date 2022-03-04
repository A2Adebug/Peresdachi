namespace Peresdachi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxEmailReg = new System.Windows.Forms.TextBox();
            this.textBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.textBoxSecondNameReg = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameReg = new System.Windows.Forms.TextBox();
            this.textBoxLastNameReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAcceptReg = new System.Windows.Forms.TextBox();
            this.buttonAcceptReg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPasswordAuth = new System.Windows.Forms.TextBox();
            this.textBoxEmailAuth = new System.Windows.Forms.TextBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 81);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(244, 366);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(220, 61);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEmailReg
            // 
            this.textBoxEmailReg.Location = new System.Drawing.Point(244, 107);
            this.textBoxEmailReg.MaxLength = 50;
            this.textBoxEmailReg.Name = "textBoxEmailReg";
            this.textBoxEmailReg.Size = new System.Drawing.Size(220, 22);
            this.textBoxEmailReg.TabIndex = 2;
            this.textBoxEmailReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmailReg_KeyPress);
            // 
            // textBoxPasswordReg
            // 
            this.textBoxPasswordReg.Location = new System.Drawing.Point(244, 157);
            this.textBoxPasswordReg.MaxLength = 50;
            this.textBoxPasswordReg.Name = "textBoxPasswordReg";
            this.textBoxPasswordReg.Size = new System.Drawing.Size(220, 22);
            this.textBoxPasswordReg.TabIndex = 3;
            this.textBoxPasswordReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPasswordReg_KeyPress);
            // 
            // textBoxSecondNameReg
            // 
            this.textBoxSecondNameReg.Location = new System.Drawing.Point(244, 209);
            this.textBoxSecondNameReg.MaxLength = 50;
            this.textBoxSecondNameReg.Name = "textBoxSecondNameReg";
            this.textBoxSecondNameReg.Size = new System.Drawing.Size(220, 22);
            this.textBoxSecondNameReg.TabIndex = 4;
            this.textBoxSecondNameReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstNameReg_KeyPress);
            // 
            // textBoxFirstNameReg
            // 
            this.textBoxFirstNameReg.Location = new System.Drawing.Point(244, 263);
            this.textBoxFirstNameReg.MaxLength = 50;
            this.textBoxFirstNameReg.Name = "textBoxFirstNameReg";
            this.textBoxFirstNameReg.Size = new System.Drawing.Size(220, 22);
            this.textBoxFirstNameReg.TabIndex = 5;
            this.textBoxFirstNameReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSecondNameReg_KeyPress);
            // 
            // textBoxLastNameReg
            // 
            this.textBoxLastNameReg.Location = new System.Drawing.Point(244, 317);
            this.textBoxLastNameReg.MaxLength = 50;
            this.textBoxLastNameReg.Name = "textBoxLastNameReg";
            this.textBoxLastNameReg.Size = new System.Drawing.Size(220, 22);
            this.textBoxLastNameReg.TabIndex = 6;
            this.textBoxLastNameReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastNameReg_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Электронная почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Отчество";
            // 
            // textBoxAcceptReg
            // 
            this.textBoxAcceptReg.Location = new System.Drawing.Point(481, 265);
            this.textBoxAcceptReg.MaxLength = 4;
            this.textBoxAcceptReg.Name = "textBoxAcceptReg";
            this.textBoxAcceptReg.Size = new System.Drawing.Size(220, 22);
            this.textBoxAcceptReg.TabIndex = 13;
            this.textBoxAcceptReg.Visible = false;
            this.textBoxAcceptReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAcceptReg_KeyPress);
            // 
            // buttonAcceptReg
            // 
            this.buttonAcceptReg.Location = new System.Drawing.Point(481, 298);
            this.buttonAcceptReg.Name = "buttonAcceptReg";
            this.buttonAcceptReg.Size = new System.Drawing.Size(220, 61);
            this.buttonAcceptReg.TabIndex = 14;
            this.buttonAcceptReg.Text = "Подтвердить регистрацию";
            this.buttonAcceptReg.UseVisualStyleBackColor = true;
            this.buttonAcceptReg.Visible = false;
            this.buttonAcceptReg.Click += new System.EventHandler(this.buttonAcceptReg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Электронная почта";
            // 
            // textBoxPasswordAuth
            // 
            this.textBoxPasswordAuth.Location = new System.Drawing.Point(720, 207);
            this.textBoxPasswordAuth.MaxLength = 50;
            this.textBoxPasswordAuth.Name = "textBoxPasswordAuth";
            this.textBoxPasswordAuth.Size = new System.Drawing.Size(220, 22);
            this.textBoxPasswordAuth.TabIndex = 16;
            // 
            // textBoxEmailAuth
            // 
            this.textBoxEmailAuth.Location = new System.Drawing.Point(720, 157);
            this.textBoxEmailAuth.MaxLength = 50;
            this.textBoxEmailAuth.Name = "textBoxEmailAuth";
            this.textBoxEmailAuth.Size = new System.Drawing.Size(220, 22);
            this.textBoxEmailAuth.TabIndex = 15;
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(720, 253);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(220, 61);
            this.buttonAuth.TabIndex = 19;
            this.buttonAuth.Text = "Авторизация";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPasswordAuth);
            this.Controls.Add(this.textBoxEmailAuth);
            this.Controls.Add(this.buttonAcceptReg);
            this.Controls.Add(this.textBoxAcceptReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLastNameReg);
            this.Controls.Add(this.textBoxFirstNameReg);
            this.Controls.Add(this.textBoxSecondNameReg);
            this.Controls.Add(this.textBoxPasswordReg);
            this.Controls.Add(this.textBoxEmailReg);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxEmailReg;
        private System.Windows.Forms.TextBox textBoxPasswordReg;
        private System.Windows.Forms.TextBox textBoxSecondNameReg;
        private System.Windows.Forms.TextBox textBoxFirstNameReg;
        private System.Windows.Forms.TextBox textBoxLastNameReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAcceptReg;
        private System.Windows.Forms.Button buttonAcceptReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPasswordAuth;
        private System.Windows.Forms.TextBox textBoxEmailAuth;
        private System.Windows.Forms.Button buttonAuth;
    }
}

