namespace IntegrationApp
{
    partial class Trainer
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
            this.GuestControls = new System.Windows.Forms.TabControl();
            this.Sportmen = new System.Windows.Forms.TabPage();
            this.Adding = new System.Windows.Forms.GroupBox();
            this.AddSportsmanButton = new System.Windows.Forms.Button();
            this.PassConfirmInput = new System.Windows.Forms.TextBox();
            this.PassConfirmLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.BirthdateInput = new System.Windows.Forms.TextBox();
            this.CitizenshipInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.NameSpInput = new System.Windows.Forms.TextBox();
            this.SurnameSpInput = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.CitizenshipLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.Deleting = new System.Windows.Forms.GroupBox();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.SportsmanDeletingButton = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SportsmenDataGroup = new System.Windows.Forms.GroupBox();
            this.SpData = new System.Windows.Forms.DataGridView();
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.GuestControls.SuspendLayout();
            this.Sportmen.SuspendLayout();
            this.Adding.SuspendLayout();
            this.Deleting.SuspendLayout();
            this.SportsmenDataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpData)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestControls
            // 
            this.GuestControls.Controls.Add(this.Sportmen);
            this.GuestControls.Location = new System.Drawing.Point(3, 101);
            this.GuestControls.Name = "GuestControls";
            this.GuestControls.SelectedIndex = 0;
            this.GuestControls.Size = new System.Drawing.Size(819, 598);
            this.GuestControls.TabIndex = 3;
            // 
            // Sportmen
            // 
            this.Sportmen.Controls.Add(this.Adding);
            this.Sportmen.Controls.Add(this.Deleting);
            this.Sportmen.Controls.Add(this.SportsmenDataGroup);
            this.Sportmen.Location = new System.Drawing.Point(4, 22);
            this.Sportmen.Name = "Sportmen";
            this.Sportmen.Padding = new System.Windows.Forms.Padding(3);
            this.Sportmen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sportmen.Size = new System.Drawing.Size(811, 572);
            this.Sportmen.TabIndex = 1;
            this.Sportmen.Text = "Спортсмены";
            this.Sportmen.UseVisualStyleBackColor = true;
            // 
            // Adding
            // 
            this.Adding.Controls.Add(this.AddSportsmanButton);
            this.Adding.Controls.Add(this.PassConfirmInput);
            this.Adding.Controls.Add(this.PassConfirmLabel);
            this.Adding.Controls.Add(this.PasswordInput);
            this.Adding.Controls.Add(this.LoginInput);
            this.Adding.Controls.Add(this.HeightInput);
            this.Adding.Controls.Add(this.WeightInput);
            this.Adding.Controls.Add(this.BirthdateInput);
            this.Adding.Controls.Add(this.CitizenshipInput);
            this.Adding.Controls.Add(this.LastNameInput);
            this.Adding.Controls.Add(this.NameSpInput);
            this.Adding.Controls.Add(this.SurnameSpInput);
            this.Adding.Controls.Add(this.PasswordLabel);
            this.Adding.Controls.Add(this.WeightLabel);
            this.Adding.Controls.Add(this.LoginLabel);
            this.Adding.Controls.Add(this.HeightLabel);
            this.Adding.Controls.Add(this.BirthdateLabel);
            this.Adding.Controls.Add(this.CitizenshipLabel);
            this.Adding.Controls.Add(this.LastNameLabel);
            this.Adding.Controls.Add(this.NameLabel);
            this.Adding.Controls.Add(this.SurnameLabel);
            this.Adding.Location = new System.Drawing.Point(6, 262);
            this.Adding.Name = "Adding";
            this.Adding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Adding.Size = new System.Drawing.Size(498, 284);
            this.Adding.TabIndex = 8;
            this.Adding.TabStop = false;
            this.Adding.Text = "Добавление спортсмена";
            // 
            // AddSportsmanButton
            // 
            this.AddSportsmanButton.Location = new System.Drawing.Point(345, 219);
            this.AddSportsmanButton.Name = "AddSportsmanButton";
            this.AddSportsmanButton.Size = new System.Drawing.Size(84, 40);
            this.AddSportsmanButton.TabIndex = 20;
            this.AddSportsmanButton.Text = "Добавить";
            this.AddSportsmanButton.UseVisualStyleBackColor = true;
            this.AddSportsmanButton.Click += new System.EventHandler(this.AddSportsmanButton_Click);
            // 
            // PassConfirmInput
            // 
            this.PassConfirmInput.Location = new System.Drawing.Point(362, 117);
            this.PassConfirmInput.Name = "PassConfirmInput";
            this.PassConfirmInput.Size = new System.Drawing.Size(100, 20);
            this.PassConfirmInput.TabIndex = 19;
            // 
            // PassConfirmLabel
            // 
            this.PassConfirmLabel.AutoSize = true;
            this.PassConfirmLabel.Location = new System.Drawing.Point(359, 92);
            this.PassConfirmLabel.Name = "PassConfirmLabel";
            this.PassConfirmLabel.Size = new System.Drawing.Size(100, 13);
            this.PassConfirmLabel.TabIndex = 18;
            this.PassConfirmLabel.Text = "Повторите пароль";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(362, 57);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 20);
            this.PasswordInput.TabIndex = 17;
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(207, 242);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(100, 20);
            this.LoginInput.TabIndex = 16;
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(207, 180);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(100, 20);
            this.HeightInput.TabIndex = 15;
            // 
            // WeightInput
            // 
            this.WeightInput.Location = new System.Drawing.Point(207, 117);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(100, 20);
            this.WeightInput.TabIndex = 14;
            // 
            // BirthdateInput
            // 
            this.BirthdateInput.Location = new System.Drawing.Point(207, 57);
            this.BirthdateInput.Name = "BirthdateInput";
            this.BirthdateInput.Size = new System.Drawing.Size(100, 20);
            this.BirthdateInput.TabIndex = 13;
            // 
            // CitizenshipInput
            // 
            this.CitizenshipInput.Location = new System.Drawing.Point(19, 244);
            this.CitizenshipInput.Name = "CitizenshipInput";
            this.CitizenshipInput.Size = new System.Drawing.Size(100, 20);
            this.CitizenshipInput.TabIndex = 12;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(19, 182);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(100, 20);
            this.LastNameInput.TabIndex = 11;
            // 
            // NameSpInput
            // 
            this.NameSpInput.Location = new System.Drawing.Point(19, 120);
            this.NameSpInput.Name = "NameSpInput";
            this.NameSpInput.Size = new System.Drawing.Size(100, 20);
            this.NameSpInput.TabIndex = 10;
            // 
            // SurnameSpInput
            // 
            this.SurnameSpInput.Location = new System.Drawing.Point(19, 57);
            this.SurnameSpInput.Name = "SurnameSpInput";
            this.SurnameSpInput.Size = new System.Drawing.Size(100, 20);
            this.SurnameSpInput.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(359, 32);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Пароль";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(204, 93);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(26, 13);
            this.WeightLabel.TabIndex = 7;
            this.WeightLabel.Text = "Вес";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(204, 220);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(204, 157);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(31, 13);
            this.HeightLabel.TabIndex = 5;
            this.HeightLabel.Text = "Рост";
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Location = new System.Drawing.Point(207, 35);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(86, 13);
            this.BirthdateLabel.TabIndex = 4;
            this.BirthdateLabel.Text = "Дата рождения";
            // 
            // CitizenshipLabel
            // 
            this.CitizenshipLabel.AutoSize = true;
            this.CitizenshipLabel.Location = new System.Drawing.Point(19, 219);
            this.CitizenshipLabel.Name = "CitizenshipLabel";
            this.CitizenshipLabel.Size = new System.Drawing.Size(74, 13);
            this.CitizenshipLabel.TabIndex = 3;
            this.CitizenshipLabel.Text = "Гражданство";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(19, 160);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(54, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Отчество";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 97);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(19, 33);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // Deleting
            // 
            this.Deleting.Controls.Add(this.SurnameInput);
            this.Deleting.Controls.Add(this.SportsmanDeletingButton);
            this.Deleting.Controls.Add(this.NameInput);
            this.Deleting.Controls.Add(this.label1);
            this.Deleting.Controls.Add(this.label2);
            this.Deleting.Location = new System.Drawing.Point(510, 262);
            this.Deleting.Name = "Deleting";
            this.Deleting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deleting.Size = new System.Drawing.Size(280, 141);
            this.Deleting.TabIndex = 7;
            this.Deleting.TabStop = false;
            this.Deleting.Text = "Удаление спортсмена";
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(121, 26);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(129, 20);
            this.SurnameInput.TabIndex = 10;
            // 
            // SportsmanDeletingButton
            // 
            this.SportsmanDeletingButton.Location = new System.Drawing.Point(19, 97);
            this.SportsmanDeletingButton.Name = "SportsmanDeletingButton";
            this.SportsmanDeletingButton.Size = new System.Drawing.Size(95, 23);
            this.SportsmanDeletingButton.TabIndex = 9;
            this.SportsmanDeletingButton.Text = "Удалить";
            this.SportsmanDeletingButton.UseVisualStyleBackColor = true;
            this.SportsmanDeletingButton.Click += new System.EventHandler(this.SportsmanDeletingButton_Click);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(121, 64);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(129, 20);
            this.NameInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // SportsmenDataGroup
            // 
            this.SportsmenDataGroup.Controls.Add(this.SpData);
            this.SportsmenDataGroup.Location = new System.Drawing.Point(6, 6);
            this.SportsmenDataGroup.Name = "SportsmenDataGroup";
            this.SportsmenDataGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SportsmenDataGroup.Size = new System.Drawing.Size(799, 250);
            this.SportsmenDataGroup.TabIndex = 0;
            this.SportsmenDataGroup.TabStop = false;
            this.SportsmenDataGroup.Text = "Данные спортсменов";
            // 
            // SpData
            // 
            this.SpData.AllowUserToAddRows = false;
            this.SpData.AllowUserToDeleteRows = false;
            this.SpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpData.Location = new System.Drawing.Point(6, 19);
            this.SpData.Name = "SpData";
            this.SpData.ReadOnly = true;
            this.SpData.Size = new System.Drawing.Size(787, 225);
            this.SpData.TabIndex = 0;
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GreetingsLabel.Location = new System.Drawing.Point(14, 42);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(249, 29);
            this.GreetingsLabel.TabIndex = 4;
            this.GreetingsLabel.Text = "Добро пожаловать,  ";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(773, 54);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(39, 13);
            this.LogoutLink.TabIndex = 5;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Выйти";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 705);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.GreetingsLabel);
            this.Controls.Add(this.GuestControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивный клуб \"Олимпиец\" - Тренер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trainer_FormClosing);
            this.Load += new System.EventHandler(this.Trainer_Load);
            this.GuestControls.ResumeLayout(false);
            this.Sportmen.ResumeLayout(false);
            this.Adding.ResumeLayout(false);
            this.Adding.PerformLayout();
            this.Deleting.ResumeLayout(false);
            this.Deleting.PerformLayout();
            this.SportsmenDataGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl GuestControls;
        private System.Windows.Forms.TabPage Sportmen;
        private System.Windows.Forms.GroupBox Deleting;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.Button SportsmanDeletingButton;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SportsmenDataGroup;
        private System.Windows.Forms.DataGridView SpData;
        private System.Windows.Forms.GroupBox Adding;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label CitizenshipLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AddSportsmanButton;
        private System.Windows.Forms.TextBox PassConfirmInput;
        private System.Windows.Forms.Label PassConfirmLabel;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.TextBox BirthdateInput;
        private System.Windows.Forms.TextBox CitizenshipInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox NameSpInput;
        private System.Windows.Forms.TextBox SurnameSpInput;
        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
    }
}