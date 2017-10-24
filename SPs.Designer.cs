namespace SearchFile
{
    partial class SPs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Connection_Strings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.CheckBox();
            this.insert = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.table_name = new System.Windows.Forms.TextBox();
            this.sp_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ups = new System.Windows.Forms.RadioButton();
            this.ins = new System.Windows.Forms.RadioButton();
            this.SqlConnection_obj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SqlCommand_obj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AllSps = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbltechnology = new System.Windows.Forms.Label();
            this.ddlTechnology = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Of Sp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 536);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FolderPath);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Connection_Strings);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.result);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Select);
            this.tabPage1.Controls.Add(this.update);
            this.tabPage1.Controls.Add(this.insert);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.table_name);
            this.tabPage1.Controls.Add(this.sp_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create New SP For Sql";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Location = new System.Drawing.Point(532, 64);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(366, 20);
            this.FolderPath.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output Folder";
            // 
            // Connection_Strings
            // 
            this.Connection_Strings.Location = new System.Drawing.Point(508, 18);
            this.Connection_Strings.Name = "Connection_Strings";
            this.Connection_Strings.Size = new System.Drawing.Size(390, 20);
            this.Connection_Strings.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CS";
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.result.Location = new System.Drawing.Point(3, 207);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(959, 300);
            this.result.TabIndex = 8;
            this.result.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Genrate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Select
            // 
            this.Select.AutoSize = true;
            this.Select.Location = new System.Drawing.Point(301, 113);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(56, 17);
            this.Select.TabIndex = 6;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Location = new System.Drawing.Point(161, 113);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(61, 17);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            this.insert.AutoSize = true;
            this.insert.Location = new System.Drawing.Point(41, 113);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(52, 17);
            this.insert.TabIndex = 4;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name Of Table";
            // 
            // table_name
            // 
            this.table_name.Location = new System.Drawing.Point(88, 60);
            this.table_name.Name = "table_name";
            this.table_name.Size = new System.Drawing.Size(350, 20);
            this.table_name.TabIndex = 2;
            // 
            // sp_name
            // 
            this.sp_name.Location = new System.Drawing.Point(88, 14);
            this.sp_name.Name = "sp_name";
            this.sp_name.Size = new System.Drawing.Size(350, 20);
            this.sp_name.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ddlTechnology);
            this.tabPage2.Controls.Add(this.lbltechnology);
            this.tabPage2.Controls.Add(this.ups);
            this.tabPage2.Controls.Add(this.ins);
            this.tabPage2.Controls.Add(this.SqlConnection_obj);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.SqlCommand_obj);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.AllSps);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(965, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SP Coding For Application";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ups
            // 
            this.ups.AutoSize = true;
            this.ups.Location = new System.Drawing.Point(370, 154);
            this.ups.Name = "ups";
            this.ups.Size = new System.Drawing.Size(60, 17);
            this.ups.TabIndex = 19;
            this.ups.Text = "Update";
            this.ups.UseVisualStyleBackColor = true;
            // 
            // ins
            // 
            this.ins.AutoSize = true;
            this.ins.Checked = true;
            this.ins.Location = new System.Drawing.Point(265, 154);
            this.ins.Name = "ins";
            this.ins.Size = new System.Drawing.Size(51, 17);
            this.ins.TabIndex = 18;
            this.ins.TabStop = true;
            this.ins.Text = "Insert";
            this.ins.UseVisualStyleBackColor = true;
            // 
            // SqlConnection_obj
            // 
            this.SqlConnection_obj.Location = new System.Drawing.Point(152, 78);
            this.SqlConnection_obj.Name = "SqlConnection_obj";
            this.SqlConnection_obj.Size = new System.Drawing.Size(482, 20);
            this.SqlConnection_obj.TabIndex = 17;
            this.SqlConnection_obj.Text = "connection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "SqlConnection";
            // 
            // SqlCommand_obj
            // 
            this.SqlCommand_obj.Location = new System.Drawing.Point(152, 52);
            this.SqlCommand_obj.Name = "SqlCommand_obj";
            this.SqlCommand_obj.Size = new System.Drawing.Size(478, 20);
            this.SqlCommand_obj.TabIndex = 15;
            this.SqlCommand_obj.Text = "command";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "SqlCommand Object";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-4, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(912, 304);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Genrate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "All Sps";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AllSps
            // 
            this.AllSps.FormattingEnabled = true;
            this.AllSps.Location = new System.Drawing.Point(152, 25);
            this.AllSps.Name = "AllSps";
            this.AllSps.Size = new System.Drawing.Size(679, 21);
            this.AllSps.TabIndex = 0;
            this.AllSps.SelectedIndexChanged += new System.EventHandler(this.AllSps_SelectedIndexChanged);
            // 
            // lbltechnology
            // 
            this.lbltechnology.AutoSize = true;
            this.lbltechnology.Location = new System.Drawing.Point(28, 107);
            this.lbltechnology.Name = "lbltechnology";
            this.lbltechnology.Size = new System.Drawing.Size(63, 13);
            this.lbltechnology.TabIndex = 20;
            this.lbltechnology.Text = "Technology";
            // 
            // ddlTechnology
            // 
            this.ddlTechnology.FormattingEnabled = true;
            this.ddlTechnology.Location = new System.Drawing.Point(152, 104);
            this.ddlTechnology.Name = "ddlTechnology";
            this.ddlTechnology.Size = new System.Drawing.Size(121, 21);
            this.ddlTechnology.TabIndex = 21;
            // 
            // SPs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "SPs";
            this.ShowInTaskbar = false;
            this.Text = "SPs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SPs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Select;
        private System.Windows.Forms.CheckBox update;
        private System.Windows.Forms.CheckBox insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox table_name;
        private System.Windows.Forms.TextBox sp_name;
        public System.Windows.Forms.TextBox Connection_Strings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AllSps;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox SqlConnection_obj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SqlCommand_obj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton ups;
        private System.Windows.Forms.RadioButton ins;
        private System.Windows.Forms.ComboBox ddlTechnology;
        private System.Windows.Forms.Label lbltechnology;
    }
}