using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalKalinaZDlab6.ViewModels
{
    public class UserVM
    {
        // imie
        public string UserName { get; set; }
        // nazwisko
        public string SurName { get; set; }
        //liczba
        public int Number { get; set; }


        public UserVM(string userName, string surName, int number)
        {
           UserName = userName;
            Number = number;
            SurName = surName;
            
        }
    }
}