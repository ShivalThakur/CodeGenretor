namespace SearchFile
{
    partial class _3_Tirer
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
            this.label1 = new System.Windows.Forms.Label();
            this.CS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tables = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView_1707 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TextBoxDropDown = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Design_ = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CS_ = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_1707)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // CS
            // 
            this.CS.Location = new System.Drawing.Point(110, 23);
            this.CS.Name = "CS";
            this.CS.Size = new System.Drawing.Size(353, 20);
            this.CS.TabIndex = 1;
            this.CS.TextChanged += new System.EventHandler(this.CS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table";
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(110, 62);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(121, 21);
            this.Tables.TabIndex = 3;
            this.Tables.SelectedIndexChanged += new System.EventHandler(this.Tables_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 110);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(536, 335);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project Path";
            // 
            // FolderPath
            // 
            this.FolderPath.Location = new System.Drawing.Point(404, 59);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(304, 20);
            this.FolderPath.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\Shival\\Desktop";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Genrate CS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Table Design Columns";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(686, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // dataGridView_1707
            // 
            this.dataGridView_1707.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_1707.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.TextBoxDropDown});
            this.dataGridView_1707.Location = new System.Drawing.Point(570, 142);
            this.dataGridView_1707.Name = "dataGridView_1707";
            this.dataGridView_1707.Size = new System.Drawing.Size(583, 303);
            this.dataGridView_1707.TabIndex = 13;
            this.dataGridView_1707.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_1707_DataBindingComplete);
            // 
            // Check
            // 
            this.Check.HeaderText = "Column1";
            this.Check.Name = "Check";
            // 
            // TextBoxDropDown
            // 
            this.TextBoxDropDown.HeaderText = "TextBox/DropDown";
            this.TextBoxDropDown.Items.AddRange(new object[] {
            "TextBox",
            "DropDown"});
            this.TextBoxDropDown.Name = "TextBoxDropDown";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Get Code";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Design\r\n";
            // 
            // Design_
            // 
            this.Design_.Location = new System.Drawing.Point(573, 498);
            this.Design_.Name = "Design_";
            this.Design_.Size = new System.Drawing.Size(635, 96);
            this.Design_.TabIndex = 16;
            this.Design_.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "CS\r\n";
            // 
            // CS_
            // 
            this.CS_.Location = new System.Drawing.Point(570, 633);
            this.CS_.Name = "CS_";
            this.CS_.Size = new System.Drawing.Size(638, 96);
            this.CS_.TabIndex = 18;
            this.CS_.Text = "";
            // 
            // _3_Tirer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 741);
            this.Controls.Add(this.CS_);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Design_);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView_1707);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CS);
            this.Controls.Add(this.label1);
            this.Name = "_3_Tirer";
            this.Text = "_3_Tirer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._3_Tirer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_1707)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Tables;
        public System.Windows.Forms.TextBox CS;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView_1707;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewComboBoxColumn TextBoxDropDown;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Design_;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox CS_;
    }
}