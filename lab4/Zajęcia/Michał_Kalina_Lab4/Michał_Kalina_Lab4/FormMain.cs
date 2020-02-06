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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ISignInAndSignUpService login = new SignlnAndSignUp();
            if (login.SingInToSystem(textBoxLogin.Text, textBoxPassword.Text)==true)
            {
                MessageBox.Show("Zostałeś zalogowany");
            }
            else
            {
                MessageBox.Show("error");

            }
        }

        private void buttonRegisterShow_Click(object sender, EventArgs e)
        {
            FormRegister signUp = new FormRegister();
            this.Hide();
            signUp.Show();
        }
    }
}
