using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichałKalinaLab6.ViewModels
{
    public class CarVM
    {

        //Model samochodu
        public string Model { get; set; }
        //Marka samochodu
        public string Manufacturer { get; set; }
        //cena
        public decimal Price { get; set; }
        //sciezka do zdjecia
        public string Photo { get; set; }

        public CarVM(string model, string manufacturrer, int price, string photo)
        {
            Model = model;
            Manufacturer = manufacturrer;
            Price = price;
            Photo = photo;
        }

    }
}