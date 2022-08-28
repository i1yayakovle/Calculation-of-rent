namespace WindowsFormsApp1
{
    partial class Indication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indication));
            this.HaveHVS = new System.Windows.Forms.CheckBox();
            this.HaveGVS = new System.Windows.Forms.CheckBox();
            this.HaveEnergy = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Board = new System.Windows.Forms.Label();
            this.TransitionButton = new System.Windows.Forms.Button();
            this.CountHVS = new System.Windows.Forms.NumericUpDown();
            this.CountGVS = new System.Windows.Forms.NumericUpDown();
            this.CountEnergyDay = new System.Windows.Forms.NumericUpDown();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CountPeople = new System.Windows.Forms.NumericUpDown();
            this.Day = new System.Windows.Forms.Label();
            this.CountEnergyNight = new System.Windows.Forms.NumericUpDown();
            this.Night = new System.Windows.Forms.Label();
            this.CNight = new System.Windows.Forms.Label();
            this.CDay = new System.Windows.Forms.Label();
            this.EnergyNight = new System.Windows.Forms.Label();
            this.Summ = new System.Windows.Forms.Label();
            this.EnergyDay = new System.Windows.Forms.Label();
            this.GVS = new System.Windows.Forms.Label();
            this.HVS = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountHVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountGVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountEnergyDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountEnergyNight)).BeginInit();
            this.SuspendLayout();
            // 
            // HaveHVS
            // 
            this.HaveHVS.AutoSize = true;
            this.HaveHVS.BackColor = System.Drawing.Color.Transparent;
            this.HaveHVS.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HaveHVS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HaveHVS.Location = new System.Drawing.Point(260, 137);
            this.HaveHVS.MaximumSize = new System.Drawing.Size(23, 23);
            this.HaveHVS.MinimumSize = new System.Drawing.Size(23, 23);
            this.HaveHVS.Name = "HaveHVS";
            this.HaveHVS.Size = new System.Drawing.Size(23, 23);
            this.HaveHVS.TabIndex = 0;
            this.HaveHVS.UseVisualStyleBackColor = false;
            this.HaveHVS.CheckedChanged += new System.EventHandler(this.HaveHVS_CheckedChanged);
            // 
            // HaveGVS
            // 
            this.HaveGVS.AutoSize = true;
            this.HaveGVS.BackColor = System.Drawing.Color.Transparent;
            this.HaveGVS.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HaveGVS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HaveGVS.Location = new System.Drawing.Point(260, 187);
            this.HaveGVS.MaximumSize = new System.Drawing.Size(23, 23);
            this.HaveGVS.MinimumSize = new System.Drawing.Size(23, 23);
            this.HaveGVS.Name = "HaveGVS";
            this.HaveGVS.Size = new System.Drawing.Size(23, 23);
            this.HaveGVS.TabIndex = 1;
            this.HaveGVS.UseVisualStyleBackColor = false;
            this.HaveGVS.CheckedChanged += new System.EventHandler(this.HaveGVS_CheckedChanged);
            // 
            // HaveEnergy
            // 
            this.HaveEnergy.AutoSize = true;
            this.HaveEnergy.BackColor = System.Drawing.Color.Transparent;
            this.HaveEnergy.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HaveEnergy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HaveEnergy.Location = new System.Drawing.Point(260, 237);
            this.HaveEnergy.MaximumSize = new System.Drawing.Size(23, 23);
            this.HaveEnergy.MinimumSize = new System.Drawing.Size(23, 23);
            this.HaveEnergy.Name = "HaveEnergy";
            this.HaveEnergy.Size = new System.Drawing.Size(23, 23);
            this.HaveEnergy.TabIndex = 3;
            this.HaveEnergy.UseVisualStyleBackColor = false;
            this.HaveEnergy.CheckedChanged += new System.EventHandler(this.HaveEnergy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество проживающих";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наличие прибора учета ХВС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(15, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наличие прибора учета ГВС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(15, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Наличие прибора учета ЭЭ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.Board);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 56);
            this.panel1.TabIndex = 5;
            // 
            // Board
            // 
            this.Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Board.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Board.Location = new System.Drawing.Point(0, 0);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(900, 56);
            this.Board.TabIndex = 0;
            this.Board.Text = "Расчет платы за коммунальные услуги";
            this.Board.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_MouseDown);
            this.Board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_MouseMove);
            // 
            // TransitionButton
            // 
            this.TransitionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TransitionButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TransitionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionButton.FlatAppearance.BorderSize = 0;
            this.TransitionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransitionButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransitionButton.Location = new System.Drawing.Point(420, 330);
            this.TransitionButton.Name = "TransitionButton";
            this.TransitionButton.Size = new System.Drawing.Size(215, 30);
            this.TransitionButton.TabIndex = 6;
            this.TransitionButton.Text = "Расчитать текущий месяц";
            this.TransitionButton.UseCompatibleTextRendering = true;
            this.TransitionButton.UseVisualStyleBackColor = false;
            this.TransitionButton.Click += new System.EventHandler(this.TransitionButton_Click);
            // 
            // CountHVS
            // 
            this.CountHVS.DecimalPlaces = 3;
            this.CountHVS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CountHVS.Location = new System.Drawing.Point(300, 137);
            this.CountHVS.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            196608});
            this.CountHVS.Name = "CountHVS";
            this.CountHVS.Size = new System.Drawing.Size(75, 20);
            this.CountHVS.TabIndex = 7;
            this.CountHVS.Visible = false;
            // 
            // CountGVS
            // 
            this.CountGVS.DecimalPlaces = 3;
            this.CountGVS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CountGVS.Location = new System.Drawing.Point(300, 187);
            this.CountGVS.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            196608});
            this.CountGVS.Name = "CountGVS";
            this.CountGVS.Size = new System.Drawing.Size(75, 20);
            this.CountGVS.TabIndex = 8;
            this.CountGVS.Visible = false;
            // 
            // CountEnergyDay
            // 
            this.CountEnergyDay.DecimalPlaces = 2;
            this.CountEnergyDay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CountEnergyDay.Location = new System.Drawing.Point(300, 225);
            this.CountEnergyDay.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.CountEnergyDay.Name = "CountEnergyDay";
            this.CountEnergyDay.Size = new System.Drawing.Size(75, 20);
            this.CountEnergyDay.TabIndex = 8;
            this.CountEnergyDay.ThousandsSeparator = true;
            this.CountEnergyDay.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(20, 330);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CountPeople
            // 
            this.CountPeople.BackColor = System.Drawing.SystemColors.Control;
            this.CountPeople.Location = new System.Drawing.Point(260, 87);
            this.CountPeople.Name = "CountPeople";
            this.CountPeople.Size = new System.Drawing.Size(37, 20);
            this.CountPeople.TabIndex = 2;
            this.CountPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.BackColor = System.Drawing.Color.Transparent;
            this.Day.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Day.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Day.Location = new System.Drawing.Point(380, 227);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(41, 20);
            this.Day.TabIndex = 11;
            this.Day.Text = "День";
            this.Day.Visible = false;
            // 
            // CountEnergyNight
            // 
            this.CountEnergyNight.Cursor = System.Windows.Forms.Cursors.Default;
            this.CountEnergyNight.DecimalPlaces = 2;
            this.CountEnergyNight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CountEnergyNight.Location = new System.Drawing.Point(300, 255);
            this.CountEnergyNight.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.CountEnergyNight.Name = "CountEnergyNight";
            this.CountEnergyNight.Size = new System.Drawing.Size(75, 20);
            this.CountEnergyNight.TabIndex = 10;
            this.CountEnergyNight.ThousandsSeparator = true;
            this.CountEnergyNight.Visible = false;
            // 
            // Night
            // 
            this.Night.AutoSize = true;
            this.Night.BackColor = System.Drawing.Color.Transparent;
            this.Night.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Night.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Night.Location = new System.Drawing.Point(379, 257);
            this.Night.Name = "Night";
            this.Night.Size = new System.Drawing.Size(42, 20);
            this.Night.TabIndex = 12;
            this.Night.Text = "Ночь";
            this.Night.Visible = false;
            // 
            // CNight
            // 
            this.CNight.AutoSize = true;
            this.CNight.BackColor = System.Drawing.Color.Transparent;
            this.CNight.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CNight.ForeColor = System.Drawing.Color.Peru;
            this.CNight.Location = new System.Drawing.Point(690, 215);
            this.CNight.Name = "CNight";
            this.CNight.Size = new System.Drawing.Size(50, 23);
            this.CNight.TabIndex = 40;
            this.CNight.Tag = "Energy";
            this.CNight.Text = "Ночь";
            this.CNight.Visible = false;
            // 
            // CDay
            // 
            this.CDay.AutoSize = true;
            this.CDay.BackColor = System.Drawing.Color.Transparent;
            this.CDay.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CDay.ForeColor = System.Drawing.Color.Peru;
            this.CDay.Location = new System.Drawing.Point(690, 185);
            this.CDay.Name = "CDay";
            this.CDay.Size = new System.Drawing.Size(49, 23);
            this.CDay.TabIndex = 39;
            this.CDay.Tag = "Energy";
            this.CDay.Text = "День";
            this.CDay.Visible = false;
            // 
            // EnergyNight
            // 
            this.EnergyNight.AutoSize = true;
            this.EnergyNight.BackColor = System.Drawing.Color.Transparent;
            this.EnergyNight.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnergyNight.ForeColor = System.Drawing.Color.Peru;
            this.EnergyNight.Location = new System.Drawing.Point(745, 215);
            this.EnergyNight.Name = "EnergyNight";
            this.EnergyNight.Size = new System.Drawing.Size(19, 23);
            this.EnergyNight.TabIndex = 38;
            this.EnergyNight.Tag = "Energy";
            this.EnergyNight.Text = "0";
            this.EnergyNight.Visible = false;
            // 
            // Summ
            // 
            this.Summ.AutoSize = true;
            this.Summ.BackColor = System.Drawing.Color.Transparent;
            this.Summ.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summ.ForeColor = System.Drawing.Color.Peru;
            this.Summ.Location = new System.Drawing.Point(670, 250);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(19, 23);
            this.Summ.TabIndex = 37;
            this.Summ.Tag = "Summ";
            this.Summ.Text = "0";
            // 
            // EnergyDay
            // 
            this.EnergyDay.AutoSize = true;
            this.EnergyDay.BackColor = System.Drawing.Color.Transparent;
            this.EnergyDay.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnergyDay.ForeColor = System.Drawing.Color.Peru;
            this.EnergyDay.Location = new System.Drawing.Point(745, 185);
            this.EnergyDay.Name = "EnergyDay";
            this.EnergyDay.Size = new System.Drawing.Size(19, 23);
            this.EnergyDay.TabIndex = 36;
            this.EnergyDay.Tag = "Energy";
            this.EnergyDay.Text = "0";
            // 
            // GVS
            // 
            this.GVS.AutoSize = true;
            this.GVS.BackColor = System.Drawing.Color.Transparent;
            this.GVS.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GVS.ForeColor = System.Drawing.Color.Peru;
            this.GVS.Location = new System.Drawing.Point(670, 135);
            this.GVS.Name = "GVS";
            this.GVS.Size = new System.Drawing.Size(19, 23);
            this.GVS.TabIndex = 35;
            this.GVS.Tag = "GVS";
            this.GVS.Text = "0";
            // 
            // HVS
            // 
            this.HVS.AutoSize = true;
            this.HVS.BackColor = System.Drawing.Color.Transparent;
            this.HVS.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HVS.ForeColor = System.Drawing.Color.Peru;
            this.HVS.Location = new System.Drawing.Point(670, 85);
            this.HVS.Name = "HVS";
            this.HVS.Size = new System.Drawing.Size(19, 23);
            this.HVS.TabIndex = 34;
            this.HVS.Tag = "HVS";
            this.HVS.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Peru;
            this.label8.Location = new System.Drawing.Point(425, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Итоговая сумма к оплате";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Peru;
            this.label9.Location = new System.Drawing.Point(425, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Начисление за элетроенергию";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Peru;
            this.label10.Location = new System.Drawing.Point(425, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 23);
            this.label10.TabIndex = 31;
            this.label10.Text = "Начисление за ХВС";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Peru;
            this.label11.Location = new System.Drawing.Point(425, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Начисление за ГВС";
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(665, 330);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(215, 30);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Расчитать следующий месяц";
            this.NextButton.UseCompatibleTextRendering = true;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(200, 330);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 30);
            this.resetButton.TabIndex = 41;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Indication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 375);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.CNight);
            this.Controls.Add(this.CDay);
            this.Controls.Add(this.EnergyNight);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.EnergyDay);
            this.Controls.Add(this.GVS);
            this.Controls.Add(this.HVS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Night);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.CountEnergyNight);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CountEnergyDay);
            this.Controls.Add(this.CountGVS);
            this.Controls.Add(this.CountHVS);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.TransitionButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HaveEnergy);
            this.Controls.Add(this.CountPeople);
            this.Controls.Add(this.HaveGVS);
            this.Controls.Add(this.HaveHVS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Indication";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountHVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountGVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountEnergyDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountEnergyNight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Board;
        private System.Windows.Forms.Button TransitionButton;
        private System.Windows.Forms.NumericUpDown CountHVS;
        private System.Windows.Forms.NumericUpDown CountGVS;
        private System.Windows.Forms.NumericUpDown CountEnergyDay;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.NumericUpDown CountPeople;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.NumericUpDown CountEnergyNight;
        private System.Windows.Forms.Label Night;
        private System.Windows.Forms.Label CNight;
        private System.Windows.Forms.Label CDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button resetButton;
        public System.Windows.Forms.Label HVS;
        public System.Windows.Forms.Label EnergyNight;
        public System.Windows.Forms.Label Summ;
        public System.Windows.Forms.Label EnergyDay;
        public System.Windows.Forms.Label GVS;
        public System.Windows.Forms.CheckBox HaveGVS;
        public System.Windows.Forms.CheckBox HaveEnergy;
        public System.Windows.Forms.CheckBox HaveHVS;
    }
}

