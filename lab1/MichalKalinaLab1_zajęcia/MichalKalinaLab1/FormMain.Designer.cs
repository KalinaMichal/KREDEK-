namespace MichalKalinaLab1
{
    partial class FormMain
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonZMIEN = new System.Windows.Forms.Button();
            this.textBoxDataDZIALANIE_2 = new System.Windows.Forms.TextBox();
            this.buttonMore = new System.Windows.Forms.Button();
            this.textBoxDZIALANIE = new System.Windows.Forms.TextBox();
            this.ButtonMNOZENIE = new System.Windows.Forms.Button();
            this.buttonDODAWANIE = new System.Windows.Forms.Button();
            this.ButtonOdejmowanie = new System.Windows.Forms.Button();
            this.buttonWARUNEK = new System.Windows.Forms.Button();
            this.TimerCounter = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxCZAS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWYNIK = new System.Windows.Forms.TextBox();
            this.labelWynik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(31, 18);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 56);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(27, 242);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(810, 113);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "MICHAŁ KALINA";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(31, 86);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(105, 56);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "buttonChange";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonZMIEN
            // 
            this.buttonZMIEN.Location = new System.Drawing.Point(252, 126);
            this.buttonZMIEN.Name = "buttonZMIEN";
            this.buttonZMIEN.Size = new System.Drawing.Size(75, 23);
            this.buttonZMIEN.TabIndex = 3;
            this.buttonZMIEN.Text = "Zmien";
            this.buttonZMIEN.UseVisualStyleBackColor = true;
            this.buttonZMIEN.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDataDZIALANIE_2
            // 
            this.textBoxDataDZIALANIE_2.Location = new System.Drawing.Point(333, 100);
            this.textBoxDataDZIALANIE_2.Name = "textBoxDataDZIALANIE_2";
            this.textBoxDataDZIALANIE_2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataDZIALANIE_2.TabIndex = 4;
            this.textBoxDataDZIALANIE_2.Text = "1";
            this.textBoxDataDZIALANIE_2.TextChanged += new System.EventHandler(this.textBoxData_TextChanged);
            // 
            // buttonMore
            // 
            this.buttonMore.Location = new System.Drawing.Point(252, 97);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(75, 23);
            this.buttonMore.TabIndex = 5;
            this.buttonMore.Text = "Wiecej";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // textBoxDZIALANIE
            // 
            this.textBoxDZIALANIE.Location = new System.Drawing.Point(439, 99);
            this.textBoxDZIALANIE.Name = "textBoxDZIALANIE";
            this.textBoxDZIALANIE.Size = new System.Drawing.Size(100, 20);
            this.textBoxDZIALANIE.TabIndex = 7;
            this.textBoxDZIALANIE.Text = "1";
            // 
            // ButtonMNOZENIE
            // 
            this.ButtonMNOZENIE.Location = new System.Drawing.Point(545, 97);
            this.ButtonMNOZENIE.Name = "ButtonMNOZENIE";
            this.ButtonMNOZENIE.Size = new System.Drawing.Size(75, 23);
            this.ButtonMNOZENIE.TabIndex = 8;
            this.ButtonMNOZENIE.Text = "Mnozenie";
            this.ButtonMNOZENIE.UseVisualStyleBackColor = true;
            this.ButtonMNOZENIE.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDODAWANIE
            // 
            this.buttonDODAWANIE.Location = new System.Drawing.Point(545, 126);
            this.buttonDODAWANIE.Name = "buttonDODAWANIE";
            this.buttonDODAWANIE.Size = new System.Drawing.Size(75, 23);
            this.buttonDODAWANIE.TabIndex = 9;
            this.buttonDODAWANIE.Text = "+";
            this.buttonDODAWANIE.UseVisualStyleBackColor = true;
            this.buttonDODAWANIE.Click += new System.EventHandler(this.DOD_Click);
            // 
            // ButtonOdejmowanie
            // 
            this.ButtonOdejmowanie.Location = new System.Drawing.Point(626, 97);
            this.ButtonOdejmowanie.Name = "ButtonOdejmowanie";
            this.ButtonOdejmowanie.Size = new System.Drawing.Size(75, 23);
            this.ButtonOdejmowanie.TabIndex = 10;
            this.ButtonOdejmowanie.Text = "-";
            this.ButtonOdejmowanie.UseVisualStyleBackColor = true;
            this.ButtonOdejmowanie.Click += new System.EventHandler(this.Odejmowanie_Click);
            // 
            // buttonWARUNEK
            // 
            this.buttonWARUNEK.Location = new System.Drawing.Point(626, 126);
            this.buttonWARUNEK.Name = "buttonWARUNEK";
            this.buttonWARUNEK.Size = new System.Drawing.Size(118, 23);
            this.buttonWARUNEK.TabIndex = 11;
            this.buttonWARUNEK.Text = "Działanie warunkowe";
            this.buttonWARUNEK.UseVisualStyleBackColor = true;
            this.buttonWARUNEK.Click += new System.EventHandler(this.button3_Click);
            // 
            // TimerCounter
            // 
            this.TimerCounter.Tick += new System.EventHandler(this.TimerCounter_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(722, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 45);
            this.Start.TabIndex = 12;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxCZAS
            // 
            this.textBoxCZAS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCZAS.ForeColor = System.Drawing.Color.Red;
            this.textBoxCZAS.Location = new System.Drawing.Point(722, 64);
            this.textBoxCZAS.Name = "textBoxCZAS";
            this.textBoxCZAS.Size = new System.Drawing.Size(100, 20);
            this.textBoxCZAS.TabIndex = 13;
            this.textBoxCZAS.Text = "0";
            this.textBoxCZAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCZAS.TextChanged += new System.EventHandler(this.textBoxCZAS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "* Dzialanie- jesli mnozenie bedzie wieksze od 5 zmieni kolor";
            // 
            // textBoxWYNIK
            // 
            this.textBoxWYNIK.Location = new System.Drawing.Point(576, 155);
            this.textBoxWYNIK.Name = "textBoxWYNIK";
            this.textBoxWYNIK.Size = new System.Drawing.Size(100, 20);
            this.textBoxWYNIK.TabIndex = 16;
            this.textBoxWYNIK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.Location = new System.Drawing.Point(520, 158);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(50, 17);
            this.labelWynik.TabIndex = 17;
            this.labelWynik.Text = "Wynik:";
            this.labelWynik.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "* Po naciśnięciu \"Start\" po 10 sekundach tło zmieni kolor";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.textBoxWYNIK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCZAS);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.buttonWARUNEK);
            this.Controls.Add(this.ButtonOdejmowanie);
            this.Controls.Add(this.buttonDODAWANIE);
            this.Controls.Add(this.ButtonMNOZENIE);
            this.Controls.Add(this.textBoxDZIALANIE);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.textBoxDataDZIALANIE_2);
            this.Controls.Add(this.buttonZMIEN);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonZMIEN;
        private System.Windows.Forms.TextBox textBoxDataDZIALANIE_2;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.TextBox textBoxDZIALANIE;
        private System.Windows.Forms.Button ButtonMNOZENIE;
        private System.Windows.Forms.Button buttonDODAWANIE;
        private System.Windows.Forms.Button ButtonOdejmowanie;
        private System.Windows.Forms.Button buttonWARUNEK;
        private System.Windows.Forms.Timer TimerCounter;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxCZAS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWYNIK;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Label label3;
    }
}

