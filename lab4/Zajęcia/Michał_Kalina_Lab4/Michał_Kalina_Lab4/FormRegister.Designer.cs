namespace Michał_Kalina_Lab4
{
    partial class FormRegister
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxSurnname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxStudentIndex = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegister.Location = new System.Drawing.Point(482, 58);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(319, 135);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxSurnname
            // 
            this.textBoxSurnname.Location = new System.Drawing.Point(128, 58);
            this.textBoxSurnname.Name = "textBoxSurnname";
            this.textBoxSurnname.Size = new System.Drawing.Size(348, 20);
            this.textBoxSurnname.TabIndex = 8;
            this.textBoxSurnname.Text = "surname";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 14);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(348, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Text = "name";
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameSurname.Location = new System.Drawing.Point(30, 257);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(602, 107);
            this.labelNameSurname.TabIndex = 6;
            this.labelNameSurname.Text = "Michał Kalina";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(128, 144);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(348, 20);
            this.textBoxEmail.TabIndex = 13;
            this.textBoxEmail.Text = "email";
            // 
            // textBoxStudentIndex
            // 
            this.textBoxStudentIndex.Location = new System.Drawing.Point(128, 100);
            this.textBoxStudentIndex.Name = "textBoxStudentIndex";
            this.textBoxStudentIndex.Size = new System.Drawing.Size(348, 20);
            this.textBoxStudentIndex.TabIndex = 12;
            this.textBoxStudentIndex.Text = "studentindex";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(128, 234);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(348, 20);
            this.textBoxPassword.TabIndex = 15;
            this.textBoxPassword.Text = "Haslo";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(128, 190);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(348, 20);
            this.textBoxUserName.TabIndex = 14;
            this.textBoxUserName.Text = "username";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxStudentIndex);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxSurnname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNameSurname);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxSurnname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxStudentIndex;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
    }
}