namespace IntegrationApp
{
    partial class Admin
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
            this.Sportmen = new System.Windows.Forms.TabPage();
            this.Direct = new System.Windows.Forms.GroupBox();
            this.DirectSpSearchButton = new System.Windows.Forms.Button();
            this.DirectSpSearchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectSpSearchOpt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SportsmenSortGroup = new System.Windows.Forms.GroupBox();
            this.ShowSortedSpButton = new System.Windows.Forms.Button();
            this.OrderSpByOpt = new System.Windows.Forms.ComboBox();
            this.OrderSpLabe = new System.Windows.Forms.Label();
            this.SortSpByOpt = new System.Windows.Forms.ComboBox();
            this.SortSpLabel = new System.Windows.Forms.Label();
            this.SportsmenDataGroup = new System.Windows.Forms.GroupBox();
            this.SpData = new System.Windows.Forms.DataGridView();
            this.AddEmployee = new System.Windows.Forms.TabPage();
            this.EmpDataGroup = new System.Windows.Forms.GroupBox();
            this.EmpData = new System.Windows.Forms.DataGridView();
            this.EmpAddingGroup = new System.Windows.Forms.GroupBox();
            this.EmpSurnameLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpLastNameLabel = new System.Windows.Forms.Label();
            this.EmpPositionLabel = new System.Windows.Forms.Label();
            this.EmpLoginLabel = new System.Windows.Forms.Label();
            this.EmpPassLabel = new System.Windows.Forms.Label();
            this.EmpPassConfirmLabel = new System.Windows.Forms.Label();
            this.EmpSurnameInput = new System.Windows.Forms.TextBox();
            this.EmpNameInput = new System.Windows.Forms.TextBox();
            this.EmpLastNameInput = new System.Windows.Forms.TextBox();
            this.EmpPositionsOpt = new System.Windows.Forms.ComboBox();
            this.EmpLoginInput = new System.Windows.Forms.TextBox();
            this.EmpPassInput = new System.Windows.Forms.TextBox();
            this.EmpPassConfirmInput = new System.Windows.Forms.TextBox();
            this.EmpAddButton = new System.Windows.Forms.Button();
            this.GuestControls.SuspendLayout();
            this.Events.SuspendLayout();
            this.DirectSearchGroup.SuspendLayout();
            this.EventSortingGroup.SuspendLayout();
            this.EventsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NearestEventsData)).BeginInit();
            this.Sportmen.SuspendLayout();
            this.Direct.SuspendLayout();
            this.SportsmenSortGroup.SuspendLayout();
            this.SportsmenDataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpData)).BeginInit();
            this.AddEmployee.SuspendLayout();
            this.EmpDataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpData)).BeginInit();
            this.EmpAddingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuestControls
            // 
            this.GuestControls.Controls.Add(this.Events);
            this.GuestControls.Controls.Add(this.Sportmen);
            this.GuestControls.Controls.Add(this.AddEmployee);
            this.GuestControls.Location = new System.Drawing.Point(12, 82);
            this.GuestControls.Name = "GuestControls";
            this.GuestControls.SelectedIndex = 0;
            this.GuestControls.Size = new System.Drawing.Size(812, 433);
            this.GuestControls.TabIndex = 3;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.DirectSearchGroup);
            this.Events.Controls.Add(this.EventSortingGroup);
            this.Events.Controls.Add(this.EventsData);
            this.Events.Location = new System.Drawing.Point(4, 22);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(804, 393);
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
            // Sportmen
            // 
            this.Sportmen.Controls.Add(this.Direct);
            this.Sportmen.Controls.Add(this.SportsmenSortGroup);
            this.Sportmen.Controls.Add(this.SportsmenDataGroup);
            this.Sportmen.Location = new System.Drawing.Point(4, 22);
            this.Sportmen.Name = "Sportmen";
            this.Sportmen.Padding = new System.Windows.Forms.Padding(3);
            this.Sportmen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sportmen.Size = new System.Drawing.Size(804, 393);
            this.Sportmen.TabIndex = 1;
            this.Sportmen.Text = "Спортсмены";
            this.Sportmen.UseVisualStyleBackColor = true;
            // 
            // Direct
            // 
            this.Direct.Controls.Add(this.DirectSpSearchButton);
            this.Direct.Controls.Add(this.DirectSpSearchInput);
            this.Direct.Controls.Add(this.label1);
            this.Direct.Controls.Add(this.DirectSpSearchOpt);
            this.Direct.Controls.Add(this.label2);
            this.Direct.Location = new System.Drawing.Point(296, 262);
            this.Direct.Name = "Direct";
            this.Direct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Direct.Size = new System.Drawing.Size(280, 141);
            this.Direct.TabIndex = 7;
            this.Direct.TabStop = false;
            this.Direct.Text = "Прямой поиск";
            // 
            // DirectSpSearchButton
            // 
            this.DirectSpSearchButton.Location = new System.Drawing.Point(19, 97);
            this.DirectSpSearchButton.Name = "DirectSpSearchButton";
            this.DirectSpSearchButton.Size = new System.Drawing.Size(95, 23);
            this.DirectSpSearchButton.TabIndex = 9;
            this.DirectSpSearchButton.Text = "Найти";
            this.DirectSpSearchButton.UseVisualStyleBackColor = true;
            // 
            // DirectSpSearchInput
            // 
            this.DirectSpSearchInput.Location = new System.Drawing.Point(121, 64);
            this.DirectSpSearchInput.Name = "DirectSpSearchInput";
            this.DirectSpSearchInput.Size = new System.Drawing.Size(129, 20);
            this.DirectSpSearchInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите значение";
            // 
            // DirectSpSearchOpt
            // 
            this.DirectSpSearchOpt.FormattingEnabled = true;
            this.DirectSpSearchOpt.Items.AddRange(new object[] {
            "Фамилии",
            "Гражданству",
            "Росту",
            "Весу",
            "Команде"});
            this.DirectSpSearchOpt.Location = new System.Drawing.Point(121, 26);
            this.DirectSpSearchOpt.Name = "DirectSpSearchOpt";
            this.DirectSpSearchOpt.Size = new System.Drawing.Size(129, 21);
            this.DirectSpSearchOpt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск по";
            // 
            // SportsmenSortGroup
            // 
            this.SportsmenSortGroup.Controls.Add(this.ShowSortedSpButton);
            this.SportsmenSortGroup.Controls.Add(this.OrderSpByOpt);
            this.SportsmenSortGroup.Controls.Add(this.OrderSpLabe);
            this.SportsmenSortGroup.Controls.Add(this.SortSpByOpt);
            this.SportsmenSortGroup.Controls.Add(this.SortSpLabel);
            this.SportsmenSortGroup.Location = new System.Drawing.Point(9, 262);
            this.SportsmenSortGroup.Name = "SportsmenSortGroup";
            this.SportsmenSortGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SportsmenSortGroup.Size = new System.Drawing.Size(272, 141);
            this.SportsmenSortGroup.TabIndex = 6;
            this.SportsmenSortGroup.TabStop = false;
            this.SportsmenSortGroup.Text = "Сортировка";
            // 
            // ShowSortedSpButton
            // 
            this.ShowSortedSpButton.Location = new System.Drawing.Point(15, 108);
            this.ShowSortedSpButton.Name = "ShowSortedSpButton";
            this.ShowSortedSpButton.Size = new System.Drawing.Size(95, 23);
            this.ShowSortedSpButton.TabIndex = 9;
            this.ShowSortedSpButton.Text = "Показать";
            this.ShowSortedSpButton.UseVisualStyleBackColor = true;
            // 
            // OrderSpByOpt
            // 
            this.OrderSpByOpt.FormattingEnabled = true;
            this.OrderSpByOpt.Items.AddRange(new object[] {
            "Возрастанию",
            "Убыванию"});
            this.OrderSpByOpt.Location = new System.Drawing.Point(105, 66);
            this.OrderSpByOpt.Name = "OrderSpByOpt";
            this.OrderSpByOpt.Size = new System.Drawing.Size(129, 21);
            this.OrderSpByOpt.TabIndex = 3;
            // 
            // OrderSpLabe
            // 
            this.OrderSpLabe.AutoSize = true;
            this.OrderSpLabe.Location = new System.Drawing.Point(12, 69);
            this.OrderSpLabe.Name = "OrderSpLabe";
            this.OrderSpLabe.Size = new System.Drawing.Size(66, 13);
            this.OrderSpLabe.TabIndex = 2;
            this.OrderSpLabe.Text = "Порядок по";
            // 
            // SortSpByOpt
            // 
            this.SortSpByOpt.FormattingEnabled = true;
            this.SortSpByOpt.Items.AddRange(new object[] {
            "Фамилии",
            "Гражданству",
            "Росту",
            "Весу",
            "Команде"});
            this.SortSpByOpt.Location = new System.Drawing.Point(105, 26);
            this.SortSpByOpt.Name = "SortSpByOpt";
            this.SortSpByOpt.Size = new System.Drawing.Size(129, 21);
            this.SortSpByOpt.TabIndex = 1;
            // 
            // SortSpLabel
            // 
            this.SortSpLabel.AutoSize = true;
            this.SortSpLabel.Location = new System.Drawing.Point(12, 29);
            this.SortSpLabel.Name = "SortSpLabel";
            this.SortSpLabel.Size = new System.Drawing.Size(87, 13);
            this.SortSpLabel.TabIndex = 0;
            this.SortSpLabel.Text = "Сортировать по";
            // 
            // SportsmenDataGroup
            // 
            this.SportsmenDataGroup.Controls.Add(this.SpData);
            this.SportsmenDataGroup.Location = new System.Drawing.Point(6, 6);
            this.SportsmenDataGroup.Name = "SportsmenDataGroup";
            this.SportsmenDataGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SportsmenDataGroup.Size = new System.Drawing.Size(784, 250);
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
            this.SpData.Size = new System.Drawing.Size(772, 225);
            this.SpData.TabIndex = 0;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Controls.Add(this.EmpAddingGroup);
            this.AddEmployee.Controls.Add(this.EmpDataGroup);
            this.AddEmployee.Location = new System.Drawing.Point(4, 22);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(804, 407);
            this.AddEmployee.TabIndex = 2;
            this.AddEmployee.Text = "Добавить сотрудника";
            this.AddEmployee.UseVisualStyleBackColor = true;
            // 
            // EmpDataGroup
            // 
            this.EmpDataGroup.Controls.Add(this.EmpData);
            this.EmpDataGroup.Location = new System.Drawing.Point(12, 17);
            this.EmpDataGroup.Name = "EmpDataGroup";
            this.EmpDataGroup.Size = new System.Drawing.Size(775, 226);
            this.EmpDataGroup.TabIndex = 0;
            this.EmpDataGroup.TabStop = false;
            this.EmpDataGroup.Text = "Сотрудники";
            // 
            // EmpData
            // 
            this.EmpData.AllowUserToAddRows = false;
            this.EmpData.AllowUserToDeleteRows = false;
            this.EmpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpData.Location = new System.Drawing.Point(6, 19);
            this.EmpData.Name = "EmpData";
            this.EmpData.ReadOnly = true;
            this.EmpData.Size = new System.Drawing.Size(763, 201);
            this.EmpData.TabIndex = 0;
            // 
            // EmpAddingGroup
            // 
            this.EmpAddingGroup.Controls.Add(this.EmpAddButton);
            this.EmpAddingGroup.Controls.Add(this.EmpPassConfirmInput);
            this.EmpAddingGroup.Controls.Add(this.EmpPassInput);
            this.EmpAddingGroup.Controls.Add(this.EmpLoginInput);
            this.EmpAddingGroup.Controls.Add(this.EmpPositionsOpt);
            this.EmpAddingGroup.Controls.Add(this.EmpLastNameInput);
            this.EmpAddingGroup.Controls.Add(this.EmpNameInput);
            this.EmpAddingGroup.Controls.Add(this.EmpSurnameInput);
            this.EmpAddingGroup.Controls.Add(this.EmpPassConfirmLabel);
            this.EmpAddingGroup.Controls.Add(this.EmpPassLabel);
            this.EmpAddingGroup.Controls.Add(this.EmpLoginLabel);
            this.EmpAddingGroup.Controls.Add(this.EmpPositionLabel);
            this.EmpAddingGroup.Controls.Add(this.EmpLastNameLabel);
            this.EmpAddingGroup.Controls.Add(this.EmpNameLabel);
            this.EmpAddingGroup.Controls.Add(this.EmpSurnameLabel);
            this.EmpAddingGroup.Location = new System.Drawing.Point(12, 249);
            this.EmpAddingGroup.Name = "EmpAddingGroup";
            this.EmpAddingGroup.Size = new System.Drawing.Size(542, 146);
            this.EmpAddingGroup.TabIndex = 1;
            this.EmpAddingGroup.TabStop = false;
            this.EmpAddingGroup.Text = "Добавление сотрудника";
            // 
            // EmpSurnameLabel
            // 
            this.EmpSurnameLabel.AutoSize = true;
            this.EmpSurnameLabel.Location = new System.Drawing.Point(6, 31);
            this.EmpSurnameLabel.Name = "EmpSurnameLabel";
            this.EmpSurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.EmpSurnameLabel.TabIndex = 0;
            this.EmpSurnameLabel.Text = "Фамилия";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Location = new System.Drawing.Point(6, 91);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(29, 13);
            this.EmpNameLabel.TabIndex = 1;
            this.EmpNameLabel.Text = "Имя";
            // 
            // EmpLastNameLabel
            // 
            this.EmpLastNameLabel.AutoSize = true;
            this.EmpLastNameLabel.Location = new System.Drawing.Point(144, 31);
            this.EmpLastNameLabel.Name = "EmpLastNameLabel";
            this.EmpLastNameLabel.Size = new System.Drawing.Size(54, 13);
            this.EmpLastNameLabel.TabIndex = 2;
            this.EmpLastNameLabel.Text = "Отчество";
            // 
            // EmpPositionLabel
            // 
            this.EmpPositionLabel.AutoSize = true;
            this.EmpPositionLabel.Location = new System.Drawing.Point(144, 91);
            this.EmpPositionLabel.Name = "EmpPositionLabel";
            this.EmpPositionLabel.Size = new System.Drawing.Size(65, 13);
            this.EmpPositionLabel.TabIndex = 3;
            this.EmpPositionLabel.Text = "Должность";
            // 
            // EmpLoginLabel
            // 
            this.EmpLoginLabel.AutoSize = true;
            this.EmpLoginLabel.Location = new System.Drawing.Point(283, 31);
            this.EmpLoginLabel.Name = "EmpLoginLabel";
            this.EmpLoginLabel.Size = new System.Drawing.Size(38, 13);
            this.EmpLoginLabel.TabIndex = 4;
            this.EmpLoginLabel.Text = "Логин";
            // 
            // EmpPassLabel
            // 
            this.EmpPassLabel.AutoSize = true;
            this.EmpPassLabel.Location = new System.Drawing.Point(283, 91);
            this.EmpPassLabel.Name = "EmpPassLabel";
            this.EmpPassLabel.Size = new System.Drawing.Size(45, 13);
            this.EmpPassLabel.TabIndex = 5;
            this.EmpPassLabel.Text = "Пароль";
            // 
            // EmpPassConfirmLabel
            // 
            this.EmpPassConfirmLabel.AutoSize = true;
            this.EmpPassConfirmLabel.Location = new System.Drawing.Point(416, 31);
            this.EmpPassConfirmLabel.Name = "EmpPassConfirmLabel";
            this.EmpPassConfirmLabel.Size = new System.Drawing.Size(83, 13);
            this.EmpPassConfirmLabel.TabIndex = 6;
            this.EmpPassConfirmLabel.Text = "Повтор пароля";
            // 
            // EmpSurnameInput
            // 
            this.EmpSurnameInput.Location = new System.Drawing.Point(9, 50);
            this.EmpSurnameInput.Name = "EmpSurnameInput";
            this.EmpSurnameInput.Size = new System.Drawing.Size(100, 20);
            this.EmpSurnameInput.TabIndex = 7;
            // 
            // EmpNameInput
            // 
            this.EmpNameInput.Location = new System.Drawing.Point(9, 107);
            this.EmpNameInput.Name = "EmpNameInput";
            this.EmpNameInput.Size = new System.Drawing.Size(100, 20);
            this.EmpNameInput.TabIndex = 8;
            // 
            // EmpLastNameInput
            // 
            this.EmpLastNameInput.Location = new System.Drawing.Point(147, 50);
            this.EmpLastNameInput.Name = "EmpLastNameInput";
            this.EmpLastNameInput.Size = new System.Drawing.Size(100, 20);
            this.EmpLastNameInput.TabIndex = 9;
            // 
            // EmpPositionsOpt
            // 
            this.EmpPositionsOpt.FormattingEnabled = true;
            this.EmpPositionsOpt.Items.AddRange(new object[] {
            "Тренер",
            "Администратор",
            "Менеджер"});
            this.EmpPositionsOpt.Location = new System.Drawing.Point(147, 107);
            this.EmpPositionsOpt.Name = "EmpPositionsOpt";
            this.EmpPositionsOpt.Size = new System.Drawing.Size(100, 21);
            this.EmpPositionsOpt.TabIndex = 10;
            // 
            // EmpLoginInput
            // 
            this.EmpLoginInput.Location = new System.Drawing.Point(286, 50);
            this.EmpLoginInput.Name = "EmpLoginInput";
            this.EmpLoginInput.Size = new System.Drawing.Size(100, 20);
            this.EmpLoginInput.TabIndex = 11;
            // 
            // EmpPassInput
            // 
            this.EmpPassInput.Location = new System.Drawing.Point(286, 108);
            this.EmpPassInput.Name = "EmpPassInput";
            this.EmpPassInput.Size = new System.Drawing.Size(100, 20);
            this.EmpPassInput.TabIndex = 12;
            // 
            // EmpPassConfirmInput
            // 
            this.EmpPassConfirmInput.Location = new System.Drawing.Point(419, 50);
            this.EmpPassConfirmInput.Name = "EmpPassConfirmInput";
            this.EmpPassConfirmInput.Size = new System.Drawing.Size(100, 20);
            this.EmpPassConfirmInput.TabIndex = 13;
            // 
            // EmpAddButton
            // 
            this.EmpAddButton.Location = new System.Drawing.Point(419, 107);
            this.EmpAddButton.Name = "EmpAddButton";
            this.EmpAddButton.Size = new System.Drawing.Size(75, 23);
            this.EmpAddButton.TabIndex = 14;
            this.EmpAddButton.Text = "Добавить";
            this.EmpAddButton.UseVisualStyleBackColor = true;
            this.EmpAddButton.Click += new System.EventHandler(this.EmpAddButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 527);
            this.Controls.Add(this.GuestControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивный клуб \"Олимпиец\" - Администратор";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.GuestControls.ResumeLayout(false);
            this.Events.ResumeLayout(false);
            this.DirectSearchGroup.ResumeLayout(false);
            this.DirectSearchGroup.PerformLayout();
            this.EventSortingGroup.ResumeLayout(false);
            this.EventSortingGroup.PerformLayout();
            this.EventsData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NearestEventsData)).EndInit();
            this.Sportmen.ResumeLayout(false);
            this.Direct.ResumeLayout(false);
            this.Direct.PerformLayout();
            this.SportsmenSortGroup.ResumeLayout(false);
            this.SportsmenSortGroup.PerformLayout();
            this.SportsmenDataGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpData)).EndInit();
            this.AddEmployee.ResumeLayout(false);
            this.EmpDataGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpData)).EndInit();
            this.EmpAddingGroup.ResumeLayout(false);
            this.EmpAddingGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TabPage Sportmen;
        private System.Windows.Forms.GroupBox Direct;
        private System.Windows.Forms.Button DirectSpSearchButton;
        private System.Windows.Forms.TextBox DirectSpSearchInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DirectSpSearchOpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SportsmenSortGroup;
        private System.Windows.Forms.Button ShowSortedSpButton;
        private System.Windows.Forms.ComboBox OrderSpByOpt;
        private System.Windows.Forms.Label OrderSpLabe;
        private System.Windows.Forms.ComboBox SortSpByOpt;
        private System.Windows.Forms.Label SortSpLabel;
        private System.Windows.Forms.GroupBox SportsmenDataGroup;
        private System.Windows.Forms.DataGridView SpData;
        private System.Windows.Forms.TabPage AddEmployee;
        private System.Windows.Forms.GroupBox EmpAddingGroup;
        private System.Windows.Forms.Button EmpAddButton;
        private System.Windows.Forms.TextBox EmpPassConfirmInput;
        private System.Windows.Forms.TextBox EmpPassInput;
        private System.Windows.Forms.TextBox EmpLoginInput;
        private System.Windows.Forms.ComboBox EmpPositionsOpt;
        private System.Windows.Forms.TextBox EmpLastNameInput;
        private System.Windows.Forms.TextBox EmpNameInput;
        private System.Windows.Forms.TextBox EmpSurnameInput;
        private System.Windows.Forms.Label EmpPassConfirmLabel;
        private System.Windows.Forms.Label EmpPassLabel;
        private System.Windows.Forms.Label EmpLoginLabel;
        private System.Windows.Forms.Label EmpPositionLabel;
        private System.Windows.Forms.Label EmpLastNameLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpSurnameLabel;
        private System.Windows.Forms.GroupBox EmpDataGroup;
        private System.Windows.Forms.DataGridView EmpData;
    }
}