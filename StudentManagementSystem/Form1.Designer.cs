
namespace StudentManagementSystem
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNameRead = new System.Windows.Forms.TextBox();
            this.txtAgeRead = new System.Windows.Forms.TextBox();
            this.txtFeesRead = new System.Windows.Forms.TextBox();
            this.txtEmailRead = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 78);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 38);
            this.txtName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(117, 137);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(252, 38);
            this.txtAge.TabIndex = 3;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(117, 200);
            this.txtFees.Multiline = true;
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(252, 38);
            this.txtFees.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 262);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 38);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNameRead
            // 
            this.txtNameRead.Location = new System.Drawing.Point(387, 78);
            this.txtNameRead.Multiline = true;
            this.txtNameRead.Name = "txtNameRead";
            this.txtNameRead.Size = new System.Drawing.Size(252, 38);
            this.txtNameRead.TabIndex = 6;
            // 
            // txtAgeRead
            // 
            this.txtAgeRead.Location = new System.Drawing.Point(387, 137);
            this.txtAgeRead.Multiline = true;
            this.txtAgeRead.Name = "txtAgeRead";
            this.txtAgeRead.Size = new System.Drawing.Size(252, 38);
            this.txtAgeRead.TabIndex = 7;
            // 
            // txtFeesRead
            // 
            this.txtFeesRead.Location = new System.Drawing.Point(387, 200);
            this.txtFeesRead.Multiline = true;
            this.txtFeesRead.Name = "txtFeesRead";
            this.txtFeesRead.Size = new System.Drawing.Size(252, 38);
            this.txtFeesRead.TabIndex = 8;
            // 
            // txtEmailRead
            // 
            this.txtEmailRead.Location = new System.Drawing.Point(387, 262);
            this.txtEmailRead.Multiline = true;
            this.txtEmailRead.Name = "txtEmailRead";
            this.txtEmailRead.Size = new System.Drawing.Size(252, 38);
            this.txtEmailRead.TabIndex = 9;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(457, 332);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(116, 48);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(683, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtEmailRead);
            this.Controls.Add(this.txtFeesRead);
            this.Controls.Add(this.txtAgeRead);
            this.Controls.Add(this.txtNameRead);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNameRead;
        private System.Windows.Forms.TextBox txtAgeRead;
        private System.Windows.Forms.TextBox txtFeesRead;
        private System.Windows.Forms.TextBox txtEmailRead;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

