namespace Sc
{
    partial class Scanner
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.firstSplit = new System.Windows.Forms.SplitContainer();
			this.gBBoxlist = new System.Windows.Forms.GroupBox();
			this.lstPorts = new System.Windows.Forms.ListView();
			this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Protocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StatePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gBoxGeneral = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBoxBeetw = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numList2 = new System.Windows.Forms.NumericUpDown();
			this.lblMin = new System.Windows.Forms.Label();
			this.numList1 = new System.Windows.Forms.NumericUpDown();
			this.gBoxStart = new System.Windows.Forms.GroupBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.btnScan = new System.Windows.Forms.Button();
			this.gBoxPorts = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chBoxUdp = new System.Windows.Forms.CheckBox();
			this.chBoxTcp = new System.Windows.Forms.CheckBox();
			this.gBoxAutoSelect = new System.Windows.Forms.GroupBox();
			this.txtBoxIP = new System.Windows.Forms.TextBox();
			this.lblIP = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.firstSplit)).BeginInit();
			this.firstSplit.Panel1.SuspendLayout();
			this.firstSplit.Panel2.SuspendLayout();
			this.firstSplit.SuspendLayout();
			this.gBBoxlist.SuspendLayout();
			this.gBoxGeneral.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numList2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numList1)).BeginInit();
			this.gBoxStart.SuspendLayout();
			this.gBoxPorts.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gBoxAutoSelect.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// firstSplit
			// 
			this.firstSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.firstSplit.IsSplitterFixed = true;
			this.firstSplit.Location = new System.Drawing.Point(0, 24);
			this.firstSplit.Name = "firstSplit";
			// 
			// firstSplit.Panel1
			// 
			this.firstSplit.Panel1.Controls.Add(this.gBBoxlist);
			// 
			// firstSplit.Panel2
			// 
			this.firstSplit.Panel2.Controls.Add(this.gBoxGeneral);
			this.firstSplit.Size = new System.Drawing.Size(836, 427);
			this.firstSplit.SplitterDistance = 510;
			this.firstSplit.TabIndex = 1;
			// 
			// gBBoxlist
			// 
			this.gBBoxlist.Controls.Add(this.lstPorts);
			this.gBBoxlist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gBBoxlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gBBoxlist.Location = new System.Drawing.Point(0, 0);
			this.gBBoxlist.Name = "gBBoxlist";
			this.gBBoxlist.Size = new System.Drawing.Size(510, 427);
			this.gBBoxlist.TabIndex = 0;
			this.gBBoxlist.TabStop = false;
			this.gBBoxlist.Text = "Список портов:";
			// 
			// lstPorts
			// 
			this.lstPorts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Protocol,
            this.StatePort,
            this.Process});
			this.lstPorts.Cursor = System.Windows.Forms.Cursors.Default;
			this.lstPorts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstPorts.FullRowSelect = true;
			this.lstPorts.Location = new System.Drawing.Point(3, 18);
			this.lstPorts.Name = "lstPorts";
			this.lstPorts.Size = new System.Drawing.Size(504, 406);
			this.lstPorts.TabIndex = 0;
			this.lstPorts.UseCompatibleStateImageBehavior = false;
			this.lstPorts.View = System.Windows.Forms.View.Details;
			// 
			// Index
			// 
			this.Index.Text = "№ порта";
			this.Index.Width = 72;
			// 
			// Protocol
			// 
			this.Protocol.Text = "Тип протокола";
			this.Protocol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Protocol.Width = 112;
			// 
			// StatePort
			// 
			this.StatePort.Text = "Состояние порта";
			this.StatePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.StatePort.Width = 108;
			// 
			// Process
			// 
			this.Process.Text = "Процесс";
			this.Process.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Process.Width = 200;
			// 
			// gBoxGeneral
			// 
			this.gBoxGeneral.Controls.Add(this.groupBox2);
			this.gBoxGeneral.Controls.Add(this.gBoxStart);
			this.gBoxGeneral.Controls.Add(this.gBoxPorts);
			this.gBoxGeneral.Controls.Add(this.gBoxAutoSelect);
			this.gBoxGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gBoxGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gBoxGeneral.Location = new System.Drawing.Point(0, 0);
			this.gBoxGeneral.Name = "gBoxGeneral";
			this.gBoxGeneral.Size = new System.Drawing.Size(322, 427);
			this.gBoxGeneral.TabIndex = 0;
			this.gBoxGeneral.TabStop = false;
			this.gBoxGeneral.Text = "Панель управления:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxBeetw);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.numList2);
			this.groupBox2.Controls.Add(this.lblMin);
			this.groupBox2.Controls.Add(this.numList1);
			this.groupBox2.Location = new System.Drawing.Point(6, 233);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(309, 106);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Диапазон портов:";
			// 
			// comboBoxBeetw
			// 
			this.comboBoxBeetw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBeetw.FormattingEnabled = true;
			this.comboBoxBeetw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboBoxBeetw.Items.AddRange(new object[] {
            "Диапазон открытых портов",
            "Поиск открытых портов"});
			this.comboBoxBeetw.Location = new System.Drawing.Point(10, 21);
			this.comboBoxBeetw.Name = "comboBoxBeetw";
			this.comboBoxBeetw.Size = new System.Drawing.Size(287, 24);
			this.comboBoxBeetw.TabIndex = 9;
			this.comboBoxBeetw.SelectedIndexChanged += new System.EventHandler(this.comboBoxBeetw_SelectedIndexChanged);
			this.comboBoxBeetw.TextUpdate += new System.EventHandler(this.comboBoxBeetw_TextUpdate);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(198, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "-";
			// 
			// numList2
			// 
			this.numList2.Location = new System.Drawing.Point(213, 62);
			this.numList2.Maximum = new decimal(new int[] {
            65635,
            0,
            0,
            0});
			this.numList2.Name = "numList2";
			this.numList2.Size = new System.Drawing.Size(81, 22);
			this.numList2.TabIndex = 7;
			this.numList2.Value = new decimal(new int[] {
            65635,
            0,
            0,
            0});
			// 
			// lblMin
			// 
			this.lblMin.AutoSize = true;
			this.lblMin.Location = new System.Drawing.Point(15, 65);
			this.lblMin.Name = "lblMin";
			this.lblMin.Size = new System.Drawing.Size(76, 16);
			this.lblMin.TabIndex = 3;
			this.lblMin.Text = "Диапазон:";
			// 
			// numList1
			// 
			this.numList1.Location = new System.Drawing.Point(114, 62);
			this.numList1.Maximum = new decimal(new int[] {
            65635,
            0,
            0,
            0});
			this.numList1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numList1.Name = "numList1";
			this.numList1.Size = new System.Drawing.Size(81, 22);
			this.numList1.TabIndex = 6;
			this.numList1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// gBoxStart
			// 
			this.gBoxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gBoxStart.Controls.Add(this.buttonClear);
			this.gBoxStart.Controls.Add(this.btnScan);
			this.gBoxStart.Location = new System.Drawing.Point(6, 349);
			this.gBoxStart.Name = "gBoxStart";
			this.gBoxStart.Size = new System.Drawing.Size(308, 70);
			this.gBoxStart.TabIndex = 2;
			this.gBoxStart.TabStop = false;
			this.gBoxStart.Text = "Запуск сканирования:";
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(177, 21);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(117, 33);
			this.buttonClear.TabIndex = 1;
			this.buttonClear.Text = "Очистить";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// btnScan
			// 
			this.btnScan.Location = new System.Drawing.Point(18, 21);
			this.btnScan.Name = "btnScan";
			this.btnScan.Size = new System.Drawing.Size(117, 33);
			this.btnScan.TabIndex = 0;
			this.btnScan.Text = "Сканировать";
			this.btnScan.UseVisualStyleBackColor = true;
			this.btnScan.Click += new System.EventHandler(this.button1_Click);
			// 
			// gBoxPorts
			// 
			this.gBoxPorts.Controls.Add(this.groupBox1);
			this.gBoxPorts.Location = new System.Drawing.Point(7, 115);
			this.gBoxPorts.Name = "gBoxPorts";
			this.gBoxPorts.Size = new System.Drawing.Size(308, 106);
			this.gBoxPorts.TabIndex = 1;
			this.gBoxPorts.TabStop = false;
			this.gBoxPorts.Text = "Порты:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chBoxUdp);
			this.groupBox1.Controls.Add(this.chBoxTcp);
			this.groupBox1.Location = new System.Drawing.Point(7, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 77);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Типы портов:";
			// 
			// chBoxUdp
			// 
			this.chBoxUdp.AutoSize = true;
			this.chBoxUdp.Location = new System.Drawing.Point(20, 47);
			this.chBoxUdp.Name = "chBoxUdp";
			this.chBoxUdp.Size = new System.Drawing.Size(99, 20);
			this.chBoxUdp.TabIndex = 4;
			this.chBoxUdp.Text = "UDP порты";
			this.chBoxUdp.UseVisualStyleBackColor = true;
			// 
			// chBoxTcp
			// 
			this.chBoxTcp.AutoSize = true;
			this.chBoxTcp.Checked = true;
			this.chBoxTcp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chBoxTcp.Location = new System.Drawing.Point(20, 21);
			this.chBoxTcp.Name = "chBoxTcp";
			this.chBoxTcp.Size = new System.Drawing.Size(97, 20);
			this.chBoxTcp.TabIndex = 3;
			this.chBoxTcp.Text = "TCP порты";
			this.chBoxTcp.UseVisualStyleBackColor = true;
			// 
			// gBoxAutoSelect
			// 
			this.gBoxAutoSelect.Controls.Add(this.txtBoxIP);
			this.gBoxAutoSelect.Controls.Add(this.lblIP);
			this.gBoxAutoSelect.Location = new System.Drawing.Point(6, 21);
			this.gBoxAutoSelect.Name = "gBoxAutoSelect";
			this.gBoxAutoSelect.Size = new System.Drawing.Size(309, 88);
			this.gBoxAutoSelect.TabIndex = 0;
			this.gBoxAutoSelect.TabStop = false;
			this.gBoxAutoSelect.Text = "Выбор станции для сканирования:";
			// 
			// txtBoxIP
			// 
			this.txtBoxIP.Location = new System.Drawing.Point(7, 48);
			this.txtBoxIP.Name = "txtBoxIP";
			this.txtBoxIP.Size = new System.Drawing.Size(290, 22);
			this.txtBoxIP.TabIndex = 3;
			// 
			// lblIP
			// 
			this.lblIP.AutoSize = true;
			this.lblIP.Location = new System.Drawing.Point(6, 29);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(66, 16);
			this.lblIP.TabIndex = 2;
			this.lblIP.Text = "IP-адрес:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(836, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьТаблицуToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// сохранитьТаблицуToolStripMenuItem
			// 
			this.сохранитьТаблицуToolStripMenuItem.Name = "сохранитьТаблицуToolStripMenuItem";
			this.сохранитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
			this.сохранитьТаблицуToolStripMenuItem.Text = "Сохранить результаты сканирования...";
			this.сохранитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТаблицуToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Scanner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 451);
			this.Controls.Add(this.firstSplit);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Scanner";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Сканер портов";
			this.firstSplit.Panel1.ResumeLayout(false);
			this.firstSplit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.firstSplit)).EndInit();
			this.firstSplit.ResumeLayout(false);
			this.gBBoxlist.ResumeLayout(false);
			this.gBoxGeneral.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numList2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numList1)).EndInit();
			this.gBoxStart.ResumeLayout(false);
			this.gBoxPorts.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gBoxAutoSelect.ResumeLayout(false);
			this.gBoxAutoSelect.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer firstSplit;
        private System.Windows.Forms.GroupBox gBBoxlist;
		private System.Windows.Forms.GroupBox gBoxGeneral;
        private System.Windows.Forms.NumericUpDown numList2;
		private System.Windows.Forms.NumericUpDown numList1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.GroupBox gBoxAutoSelect;
        private System.Windows.Forms.TextBox txtBoxIP;
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.GroupBox gBoxStart;
        private System.Windows.Forms.Button btnScan;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstPorts;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Protocol;
        private System.Windows.Forms.ColumnHeader StatePort;
		private System.Windows.Forms.ColumnHeader Process;
		private System.Windows.Forms.ComboBox comboBoxBeetw;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gBoxPorts;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chBoxUdp;
		private System.Windows.Forms.CheckBox chBoxTcp;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьТаблицуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonClear;

    }
}

