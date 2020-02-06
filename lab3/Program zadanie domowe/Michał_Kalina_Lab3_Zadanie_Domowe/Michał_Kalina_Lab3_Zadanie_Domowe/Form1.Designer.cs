namespace Michał_Kalina_Lab3_Zadanie_Domowe
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
            this.buttonShowBooks = new System.Windows.Forms.Button();
            this.buttonShowWypozycznia = new System.Windows.Forms.Button();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonShowStudents = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonShowSongs = new System.Windows.Forms.Button();
            this.buttonShowMovies = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.panelAddStudent = new System.Windows.Forms.Panel();
            this.panelAddThings = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTitleThings = new System.Windows.Forms.TextBox();
            this.textBoxAutorThings = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.buttonDelateMusic = new System.Windows.Forms.Button();
            this.buttonDelateStudents = new System.Windows.Forms.Button();
            this.buttonDelateBooks = new System.Windows.Forms.Button();
            this.buttonDelateFilms = new System.Windows.Forms.Button();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonTurnBack = new System.Windows.Forms.Button();
            this.buttonRentPanel = new System.Windows.Forms.Button();
            this.labelRentID = new System.Windows.Forms.Label();
            this.textBoxRentID = new System.Windows.Forms.TextBox();
            this.panelRentBack = new System.Windows.Forms.Panel();
            this.buttonTurnBackPanel = new System.Windows.Forms.Button();
            this.panelNewRent = new System.Windows.Forms.Panel();
            this.labelSongID = new System.Windows.Forms.Label();
            this.textBoxSongRentID = new System.Windows.Forms.TextBox();
            this.labelMovieID = new System.Windows.Forms.Label();
            this.textBoxMovieRentID = new System.Windows.Forms.TextBox();
            this.buttonNewRent = new System.Windows.Forms.Button();
            this.labelBookID = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxBookRentID = new System.Windows.Forms.TextBox();
            this.textBoxStudentRentID = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAutorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.panelAddStudent.SuspendLayout();
            this.panelAddThings.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelRentBack.SuspendLayout();
            this.panelNewRent.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowBooks
            // 
            this.buttonShowBooks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowBooks.Location = new System.Drawing.Point(758, 170);
            this.buttonShowBooks.Name = "buttonShowBooks";
            this.buttonShowBooks.Size = new System.Drawing.Size(131, 64);
            this.buttonShowBooks.TabIndex = 16;
            this.buttonShowBooks.Text = "Zobacz książki";
            this.buttonShowBooks.UseVisualStyleBackColor = false;
            this.buttonShowBooks.Click += new System.EventHandler(this.buttonViewCourses_Click);
            // 
            // buttonShowWypozycznia
            // 
            this.buttonShowWypozycznia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowWypozycznia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowWypozycznia.Location = new System.Drawing.Point(758, 30);
            this.buttonShowWypozycznia.Name = "buttonShowWypozycznia";
            this.buttonShowWypozycznia.Size = new System.Drawing.Size(131, 64);
            this.buttonShowWypozycznia.TabIndex = 15;
            this.buttonShowWypozycznia.Text = "Pokaż listę wypożyczeń";
            this.buttonShowWypozycznia.UseVisualStyleBackColor = false;
            this.buttonShowWypozycznia.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(167, 11);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(56, 13);
            this.labelCourse.TabIndex = 14;
            this.labelCourse.Text = "Nazwisko:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Imię:";
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(132, 27);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurName.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(20, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // buttonShowStudents
            // 
            this.buttonShowStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowStudents.Location = new System.Drawing.Point(758, 100);
            this.buttonShowStudents.Name = "buttonShowStudents";
            this.buttonShowStudents.Size = new System.Drawing.Size(131, 64);
            this.buttonShowStudents.TabIndex = 10;
            this.buttonShowStudents.Text = "Zobacz studentów";
            this.buttonShowStudents.UseVisualStyleBackColor = false;
            this.buttonShowStudents.Click += new System.EventHandler(this.buttonViewGrades_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(579, 311);
            this.dataGridViewData.TabIndex = 9;
            // 
            // buttonShowSongs
            // 
            this.buttonShowSongs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowSongs.Location = new System.Drawing.Point(758, 240);
            this.buttonShowSongs.Name = "buttonShowSongs";
            this.buttonShowSongs.Size = new System.Drawing.Size(131, 64);
            this.buttonShowSongs.TabIndex = 17;
            this.buttonShowSongs.Text = "Zobacz Muzykę";
            this.buttonShowSongs.UseVisualStyleBackColor = false;
            this.buttonShowSongs.Click += new System.EventHandler(this.buttonShowSongs_Click);
            // 
            // buttonShowMovies
            // 
            this.buttonShowMovies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowMovies.Location = new System.Drawing.Point(758, 310);
            this.buttonShowMovies.Name = "buttonShowMovies";
            this.buttonShowMovies.Size = new System.Drawing.Size(131, 64);
            this.buttonShowMovies.TabIndex = 18;
            this.buttonShowMovies.Text = "Zobacz Filmy";
            this.buttonShowMovies.UseVisualStyleBackColor = false;
            this.buttonShowMovies.Click += new System.EventHandler(this.buttonShowMovies_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddStudent.Location = new System.Drawing.Point(456, 11);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(131, 64);
            this.buttonAddStudent.TabIndex = 19;
            this.buttonAddStudent.Text = "Dodaj studenta";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "numer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adres:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(350, 27);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentID.TabIndex = 21;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(238, 27);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdress.TabIndex = 20;
            // 
            // panelAddStudent
            // 
            this.panelAddStudent.Controls.Add(this.label1);
            this.panelAddStudent.Controls.Add(this.label2);
            this.panelAddStudent.Controls.Add(this.textBoxStudentID);
            this.panelAddStudent.Controls.Add(this.textBoxAdress);
            this.panelAddStudent.Controls.Add(this.buttonAddStudent);
            this.panelAddStudent.Controls.Add(this.labelCourse);
            this.panelAddStudent.Controls.Add(this.labelName);
            this.panelAddStudent.Controls.Add(this.textBoxSurName);
            this.panelAddStudent.Controls.Add(this.textBoxName);
            this.panelAddStudent.Location = new System.Drawing.Point(19, 349);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Size = new System.Drawing.Size(596, 101);
            this.panelAddStudent.TabIndex = 24;
            this.panelAddStudent.Visible = false;
            this.panelAddStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddStudent_Paint);
            // 
            // panelAddThings
            // 
            this.panelAddThings.Controls.Add(this.buttonAdd);
            this.panelAddThings.Controls.Add(this.label5);
            this.panelAddThings.Controls.Add(this.label6);
            this.panelAddThings.Controls.Add(this.textBoxTitleThings);
            this.panelAddThings.Controls.Add(this.textBoxAutorThings);
            this.panelAddThings.Location = new System.Drawing.Point(98, 359);
            this.panelAddThings.Name = "panelAddThings";
            this.panelAddThings.Size = new System.Drawing.Size(417, 99);
            this.panelAddThings.TabIndex = 25;
            this.panelAddThings.Visible = false;
            this.panelAddThings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddThings_Paint);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(265, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 64);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tytuł: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Autor:";
            // 
            // textBoxTitleThings
            // 
            this.textBoxTitleThings.Location = new System.Drawing.Point(151, 35);
            this.textBoxTitleThings.Name = "textBoxTitleThings";
            this.textBoxTitleThings.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitleThings.TabIndex = 12;
            // 
            // textBoxAutorThings
            // 
            this.textBoxAutorThings.Location = new System.Drawing.Point(39, 35);
            this.textBoxAutorThings.Name = "textBoxAutorThings";
            this.textBoxAutorThings.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutorThings.TabIndex = 11;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddBook.Location = new System.Drawing.Point(621, 170);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(131, 64);
            this.buttonAddBook.TabIndex = 26;
            this.buttonAddBook.Text = "Dodaj";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMovie.Location = new System.Drawing.Point(621, 310);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(131, 64);
            this.buttonAddMovie.TabIndex = 27;
            this.buttonAddMovie.Text = "Dodaj";
            this.buttonAddMovie.UseVisualStyleBackColor = false;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSong.Location = new System.Drawing.Point(621, 244);
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.Size = new System.Drawing.Size(131, 64);
            this.buttonAddSong.TabIndex = 28;
            this.buttonAddSong.Text = "Dodaj";
            this.buttonAddSong.UseVisualStyleBackColor = false;
            this.buttonAddSong.Click += new System.EventHandler(this.buttonAddSong_Click);
            // 
            // buttonDelateMusic
            // 
            this.buttonDelateMusic.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDelateMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelateMusic.Location = new System.Drawing.Point(895, 244);
            this.buttonDelateMusic.Name = "buttonDelateMusic";
            this.buttonDelateMusic.Size = new System.Drawing.Size(131, 64);
            this.buttonDelateMusic.TabIndex = 29;
            this.buttonDelateMusic.Text = "Usuń Muzyki";
            this.buttonDelateMusic.UseVisualStyleBackColor = false;
            this.buttonDelateMusic.Click += new System.EventHandler(this.buttonDelateMusic_Click);
            // 
            // buttonDelateStudents
            // 
            this.buttonDelateStudents.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDelateStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelateStudents.Location = new System.Drawing.Point(895, 100);
            this.buttonDelateStudents.Name = "buttonDelateStudents";
            this.buttonDelateStudents.Size = new System.Drawing.Size(131, 64);
            this.buttonDelateStudents.TabIndex = 30;
            this.buttonDelateStudents.Text = "Usuń Studentów";
            this.buttonDelateStudents.UseVisualStyleBackColor = false;
            this.buttonDelateStudents.Click += new System.EventHandler(this.buttonDelateStudents_Click);
            // 
            // buttonDelateBooks
            // 
            this.buttonDelateBooks.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDelateBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelateBooks.Location = new System.Drawing.Point(895, 170);
            this.buttonDelateBooks.Name = "buttonDelateBooks";
            this.buttonDelateBooks.Size = new System.Drawing.Size(131, 64);
            this.buttonDelateBooks.TabIndex = 31;
            this.buttonDelateBooks.Text = "Usuń książki";
            this.buttonDelateBooks.UseVisualStyleBackColor = false;
            this.buttonDelateBooks.Click += new System.EventHandler(this.buttonDelateBooks_Click);
            // 
            // buttonDelateFilms
            // 
            this.buttonDelateFilms.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDelateFilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelateFilms.Location = new System.Drawing.Point(895, 314);
            this.buttonDelateFilms.Name = "buttonDelateFilms";
            this.buttonDelateFilms.Size = new System.Drawing.Size(131, 64);
            this.buttonDelateFilms.TabIndex = 32;
            this.buttonDelateFilms.Text = "UsuńFilmy";
            this.buttonDelateFilms.UseVisualStyleBackColor = false;
            this.buttonDelateFilms.Click += new System.EventHandler(this.buttonDelateFilms_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.label3);
            this.panelDelete.Controls.Add(this.textBoxID);
            this.panelDelete.Controls.Add(this.buttonDelete);
            this.panelDelete.Location = new System.Drawing.Point(300, 356);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(299, 100);
            this.panelDelete.TabIndex = 33;
            this.panelDelete.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Numer ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(39, 42);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 32;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(155, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 64);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonTurnBack
            // 
            this.buttonTurnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonTurnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTurnBack.Location = new System.Drawing.Point(7, 70);
            this.buttonTurnBack.Name = "buttonTurnBack";
            this.buttonTurnBack.Size = new System.Drawing.Size(131, 64);
            this.buttonTurnBack.TabIndex = 34;
            this.buttonTurnBack.Text = "Zwrot rzeczy do biblioteki";
            this.buttonTurnBack.UseVisualStyleBackColor = false;
            this.buttonTurnBack.Click += new System.EventHandler(this.buttonTurnBack_Click);
            // 
            // buttonRentPanel
            // 
            this.buttonRentPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRentPanel.Location = new System.Drawing.Point(621, 30);
            this.buttonRentPanel.Name = "buttonRentPanel";
            this.buttonRentPanel.Size = new System.Drawing.Size(131, 64);
            this.buttonRentPanel.TabIndex = 35;
            this.buttonRentPanel.Text = "Nowe wypożyczenie w bibliotece";
            this.buttonRentPanel.UseVisualStyleBackColor = false;
            this.buttonRentPanel.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // labelRentID
            // 
            this.labelRentID.AutoSize = true;
            this.labelRentID.Location = new System.Drawing.Point(14, 9);
            this.labelRentID.Name = "labelRentID";
            this.labelRentID.Size = new System.Drawing.Size(124, 13);
            this.labelRentID.TabIndex = 33;
            this.labelRentID.Text = "Numer ID wypożyczenia:";
            // 
            // textBoxRentID
            // 
            this.textBoxRentID.Location = new System.Drawing.Point(28, 31);
            this.textBoxRentID.Name = "textBoxRentID";
            this.textBoxRentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentID.TabIndex = 32;
            // 
            // panelRentBack
            // 
            this.panelRentBack.Controls.Add(this.labelRentID);
            this.panelRentBack.Controls.Add(this.textBoxRentID);
            this.panelRentBack.Controls.Add(this.buttonTurnBack);
            this.panelRentBack.Location = new System.Drawing.Point(144, 329);
            this.panelRentBack.Name = "panelRentBack";
            this.panelRentBack.Size = new System.Drawing.Size(143, 157);
            this.panelRentBack.TabIndex = 36;
            this.panelRentBack.Visible = false;
            // 
            // buttonTurnBackPanel
            // 
            this.buttonTurnBackPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonTurnBackPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTurnBackPanel.Location = new System.Drawing.Point(895, 30);
            this.buttonTurnBackPanel.Name = "buttonTurnBackPanel";
            this.buttonTurnBackPanel.Size = new System.Drawing.Size(131, 64);
            this.buttonTurnBackPanel.TabIndex = 35;
            this.buttonTurnBackPanel.Text = "Zwrot rzeczy do biblioteki";
            this.buttonTurnBackPanel.UseVisualStyleBackColor = false;
            this.buttonTurnBackPanel.Click += new System.EventHandler(this.buttonTurnBackPanel_Click);
            // 
            // panelNewRent
            // 
            this.panelNewRent.Controls.Add(this.labelSongID);
            this.panelNewRent.Controls.Add(this.textBoxSongRentID);
            this.panelNewRent.Controls.Add(this.labelMovieID);
            this.panelNewRent.Controls.Add(this.textBoxMovieRentID);
            this.panelNewRent.Controls.Add(this.buttonNewRent);
            this.panelNewRent.Controls.Add(this.labelBookID);
            this.panelNewRent.Controls.Add(this.labelStudentID);
            this.panelNewRent.Controls.Add(this.textBoxBookRentID);
            this.panelNewRent.Controls.Add(this.textBoxStudentRentID);
            this.panelNewRent.Location = new System.Drawing.Point(12, 395);
            this.panelNewRent.Name = "panelNewRent";
            this.panelNewRent.Size = new System.Drawing.Size(631, 99);
            this.panelNewRent.TabIndex = 37;
            this.panelNewRent.Visible = false;
            // 
            // labelSongID
            // 
            this.labelSongID.AutoSize = true;
            this.labelSongID.Location = new System.Drawing.Point(391, 19);
            this.labelSongID.Name = "labelSongID";
            this.labelSongID.Size = new System.Drawing.Size(57, 13);
            this.labelSongID.TabIndex = 24;
            this.labelSongID.Text = "ID Muzyki:";
            // 
            // textBoxSongRentID
            // 
            this.textBoxSongRentID.Location = new System.Drawing.Point(363, 35);
            this.textBoxSongRentID.Name = "textBoxSongRentID";
            this.textBoxSongRentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSongRentID.TabIndex = 23;
            // 
            // labelMovieID
            // 
            this.labelMovieID.AutoSize = true;
            this.labelMovieID.Location = new System.Drawing.Point(276, 19);
            this.labelMovieID.Name = "labelMovieID";
            this.labelMovieID.Size = new System.Drawing.Size(51, 13);
            this.labelMovieID.TabIndex = 22;
            this.labelMovieID.Text = "ID Filmu: ";
            // 
            // textBoxMovieRentID
            // 
            this.textBoxMovieRentID.Location = new System.Drawing.Point(257, 35);
            this.textBoxMovieRentID.Name = "textBoxMovieRentID";
            this.textBoxMovieRentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMovieRentID.TabIndex = 20;
            // 
            // buttonNewRent
            // 
            this.buttonNewRent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNewRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewRent.Location = new System.Drawing.Point(489, 12);
            this.buttonNewRent.Name = "buttonNewRent";
            this.buttonNewRent.Size = new System.Drawing.Size(131, 64);
            this.buttonNewRent.TabIndex = 19;
            this.buttonNewRent.Text = "Dodaj";
            this.buttonNewRent.UseVisualStyleBackColor = false;
            this.buttonNewRent.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(186, 19);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(57, 13);
            this.labelBookID.TabIndex = 14;
            this.labelBookID.Text = "ID Książki:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(58, 19);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(67, 13);
            this.labelStudentID.TabIndex = 13;
            this.labelStudentID.Text = "ID Studenta:";
            // 
            // textBoxBookRentID
            // 
            this.textBoxBookRentID.Location = new System.Drawing.Point(151, 35);
            this.textBoxBookRentID.Name = "textBoxBookRentID";
            this.textBoxBookRentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookRentID.TabIndex = 12;
            // 
            // textBoxStudentRentID
            // 
            this.textBoxStudentRentID.Location = new System.Drawing.Point(39, 35);
            this.textBoxStudentRentID.Name = "textBoxStudentRentID";
            this.textBoxStudentRentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentRentID.TabIndex = 11;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(806, 384);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(194, 113);
            this.buttonBack.TabIndex = 38;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(621, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 64);
            this.button1.TabIndex = 39;
            this.button1.Text = "Dodaj studenta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelAutorName
            // 
            this.labelAutorName.AutoSize = true;
            this.labelAutorName.Location = new System.Drawing.Point(728, 476);
            this.labelAutorName.Name = "labelAutorName";
            this.labelAutorName.Size = new System.Drawing.Size(72, 13);
            this.labelAutorName.TabIndex = 40;
            this.labelAutorName.Text = "Michał Kalina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 498);
            this.Controls.Add(this.labelAutorName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelNewRent);
            this.Controls.Add(this.buttonTurnBackPanel);
            this.Controls.Add(this.panelRentBack);
            this.Controls.Add(this.buttonRentPanel);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.buttonDelateFilms);
            this.Controls.Add(this.buttonDelateBooks);
            this.Controls.Add(this.panelAddThings);
            this.Controls.Add(this.buttonDelateStudents);
            this.Controls.Add(this.buttonDelateMusic);
            this.Controls.Add(this.buttonAddSong);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.panelAddStudent);
            this.Controls.Add(this.buttonShowMovies);
            this.Controls.Add(this.buttonShowSongs);
            this.Controls.Add(this.buttonShowBooks);
            this.Controls.Add(this.buttonShowWypozycznia);
            this.Controls.Add(this.buttonShowStudents);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.panelAddStudent.ResumeLayout(false);
            this.panelAddStudent.PerformLayout();
            this.panelAddThings.ResumeLayout(false);
            this.panelAddThings.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelRentBack.ResumeLayout(false);
            this.panelRentBack.PerformLayout();
            this.panelNewRent.ResumeLayout(false);
            this.panelNewRent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowBooks;
        private System.Windows.Forms.Button buttonShowWypozycznia;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonShowStudents;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonShowSongs;
        private System.Windows.Forms.Button buttonShowMovies;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Panel panelAddStudent;
        private System.Windows.Forms.Panel panelAddThings;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTitleThings;
        private System.Windows.Forms.TextBox textBoxAutorThings;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonAddSong;
        private System.Windows.Forms.Button buttonDelateMusic;
        private System.Windows.Forms.Button buttonDelateStudents;
        private System.Windows.Forms.Button buttonDelateBooks;
        private System.Windows.Forms.Button buttonDelateFilms;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonTurnBack;
        private System.Windows.Forms.Button buttonRentPanel;
        private System.Windows.Forms.Label labelRentID;
        private System.Windows.Forms.TextBox textBoxRentID;
        private System.Windows.Forms.Panel panelRentBack;
        private System.Windows.Forms.Button buttonTurnBackPanel;
        private System.Windows.Forms.Panel panelNewRent;
        private System.Windows.Forms.Label labelSongID;
        private System.Windows.Forms.TextBox textBoxSongRentID;
        private System.Windows.Forms.Label labelMovieID;
        private System.Windows.Forms.TextBox textBoxMovieRentID;
        private System.Windows.Forms.Button buttonNewRent;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox textBoxBookRentID;
        private System.Windows.Forms.TextBox textBoxStudentRentID;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAutorName;
    }
}

