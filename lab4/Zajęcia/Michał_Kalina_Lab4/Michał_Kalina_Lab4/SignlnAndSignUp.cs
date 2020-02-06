using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michał_Kalina_Lab4
{
    class SignlnAndSignUp : ISignInAndSignUpService
    {
        /// <summary>
        /// zwraca liczbe uzytkownikow boolowska
        /// </summary>
        public bool IsTrue{get;set;}

        /// <summary>
        /// konstrukotor domyslny
        /// </summary>

        public SignlnAndSignUp()
        {
            IsTrue = false;
        }
        /// <summary>
        /// Metoda rejestrujaca uzytkownika do ststemu
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="surnname"></param>
        /// <param name="studentIndex"></param>
        /// <param name="email"></param>
        public void SignUpToSystem(string username, string password, string name, string surnname, string studentIndex, string email)
        {
            //throw new NotImplementedException();
            using (RegistrationSystemApprenticeEntities context = new RegistrationSystemApprenticeEntities())
            {
                //Zmienna pozwalajaca na dodawanie do bazy danych
                var registerLoginlData = context.StudentLogInSystem.FirstOrDefault();
                registerLoginlData.UserName = username;
                registerLoginlData.Password = password;

                //zmienna pozwalajca na dodanie do bazy danych informacji o danych o uzytkowniku
                var registerPersonalData = context.InformationAboutStudent.FirstOrDefault();
                registerPersonalData.Name = name;
                registerPersonalData.Surnname = surnname;
                registerPersonalData.StudentIndex = studentIndex;
                registerPersonalData.Email = email;

                var checkUserExist = context.StudentLogInSystem.Where(x => x.UserName == username).Count();
                
                if(checkUserExist<1)
                {
                    context.StudentLogInSystem.Add(registerLoginlData);
                    context.InformationAboutStudent.Add(registerPersonalData);

                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Użytkownik o tym loginie juz istnieje");

                }

            }
        }
        /// <summary>
        /// Logowanie sie do systemu
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public bool SingInToSystem(string username, string password)
        {
            using (RegistrationSystemApprenticeEntities context = new RegistrationSystemApprenticeEntities())
            {
                var signIn = context.StudentLogInSystem.Where(x => x.UserName == username && x.Password == password).Count();
                if(signIn>=1)
                {
                    IsTrue = true;
                }

                return IsTrue;
            }
        }

        public bool UserExist(string username)
        {
            throw new NotImplementedException();
        }
    }
}
