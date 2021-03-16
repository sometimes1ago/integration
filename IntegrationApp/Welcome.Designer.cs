namespace IntegrationApp
{
    partial class Welcome
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ToAuthLink = new System.Windows.Forms.LinkLabel();
            this.GuestControls = new System.Windows.Forms.TabControl();
            this.Events = new System.Windows.Forms.TabPage();
            this.DirectSearchGroup = new System.Windows.Forms.GroupBox();
            this.DirectSearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DirectSearchValueLabel = new System.Windows.Forms.Label();
            this.SearchByOpt = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.EventSortingGroup = new System.Windows.Forms.GroupBox();
            this.ShowSortedEvtButton = new System.Windows.Forms.Button();
            this.DateRangeLabelTo = new System.Windows.Forms.Label();
            this.DateTo = new System.Windows.Forms.TextBox();
            this.DateFrom = new System.Windows.Forms.TextBox();
            this.DateRangeLabelFrom = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OrderEvtLabel = new System.Windows.Forms.Label();
            this.SortEvtOpt = new System.Windows.Forms.ComboBox();
            this.SortEvtLabel = new System.Windows.Forms.Label();
            this.EventsData = new System.Windows.Forms.GroupBox();
            this.NearestEventsData = new System.Windows.Forms.DataGridView();
            this.Sportmen = new System.Windows.Forms.TabPage();
            this.Direct = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.WelcomeLabel.Location = new System.Drawing.Point(180, 25);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(454, 67);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Добро пожаловать в спортивный клуб \"Олимпиец\"";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToAuthLink
            // 
            this.ToAuthLink.AutoSize = true;
            this.ToAuthLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ToAuthLink.Location = new System.Drawing.Point(763, 55);
            this.ToAuthLink.Name = "ToAuthLink";
            this.ToAuthLink.Size = new System.Drawing.Size(43, 15);
            this.ToAuthLink.TabIndex = 1;
            this.ToAuthLink.TabStop = true;
            this.ToAuthLink.Text = "Войти";
            this.ToAuthLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToAuthLink_LinkClicked);
            // 
            // GuestControls
            // 
            this.GuestControls.Controls.Add(this.Events);
            this.GuestControls.Controls.Add(this.Sportmen);
            this.GuestControls.Location = new System.Drawing.Point(12, 123);
            this.GuestControls.Name = "GuestControls";
            this.GuestControls.SelectedIndex = 0;
            this.GuestControls.Size = new System.Drawing.Size(810, 437);
            this.GuestControls.TabIndex = 2;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.DirectSearchGroup);
            this.Events.Controls.Add(this.EventSortingGroup);
            this.Events.Controls.Add(this.EventsData);
            this.Events.Location = new System.Drawing.Point(4, 22);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(802, 411);
            this.Events.TabIndex = 0;
            this.Events.Text = "Мероприятия";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // DirectSearchGroup
            // 
            this.DirectSearchGroup.Controls.Add(this.DirectSearchButton);
            this.DirectSearchGroup.Controls.Add(this.textBox1);
            this.DirectSearchGroup.Controls.Add(this.DirectSearchValueLabel);
            this.DirectSearchGroup.Controls.Add(this.SearchByOpt);
            this.DirectSearchGroup.Controls.Add(this.SearchByLabel);
            this.DirectSearchGroup.Location = new System.Drawing.Point(416, 238);
            this.DirectSearchGroup.Name = "DirectSearchGroup";
            this.DirectSearchGroup.Size = new System.Drawing.Size(374, 167);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 5;
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
            this.EventSortingGroup.Controls.Add(this.ShowSortedEvtButton);
            this.EventSortingGroup.Controls.Add(this.DateRangeLabelTo);
            this.EventSortingGroup.Controls.Add(this.DateTo);
            this.EventSortingGroup.Controls.Add(this.DateFrom);
            this.EventSortingGroup.Controls.Add(this.DateRangeLabelFrom);
            this.EventSortingGroup.Controls.Add(this.comboBox1);
            this.EventSortingGroup.Controls.Add(this.OrderEvtLabel);
            this.EventSortingGroup.Controls.Add(this.SortEvtOpt);
            this.EventSortingGroup.Controls.Add(this.SortEvtLabel);
            this.EventSortingGroup.Location = new System.Drawing.Point(6, 238);
            this.EventSortingGroup.Name = "EventSortingGroup";
            this.EventSortingGroup.Size = new System.Drawing.Size(393, 167);
            this.EventSortingGroup.TabIndex = 4;
            this.EventSortingGroup.TabStop = false;
            this.EventSortingGroup.Text = "Сортировка";
            // 
            // ShowSortedEvtButton
            // 
            this.ShowSortedEvtButton.Location = new System.Drawing.Point(273, 106);
            this.ShowSortedEvtButton.Name = "ShowSortedEvtButton";
            this.ShowSortedEvtButton.Size = new System.Drawing.Size(95, 23);
            this.ShowSortedEvtButton.TabIndex = 8;
            this.ShowSortedEvtButton.Text = "Показать";
            this.ShowSortedEvtButton.UseVisualStyleBackColor = true;
            // 
            // DateRangeLabelTo
            // 
            this.DateRangeLabelTo.AutoSize = true;
            this.DateRangeLabelTo.Location = new System.Drawing.Point(176, 111);
            this.DateRangeLabelTo.Name = "DateRangeLabelTo";
            this.DateRangeLabelTo.Size = new System.Drawing.Size(19, 13);
            this.DateRangeLabelTo.TabIndex = 7;
            this.DateRangeLabelTo.Text = "до";
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(208, 107);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(46, 20);
            this.DateTo.TabIndex = 6;
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(120, 108);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(46, 20);
            this.DateFrom.TabIndex = 5;
            // 
            // DateRangeLabelFrom
            // 
            this.DateRangeLabelFrom.AutoSize = true;
            this.DateRangeLabelFrom.Location = new System.Drawing.Point(17, 111);
            this.DateRangeLabelFrom.Name = "DateRangeLabelFrom";
            this.DateRangeLabelFrom.Size = new System.Drawing.Size(97, 13);
            this.DateRangeLabelFrom.TabIndex = 4;
            this.DateRangeLabelFrom.Text = "Диапазон дат. От";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 3;
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
            this.EventsData.Size = new System.Drawing.Size(790, 226);
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
            this.NearestEventsData.Size = new System.Drawing.Size(778, 201);
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
            this.Sportmen.Size = new System.Drawing.Size(802, 411);
            this.Sportmen.TabIndex = 1;
            this.Sportmen.Text = "Спортсмены";
            this.Sportmen.UseVisualStyleBackColor = true;
            // 
            // Direct
            // 
            this.Direct.Controls.Add(this.button1);
            this.Direct.Controls.Add(this.textBox2);
            this.Direct.Controls.Add(this.label1);
            this.Direct.Controls.Add(this.comboBox2);
            this.Direct.Controls.Add(this.label2);
            this.Direct.Location = new System.Drawing.Point(296, 262);
            this.Direct.Name = "Direct";
            this.Direct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Direct.Size = new System.Drawing.Size(280, 141);
            this.Direct.TabIndex = 7;
            this.Direct.TabStop = false;
            this.Direct.Text = "Прямой поиск";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 5;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 21);
            this.comboBox2.TabIndex = 3;
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
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 572);
            this.Controls.Add(this.GuestControls);
            this.Controls.Add(this.ToAuthLink);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.Text = "Добро пожаловать";
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.LinkLabel ToAuthLink;
        private System.Windows.Forms.TabControl GuestControls;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.GroupBox DirectSearchGroup;
        private System.Windows.Forms.ComboBox SearchByOpt;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.GroupBox EventSortingGroup;
        private System.Windows.Forms.Button ShowSortedEvtButton;
        private System.Windows.Forms.Label DateRangeLabelTo;
        private System.Windows.Forms.TextBox DateTo;
        private System.Windows.Forms.TextBox DateFrom;
        private System.Windows.Forms.Label DateRangeLabelFrom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label OrderEvtLabel;
        private System.Windows.Forms.ComboBox SortEvtOpt;
        private System.Windows.Forms.Label SortEvtLabel;
        private System.Windows.Forms.GroupBox EventsData;
        private System.Windows.Forms.DataGridView NearestEventsData;
        private System.Windows.Forms.TabPage Sportmen;
        private System.Windows.Forms.Button DirectSearchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DirectSearchValueLabel;
        private System.Windows.Forms.GroupBox SportsmenDataGroup;
        private System.Windows.Forms.GroupBox Direct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SportsmenSortGroup;
        private System.Windows.Forms.Button ShowSortedSpButton;
        private System.Windows.Forms.ComboBox OrderSpByOpt;
        private System.Windows.Forms.Label OrderSpLabe;
        private System.Windows.Forms.ComboBox SortSpByOpt;
        private System.Windows.Forms.Label SortSpLabel;
        private System.Windows.Forms.DataGridView SpData;
    }
}

