namespace WindowsFormsApplication5
{
    partial class Manage_Projects
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(61, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(184, 65);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(205, 39);
            this.txtTitle.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(61, 131);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(184, 131);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 83);
            this.txtDescription.TabIndex = 4;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(64, 255);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(118, 23);
            this.cmdAdd.TabIndex = 5;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(204, 255);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(124, 23);
            this.cmdDelete.TabIndex = 6;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // Manage_Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 303);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Projects";
            this.Text = "Manage_Projects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDelete;
    }
}