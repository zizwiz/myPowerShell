namespace myPowerShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_help = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rchtxbx_script = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbobx_scripts = new System.Windows.Forms.ComboBox();
            this.btn_start_script = new System.Windows.Forms.Button();
            this.btn_stop_script = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.Col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rchtxbx_result = new System.Windows.Forms.RichTextBox();
            this.chkbx_text = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_help.Location = new System.Drawing.Point(9, 6);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(60, 29);
            this.btn_help.TabIndex = 0;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 169);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchtxbx_script);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script";
            // 
            // rchtxbx_script
            // 
            this.rchtxbx_script.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxbx_script.Location = new System.Drawing.Point(3, 18);
            this.rchtxbx_script.Name = "rchtxbx_script";
            this.rchtxbx_script.Size = new System.Drawing.Size(788, 148);
            this.rchtxbx_script.TabIndex = 0;
            this.rchtxbx_script.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 169);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchtxbx_result);
            this.groupBox2.Controls.Add(this.dgv_result);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 169);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbobx_scripts);
            this.panel3.Controls.Add(this.btn_start_script);
            this.panel3.Controls.Add(this.btn_stop_script);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 44);
            this.panel3.TabIndex = 2;
            // 
            // cmbobx_scripts
            // 
            this.cmbobx_scripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbobx_scripts.FormattingEnabled = true;
            this.cmbobx_scripts.Location = new System.Drawing.Point(9, 8);
            this.cmbobx_scripts.Name = "cmbobx_scripts";
            this.cmbobx_scripts.Size = new System.Drawing.Size(509, 24);
            this.cmbobx_scripts.Sorted = true;
            this.cmbobx_scripts.TabIndex = 4;
            this.cmbobx_scripts.SelectedIndexChanged += new System.EventHandler(this.cmbobx_scripts_SelectedIndexChanged);
            // 
            // btn_start_script
            // 
            this.btn_start_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start_script.Location = new System.Drawing.Point(533, 6);
            this.btn_start_script.Name = "btn_start_script";
            this.btn_start_script.Size = new System.Drawing.Size(123, 29);
            this.btn_start_script.TabIndex = 3;
            this.btn_start_script.Text = "Start Script";
            this.btn_start_script.UseVisualStyleBackColor = true;
            this.btn_start_script.Click += new System.EventHandler(this.btn_start_script_Click);
            // 
            // btn_stop_script
            // 
            this.btn_stop_script.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop_script.Location = new System.Drawing.Point(662, 6);
            this.btn_stop_script.Name = "btn_stop_script";
            this.btn_stop_script.Size = new System.Drawing.Size(123, 29);
            this.btn_stop_script.TabIndex = 2;
            this.btn_stop_script.Text = "Stop Script";
            this.btn_stop_script.UseVisualStyleBackColor = true;
            this.btn_stop_script.Click += new System.EventHandler(this.btn_stop_script_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkbx_text);
            this.panel4.Controls.Add(this.btn_clear);
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Controls.Add(this.btn_exit);
            this.panel4.Controls.Add(this.btn_help);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 403);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(794, 44);
            this.panel4.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Location = new System.Drawing.Point(659, 6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(60, 29);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_refresh.Location = new System.Drawing.Point(348, 8);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(98, 29);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(725, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(60, 29);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_name,
            this.Col_value,
            this.Col_property});
            this.dgv_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_result.Location = new System.Drawing.Point(3, 18);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.RowTemplate.Height = 24;
            this.dgv_result.Size = new System.Drawing.Size(788, 148);
            this.dgv_result.TabIndex = 1;
            // 
            // Col_name
            // 
            this.Col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_name.HeaderText = "Name";
            this.Col_name.Name = "Col_name";
            this.Col_name.ReadOnly = true;
            // 
            // Col_value
            // 
            this.Col_value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_value.HeaderText = "Value";
            this.Col_value.Name = "Col_value";
            this.Col_value.ReadOnly = true;
            // 
            // Col_property
            // 
            this.Col_property.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_property.HeaderText = "Property";
            this.Col_property.Name = "Col_property";
            this.Col_property.ReadOnly = true;
            // 
            // rchtxbx_result
            // 
            this.rchtxbx_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxbx_result.Location = new System.Drawing.Point(3, 18);
            this.rchtxbx_result.Name = "rchtxbx_result";
            this.rchtxbx_result.Size = new System.Drawing.Size(788, 148);
            this.rchtxbx_result.TabIndex = 2;
            this.rchtxbx_result.Text = "";
            // 
            // chkbx_text
            // 
            this.chkbx_text.AutoSize = true;
            this.chkbx_text.Checked = true;
            this.chkbx_text.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_text.Location = new System.Drawing.Point(120, 11);
            this.chkbx_text.Name = "chkbx_text";
            this.chkbx_text.Size = new System.Drawing.Size(90, 21);
            this.chkbx_text.TabIndex = 4;
            this.chkbx_text.Text = "Text Only";
            this.chkbx_text.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "myPowerShell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchtxbx_script;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cmbobx_scripts;
        private System.Windows.Forms.Button btn_start_script;
        private System.Windows.Forms.Button btn_stop_script;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_property;
        private System.Windows.Forms.RichTextBox rchtxbx_result;
        private System.Windows.Forms.CheckBox chkbx_text;
    }
}

