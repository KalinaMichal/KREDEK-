using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichałKalina_Lab2
{
    class Unicorn : Horse
    {
        /// <summary>
        /// wlasciwosci- kolor rogu
        /// </summary>
        public string HornColor { get; set; }

        //konstruktor bezparametriwy

        public Unicorn()
        {
            
        }

        public Unicorn(Horse horse)
        {
            //przypisywanie wartosci z objektu "horse" do wartosci z DANEGO objektu
            this.Name = horse.Name;


            this.FavouriteNumber = horse.FavouriteNumber;


        }
    }
}
