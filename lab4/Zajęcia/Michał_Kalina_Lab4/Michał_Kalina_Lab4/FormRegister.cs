using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michał_Kalina_Lab4
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            FormMain main = new FormMain();
            SignlnAndSignUp singUp = new SignlnAndSignUp();

            /// Zmienna typu bool, sprawdzająca czy użytkownik o podanej nazwie konta istnieje.
            var isTrue = singUp.UserExist(textBoxUserName.Text);

            singUp.SignUpToSystem(textBoxUserName.Text, textBoxPassword.Text, textBoxName.Text, textBoxSurnname.Text, textBoxStudentIndex.Text, textBoxEmail.Text);

            ///Jeżeli użytkownik nie istnieje to zamknij formularz rejestracji.
            if (isTrue == true)
            {
                this.Close();
                main.Show();
            }
        }
    
    }
}
