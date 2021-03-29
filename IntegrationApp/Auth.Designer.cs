namespace IntegrationApp
{
    partial class Auth
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
            this.AuthLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ShowPassControl = new System.Windows.Forms.CheckBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.BackLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AuthLabel
            // 
            this.AuthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AuthLabel.Location = new System.Drawing.Point(48, 32);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(220, 68);
            this.AuthLabel.TabIndex = 0;
            this.AuthLabel.Text = "Авторизация пользователей";
            this.AuthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LoginLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LoginLabel.Location = new System.Drawing.Point(135, 125);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(47, 17);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(69, 157);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(179, 20);
            this.LoginInput.TabIndex = 2;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(69, 228);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(179, 20);
            this.PasswordInput.TabIndex = 4;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.PasswordLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PasswordLabel.Location = new System.Drawing.Point(130, 196);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 17);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Пароль";
            // 
            // ShowPassControl
            // 
            this.ShowPassControl.AutoSize = true;
            this.ShowPassControl.Location = new System.Drawing.Point(101, 266);
            this.ShowPassControl.Name = "ShowPassControl";
            this.ShowPassControl.Size = new System.Drawing.Size(114, 17);
            this.ShowPassControl.TabIndex = 5;
            this.ShowPassControl.Text = "Показать пароль";
            this.ShowPassControl.UseVisualStyleBackColor = true;
            this.ShowPassControl.CheckedChanged += new System.EventHandler(this.ShowPassControl_CheckedChanged);
            // 
            // AuthButton
            // 
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AuthButton.Location = new System.Drawing.Point(69, 307);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(179, 29);
            this.AuthButton.TabIndex = 6;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // BackLink
            // 
            this.BackLink.AutoSize = true;
            this.BackLink.Location = new System.Drawing.Point(139, 358);
            this.BackLink.Name = "BackLink";
            this.BackLink.Size = new System.Drawing.Size(39, 13);
            this.BackLink.TabIndex = 8;
            this.BackLink.TabStop = true;
            this.BackLink.Text = "Назад";
            this.BackLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLink_LinkClicked);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 405);
            this.Controls.Add(this.BackLink);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.ShowPassControl);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.AuthLabel);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox ShowPassControl;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.LinkLabel BackLink;
    }
}