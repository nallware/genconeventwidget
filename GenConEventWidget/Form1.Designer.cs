namespace GenConEventWidget
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ckSpecEvent = new System.Windows.Forms.CheckBox();
            this.rbShowOpen = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStartHr = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.ckMaterialsProvided = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbExp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numMaxPlay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numMinPlay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSystem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 670);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ckSpecEvent);
            this.tabPage1.Controls.Add(this.rbShowOpen);
            this.tabPage1.Controls.Add(this.rbShowAll);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cbDuration);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cbStartHr);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cbDay);
            this.tabPage1.Controls.Add(this.ckMaterialsProvided);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbExp);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.numMaxPlay);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.numMinPlay);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbAge);
            this.tabPage1.Controls.Add(this.tbTitle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbSystem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbType);
            this.tabPage1.Controls.Add(this.dgvEvents);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1219, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Events Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ckSpecEvent
            // 
            this.ckSpecEvent.AutoSize = true;
            this.ckSpecEvent.Location = new System.Drawing.Point(646, 5);
            this.ckSpecEvent.Name = "ckSpecEvent";
            this.ckSpecEvent.Size = new System.Drawing.Size(116, 17);
            this.ckSpecEvent.TabIndex = 26;
            this.ckSpecEvent.Text = "Special Event Only";
            this.ckSpecEvent.UseVisualStyleBackColor = true;
            // 
            // rbShowOpen
            // 
            this.rbShowOpen.AutoSize = true;
            this.rbShowOpen.Location = new System.Drawing.Point(1046, 29);
            this.rbShowOpen.Name = "rbShowOpen";
            this.rbShowOpen.Size = new System.Drawing.Size(105, 17);
            this.rbShowOpen.TabIndex = 25;
            this.rbShowOpen.TabStop = true;
            this.rbShowOpen.Text = "Show Only Open";
            this.rbShowOpen.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(1046, 6);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(66, 17);
            this.rbShowAll.TabIndex = 24;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show All";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(956, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Duration";
            // 
            // cbDuration
            // 
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(959, 25);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(67, 21);
            this.cbDuration.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(878, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Start Hr";
            // 
            // cbStartHr
            // 
            this.cbStartHr.FormattingEnabled = true;
            this.cbStartHr.Location = new System.Drawing.Point(881, 25);
            this.cbStartHr.Name = "cbStartHr";
            this.cbStartHr.Size = new System.Drawing.Size(67, 21);
            this.cbStartHr.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Day";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(789, 25);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(80, 21);
            this.cbDay.TabIndex = 18;
            // 
            // ckMaterialsProvided
            // 
            this.ckMaterialsProvided.AutoSize = true;
            this.ckMaterialsProvided.Location = new System.Drawing.Point(646, 25);
            this.ckMaterialsProvided.Name = "ckMaterialsProvided";
            this.ckMaterialsProvided.Size = new System.Drawing.Size(132, 17);
            this.ckMaterialsProvided.TabIndex = 17;
            this.ckMaterialsProvided.Text = "Material Provided Only";
            this.ckMaterialsProvided.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Exp";
            // 
            // cbExp
            // 
            this.cbExp.FormattingEnabled = true;
            this.cbExp.Location = new System.Drawing.Point(577, 25);
            this.cbExp.Name = "cbExp";
            this.cbExp.Size = new System.Drawing.Size(63, 21);
            this.cbExp.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Age";
            // 
            // numMaxPlay
            // 
            this.numMaxPlay.Location = new System.Drawing.Point(455, 26);
            this.numMaxPlay.Name = "numMaxPlay";
            this.numMaxPlay.Size = new System.Drawing.Size(41, 20);
            this.numMaxPlay.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "MaxP";
            // 
            // numMinPlay
            // 
            this.numMinPlay.Location = new System.Drawing.Point(404, 26);
            this.numMinPlay.Name = "numMinPlay";
            this.numMinPlay.Size = new System.Drawing.Size(41, 20);
            this.numMinPlay.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "MinP";
            // 
            // cbAge
            // 
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Location = new System.Drawing.Point(502, 25);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(63, 21);
            this.cbAge.TabIndex = 8;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(16, 26);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(119, 20);
            this.tbTitle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "System";
            // 
            // cbSystem
            // 
            this.cbSystem.FormattingEnabled = true;
            this.cbSystem.Location = new System.Drawing.Point(272, 25);
            this.cbSystem.Name = "cbSystem";
            this.cbSystem.Size = new System.Drawing.Size(121, 21);
            this.cbSystem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(145, 25);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(6, 52);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(1207, 581);
            this.dgvEvents.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1219, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Events Viewer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1219, 644);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Events Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.Location = new System.Drawing.Point(12, 682);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(89, 23);
            this.btnUpdateDB.TabIndex = 2;
            this.btnUpdateDB.Text = "Update Events";
            this.btnUpdateDB.UseVisualStyleBackColor = true;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 683);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 717);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateDB);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ckSpecEvent;
        private System.Windows.Forms.RadioButton rbShowOpen;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbStartHr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.CheckBox ckMaterialsProvided;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbExp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMaxPlay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMinPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAge;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

