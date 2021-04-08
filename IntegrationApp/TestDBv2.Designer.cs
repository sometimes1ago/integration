namespace IntegrationApp
{
    partial class TestDBv2
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
            this.SuspendLayout();
            // 
            // GuestControls
            // 
            this.GuestControls.Controls.Add(this.Events);
            this.GuestControls.Controls.Add(this.Sportmen);
            this.GuestControls.Location = new System.Drawing.Point(12, 12);
            this.GuestControls.Name = "GuestControls";
            this.GuestControls.SelectedIndex = 0;
            this.GuestControls.Size = new System.Drawing.Size(686, 419);
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
            this.Events.Size = new System.Drawing.Size(678, 393);
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
            this.NearestEventsData.Location = new System.Drawing.Point(-10, 25);
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
            this.Sportmen.Size = new System.Drawing.Size(678, 393);
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
            // TestDBv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuestControls);
            this.Name = "TestDBv2";
            this.Text = "TestDBv2";
            this.Load += new System.EventHandler(this.TestDBv2_Load);
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
    }
}