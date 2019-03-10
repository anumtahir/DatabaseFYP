namespace WindowsFormsApplication5
{
    partial class Person
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(56, 79);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(56, 130);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(56, 178);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(56, 223);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(56, 267);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(56, 318);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(218, 178);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 20);
            this.txtContact.TabIndex = 7;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(218, 130);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 20);
            this.txtLName.TabIndex = 8;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(218, 76);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(200, 20);
            this.txtFName.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(218, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(218, 267);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 11;
            this.dateTimePickerDOB.ValueChanged += new System.EventHandler(this.dateTimePickerDOB_ValueChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(218, 318);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGender.TabIndex = 12;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(602, 257);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 13;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(602, 316);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 14;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 400);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.Name = "Person";
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDelete;
    }
}