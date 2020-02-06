namespace MichałKalina_Lab2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.AddHorse = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFavouriteNumber = new System.Windows.Forms.TextBox();
            this.labelFavourite = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AddUnicorn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHornColor = new System.Windows.Forms.TextBox();
            this.textBoxCornFavouriteNumber = new System.Windows.Forms.TextBox();
            this.textBoxCornName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Michał KALINA";
            // 
            // AddHorse
            // 
            this.AddHorse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddHorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddHorse.Location = new System.Drawing.Point(107, 233);
            this.AddHorse.Name = "AddHorse";
            this.AddHorse.Size = new System.Drawing.Size(175, 107);
            this.AddHorse.TabIndex = 1;
            this.AddHorse.Text = "Add horse";
            this.toolTip1.SetToolTip(this.AddHorse, "Dodaj konia\r\n");
            this.AddHorse.UseVisualStyleBackColor = true;
            this.AddHorse.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(139, 116);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 20);
            this.textBoxName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxName, "Wprowadź imię");
            // 
            // textBoxFavouriteNumber
            // 
            this.textBoxFavouriteNumber.Location = new System.Drawing.Point(273, 178);
            this.textBoxFavouriteNumber.Name = "textBoxFavouriteNumber";
            this.textBoxFavouriteNumber.Size = new System.Drawing.Size(103, 20);
            this.textBoxFavouriteNumber.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxFavouriteNumber, "Wprowadź numer");
            // 
            // labelFavourite
            // 
            this.labelFavourite.AutoSize = true;
            this.labelFavourite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFavourite.Location = new System.Drawing.Point(44, 167);
            this.labelFavourite.Name = "labelFavourite";
            this.labelFavourite.Size = new System.Drawing.Size(232, 31);
            this.labelFavourite.TabIndex = 4;
            this.labelFavourite.Text = "FavouriteNumber:";
            this.toolTip1.SetToolTip(this.labelFavourite, "FavoriteNumber\r\n\r\n");
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(44, 116);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 31);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            this.toolTip1.SetToolTip(this.labelName, "Imię");
            // 
            // AddUnicorn
            // 
            this.AddUnicorn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUnicorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddUnicorn.Location = new System.Drawing.Point(472, 233);
            this.AddUnicorn.Name = "AddUnicorn";
            this.AddUnicorn.Size = new System.Drawing.Size(196, 107);
            this.AddUnicorn.TabIndex = 12;
            this.AddUnicorn.Text = "Add UniCorn";
            this.toolTip1.SetToolTip(this.AddUnicorn, "Dodaj jednorozca\r\n");
            this.AddUnicorn.UseVisualStyleBackColor = true;
            this.AddUnicorn.Click += new System.EventHandler(this.AddUnicorn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(404, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "FavouriteNumber:";
            this.toolTip1.SetToolTip(this.label4, "FavoriteNumber\r\n\r\n");
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(404, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "kolor rogu";
            this.toolTip1.SetToolTip(this.label2, "kolor rogu");
            // 
            // textBoxHornColor
            // 
            this.textBoxHornColor.Location = new System.Drawing.Point(544, 184);
            this.textBoxHornColor.Name = "textBoxHornColor";
            this.textBoxHornColor.Size = new System.Drawing.Size(194, 20);
            this.textBoxHornColor.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxHornColor, "Wprowadź kolor");
            // 
            // textBoxCornFavouriteNumber
            // 
            this.textBoxCornFavouriteNumber.Location = new System.Drawing.Point(638, 145);
            this.textBoxCornFavouriteNumber.Name = "textBoxCornFavouriteNumber";
            this.textBoxCornFavouriteNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxCornFavouriteNumber.TabIndex = 9;
            this.textBoxCornFavouriteNumber.Visible = false;
            // 
            // textBoxCornName
            // 
            this.textBoxCornName.Location = new System.Drawing.Point(519, 101);
            this.textBoxCornName.Name = "textBoxCornName";
            this.textBoxCornName.Size = new System.Drawing.Size(219, 20);
            this.textBoxCornName.TabIndex = 8;
            this.textBoxCornName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(404, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            this.toolTip1.SetToolTip(this.label3, "imię");
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddUnicorn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCornFavouriteNumber);
            this.Controls.Add(this.textBoxCornName);
            this.Controls.Add(this.textBoxHornColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFavourite);
            this.Controls.Add(this.textBoxFavouriteNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.AddHorse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddHorse;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFavouriteNumber;
        private System.Windows.Forms.Label labelFavourite;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHornColor;
        private System.Windows.Forms.TextBox textBoxCornFavouriteNumber;
        private System.Windows.Forms.Button AddUnicorn;
        private System.Windows.Forms.TextBox textBoxCornName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

