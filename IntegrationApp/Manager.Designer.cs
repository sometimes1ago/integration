namespace IntegrationApp
{
    partial class Manager
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
            this.Events = new System.Windows.Forms.TabPage();
            this.AddTeamOnEventGroup = new System.Windows.Forms.GroupBox();
            this.EventCreatingSection = new System.Windows.Forms.GroupBox();
            this.CreateEventButton = new System.Windows.Forms.Button();
            this.EventPlaceInput = new System.Windows.Forms.TextBox();
            this.EventTimeInput = new System.Windows.Forms.TextBox();
            this.EventDateInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.EventTypeLabel = new System.Windows.Forms.Label();
            this.EventNameInput = new System.Windows.Forms.TextBox();
            this.EventTypeOpt = new System.Windows.Forms.ComboBox();
            this.EventNameLabel = new System.Windows.Forms.Label();
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
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.SelectEvtOpt = new System.Windows.Forms.ComboBox();
            this.SelectTeamOpt = new System.Windows.Forms.ComboBox();
            this.SelTeamLab = new System.Windows.Forms.Label();
            this.AddTeamToEvtButton = new System.Windows.Forms.Button();
            this.GuestControls.SuspendLayout();
            this.Events.SuspendLayout();
            this.AddTeamOnEventGroup.SuspendLayout();
            this.EventCreatingSection.SuspendLayout();
            this.DirectSearchGroup.SuspendLayout();
            this.EventSortingGroup.SuspendLayout();
            this.EventsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NearestEventsData)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestControls
            // 
            this.GuestControls.Controls.Add(this.Events);
            this.GuestControls.Location = new System.Drawing.Point(12, 105);
            this.GuestControls.Name = "GuestControls";
            this.GuestControls.SelectedIndex = 0;
            this.GuestControls.Size = new System.Drawing.Size(1100, 419);
            this.GuestControls.TabIndex = 3;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.AddTeamOnEventGroup);
            this.Events.Controls.Add(this.EventCreatingSection);
            this.Events.Controls.Add(this.DirectSearchGroup);
            this.Events.Controls.Add(this.EventSortingGroup);
            this.Events.Controls.Add(this.EventsData);
            this.Events.Location = new System.Drawing.Point(4, 22);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(1092, 393);
            this.Events.TabIndex = 0;
            this.Events.Text = "Мероприятия";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // AddTeamOnEventGroup
            // 
            this.AddTeamOnEventGroup.Controls.Add(this.AddTeamToEvtButton);
            this.AddTeamOnEventGroup.Controls.Add(this.SelectTeamOpt);
            this.AddTeamOnEventGroup.Controls.Add(this.SelTeamLab);
            this.AddTeamOnEventGroup.Controls.Add(this.SelectEvtOpt);
            this.AddTeamOnEventGroup.Controls.Add(this.SelectTeamLabel);
            this.AddTeamOnEventGroup.Location = new System.Drawing.Point(585, 238);
            this.AddTeamOnEventGroup.Name = "AddTeamOnEventGroup";
            this.AddTeamOnEventGroup.Size = new System.Drawing.Size(286, 144);
            this.AddTeamOnEventGroup.TabIndex = 7;
            this.AddTeamOnEventGroup.TabStop = false;
            this.AddTeamOnEventGroup.Text = "Добавление команды на мероприятие";
            // 
            // EventCreatingSection
            // 
            this.EventCreatingSection.Controls.Add(this.CreateEventButton);
            this.EventCreatingSection.Controls.Add(this.EventPlaceInput);
            this.EventCreatingSection.Controls.Add(this.EventTimeInput);
            this.EventCreatingSection.Controls.Add(this.EventDateInput);
            this.EventCreatingSection.Controls.Add(this.label4);
            this.EventCreatingSection.Controls.Add(this.label3);
            this.EventCreatingSection.Controls.Add(this.EventDateLabel);
            this.EventCreatingSection.Controls.Add(this.EventTypeLabel);
            this.EventCreatingSection.Controls.Add(this.EventNameInput);
            this.EventCreatingSection.Controls.Add(this.EventTypeOpt);
            this.EventCreatingSection.Controls.Add(this.EventNameLabel);
            this.EventCreatingSection.Location = new System.Drawing.Point(674, 6);
            this.EventCreatingSection.Name = "EventCreatingSection";
            this.EventCreatingSection.Size = new System.Drawing.Size(412, 226);
            this.EventCreatingSection.TabIndex = 6;
            this.EventCreatingSection.TabStop = false;
            this.EventCreatingSection.Text = "Создание мероприятия";
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(233, 184);
            this.CreateEventButton.Name = "CreateEventButton";
            this.CreateEventButton.Size = new System.Drawing.Size(95, 23);
            this.CreateEventButton.TabIndex = 10;
            this.CreateEventButton.Text = "Создать";
            this.CreateEventButton.UseVisualStyleBackColor = true;
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // EventPlaceInput
            // 
            this.EventPlaceInput.Location = new System.Drawing.Point(233, 121);
            this.EventPlaceInput.Name = "EventPlaceInput";
            this.EventPlaceInput.Size = new System.Drawing.Size(139, 20);
            this.EventPlaceInput.TabIndex = 9;
            // 
            // EventTimeInput
            // 
            this.EventTimeInput.Location = new System.Drawing.Point(233, 55);
            this.EventTimeInput.Name = "EventTimeInput";
            this.EventTimeInput.Size = new System.Drawing.Size(139, 20);
            this.EventTimeInput.TabIndex = 8;
            // 
            // EventDateInput
            // 
            this.EventDateInput.Location = new System.Drawing.Point(18, 187);
            this.EventDateInput.Name = "EventDateInput";
            this.EventDateInput.Size = new System.Drawing.Size(139, 20);
            this.EventDateInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Место проведения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время проведения";
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Location = new System.Drawing.Point(15, 162);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(96, 13);
            this.EventDateLabel.TabIndex = 4;
            this.EventDateLabel.Text = "Дата проведения";
            // 
            // EventTypeLabel
            // 
            this.EventTypeLabel.AutoSize = true;
            this.EventTypeLabel.Location = new System.Drawing.Point(15, 93);
            this.EventTypeLabel.Name = "EventTypeLabel";
            this.EventTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.EventTypeLabel.TabIndex = 3;
            this.EventTypeLabel.Text = "Тип мероприятия";
            // 
            // EventNameInput
            // 
            this.EventNameInput.Location = new System.Drawing.Point(18, 55);
            this.EventNameInput.Name = "EventNameInput";
            this.EventNameInput.Size = new System.Drawing.Size(139, 20);
            this.EventNameInput.TabIndex = 2;
            // 
            // EventTypeOpt
            // 
            this.EventTypeOpt.FormattingEnabled = true;
            this.EventTypeOpt.Items.AddRange(new object[] {
            "Турнир",
            "Олимпиада",
            "Соревнование"});
            this.EventTypeOpt.Location = new System.Drawing.Point(18, 120);
            this.EventTypeOpt.Name = "EventTypeOpt";
            this.EventTypeOpt.Size = new System.Drawing.Size(139, 21);
            this.EventTypeOpt.TabIndex = 1;
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Location = new System.Drawing.Point(15, 28);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(83, 13);
            this.EventNameLabel.TabIndex = 0;
            this.EventNameLabel.Text = "Наименование";
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
            this.EventsData.Size = new System.Drawing.Size(662, 226);
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
            this.NearestEventsData.Size = new System.Drawing.Size(649, 201);
            this.NearestEventsData.TabIndex = 0;
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GreetingsLabel.Location = new System.Drawing.Point(23, 35);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(249, 29);
            this.GreetingsLabel.TabIndex = 5;
            this.GreetingsLabel.Text = "Добро пожаловать,  ";
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(1063, 47);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(39, 13);
            this.LogoutLink.TabIndex = 6;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Выйти";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Location = new System.Drawing.Point(6, 23);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(127, 13);
            this.SelectTeamLabel.TabIndex = 11;
            this.SelectTeamLabel.Text = "Выберите мероприятие";
            // 
            // SelectEvtOpt
            // 
            this.SelectEvtOpt.FormattingEnabled = true;
            this.SelectEvtOpt.Location = new System.Drawing.Point(9, 47);
            this.SelectEvtOpt.Name = "SelectEvtOpt";
            this.SelectEvtOpt.Size = new System.Drawing.Size(121, 21);
            this.SelectEvtOpt.TabIndex = 12;
            // 
            // SelectTeamOpt
            // 
            this.SelectTeamOpt.FormattingEnabled = true;
            this.SelectTeamOpt.Location = new System.Drawing.Point(9, 107);
            this.SelectTeamOpt.Name = "SelectTeamOpt";
            this.SelectTeamOpt.Size = new System.Drawing.Size(121, 21);
            this.SelectTeamOpt.TabIndex = 14;
            // 
            // SelTeamLab
            // 
            this.SelTeamLab.AutoSize = true;
            this.SelTeamLab.Location = new System.Drawing.Point(6, 83);
            this.SelTeamLab.Name = "SelTeamLab";
            this.SelTeamLab.Size = new System.Drawing.Size(103, 13);
            this.SelTeamLab.TabIndex = 13;
            this.SelTeamLab.Text = "Выберите команду";
            // 
            // AddTeamToEvtButton
            // 
            this.AddTeamToEvtButton.Location = new System.Drawing.Point(166, 104);
            this.AddTeamToEvtButton.Name = "AddTeamToEvtButton";
            this.AddTeamToEvtButton.Size = new System.Drawing.Size(95, 23);
            this.AddTeamToEvtButton.TabIndex = 15;
            this.AddTeamToEvtButton.Text = "Создать";
            this.AddTeamToEvtButton.UseVisualStyleBackColor = true;
            this.AddTeamToEvtButton.Click += new System.EventHandler(this.AddTeamToEvtButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 525);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.GreetingsLabel);
            this.Controls.Add(this.GuestControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивный клуб \"Олимпиец\" - Менеджер";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.GuestControls.ResumeLayout(false);
            this.Events.ResumeLayout(false);
            this.AddTeamOnEventGroup.ResumeLayout(false);
            this.AddTeamOnEventGroup.PerformLayout();
            this.EventCreatingSection.ResumeLayout(false);
            this.EventCreatingSection.PerformLayout();
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

        private System.Windows.Forms.TabControl GuestControls;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.GroupBox EventCreatingSection;
        private System.Windows.Forms.TextBox EventNameInput;
        private System.Windows.Forms.ComboBox EventTypeOpt;
        private System.Windows.Forms.Label EventNameLabel;
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
        private System.Windows.Forms.GroupBox AddTeamOnEventGroup;
        private System.Windows.Forms.Button CreateEventButton;
        private System.Windows.Forms.TextBox EventPlaceInput;
        private System.Windows.Forms.TextBox EventTimeInput;
        private System.Windows.Forms.TextBox EventDateInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EventDateLabel;
        private System.Windows.Forms.Label EventTypeLabel;
        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Button AddTeamToEvtButton;
        private System.Windows.Forms.ComboBox SelectTeamOpt;
        private System.Windows.Forms.Label SelTeamLab;
        private System.Windows.Forms.ComboBox SelectEvtOpt;
        private System.Windows.Forms.Label SelectTeamLabel;
    }
}