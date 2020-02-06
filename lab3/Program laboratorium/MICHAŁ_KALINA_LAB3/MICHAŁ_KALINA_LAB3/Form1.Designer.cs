namespace MICHAŁ_KALINA_LAB3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonViewGrades = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonViewCourses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "MICHAŁ KALINA";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 127);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(579, 311);
            this.dataGridViewData.TabIndex = 1;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // buttonViewGrades
            // 
            this.buttonViewGrades.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonViewGrades.Location = new System.Drawing.Point(627, 127);
            this.buttonViewGrades.Name = "buttonViewGrades";
            this.buttonViewGrades.Size = new System.Drawing.Size(131, 64);
            this.buttonViewGrades.TabIndex = 2;
            this.buttonViewGrades.Text = "Zobacz oceny";
            this.buttonViewGrades.UseVisualStyleBackColor = false;
            this.buttonViewGrades.Click += new System.EventHandler(this.buttonViewGrades_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(645, 210);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(645, 257);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourse.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(653, 194);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(92, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Imię wykładowcy:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(675, 241);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(31, 13);
            this.labelCourse.TabIndex = 6;
            this.labelCourse.Text = "Kurs:";
            this.labelCourse.Click += new System.EventHandler(this.labelCourse_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddCourse.Location = new System.Drawing.Point(627, 295);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(131, 64);
            this.buttonAddCourse.TabIndex = 7;
            this.buttonAddCourse.Text = "Dodaj nowy kurs";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonViewCourses
            // 
            this.buttonViewCourses.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonViewCourses.Location = new System.Drawing.Point(627, 365);
            this.buttonViewCourses.Name = "buttonViewCourses";
            this.buttonViewCourses.Size = new System.Drawing.Size(131, 64);
            this.buttonViewCourses.TabIndex = 8;
            this.buttonViewCourses.Text = "Zobacz kursy";
            this.buttonViewCourses.UseVisualStyleBackColor = false;
            this.buttonViewCourses.Click += new System.EventHandler(this.buttonViewCourses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 564);
            this.Controls.Add(this.buttonViewCourses);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonViewGrades);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonViewGrades;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonViewCourses;
    }
}

