
namespace Simulation_System
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridVarRange = new System.Windows.Forms.DataGridView();
            this.gridClass = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.customClasses = new System.Windows.Forms.GroupBox();
            this.checkAbnormalV = new System.Windows.Forms.CheckBox();
            this.numClasses = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.customGenerator = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Uniform = new System.Windows.Forms.RadioButton();
            this.Exponential = new System.Windows.Forms.RadioButton();
            this.Rayleigh = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rangeGeneraton = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMaxQueue = new System.Windows.Forms.NumericUpDown();
            this.numMinQueue = new System.Windows.Forms.NumericUpDown();
            this.numMaxResponse = new System.Windows.Forms.NumericUpDown();
            this.numMinResponse = new System.Windows.Forms.NumericUpDown();
            this.byHand = new System.Windows.Forms.RadioButton();
            this.byFile = new System.Windows.Forms.RadioButton();
            this.numOfRequests = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.gridRandom = new System.Windows.Forms.DataGridView();
            this.customParser = new System.Windows.Forms.GroupBox();
            this.tabProgram = new System.Windows.Forms.TabControl();
            this.tIdentification = new System.Windows.Forms.TabPage();
            this.tGenerator = new System.Windows.Forms.TabPage();
            this.genChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tResult = new System.Windows.Forms.TabPage();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVarRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).BeginInit();
            this.customClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClasses)).BeginInit();
            this.customGenerator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rangeGeneraton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRandom)).BeginInit();
            this.customParser.SuspendLayout();
            this.tabProgram.SuspendLayout();
            this.tIdentification.SuspendLayout();
            this.tGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genChart)).BeginInit();
            this.tResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(6, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(103, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(99, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Identificate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileChart
            // 
            this.fileChart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileChart.BorderlineColor = System.Drawing.SystemColors.Control;
            this.fileChart.BorderSkin.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.fileChart.ChartAreas.Add(chartArea3);
            this.fileChart.Location = new System.Drawing.Point(385, 6);
            this.fileChart.Name = "fileChart";
            this.fileChart.Size = new System.Drawing.Size(295, 420);
            this.fileChart.TabIndex = 6;
            this.fileChart.Text = "chart1";
            // 
            // gridVarRange
            // 
            this.gridVarRange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVarRange.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridVarRange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridVarRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVarRange.Location = new System.Drawing.Point(6, 103);
            this.gridVarRange.Name = "gridVarRange";
            this.gridVarRange.RowHeadersVisible = false;
            this.gridVarRange.Size = new System.Drawing.Size(371, 152);
            this.gridVarRange.TabIndex = 7;
            // 
            // gridClass
            // 
            this.gridClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridClass.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClass.Location = new System.Drawing.Point(6, 261);
            this.gridClass.Name = "gridClass";
            this.gridClass.RowHeadersVisible = false;
            this.gridClass.Size = new System.Drawing.Size(371, 170);
            this.gridClass.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сount";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.CustomClassRB_CheckedChanged);
            // 
            // customClasses
            // 
            this.customClasses.Controls.Add(this.checkAbnormalV);
            this.customClasses.Controls.Add(this.numClasses);
            this.customClasses.Controls.Add(this.radioButton2);
            this.customClasses.Controls.Add(this.radioButton1);
            this.customClasses.Controls.Add(this.button2);
            this.customClasses.Enabled = false;
            this.customClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customClasses.Location = new System.Drawing.Point(188, 6);
            this.customClasses.Name = "customClasses";
            this.customClasses.Size = new System.Drawing.Size(189, 91);
            this.customClasses.TabIndex = 11;
            this.customClasses.TabStop = false;
            this.customClasses.Text = "Custom classes";
            // 
            // checkAbnormalV
            // 
            this.checkAbnormalV.AutoSize = true;
            this.checkAbnormalV.Checked = true;
            this.checkAbnormalV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAbnormalV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAbnormalV.Location = new System.Drawing.Point(6, 65);
            this.checkAbnormalV.Name = "checkAbnormalV";
            this.checkAbnormalV.Size = new System.Drawing.Size(87, 19);
            this.checkAbnormalV.TabIndex = 13;
            this.checkAbnormalV.Text = "Abnormal";
            this.checkAbnormalV.UseVisualStyleBackColor = true;
            // 
            // numClasses
            // 
            this.numClasses.Enabled = false;
            this.numClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numClasses.Location = new System.Drawing.Point(6, 42);
            this.numClasses.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numClasses.Name = "numClasses";
            this.numClasses.Size = new System.Drawing.Size(62, 20);
            this.numClasses.TabIndex = 12;
            this.numClasses.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(102, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Auto";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.CustomClassRB_CheckedChanged);
            // 
            // customGenerator
            // 
            this.customGenerator.Controls.Add(this.button4);
            this.customGenerator.Controls.Add(this.groupBox1);
            this.customGenerator.Controls.Add(this.label7);
            this.customGenerator.Controls.Add(this.rangeGeneraton);
            this.customGenerator.Controls.Add(this.byHand);
            this.customGenerator.Controls.Add(this.byFile);
            this.customGenerator.Controls.Add(this.numOfRequests);
            this.customGenerator.Controls.Add(this.button3);
            this.customGenerator.Enabled = false;
            this.customGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customGenerator.Location = new System.Drawing.Point(19, 6);
            this.customGenerator.Name = "customGenerator";
            this.customGenerator.Size = new System.Drawing.Size(226, 422);
            this.customGenerator.TabIndex = 12;
            this.customGenerator.TabStop = false;
            this.customGenerator.Text = "Custom generator";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Normal);
            this.groupBox1.Controls.Add(this.Uniform);
            this.groupBox1.Controls.Add(this.Exponential);
            this.groupBox1.Controls.Add(this.Rayleigh);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(6, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 184);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribution";
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.BackColor = System.Drawing.Color.Transparent;
            this.Normal.ImageIndex = 0;
            this.Normal.ImageList = this.imageList1;
            this.Normal.Location = new System.Drawing.Point(6, 15);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(94, 80);
            this.Normal.TabIndex = 0;
            this.Normal.TabStop = true;
            this.Normal.UseVisualStyleBackColor = false;
            this.Normal.CheckedChanged += new System.EventHandler(this.CustomGeneratorRB_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Normal.png");
            this.imageList1.Images.SetKeyName(1, "Exponential.png");
            this.imageList1.Images.SetKeyName(2, "Uniform.png");
            this.imageList1.Images.SetKeyName(3, "Reyleigh.png");
            // 
            // Uniform
            // 
            this.Uniform.AutoSize = true;
            this.Uniform.ImageIndex = 2;
            this.Uniform.ImageList = this.imageList1;
            this.Uniform.Location = new System.Drawing.Point(114, 15);
            this.Uniform.Name = "Uniform";
            this.Uniform.Size = new System.Drawing.Size(94, 80);
            this.Uniform.TabIndex = 2;
            this.Uniform.TabStop = true;
            this.Uniform.UseVisualStyleBackColor = true;
            this.Uniform.CheckedChanged += new System.EventHandler(this.CustomGeneratorRB_CheckedChanged);
            // 
            // Exponential
            // 
            this.Exponential.AutoSize = true;
            this.Exponential.ImageIndex = 1;
            this.Exponential.ImageList = this.imageList1;
            this.Exponential.Location = new System.Drawing.Point(8, 98);
            this.Exponential.Name = "Exponential";
            this.Exponential.Size = new System.Drawing.Size(94, 80);
            this.Exponential.TabIndex = 1;
            this.Exponential.TabStop = true;
            this.Exponential.UseVisualStyleBackColor = true;
            this.Exponential.CheckedChanged += new System.EventHandler(this.CustomGeneratorRB_CheckedChanged);
            // 
            // Rayleigh
            // 
            this.Rayleigh.AutoSize = true;
            this.Rayleigh.ImageIndex = 3;
            this.Rayleigh.ImageList = this.imageList1;
            this.Rayleigh.Location = new System.Drawing.Point(114, 98);
            this.Rayleigh.Name = "Rayleigh";
            this.Rayleigh.Size = new System.Drawing.Size(94, 80);
            this.Rayleigh.TabIndex = 3;
            this.Rayleigh.TabStop = true;
            this.Rayleigh.UseVisualStyleBackColor = true;
            this.Rayleigh.CheckedChanged += new System.EventHandler(this.CustomGeneratorRB_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Number of requests";
            // 
            // rangeGeneraton
            // 
            this.rangeGeneraton.Controls.Add(this.label6);
            this.rangeGeneraton.Controls.Add(this.label5);
            this.rangeGeneraton.Controls.Add(this.label4);
            this.rangeGeneraton.Controls.Add(this.label3);
            this.rangeGeneraton.Controls.Add(this.label2);
            this.rangeGeneraton.Controls.Add(this.label1);
            this.rangeGeneraton.Controls.Add(this.numMaxQueue);
            this.rangeGeneraton.Controls.Add(this.numMinQueue);
            this.rangeGeneraton.Controls.Add(this.numMaxResponse);
            this.rangeGeneraton.Controls.Add(this.numMinResponse);
            this.rangeGeneraton.Enabled = false;
            this.rangeGeneraton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeGeneraton.Location = new System.Drawing.Point(6, 43);
            this.rangeGeneraton.Name = "rangeGeneraton";
            this.rangeGeneraton.Size = new System.Drawing.Size(214, 117);
            this.rangeGeneraton.TabIndex = 16;
            this.rangeGeneraton.TabStop = false;
            this.rangeGeneraton.Text = "Range generation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Queue time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Response time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(117, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(117, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // numMaxQueue
            // 
            this.numMaxQueue.DecimalPlaces = 1;
            this.numMaxQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMaxQueue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMaxQueue.Location = new System.Drawing.Point(145, 87);
            this.numMaxQueue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxQueue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMaxQueue.Name = "numMaxQueue";
            this.numMaxQueue.Size = new System.Drawing.Size(48, 20);
            this.numMaxQueue.TabIndex = 3;
            this.numMaxQueue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMinQueue
            // 
            this.numMinQueue.DecimalPlaces = 1;
            this.numMinQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMinQueue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMinQueue.Location = new System.Drawing.Point(54, 87);
            this.numMinQueue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinQueue.Name = "numMinQueue";
            this.numMinQueue.Size = new System.Drawing.Size(48, 20);
            this.numMinQueue.TabIndex = 2;
            this.numMinQueue.ValueChanged += new System.EventHandler(this.numMinQueue_ValueChanged);
            // 
            // numMaxResponse
            // 
            this.numMaxResponse.DecimalPlaces = 1;
            this.numMaxResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMaxResponse.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMaxResponse.Location = new System.Drawing.Point(145, 40);
            this.numMaxResponse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxResponse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMaxResponse.Name = "numMaxResponse";
            this.numMaxResponse.Size = new System.Drawing.Size(48, 20);
            this.numMaxResponse.TabIndex = 1;
            this.numMaxResponse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMinResponse
            // 
            this.numMinResponse.DecimalPlaces = 1;
            this.numMinResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMinResponse.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMinResponse.Location = new System.Drawing.Point(54, 40);
            this.numMinResponse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinResponse.Name = "numMinResponse";
            this.numMinResponse.Size = new System.Drawing.Size(48, 20);
            this.numMinResponse.TabIndex = 0;
            this.numMinResponse.ValueChanged += new System.EventHandler(this.numMinResponse_ValueChanged);
            // 
            // byHand
            // 
            this.byHand.AutoSize = true;
            this.byHand.Enabled = false;
            this.byHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byHand.Location = new System.Drawing.Point(117, 20);
            this.byHand.Name = "byHand";
            this.byHand.Size = new System.Drawing.Size(76, 19);
            this.byHand.TabIndex = 15;
            this.byHand.Text = "By hand";
            this.byHand.UseVisualStyleBackColor = true;
            this.byHand.CheckedChanged += new System.EventHandler(this.byHand_CheckedChanged);
            // 
            // byFile
            // 
            this.byFile.AutoSize = true;
            this.byFile.Enabled = false;
            this.byFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byFile.Location = new System.Drawing.Point(6, 20);
            this.byFile.Name = "byFile";
            this.byFile.Size = new System.Drawing.Size(64, 19);
            this.byFile.TabIndex = 14;
            this.byFile.Text = "By file";
            this.byFile.UseVisualStyleBackColor = true;
            this.byFile.CheckedChanged += new System.EventHandler(this.byHand_CheckedChanged);
            // 
            // numOfRequests
            // 
            this.numOfRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfRequests.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOfRequests.Location = new System.Drawing.Point(26, 374);
            this.numOfRequests.Maximum = new decimal(new int[] {
            70000,
            0,
            0,
            0});
            this.numOfRequests.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOfRequests.Name = "numOfRequests";
            this.numOfRequests.Size = new System.Drawing.Size(82, 20);
            this.numOfRequests.TabIndex = 13;
            this.numOfRequests.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(145, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridRandom
            // 
            this.gridRandom.AllowUserToDeleteRows = false;
            this.gridRandom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRandom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridRandom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRandom.Location = new System.Drawing.Point(251, 6);
            this.gridRandom.Name = "gridRandom";
            this.gridRandom.ReadOnly = true;
            this.gridRandom.RowHeadersVisible = false;
            this.gridRandom.Size = new System.Drawing.Size(149, 422);
            this.gridRandom.TabIndex = 14;
            // 
            // customParser
            // 
            this.customParser.Controls.Add(this.comboBox1);
            this.customParser.Controls.Add(this.button1);
            this.customParser.Enabled = false;
            this.customParser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customParser.Location = new System.Drawing.Point(6, 6);
            this.customParser.Name = "customParser";
            this.customParser.Size = new System.Drawing.Size(176, 91);
            this.customParser.TabIndex = 15;
            this.customParser.TabStop = false;
            this.customParser.Text = "Custom parser";
            // 
            // tabProgram
            // 
            this.tabProgram.Controls.Add(this.tIdentification);
            this.tabProgram.Controls.Add(this.tGenerator);
            this.tabProgram.Controls.Add(this.tResult);
            this.tabProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProgram.Location = new System.Drawing.Point(0, 24);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.SelectedIndex = 0;
            this.tabProgram.Size = new System.Drawing.Size(697, 460);
            this.tabProgram.TabIndex = 16;
            // 
            // tIdentification
            // 
            this.tIdentification.BackColor = System.Drawing.SystemColors.Control;
            this.tIdentification.Controls.Add(this.customParser);
            this.tIdentification.Controls.Add(this.customClasses);
            this.tIdentification.Controls.Add(this.gridVarRange);
            this.tIdentification.Controls.Add(this.fileChart);
            this.tIdentification.Controls.Add(this.gridClass);
            this.tIdentification.Location = new System.Drawing.Point(4, 22);
            this.tIdentification.Name = "tIdentification";
            this.tIdentification.Padding = new System.Windows.Forms.Padding(3);
            this.tIdentification.Size = new System.Drawing.Size(689, 434);
            this.tIdentification.TabIndex = 0;
            this.tIdentification.Text = "Distribution identification";
            // 
            // tGenerator
            // 
            this.tGenerator.BackColor = System.Drawing.SystemColors.Control;
            this.tGenerator.Controls.Add(this.genChart);
            this.tGenerator.Controls.Add(this.customGenerator);
            this.tGenerator.Controls.Add(this.gridRandom);
            this.tGenerator.Location = new System.Drawing.Point(4, 22);
            this.tGenerator.Name = "tGenerator";
            this.tGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tGenerator.Size = new System.Drawing.Size(689, 434);
            this.tGenerator.TabIndex = 1;
            this.tGenerator.Text = "Generator";
            // 
            // genChart
            // 
            this.genChart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea4.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.genChart.ChartAreas.Add(chartArea4);
            this.genChart.Location = new System.Drawing.Point(406, 6);
            this.genChart.Name = "genChart";
            this.genChart.Size = new System.Drawing.Size(277, 420);
            this.genChart.TabIndex = 15;
            this.genChart.Text = "chart2";
            // 
            // tResult
            // 
            this.tResult.BackColor = System.Drawing.SystemColors.Control;
            this.tResult.Controls.Add(this.gridResult);
            this.tResult.Location = new System.Drawing.Point(4, 22);
            this.tResult.Name = "tResult";
            this.tResult.Size = new System.Drawing.Size(689, 434);
            this.tResult.TabIndex = 2;
            this.tResult.Text = "Result";
            // 
            // gridResult
            // 
            this.gridResult.AllowUserToAddRows = false;
            this.gridResult.AllowUserToDeleteRows = false;
            this.gridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResult.Location = new System.Drawing.Point(0, 0);
            this.gridResult.Name = "gridResult";
            this.gridResult.RowHeadersVisible = false;
            this.gridResult.Size = new System.Drawing.Size(689, 434);
            this.gridResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 484);
            this.Controls.Add(this.tabProgram);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Diploma project (Yehor Zahnii)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVarRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).EndInit();
            this.customClasses.ResumeLayout(false);
            this.customClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClasses)).EndInit();
            this.customGenerator.ResumeLayout(false);
            this.customGenerator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rangeGeneraton.ResumeLayout(false);
            this.rangeGeneraton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRandom)).EndInit();
            this.customParser.ResumeLayout(false);
            this.tabProgram.ResumeLayout(false);
            this.tIdentification.ResumeLayout(false);
            this.tGenerator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genChart)).EndInit();
            this.tResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart fileChart;
        private System.Windows.Forms.DataGridView gridVarRange;
        private System.Windows.Forms.DataGridView gridClass;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox customClasses;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox customGenerator;
        private System.Windows.Forms.RadioButton Rayleigh;
        private System.Windows.Forms.RadioButton Uniform;
        private System.Windows.Forms.RadioButton Exponential;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.NumericUpDown numOfRequests;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView gridRandom;
        private System.Windows.Forms.GroupBox customParser;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabProgram;
        private System.Windows.Forms.TabPage tIdentification;
        private System.Windows.Forms.TabPage tGenerator;
        private System.Windows.Forms.RadioButton byHand;
        private System.Windows.Forms.RadioButton byFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart genChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox rangeGeneraton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMaxQueue;
        private System.Windows.Forms.NumericUpDown numMinQueue;
        private System.Windows.Forms.NumericUpDown numMaxResponse;
        private System.Windows.Forms.NumericUpDown numMinResponse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numClasses;
        private System.Windows.Forms.CheckBox checkAbnormalV;
        private System.Windows.Forms.TabPage tResult;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.Button button4;
    }
}

