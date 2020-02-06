namespace MichalKalina_Zadanie_Domowe_Lab4
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
            this.dataGridViewCostumer = new System.Windows.Forms.DataGridView();
            this.labelAdress = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSurName = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonInstruction = new System.Windows.Forms.Button();
            this.panelUserData = new System.Windows.Forms.Panel();
            this.panelInstruction = new System.Windows.Forms.Panel();
            this.labelInstruction1 = new System.Windows.Forms.Label();
            this.labelInstruction2 = new System.Windows.Forms.Label();
            this.labelInstruction1a = new System.Windows.Forms.Label();
            this.buttonBackFromInstruction = new System.Windows.Forms.Button();
            this.labelAutor = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelInstruction3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostumer)).BeginInit();
            this.panelUserData.SuspendLayout();
            this.panelInstruction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCostumer
            // 
            this.dataGridViewCostumer.AllowUserToDeleteRows = false;
            this.dataGridViewCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCostumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Firstname,
            this.LastName,
            this.City});
            this.dataGridViewCostumer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewCostumer.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewCostumer.Name = "dataGridViewCostumer";
            this.dataGridViewCostumer.ReadOnly = true;
            this.dataGridViewCostumer.Size = new System.Drawing.Size(512, 377);
            this.dataGridViewCostumer.TabIndex = 0;
            this.dataGridViewCostumer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCostumer_CellContentClick);
            this.dataGridViewCostumer.DoubleClick += new System.EventHandler(this.dataGridViewCostumer_DoubleClick);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdress.Location = new System.Drawing.Point(3, 172);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(130, 31);
            this.labelAdress.TabIndex = 2;
            this.labelAdress.Text = "Address:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(593, 403);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 36);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(492, 403);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(97, 36);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(3, 1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(99, 31);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name:";
            this.labelName.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(694, 403);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 36);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(156, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(156, 131);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 11;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(9, 206);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(252, 20);
            this.textBoxAdress.TabIndex = 12;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(156, 71);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurName.TabIndex = 13;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CoustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // Firstname
            // 
            this.Firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "First Name";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSurName.Location = new System.Drawing.Point(0, 60);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(144, 31);
            this.labelSurName.TabIndex = 14;
            this.labelSurName.Text = "SurName:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCity.Location = new System.Drawing.Point(3, 120);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(75, 31);
            this.labelCity.TabIndex = 15;
            this.labelCity.Text = "City:";
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInstruction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonInstruction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInstruction.Location = new System.Drawing.Point(362, 403);
            this.buttonInstruction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(126, 36);
            this.buttonInstruction.TabIndex = 16;
            this.buttonInstruction.Text = "Instruction";
            this.buttonInstruction.UseVisualStyleBackColor = true;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonInstruction_Click);
            // 
            // panelUserData
            // 
            this.panelUserData.Controls.Add(this.labelName);
            this.panelUserData.Controls.Add(this.labelAdress);
            this.panelUserData.Controls.Add(this.labelCity);
            this.panelUserData.Controls.Add(this.textBoxName);
            this.panelUserData.Controls.Add(this.labelSurName);
            this.panelUserData.Controls.Add(this.textBoxCity);
            this.panelUserData.Controls.Add(this.textBoxSurName);
            this.panelUserData.Controls.Add(this.textBoxAdress);
            this.panelUserData.Location = new System.Drawing.Point(530, 108);
            this.panelUserData.Name = "panelUserData";
            this.panelUserData.Size = new System.Drawing.Size(276, 245);
            this.panelUserData.TabIndex = 17;
            // 
            // panelInstruction
            // 
            this.panelInstruction.Controls.Add(this.labelInstruction3);
            this.panelInstruction.Controls.Add(this.labelAutor);
            this.panelInstruction.Controls.Add(this.buttonBackFromInstruction);
            this.panelInstruction.Controls.Add(this.labelInstruction1a);
            this.panelInstruction.Controls.Add(this.labelInstruction2);
            this.panelInstruction.Controls.Add(this.labelInstruction1);
            this.panelInstruction.Location = new System.Drawing.Point(28, 89);
            this.panelInstruction.Name = "panelInstruction";
            this.panelInstruction.Size = new System.Drawing.Size(604, 154);
            this.panelInstruction.TabIndex = 18;
            this.panelInstruction.Visible = false;
            this.panelInstruction.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInstruction_Paint);
            // 
            // labelInstruction1
            // 
            this.labelInstruction1.AutoSize = true;
            this.labelInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstruction1.Location = new System.Drawing.Point(13, 9);
            this.labelInstruction1.Name = "labelInstruction1";
            this.labelInstruction1.Size = new System.Drawing.Size(374, 22);
            this.labelInstruction1.TabIndex = 0;
            this.labelInstruction1.Text = "# Aby zmienić dane osoby już wprowadzonej, ";
            // 
            // labelInstruction2
            // 
            this.labelInstruction2.AutoSize = true;
            this.labelInstruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstruction2.Location = new System.Drawing.Point(13, 59);
            this.labelInstruction2.Name = "labelInstruction2";
            this.labelInstruction2.Size = new System.Drawing.Size(584, 22);
            this.labelInstruction2.TabIndex = 1;
            this.labelInstruction2.Text = "# Aby usunąć element z bazy kliknij na niego dwukrotnie i kliknij \"Delete\"";
            // 
            // labelInstruction1a
            // 
            this.labelInstruction1a.AutoSize = true;
            this.labelInstruction1a.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstruction1a.Location = new System.Drawing.Point(13, 31);
            this.labelInstruction1a.Name = "labelInstruction1a";
            this.labelInstruction1a.Size = new System.Drawing.Size(456, 22);
            this.labelInstruction1a.TabIndex = 2;
            this.labelInstruction1a.Text = "kliknij 2 razy na nią w tabeli zmień dane i kliknij \"Update\"";
            // 
            // buttonBackFromInstruction
            // 
            this.buttonBackFromInstruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackFromInstruction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonBackFromInstruction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonBackFromInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackFromInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackFromInstruction.Location = new System.Drawing.Point(500, 112);
            this.buttonBackFromInstruction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackFromInstruction.Name = "buttonBackFromInstruction";
            this.buttonBackFromInstruction.Size = new System.Drawing.Size(97, 36);
            this.buttonBackFromInstruction.TabIndex = 10;
            this.buttonBackFromInstruction.Text = "Back";
            this.buttonBackFromInstruction.UseVisualStyleBackColor = true;
            this.buttonBackFromInstruction.Click += new System.EventHandler(this.buttonBackFromInstruction_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAutor.Location = new System.Drawing.Point(12, 118);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(178, 25);
            this.labelAutor.TabIndex = 11;
            this.labelAutor.Text = "MICHAŁ KALINA";
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(12, 403);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 36);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelInstruction3
            // 
            this.labelInstruction3.AutoSize = true;
            this.labelInstruction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstruction3.Location = new System.Drawing.Point(13, 87);
            this.labelInstruction3.Name = "labelInstruction3";
            this.labelInstruction3.Size = new System.Drawing.Size(396, 22);
            this.labelInstruction3.TabIndex = 12;
            this.labelInstruction3.Text = "# Aby dodać obiekt, wypełnij pola i naciśnij Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MichalKalina_Zadanie_Domowe_Lab4.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelInstruction);
            this.Controls.Add(this.panelUserData);
            this.Controls.Add(this.buttonInstruction);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewCostumer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostumer)).EndInit();
            this.panelUserData.ResumeLayout(false);
            this.panelUserData.PerformLayout();
            this.panelInstruction.ResumeLayout(false);
            this.panelInstruction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCostumer;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonInstruction;
        private System.Windows.Forms.Panel panelUserData;
        private System.Windows.Forms.Panel panelInstruction;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Button buttonBackFromInstruction;
        private System.Windows.Forms.Label labelInstruction1a;
        private System.Windows.Forms.Label labelInstruction2;
        private System.Windows.Forms.Label labelInstruction1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelInstruction3;
    }
}

