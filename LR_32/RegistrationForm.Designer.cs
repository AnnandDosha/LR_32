namespace LR_32
{
    partial class RegistrationForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repeatTextBox = new System.Windows.Forms.TextBox();
            this.registryButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.countryLabel = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.informationTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(36, 64);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(36, 102);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль";
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Location = new System.Drawing.Point(36, 139);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(112, 13);
            this.repeatLabel.TabIndex = 2;
            this.repeatLabel.Text = "Подтвердите параль";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.BackColor = System.Drawing.Color.White;
            this.loginTextBox.Location = new System.Drawing.Point(179, 61);
            this.loginTextBox.MaxLength = 20;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(179, 95);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // repeatTextBox
            // 
            this.repeatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatTextBox.Location = new System.Drawing.Point(179, 132);
            this.repeatTextBox.MaxLength = 20;
            this.repeatTextBox.Name = "repeatTextBox";
            this.repeatTextBox.Size = new System.Drawing.Size(100, 20);
            this.repeatTextBox.TabIndex = 5;
            this.repeatTextBox.UseSystemPasswordChar = true;
            this.repeatTextBox.TextChanged += new System.EventHandler(this.repeatTextBox_TextChanged);
            // 
            // registryButton
            // 
            this.registryButton.Location = new System.Drawing.Point(39, 199);
            this.registryButton.Name = "registryButton";
            this.registryButton.Size = new System.Drawing.Size(129, 23);
            this.registryButton.TabIndex = 6;
            this.registryButton.Text = "Зарегистрироваться";
            this.registryButton.UseVisualStyleBackColor = true;
            this.registryButton.Click += new System.EventHandler(this.registryButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(204, 199);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(356, 61);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 8;
            this.countryLabel.Text = "Страна";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(356, 98);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(109, 13);
            this.informationLabel.TabIndex = 9;
            this.informationLabel.Text = "Информация о себе";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryTextBox.BackColor = System.Drawing.Color.White;
            this.countryTextBox.Location = new System.Drawing.Point(495, 54);
            this.countryTextBox.MaxLength = 20;
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 10;
            this.countryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countryTextBox_KeyPress);
            // 
            // informationTextBox
            // 
            this.informationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationTextBox.BackColor = System.Drawing.Color.White;
            this.informationTextBox.Location = new System.Drawing.Point(495, 95);
            this.informationTextBox.MaxLength = 20;
            this.informationTextBox.Multiline = true;
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.Size = new System.Drawing.Size(100, 57);
            this.informationTextBox.TabIndex = 11;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(338, 198);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateTimePicker.TabIndex = 13;
            this.birthDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Укажите дату вашего рождения";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(544, 205);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(52, 13);
            this.ageLabel.TabIndex = 15;
            this.ageLabel.Text = "Возраст:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Задание 5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.informationTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registryButton);
            this.Controls.Add(this.repeatTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.repeatLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label repeatLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox repeatTextBox;
        private System.Windows.Forms.Button registryButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox informationTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button button1;
    }
}