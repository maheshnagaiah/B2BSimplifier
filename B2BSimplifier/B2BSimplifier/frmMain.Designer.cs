namespace B2BSimplifier
{
    partial class frmMain
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
            this.label32 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRedemption = new System.Windows.Forms.TextBox();
            this.chkbSupressInvite = new System.Windows.Forms.CheckBox();
            this.dgvCSVData = new System.Windows.Forms.DataGridView();
            this.chkBxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnOnBoard = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVData)).BeginInit();
            this.SuspendLayout();
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(-503, 370);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(181, 32);
            this.label32.TabIndex = 23;
            this.label32.Text = "Choose Files";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(228, 166);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(228, 69);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Location = new System.Drawing.Point(471, 166);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(261, 69);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Parse";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(636, 38);
            this.textBox1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Location = new System.Drawing.Point(63, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 288);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOnBoard);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRedemption);
            this.groupBox2.Controls.Add(this.chkbSupressInvite);
            this.groupBox2.Location = new System.Drawing.Point(959, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 269);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delayed Redemption";
            // 
            // txtRedemption
            // 
            this.txtRedemption.Location = new System.Drawing.Point(459, 65);
            this.txtRedemption.Name = "txtRedemption";
            this.txtRedemption.Size = new System.Drawing.Size(161, 38);
            this.txtRedemption.TabIndex = 3;
            this.txtRedemption.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtRedemption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRedemption_KeyPress);
            // 
            // chkbSupressInvite
            // 
            this.chkbSupressInvite.AutoSize = true;
            this.chkbSupressInvite.Location = new System.Drawing.Point(119, 180);
            this.chkbSupressInvite.Name = "chkbSupressInvite";
            this.chkbSupressInvite.Size = new System.Drawing.Size(293, 36);
            this.chkbSupressInvite.TabIndex = 2;
            this.chkbSupressInvite.Text = "Supress Invitations";
            this.chkbSupressInvite.UseVisualStyleBackColor = true;
            // 
            // dgvCSVData
            // 
            this.dgvCSVData.AllowUserToAddRows = false;
            this.dgvCSVData.AllowUserToDeleteRows = false;
            this.dgvCSVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBxSelect});
            this.dgvCSVData.Location = new System.Drawing.Point(301, 411);
            this.dgvCSVData.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvCSVData.Name = "dgvCSVData";
            this.dgvCSVData.Size = new System.Drawing.Size(1181, 731);
            this.dgvCSVData.TabIndex = 28;
            // 
            // chkBxSelect
            // 
            this.chkBxSelect.DataPropertyName = "IsChecked";
            this.chkBxSelect.HeaderText = "";
            this.chkBxSelect.Name = "chkBxSelect";
            this.chkBxSelect.Width = 50;
            // 
            // btnOnBoard
            // 
            this.btnOnBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnBoard.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnOnBoard.Location = new System.Drawing.Point(459, 163);
            this.btnOnBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnBoard.Name = "btnOnBoard";
            this.btnOnBoard.Size = new System.Drawing.Size(211, 69);
            this.btnOnBoard.TabIndex = 29;
            this.btnOnBoard.Text = "OnBoard";
            this.btnOnBoard.UseVisualStyleBackColor = true;
            this.btnOnBoard.Click += new System.EventHandler(this.btnOnBoard_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1174);
            this.Controls.Add(this.dgvCSVData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label32);
            this.Name = "frmMain";
            this.Text = "B2B Simplifier";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkbSupressInvite;
        private System.Windows.Forms.TextBox txtRedemption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCSVData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBxSelect;
        private System.Windows.Forms.Button btnOnBoard;
    }
}

