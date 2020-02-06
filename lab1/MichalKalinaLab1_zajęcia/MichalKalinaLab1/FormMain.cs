using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalKalinaLab1
{
    public partial class FormMain : Form
    {
       
        int counter = 0, counterChange=0, counterTime=0;
        public FormMain()
        {

            InitializeComponent();
        }
        /// <summary>
        /// Funkcja zanykajaca okienko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Zamkniecie okien
            Close();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //zmienia tlo i przycisk zamnij
            this.BackColor = Color.Cornsilk;
            buttonClose.BackColor = Color.GreenYellow;
            buttonChange.Hide();
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            //Zmienna prezech. wartosci
            string dataString = " ";
            dataString = textBoxDataDZIALANIE_2.Text;
            counterChange = Int32.Parse(dataString);
            counterChange++;
            MessageBox.Show(counterChange.ToString());
            textBoxDataDZIALANIE_2.Text = counterChange.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dataString = " ", dataString2 = " ";
            dataString = textBoxDataDZIALANIE_2.Text;
            dataString2 = textBoxDZIALANIE.Text;
            counter = Int32.Parse(dataString)* Int32.Parse(dataString2);
            dataString2 = textBoxDZIALANIE.Text;
            
            MessageBox.Show(counter.ToString());
            textBoxWYNIK.Text = counter.ToString();

      
        }

        private void DOD_Click(object sender, EventArgs e)
        {
            string dataString = " ", dataString2 = " ";
            dataString = textBoxDataDZIALANIE_2.Text;
            dataString2 = textBoxDZIALANIE.Text;
            counter = Int32.Parse(dataString) + Int32.Parse(dataString2);
            dataString2 = textBoxDZIALANIE.Text;

            MessageBox.Show(counter.ToString());
            textBoxWYNIK.Text = counter.ToString();


        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            string dataString = " ", dataString2 = " ";
            dataString = textBoxDataDZIALANIE_2.Text;
            dataString2 = textBoxDZIALANIE.Text;
            counter = Int32.Parse(dataString) - Int32.Parse(dataString2);
            dataString2 = textBoxDZIALANIE.Text;

            MessageBox.Show(counter.ToString());
            textBoxWYNIK.Text = counter.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dataString = " ", dataString2 = " ";
            dataString = textBoxDataDZIALANIE_2.Text;
            dataString2 = textBoxDZIALANIE.Text;
            counter = Int32.Parse(dataString) * Int32.Parse(dataString2);
            dataString2 = textBoxDZIALANIE.Text;
            if (counter > 5)
                this.BackColor = Color.Gray;
            textBoxWYNIK.Text = counter.ToString();


        }

        private void Start_Click(object sender, EventArgs e)
        {
            TimerCounter.Interval = 1000;
    
            TimerCounter.Start();
        }

        private void TimerCounter_Tick(object sender, EventArgs e)
        {
            counterTime++;
            textBoxCZAS.Text = counterTime.ToString();
            if (counterTime == 10)
                this.BackColor = Color.Violet;
            
        }

        private void textBoxCZAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zmienia kolor przycisku zamnij
            buttonClose.BackColor = Color.Green;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
