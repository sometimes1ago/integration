namespace IntegrationApp
{
    partial class Sportsman
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.GuestControls = new System.Windows.Forms.TabControl();
            this.Events = new System.Windows.Forms.TabPage();
            this.DirectSearchGroup = new System.Windows.Forms.GroupBox();
            this.DirectSearchButton = new System.Windows.Forms.Button();
            this.DirectSearchInput = new System.Windows.Forms.TextBox();
            this.DirectSearchValueLabel = new System.Windows.Forms.Label();
            this.SearchByOpt = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.EventSortingGroup = new System.Windows.Forms.GroupBox();
            this.ShowEventsButton = new System.Windows.Forms.Button();
            this.OrderEvtOpt = new System.Windows.Forms.ComboBox();
            this.OrderEvtLabel = new System.Windows.Forms.Label();
            this.SortEvtOpt = new System.Windows.Forms.ComboBox();
            this.SortEvtLabel = new System.Windows.Forms.Label();
            this.EventsData = new System.Windows.Forms.GroupBox();
            this.NearestEventsData = new System.Windows.Forms.DataGridView();
            this.YourDataLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.CitizenshipLabel = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.GuestControls.SuspendLayout();
            this.Events.SuspendLayout();
            this.DirectSearchGroup.SuspendLayout();
            this.EventSortingGroup.SuspendLayout();
            this.EventsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NearestEventsData)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.WelcomeLabel.Location = new System.Drawing.Point(292, 33);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(346, 40);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Добро пожаловать!";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(948, 45);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(39, 13);
            this.LogoutLink.TabIndex = 1;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Выйти";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // GuestControls
            // 
            this.GuestControls.Controls.Add(this.Events);
            this.GuestControls.Location = new System.Drawing.Point(12, 102);
            this.GuestControls.Name = "GuestControls";
            this.GuestControls.SelectedIndex = 0;
            this.GuestControls.Size = new System.Drawing.Size(979, 419);
            this.GuestControls.TabIndex = 3;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.WeightLabel);
            this.Events.Controls.Add(this.HeightLabel);
            this.Events.Controls.Add(this.BirthDate);
            this.Events.Controls.Add(this.CitizenshipLabel);
            this.Events.Controls.Add(this.LastNameLabel);
            this.Events.Controls.Add(this.NameLabel);
            this.Events.Controls.Add(this.SurnameLabel);
            this.Events.Controls.Add(this.YourDataLabel);
            this.Events.Controls.Add(this.DirectSearchGroup);
            this.Events.Controls.Add(this.EventSortingGroup);
            this.Events.Controls.Add(this.EventsData);
            this.Events.Location = new System.Drawing.Point(4, 22);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(971, 393);
            this.Events.TabIndex = 0;
            this.Events.Text = "Мероприятия";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // DirectSearchGroup
            // 
            this.DirectSearchGroup.Controls.Add(this.DirectSearchButton);
            this.DirectSearchGroup.Controls.Add(this.DirectSearchInput);
            this.DirectSearchGroup.Controls.Add(this.DirectSearchValueLabel);
            this.DirectSearchGroup.Controls.Add(this.SearchByOpt);
            this.DirectSearchGroup.Controls.Add(this.SearchByLabel);
            this.DirectSearchGroup.Location = new System.Drawing.Point(283, 238);
            this.DirectSearchGroup.Name = "DirectSearchGroup";
            this.DirectSearchGroup.Size = new System.Drawing.Size(279, 144);
            this.DirectSearchGroup.TabIndex = 5;
            this.DirectSearchGroup.TabStop = false;
            this.DirectSearchGroup.Text = "Прямой поиск";
            // 
            // DirectSearchButton
            // 
            this.DirectSearchButton.Location = new System.Drawing.Point(19, 104);
            this.DirectSearchButton.Name = "DirectSearchButton";
            this.DirectSearchButton.Size = new System.Drawing.Size(95, 23);
            this.DirectSearchButton.TabIndex = 9;
            this.DirectSearchButton.Text = "Найти";
            this.DirectSearchButton.UseVisualStyleBackColor = true;
            this.DirectSearchButton.Click += new System.EventHandler(this.DirectSearchButton_Click);
            // 
            // DirectSearchInput
            // 
            this.DirectSearchInput.Location = new System.Drawing.Point(121, 64);
            this.DirectSearchInput.Name = "DirectSearchInput";
            this.DirectSearchInput.Size = new System.Drawing.Size(129, 20);
            this.DirectSearchInput.TabIndex = 5;
            // 
            // DirectSearchValueLabel
            // 
            this.DirectSearchValueLabel.AutoSize = true;
            this.DirectSearchValueLabel.Location = new System.Drawing.Point(16, 66);
            this.DirectSearchValueLabel.Name = "DirectSearchValueLabel";
            this.DirectSearchValueLabel.Size = new System.Drawing.Size(99, 13);
            this.DirectSearchValueLabel.TabIndex = 4;
            this.DirectSearchValueLabel.Text = "Введите значение";
            // 
            // SearchByOpt
            // 
            this.SearchByOpt.FormattingEnabled = true;
            this.SearchByOpt.Items.AddRange(new object[] {
            "Команде",
            "Названию",
            "Месту",
            "Типу"});
            this.SearchByOpt.Location = new System.Drawing.Point(121, 26);
            this.SearchByOpt.Name = "SearchByOpt";
            this.SearchByOpt.Size = new System.Drawing.Size(129, 21);
            this.SearchByOpt.TabIndex = 3;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(16, 29);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(54, 13);
            this.SearchByLabel.TabIndex = 2;
            this.SearchByLabel.Text = "Поиск по";
            // 
            // EventSortingGroup
            // 
            this.EventSortingGroup.Controls.Add(this.ShowEventsButton);
            this.EventSortingGroup.Controls.Add(this.OrderEvtOpt);
            this.EventSortingGroup.Controls.Add(this.OrderEvtLabel);
            this.EventSortingGroup.Controls.Add(this.SortEvtOpt);
            this.EventSortingGroup.Controls.Add(this.SortEvtLabel);
            this.EventSortingGroup.Location = new System.Drawing.Point(6, 238);
            this.EventSortingGroup.Name = "EventSortingGroup";
            this.EventSortingGroup.Size = new System.Drawing.Size(271, 144);
            this.EventSortingGroup.TabIndex = 4;
            this.EventSortingGroup.TabStop = false;
            this.EventSortingGroup.Text = "Сортировка";
            // 
            // ShowEventsButton
            // 
            this.ShowEventsButton.Location = new System.Drawing.Point(20, 104);
            this.ShowEventsButton.Name = "ShowEventsButton";
            this.ShowEventsButton.Size = new System.Drawing.Size(95, 23);
            this.ShowEventsButton.TabIndex = 10;
            this.ShowEventsButton.Text = "Показать";
            this.ShowEventsButton.UseVisualStyleBackColor = true;
            this.ShowEventsButton.Click += new System.EventHandler(this.ShowEventsButton_Click);
            // 
            // OrderEvtOpt
            // 
            this.OrderEvtOpt.FormattingEnabled = true;
            this.OrderEvtOpt.Items.AddRange(new object[] {
            "Возрастанию",
            "Убыванию"});
            this.OrderEvtOpt.Location = new System.Drawing.Point(110, 66);
            this.OrderEvtOpt.Name = "OrderEvtOpt";
            this.OrderEvtOpt.Size = new System.Drawing.Size(129, 21);
            this.OrderEvtOpt.TabIndex = 3;
            // 
            // OrderEvtLabel
            // 
            this.OrderEvtLabel.AutoSize = true;
            this.OrderEvtLabel.Location = new System.Drawing.Point(17, 69);
            this.OrderEvtLabel.Name = "OrderEvtLabel";
            this.OrderEvtLabel.Size = new System.Drawing.Size(66, 13);
            this.OrderEvtLabel.TabIndex = 2;
            this.OrderEvtLabel.Text = "Порядок по";
            // 
            // SortEvtOpt
            // 
            this.SortEvtOpt.FormattingEnabled = true;
            this.SortEvtOpt.Items.AddRange(new object[] {
            "Месту",
            "Команде",
            "Дате",
            "Времени",
            "Названию",
            "Типу"});
            this.SortEvtOpt.Location = new System.Drawing.Point(110, 26);
            this.SortEvtOpt.Name = "SortEvtOpt";
            this.SortEvtOpt.Size = new System.Drawing.Size(129, 21);
            this.SortEvtOpt.TabIndex = 1;
            // 
            // SortEvtLabel
            // 
            this.SortEvtLabel.AutoSize = true;
            this.SortEvtLabel.Location = new System.Drawing.Point(17, 29);
            this.SortEvtLabel.Name = "SortEvtLabel";
            this.SortEvtLabel.Size = new System.Drawing.Size(87, 13);
            this.SortEvtLabel.TabIndex = 0;
            this.SortEvtLabel.Text = "Сортировать по";
            // 
            // EventsData
            // 
            this.EventsData.Controls.Add(this.NearestEventsData);
            this.EventsData.Location = new System.Drawing.Point(6, 6);
            this.EventsData.Name = "EventsData";
            this.EventsData.Size = new System.Drawing.Size(746, 226);
            this.EventsData.TabIndex = 3;
            this.EventsData.TabStop = false;
            this.EventsData.Text = "Ближайщие метроприятия";
            // 
            // NearestEventsData
            // 
            this.NearestEventsData.AllowUserToAddRows = false;
            this.NearestEventsData.AllowUserToDeleteRows = false;
            this.NearestEventsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NearestEventsData.Location = new System.Drawing.Point(6, 19);
            this.NearestEventsData.Name = "NearestEventsData";
            this.NearestEventsData.ReadOnly = true;
            this.NearestEventsData.Size = new System.Drawing.Size(728, 201);
            this.NearestEventsData.TabIndex = 0;
            // 
            // YourDataLabel
            // 
            this.YourDataLabel.AutoSize = true;
            this.YourDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.YourDataLabel.Location = new System.Drawing.Point(758, 13);
            this.YourDataLabel.Name = "YourDataLabel";
            this.YourDataLabel.Size = new System.Drawing.Size(135, 25);
            this.YourDataLabel.TabIndex = 6;
            this.YourDataLabel.Text = "Ваши данные";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(760, 53);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(62, 13);
            this.SurnameLabel.TabIndex = 7;
            this.SurnameLabel.Text = "Фамилия: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(760, 91);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Имя: ";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(760, 129);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(60, 13);
            this.LastNameLabel.TabIndex = 9;
            this.LastNameLabel.Text = "Отчество: ";
            // 
            // CitizenshipLabel
            // 
            this.CitizenshipLabel.AutoSize = true;
            this.CitizenshipLabel.Location = new System.Drawing.Point(760, 167);
            this.CitizenshipLabel.Name = "CitizenshipLabel";
            this.CitizenshipLabel.Size = new System.Drawing.Size(80, 13);
            this.CitizenshipLabel.TabIndex = 10;
            this.CitizenshipLabel.Text = "Гражданство: ";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(760, 205);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(92, 13);
            this.BirthDate.TabIndex = 11;
            this.BirthDate.Text = "Дата рождения: ";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(760, 243);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(37, 13);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.Text = "Рост: ";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(760, 281);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(32, 13);
            this.WeightLabel.TabIndex = 13;
            this.WeightLabel.Text = "Вес: ";
            // 
            // Sportsman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 527);
            this.Controls.Add(this.GuestControls);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Sportsman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивный клуб \"Олимпиец\" - Спортсмен";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sportsman_FormClosing);
            this.Load += new System.EventHandler(this.Sportsman_Load);
            this.GuestControls.ResumeLayout(false);
            this.Events.ResumeLayout(false);
            this.Events.PerformLayout();
            this.DirectSearchGroup.ResumeLayout(false);
            this.DirectSearchGroup.PerformLayout();
            this.EventSortingGroup.ResumeLayout(false);
            this.EventSortingGroup.PerformLayout();
            this.EventsData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NearestEventsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.TabControl GuestControls;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.GroupBox DirectSearchGroup;
        private System.Windows.Forms.Button DirectSearchButton;
        private System.Windows.Forms.TextBox DirectSearchInput;
        private System.Windows.Forms.Label DirectSearchValueLabel;
        private System.Windows.Forms.ComboBox SearchByOpt;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.GroupBox EventSortingGroup;
        private System.Windows.Forms.Button ShowEventsButton;
        private System.Windows.Forms.ComboBox OrderEvtOpt;
        private System.Windows.Forms.Label OrderEvtLabel;
        private System.Windows.Forms.ComboBox SortEvtOpt;
        private System.Windows.Forms.Label SortEvtLabel;
        private System.Windows.Forms.GroupBox EventsData;
        private System.Windows.Forms.DataGridView NearestEventsData;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label CitizenshipLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label YourDataLabel;
    }
}