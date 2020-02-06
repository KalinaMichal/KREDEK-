using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Michał_Kalina_Lab3_Zadanie_Domowe
{
    public partial class Form1 : Form
    {
        int CaseThings=0; //pomaga wybrac odpowiedni parametr do funkcji

        int CaseDelete = 0;//pomaga wybrac odpowiedni parametr do funkcji

        /// <summary>
        /// Polaczenie z baza danych
        /// </summary>
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=KALINA\MICHALSQL; database=Test;Trusted_connection=yes");
        }
        private void ShowData(string tableName)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT*FROM {tableName}", connection);
            DataTable table = new DataTable();
            //Wypelnianie tablicy
            dataAdapter.Fill(table);
            //Wyswietlanie
            dataGridViewData.DataSource = table;

        }
        private void Hide()//zamyka okna
        {
            panelDelete.Hide();
            panelAddStudent.Hide();
            panelAddThings.Hide();
            panelRentBack.Hide();
            panelNewRent.Hide();
        }
        private void Delete(string tableName)
        {

            //Students(FirstName, LastName, Address, StudentIdent)
            SqlCommand command = new SqlCommand($@"DELETE FROM {tableName} WHERE ID=@id", connection);
            //Dodawanie parametrow kwerendy
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBoxID.Text;

            //Wykonywanie kwerendy
            connection.Open();
            //daje mozliwosc edycji
            command.ExecuteNonQuery();

            //Dodawanie nowego kursu do bazy danych

            connection.Close(); //zamyka polaczenie
        }
        private void Add(string tableName)
        {
            //Students(FirstName, LastName, Address, StudentIdent)
            SqlCommand command = new SqlCommand($@"INSERT INTO {tableName} (Name,Autor) VALUES (@Name, @Autor)", connection);
            //Dodawanie parametrow kwerendy
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxTitleThings.Text;
            command.Parameters.Add("@Autor", SqlDbType.NVarChar).Value = textBoxAutorThings.Text;
            //Wykonywanie kwerendy
            connection.Open();
            //daje mozliwosc edycji
            command.ExecuteNonQuery();

            //Dodawanie nowego kursu do bazy danych

            connection.Close(); //zamyka polaczenie
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewCourses_Click(object sender, EventArgs e)
        {
            ShowData("Books");//pokazuje tabelę
        }

        private void buttonViewGrades_Click(object sender, EventArgs e)
        {
            ShowData("Students");//pokazuje tabelę
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            ShowData("RentIndex");//pokazuje tabelę

        }

        private void buttonShowSongs_Click(object sender, EventArgs e)
        {
            ShowData("Songs");//pokazuje tabelę
        }

        private void buttonShowMovies_Click(object sender, EventArgs e)
        {
            ShowData("Movies");//pokazuje tabelę
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            //Students(FirstName, LastName, Address, StudentIdent)
            SqlCommand command = new SqlCommand(@"INSERT INTO Students(FirstName, LastName, Address, StudentIdent) VALUES (@Name, @SurName,@Adress,@StudentIdent)", connection);
            //Dodawanie parametrow kwerendy
            command.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = textBoxSurName.Text;
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxName.Text;
            command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = textBoxAdress.Text;
            command.Parameters.Add("@StudentIdent", SqlDbType.NVarChar).Value = textBoxStudentID.Text;
            //Wykonywanie kwerendy
            connection.Open();
            //daje mozliwosc edycji
            command.ExecuteNonQuery();

            //Dodawanie nowego kursu do bazy danych

            connection.Close(); //zamyka polaczenie
            panelAddStudent.Hide();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Hide();
            panelAddThings.Show();
            CaseThings = 1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)//sprawdza co ma dodać i to dodaje
        {
            if(CaseThings == 1)
            {
                Add("Books");
            }
            if (CaseThings == 2)
            {
                Add("Songs");
            }
            if (CaseThings == 3)
            {
                Add("Movies");
            }
            panelAddThings.Hide();
        }

        private void buttonAddSong_Click(object sender, EventArgs e)//dodaje muzykę
        {
            Hide();
            CaseThings = 2;
            panelAddThings.Show();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)//dodaje film
        {
            Hide();
            CaseThings = 3;
            panelAddThings.Show();
        }

        private void panelAddThings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)//sprawdza co ma usunac i to usuwa
        {
            if (CaseDelete == 1)
            {
                Delete("Books");
            }
            if (CaseDelete == 2)
            {
                Delete("Movies");
            }
            if (CaseDelete == 3)
            {
                Delete("Songs");
            }
            if (CaseDelete == 4)
            {
                Delete("Students");
            }
            panelDelete.Hide();

        }

        private void buttonDelateBooks_Click(object sender, EventArgs e)//usuwa
        {
            Hide();
            CaseDelete = 1;
            panelDelete.Show();
        }

        private void buttonDelateMusic_Click(object sender, EventArgs e)//usuwa
        {
            Hide();
            CaseDelete = 3;
            panelDelete.Show();
        }

        private void buttonDelateFilms_Click(object sender, EventArgs e)//usuwa
        {
            Hide();
            CaseDelete = 2;
            panelDelete.Show();
        }

        private void buttonDelateStudents_Click(object sender, EventArgs e)//usuwa studenta
        {
            Hide();
            CaseDelete = 4;
            panelDelete.Show();
        }

        private void buttonTurnBack_Click(object sender, EventArgs e)
        {
            panelRentBack.Hide();
            //Students(FirstName, LastName, Address, StudentIdent)
            SqlCommand command = new SqlCommand(@"DELETE FROM RentIndex WHERE ID=@id", connection);
            //Dodawanie parametrow kwerendy
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBoxRentID.Text;

            //Wykonywanie kwerendy
            connection.Open();
            //daje mozliwosc edycji
            command.ExecuteNonQuery();

            //Dodawanie nowego kursu do bazy danych

            connection.Close(); //zamyka polaczenie

        }

        private void buttonTrurnBackLast_Click(object sender, EventArgs e)
        {

        }

        private void buttonRent_Click(object sender, EventArgs e)//dodaje wyporzyczenie
        {
            Hide();
            panelNewRent.Show();
        }

        private void buttonTurnBackPanel_Click(object sender, EventArgs e)//pokazuje panel wyporzyczenia ksiazki
        {
            Hide();
            panelRentBack.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelNewRent.Hide();
            //Students(FirstName, LastName, Address, StudentIdent)
            SqlCommand command = new SqlCommand(@"INSERT INTO RentIndex (StudentID,BookID,MovieID,SongID) VALUES (@StudentID, @BookID,@MovieID,@SongID)", connection);
            //Dodawanie parametrow kwerendy
            command.Parameters.Add("@StudentID", SqlDbType.NVarChar).Value = textBoxStudentRentID.Text;
            command.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = textBoxBookRentID.Text;
            command.Parameters.Add("@MovieID", SqlDbType.NVarChar).Value = textBoxMovieRentID.Text;
            command.Parameters.Add("@SongID", SqlDbType.NVarChar).Value = textBoxSongRentID.Text;
            
            //Wykonywanie kwerendy
            connection.Open();
            //daje mozliwosc edycji
            command.ExecuteNonQuery();

            //Dodawanie nowego kursu do bazy danych

            connection.Close(); //zamyka polaczenie
        }

        private void buttonBack_Click(object sender, EventArgs e)//chowa wszystkie panele
        {
            Hide();
        }

        private void panelAddStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//pokazuje panel dodaj studenta
        {
            Hide();
            panelAddStudent.Show();
        }
    }
}
