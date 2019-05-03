namespace WindowsFormsApplication5
{
    partial class Student_Group
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblCO = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCO = new System.Windows.Forms.DateTimePicker();
            this.cmdCreated = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(40, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(40, 144);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(84, 13);
            this.lblAD.TabIndex = 0;
            this.lblAD.Text = "AssignmentDate";
            // 
            // lblCO
            // 
            this.lblCO.AutoSize = true;
            this.lblCO.Location = new System.Drawing.Point(40, 211);
            this.lblCO.Name = "lblCO";
            this.lblCO.Size = new System.Drawing.Size(58, 13);
            this.lblCO.TabIndex = 0;
            this.lblCO.Text = "CreatedOn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.comboBox1.Location = new System.Drawing.Point(167, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePickerAD
            // 
            this.dateTimePickerAD.Location = new System.Drawing.Point(167, 144);
            this.dateTimePickerAD.Name = "dateTimePickerAD";
            this.dateTimePickerAD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAD.TabIndex = 3;
            // 
            // dateTimePickerCO
            // 
            this.dateTimePickerCO.Location = new System.Drawing.Point(167, 211);
            this.dateTimePickerCO.Name = "dateTimePickerCO";
            this.dateTimePickerCO.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCO.TabIndex = 3;
            // 
            // cmdCreated
            // 
            this.cmdCreated.Location = new System.Drawing.Point(263, 293);
            this.cmdCreated.Name = "cmdCreated";
            this.cmdCreated.Size = new System.Drawing.Size(104, 40);
            this.cmdCreated.TabIndex = 4;
            this.cmdCreated.Text = "Created";
            this.cmdCreated.UseVisualStyleBackColor = true;
            this.cmdCreated.Click += new System.EventHandler(this.cmdCreated_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dataGridView1.Location = new System.Drawing.Point(424, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 282);
            this.dataGridView1.TabIndex = 5;
            // 
            // Check
            // 
            this.Check.HeaderText = "Column1";
            this.Check.Name = "Check";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Home Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student Group";
            // 
            // Student_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdCreated);
            this.Controls.Add(this.dateTimePickerCO);
            this.Controls.Add(this.dateTimePickerAD);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCO);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.lblStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_Group";
            this.Text = "Student_Group";
            this.Load += new System.EventHandler(this.Student_Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Label lblCO;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAD;
        private System.Windows.Forms.DateTimePicker dateTimePickerCO;
        private System.Windows.Forms.Button cmdCreated;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}