namespace UltraAutoClicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursCounter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.minutesCounter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.secondsCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.millisecondsCounter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.randomizerCount = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clickTypeSelector = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mouseButtonSelector = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.yCoordinateSelector = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.xCoordinateSelector = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hoursCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomizerCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinateSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinateSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours";
            // 
            // hoursCounter
            // 
            this.hoursCounter.Location = new System.Drawing.Point(49, 19);
            this.hoursCounter.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.hoursCounter.Name = "hoursCounter";
            this.hoursCounter.Size = new System.Drawing.Size(53, 20);
            this.hoursCounter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutes";
            // 
            // minutesCounter
            // 
            this.minutesCounter.Location = new System.Drawing.Point(158, 19);
            this.minutesCounter.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesCounter.Name = "minutesCounter";
            this.minutesCounter.Size = new System.Drawing.Size(53, 20);
            this.minutesCounter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seconds";
            // 
            // secondsCounter
            // 
            this.secondsCounter.Location = new System.Drawing.Point(272, 19);
            this.secondsCounter.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsCounter.Name = "secondsCounter";
            this.secondsCounter.Size = new System.Drawing.Size(53, 20);
            this.secondsCounter.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Milliseconds";
            // 
            // millisecondsCounter
            // 
            this.millisecondsCounter.Location = new System.Drawing.Point(401, 19);
            this.millisecondsCounter.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.millisecondsCounter.Name = "millisecondsCounter";
            this.millisecondsCounter.Size = new System.Drawing.Size(53, 20);
            this.millisecondsCounter.TabIndex = 7;
            this.millisecondsCounter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Randomize ±";
            // 
            // randomizerCount
            // 
            this.randomizerCount.Location = new System.Drawing.Point(82, 64);
            this.randomizerCount.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.randomizerCount.Name = "randomizerCount";
            this.randomizerCount.Size = new System.Drawing.Size(53, 20);
            this.randomizerCount.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Milliseconds",
            "Seconds",
            "Minutes",
            "Hours"});
            this.comboBox1.Location = new System.Drawing.Point(141, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hoursCounter);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.randomizerCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.minutesCounter);
            this.groupBox1.Controls.Add(this.millisecondsCounter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.secondsCounter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 103);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click interval";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clickTypeSelector);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mouseButtonSelector);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click options";
            // 
            // clickTypeSelector
            // 
            this.clickTypeSelector.FormattingEnabled = true;
            this.clickTypeSelector.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.clickTypeSelector.Location = new System.Drawing.Point(66, 53);
            this.clickTypeSelector.Name = "clickTypeSelector";
            this.clickTypeSelector.Size = new System.Drawing.Size(128, 21);
            this.clickTypeSelector.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Click type";
            // 
            // mouseButtonSelector
            // 
            this.mouseButtonSelector.FormattingEnabled = true;
            this.mouseButtonSelector.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.mouseButtonSelector.Location = new System.Drawing.Point(79, 17);
            this.mouseButtonSelector.Name = "mouseButtonSelector";
            this.mouseButtonSelector.Size = new System.Drawing.Size(115, 21);
            this.mouseButtonSelector.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mouse button";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.numericUpDown6);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(219, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Click repeat";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Until stopped";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "times";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(82, 19);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown6.TabIndex = 1;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Repeat";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.yCoordinateSelector);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.xCoordinateSelector);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.button0);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Location = new System.Drawing.Point(13, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 70);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Click position";
            // 
            // yCoordinateSelector
            // 
            this.yCoordinateSelector.Location = new System.Drawing.Point(400, 31);
            this.yCoordinateSelector.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.yCoordinateSelector.Name = "yCoordinateSelector";
            this.yCoordinateSelector.Size = new System.Drawing.Size(55, 20);
            this.yCoordinateSelector.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Y:";
            // 
            // xCoordinateSelector
            // 
            this.xCoordinateSelector.Location = new System.Drawing.Point(323, 31);
            this.xCoordinateSelector.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.xCoordinateSelector.Name = "xCoordinateSelector";
            this.xCoordinateSelector.Size = new System.Drawing.Size(52, 20);
            this.xCoordinateSelector.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "X:";
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(206, 31);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(93, 23);
            this.button0.TabIndex = 2;
            this.button0.Text = "Select location";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(160, 34);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Here:";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(132, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Current mouse position";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Start (Shift + F6)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Hotkey Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(244, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "Stop (Shift + F6)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(244, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 38);
            this.button4.TabIndex = 18;
            this.button4.Text = "Credits";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 398);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 437);
            this.MinimumSize = new System.Drawing.Size(497, 437);
            this.Name = "Form1";
            this.Text = "UltraAutoClicker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomizerCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinateSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinateSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hoursCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minutesCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown secondsCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown millisecondsCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown randomizerCount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox mouseButtonSelector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox clickTypeSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.NumericUpDown yCoordinateSelector;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown xCoordinateSelector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}

