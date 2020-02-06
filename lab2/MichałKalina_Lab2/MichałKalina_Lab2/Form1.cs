using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichałKalina_Lab2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// wlsciwosci - lista koniow
        /// </summary>

        public List<Horse> HorseList { get; set; }



        public Form1()
        {
            InitializeComponent();

            //tworzenie zdefiniowanej listy
            HorseList = new List<Horse>();
        }
        /// <summary>
        /// Dodanie nowego konia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // tworzenie obiektu"kon" na podstawie danych, ktore wprowadzamy do textboxow
            //obiekt zostanie stworzonyw srodku funkcji "GetHorseData"
            //i zwrocony do zmiennej lokalknej "newHorse"
            Horse newHorse = GetHorseData();

            //dodawanie konia do listy
            HorseList.Add(newHorse);

        }

        private void AddUnicorn_Click(object sender, EventArgs e)     //Prywatna metoda
                                                                      //ktora na wejsciu nie ma parametow
        {
            Horse horse = GetHorseData();

            //tworzenie objektu jednorozca na podstawie objektu "horse"
            Unicorn unicorn = new Unicorn (horse);

            unicorn.HornColor=textBoxHornColor.Text;

            HorseList.Add(unicorn);
            HorseList.Add(horse);
            

       
        }


        public Horse GetHorseData()
        {
            #region
            //tworzenie konia
            Horse newHorse = new Horse();
            

            //przypisywanie wartosci do wlasnosci Name
            newHorse.Name = "Franek";

            //przyp wart z textboxa
            newHorse.Name = textBoxName.Text;

            //przypisywanie wartosci do wlasnosci FavouritaName
            //newHorse.FavouriteNumber = 1;
            newHorse.FavouriteNumber = int.Parse(textBoxFavouriteNumber.Text);

            #endregion 

            //zwracanie obiektu
            return newHorse;


        }
    }
}
