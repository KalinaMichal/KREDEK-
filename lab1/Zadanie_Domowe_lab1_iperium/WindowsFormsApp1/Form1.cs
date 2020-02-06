using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       public int counterRabit = 0, counterDog = 0, counterOdyniec = 0, counterCow = 0, counterKango = 0; //licznik zasobow(zwierząt)
        public int TimevalueDog = 1, TimevalueRabit = 1, TimevalueOdyniec = 1, TimevalueCow = 1, TimevalueKango = 1; //wartosc ile zwierzat sie produkuje w jedej sekundzie.
        public int valueDog = 2, valueRabit = 1,valueOdyniec=3,valueCow=4,valueKango=5; //wartosc za poszczegolne zwierzęta(w monetach)
        public int money = 0; //licznik pieniedzy
        public int DogLimit = 20, OdyniecLimit =5 , CowLimit = 0, KangoLimit = 0; //licznik miejsca w magazynie, kroliki maja nieskonczonosc.
        int iRabit = 5, iDog=10, iOdyniec=4, iCow=50, iKango=100; //i-taka jakby petla (zwiekszacz ceny za updateCeny)
        int itRabit = 25, itDog = 100, itOdyniec = 150, itCow = 300, itKango = 500;  //i-taka jakby petla (zwiekszacz ceny za updateCzasu)
        int  isDog = 100, isOdyniec = 100, isCow = 100, isKango = 100; //i-taka jakby petla (zwiekszacz ceny za updateMagazynu)
        int LoseCounter = 0, LoseCounterValue=1000, LoseCounterShaman=0; //odlicza punkty zlosci przy szamanie i gangu
        int DisasterOption = 1; //służy do wybierania rodzaju katastrofy
        int RabitMakeTime=1000; //czas w jakim tworzy sie 1 krolik
        int RabitMakeTimePrice = 10; //ilosc monet jakie trzeba zaplacic by zmniejszyc czas produkcji krolika czas 

        private void buttonDogTimeUP_Click(object sender, EventArgs e)//zwieksza produkcje na sekunde
        {

            if (itDog <= money)
            {
                TimevalueDog = TimevalueDog + 1;
                money = money - itDog;
                itDog = (itDog * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTDog.Text = itDog.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void buttonOdyniecTimeUP_Click(object sender, EventArgs e)//zwieksza produkcje na sekunde
        {

            if (itOdyniec <= money)
            {
                TimevalueOdyniec = TimevalueOdyniec + 1;
                money = money - itOdyniec;
                itOdyniec = (itOdyniec * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTOdyniec.Text = itOdyniec.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void buttonCowTimeUP_Click(object sender, EventArgs e)//zwieksza produkcje na sekunde
        {

            if (itCow <= money)
            {
                TimevalueCow = TimevalueCow + 1;
                money = money - itCow;
                itCow = (itCow * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTCow.Text = itCow.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void StockroomDogUP_Click(object sender, EventArgs e)//zwieksza miejsce w magazynie
        {

            if (isDog <= money)
            {
                DogLimit = DogLimit*2;
                money = money - isDog;
                isDog = (isDog * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxDog.Text = DogLimit.ToString();
                labelMaxDogUP.Text = isDog.ToString();

            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void StockroomOdyniecUP_Click(object sender, EventArgs e)//zwieksza miejsce w magazynie
        {

            if (isOdyniec <= money)
            {
                OdyniecLimit = OdyniecLimit * 2;
                money = money - isDog;
                isOdyniec = (isOdyniec * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxOdyniec.Text = OdyniecLimit.ToString();
                labelMaxOdyniecUP.Text = isOdyniec.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void StockroomCowUP_Click(object sender, EventArgs e)//zwieksza miejsce w magazynie
        {
            if (isCow <= money)
            {
                CowLimit = CowLimit * 2;
                money = money - isCow;
                isCow = (isCow * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxCow.Text = CowLimit.ToString();
          
                labelMaxCowUP.Text = isCow.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void StockroomKangoUP_Click(object sender, EventArgs e)//zwieksza miejsce w magazynie
        {
            if (isKango <= money)
            {
                KangoLimit = KangoLimit*2;
                money = money - isKango;
                isKango = (isKango * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxKango.Text = KangoLimit.ToString();
                labelMaxKangoUP.Text = isKango.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoseUP_Click(object sender, EventArgs e)//Bierze 100 monet. Zmniejsza poziom zlosci o polowe
        {
            if ( money>=100)
            {
                LoseCounter = LoseCounter / 2;
                money = money - 100;
                MoneyLabel.Text = money.ToString();
                labelLoseCounter.Text = LoseCounter.ToString();

            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! Gang chce od ciebie 100 monet ");
            }
        }

        private void labelLoseCounter_Click(object sender, EventArgs e)
        {

        }

        private void buttonOdyniec_Click(object sender, EventArgs e)
        {

        }

        private void buttonCow_Click(object sender, EventArgs e)
        {

        }

        private void labelPriceTOdyniec_Click(object sender, EventArgs e)
        {

        }

        private void timerDisaster_Tick(object sender, EventArgs e) //liczy czas i co 1min wybiera 1 katastrofe
        {
            if (DisasterOption == 1)
            {
                counterRabit = 0;
                DisasterOption++;
                MessageBox.Show("Wilk zjadł wszystkie króliki");
            }
            else
            {
                if (DisasterOption == 2)
                {
                    money = 0;
                    DisasterOption++;
                    MessageBox.Show("Spalił ci się dom. Wszystkie pieniądze poszły na jego odbudowę. ");
                    MoneyLabel.Text = "0";
                }
                else
                {
                    if (DisasterOption == 3)
                    {
                        counterDog = 0;
                        DisasterOption++;
                        MessageBox.Show("Psy zostały zatrute i zdechły");
                    }
                    else
                    {
                        if (DisasterOption == 4)
                        {
                            counterOdyniec = 0;
                            DisasterOption++;
                            MessageBox.Show(" Dziki zachorowały i pomarły");
                        }
                        else
                        {
                            if (DisasterOption == 5)
                            {
                                money = 0;
                                DisasterOption++;
                                MessageBox.Show("Okradli cię ");
                            }
                            else
                            {
                                if (DisasterOption == 6)
                                {
                                    counterCow = 0;
                                    DisasterOption++;
                                    MessageBox.Show("Krowy umarły ");
                                }

                                else
                                {
                                    counterKango = 0;
                                    DisasterOption = 1;
                                    MessageBox.Show("Wszystkie kangury uciekły ");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void labelLoseCounterShaman_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e) //skaldanie ofiary szamanowi. Zmniejsza wskaznik do 0.
        {
            if(counterRabit>=50 && counterDog>=10)
            {
                counterRabit = counterRabit - 50;
                counterDog = counterDog - 10;
                LoseCounterShaman = 0;

            }
            else
            {
                MessageBox.Show("Nie masz tylu królików i psów ");
            }
        }

        private void AddRabit_Click(object sender, EventArgs e)//dodaje 1 zwierze do licznika sprzedawania
        {
            int x;
            x = Int32.Parse(textBoxSellRabit.Text);
            x++;
            textBoxSellRabit.Text = x.ToString();
        }

        private void AddDog_Click(object sender, EventArgs e)//dodaje 1 zwierze do licznika sprzedawania
        {
            int x;
            x = Int32.Parse(textBoxSellDog.Text);
            x++;
            textBoxSellDog.Text = x.ToString();
        }

        private void AddOdyniec_Click(object sender, EventArgs e)//dodaje 1 zwierze do licznika sprzedawania
        {
            int x;
            x = Int32.Parse(textBoxSellOdyniec.Text);
            x++;
            textBoxSellOdyniec.Text = x.ToString();
        }

        private void AddCow_Click(object sender, EventArgs e)//dodaje 1 zwierze do licznika sprzedawania
        {
            int x;
            x = Int32.Parse(textBoxSellCow.Text);
            x++;
            textBoxSellCow.Text = x.ToString();
        }

        private void AddKango_Click(object sender, EventArgs e)//dodaje 1 zwierze do licznika sprzedawania
        {
            int x;
            x = Int32.Parse(textBoxSellKango.Text);
            x++;
            textBoxSellKango.Text = x.ToString();
        }

        private void button1_Click_5(object sender, EventArgs e) //kupowanie, odblokowanie kangura
        {
            if (isKango <= money)
            {
                KangoLimit = KangoLimit +1;
                money = money - isKango;
                isKango = (isKango * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxKango.Text = KangoLimit.ToString();


                labelMaxKangoUP.Text = isKango.ToString();
                buttonBuyKango.Hide();
                pictureBoxBlockKango.Hide();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
            

        }

        private void buttonClose_Click(object sender, EventArgs e)//prawie zamyka program
        {
            buttonNO.Show();
            buttonYES.Show();
            labelAreUSure.Show();

        }

        private void buttonNO_Click(object sender, EventArgs e)//nie zamyka programu
        {
            buttonNO.Hide();
            buttonYES.Hide();
            labelAreUSure.Hide();
        }

        private void buttonYES_Click(object sender, EventArgs e)//zamyka program calokwicie
        {
            this.Close();
        }

        private void MoneyLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRabitAll_Click(object sender, EventArgs e)//dodaaje do licznika sprzedawania wszystkie krolik
        {
            textBoxSellRabit.Text = counterRabit.ToString();
                 
        }

        private void button1_Click_6(object sender, EventArgs e)//dodaaje do licznika sprzedawania wszystkie psy
        {
            textBoxSellDog.Text = counterDog.ToString();
        }

        private void buttonAllOdyniec_Click(object sender, EventArgs e)//dodaaje do licznika sprzedawania wszystkie odynce
        {
            textBoxSellOdyniec.Text = counterOdyniec.ToString();
        }

        private void buttonAllCow_Click(object sender, EventArgs e)//dodaaje do licznika sprzedawania wszystkie krowy
        {
            textBoxSellCow.Text = counterCow.ToString();
        }

        private void buttonAllKango_Click(object sender, EventArgs e)//dodaaje do licznika sprzedawania wszystkie kangury
        {
            textBoxSellKango.Text = counterKango.ToString();
        }

        

        private void buttonSellAll_Click(object sender, EventArgs e)//sprzedaje wszystko
        {
     
            money = money + ((counterRabit * valueRabit) + (counterDog * valueDog) + (counterOdyniec * valueOdyniec) + (counterCow * valueCow) + (counterKango * valueKango));
            counterRabit = 0; counterDog = 0; counterOdyniec = 0; counterCow = 0;counterKango = 0;
            MoneyLabel.Text = money.ToString();
            RabitShow.Text = counterRabit.ToString();
            DogShow.Text = counterDog.ToString();
            OdyniecShow.Text = counterOdyniec.ToString();
            CowShow.Text = counterCow.ToString();
            KangoShow.Text = counterKango.ToString();

        }

        private void buttonBuyCow_Click(object sender, EventArgs e) //odblokuj krowy
        {
            if (80 <= money)
            {
                CowLimit = 2;
                money = money - 80;
            
                MoneyLabel.Text = money.ToString();
                labelMaxCow.Text = CowLimit.ToString();

                labelMaxCowUP.Text = isCow.ToString();
                buttonBuyCow.Hide();
                pictureBoxBlockCow.Hide();
            }
            else
            {
                MessageBox.Show("Nie możesz kupić pastwiska, ponieważ nie masz tylu pieniędzy! ");
            }
        }

        private void buttonFasterRabit_Click(object sender, EventArgs e) //szybsza produkcja krolikow
        {
            if (RabitMakeTimePrice <= money) 
            {
                if (RabitMakeTimePrice > 1000)
                {
                    RabitMakeTime = RabitMakeTime - 1000;
                    RabitMakeTimePrice = RabitMakeTimePrice * 2;
                    MoneyLabel.Text = money.ToString();
                    labelRabitFaster.Text = RabitMakeTimePrice.ToString();
                }
                else
                { 
                    RabitMakeTime = RabitMakeTime - 50;
                    RabitMakeTimePrice = RabitMakeTimePrice * 2;
                    MoneyLabel.Text = money.ToString();
                    labelRabitFaster.Text = RabitMakeTimePrice.ToString();
                }
                if (RabitMakeTime < 200)
                {
                    
                    buttonFasterRabit.Hide();
                }
            }
            else
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
        }

        private void labelRabitSpeed_Click(object sender, EventArgs e)
        {

        }

        private void labelPriceTDog_Click(object sender, EventArgs e)
        {

        }

        private void labelMaxOdyniecUP_Click(object sender, EventArgs e)
        {

        }

        private void labelMaxKango_Click(object sender, EventArgs e)
        {

        }

        private void labelMaxDog_Click(object sender, EventArgs e)
        {

        }

        private void labelPriceKango_Click(object sender, EventArgs e)
        {

        }

        private void labelPriceTKango_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_8(object sender, EventArgs e)
        {
            TimerRabit.Interval = 1000;
            TimerRabit.Start();
            TimerDog.Interval = 2000;
            TimerDog.Start();
            TimerOdyniec.Interval = 5000;
            TimerOdyniec.Start();
            TimerCow.Interval = 10000;
            TimerCow.Start();
            TimerKango.Interval = 15000;
            TimerKango.Start();
            timerLoseGameSeba.Interval = LoseCounterValue;
            timerLoseGameSeba.Start();
            timerDisaster.Interval = 60000;
            timerDisaster.Start();
            timerLoseGameShaman.Interval = LoseCounterValue;
            timerLoseGameShaman.Start();


            //START.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)//skraca czas produkcji krolika
        {
            if (RabitMakeTimePrice <= money)
            {
                if (RabitMakeTimePrice > 500)
                {
                    RabitMakeTime = RabitMakeTime/2;
                    money = money - RabitMakeTimePrice;
                    RabitMakeTimePrice = RabitMakeTimePrice * 2;
                    MoneyLabel.Text = money.ToString();
                    labelRabitFaster.Text = RabitMakeTimePrice.ToString();
                    TimerRabit.Stop();
                    TimerRabit.Interval = RabitMakeTime;
                    TimerRabit.Start();
                }
                else
                {
                    RabitMakeTime = (RabitMakeTime+30)/2;
                    money = money - RabitMakeTimePrice;
                    RabitMakeTimePrice = (RabitMakeTimePrice+100) * 2;
                    MoneyLabel.Text = money.ToString();
                    labelRabitFaster.Text = RabitMakeTimePrice.ToString();
                    TimerRabit.Stop();
                    TimerRabit.Interval = RabitMakeTime;
                    TimerRabit.Start();
                }
                if (RabitMakeTime < 40)
                {

                    buttonFasterRabit.Hide();
                    labelRabitFaster.Hide();
                }
            }
            else
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)//podnosi cene za 1 zwierze
        {

            if (iRabit <= money)
            {
                if (iRabit > 50)
                {
                    LoseCounterValue = 2;
                }
                valueRabit = 1 + valueRabit;
                money = money - iRabit;
                iRabit = (iRabit * 4);
                MoneyLabel.Text = money.ToString();
                labelPriceRabit.Text = iRabit.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_2(object sender, EventArgs e)//podnosi cene za 1 zwierze
        {

            if (iDog <= money)
            {
                valueDog = valueDog + 5;
                money = money - iDog;
                iDog = (iDog * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceDog.Text = iDog.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }

        }

        private void pictureBox7_Click_3(object sender, EventArgs e)//podnosi cene za 1 zwierze
        {

            if (iOdyniec <= money)
            {
                valueOdyniec = 5 + valueOdyniec;
                money = money - iOdyniec;
                iOdyniec = ((iOdyniec + 20) * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceOdyniec.Text = iOdyniec.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_4(object sender, EventArgs e)//podnosi cene za 1 zwierze
        {

            if (iCow <= money)
            {
                valueCow = 15 + valueCow;
                money = money - iCow;
                iCow = (iCow * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceCow.Text = iCow.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_5(object sender, EventArgs e)//podnosi cene za 1 zwierze
        {

            if (iKango <= money)
            {
                valueKango = 25 + valueKango;
                money = money - iKango;
                iKango = (iKango * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceKango.Text = iKango.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_6(object sender, EventArgs e)//zwieksza produkcje krulika
        {

            if (itRabit <= money)
            {
                TimevalueRabit = TimevalueRabit + 1;
                money = money - itRabit;
                itRabit = (itRabit * 4);
                MoneyLabel.Text = money.ToString();
                labelPriceTRabit.Text = itRabit.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_7(object sender, EventArgs e)//zwieksza produkcje psow
        {


            if (itDog <= money)
            {
                TimevalueDog = TimevalueDog + 1;
                money = money - itDog;
                itDog = (itDog * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTDog.Text = itDog.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_8(object sender, EventArgs e)//zwieksza produkcje odynca
        {

            if (itOdyniec <= money)
            {
                TimevalueOdyniec = TimevalueOdyniec + 1;
                money = money - itOdyniec;
                itOdyniec = (itOdyniec * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTOdyniec.Text = itOdyniec.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_9(object sender, EventArgs e)//zwieksza produkcje krowy
        {

            if (itCow <= money)
            {
                TimevalueCow = TimevalueCow + 1;
                money = money - itCow;
                itCow = (itCow * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTCow.Text = itCow.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_10(object sender, EventArgs e)//zwieksza produkcje kangura
        {
            if (itKango <= money)
            {
                TimevalueKango = TimevalueKango + 1;
                money = money - itKango;
                itKango = (itKango * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTKango.Text = itKango.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_11(object sender, EventArgs e)//powieksza magazyn dla kangura
        {
            if (isKango <= money)
            {
                KangoLimit = KangoLimit * 2;
                money = money - isKango;
                isKango = (isKango * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxKango.Text = KangoLimit.ToString();
                labelMaxKangoUP.Text = isKango.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_12(object sender, EventArgs e)//powieksza magazyn dla krowy
        {
            if (isCow <= money)
            {
                CowLimit = CowLimit * 2;
                money = money - isCow;
                isCow = (isCow * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxCow.Text = CowLimit.ToString();

                labelMaxCowUP.Text = isCow.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_13(object sender, EventArgs e)//powieksza magazyn dla odynca
        {

            if (isOdyniec <= money)
            {
                OdyniecLimit = OdyniecLimit * 2;
                money = money - isDog;
                isOdyniec = (isOdyniec * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxOdyniec.Text = OdyniecLimit.ToString();
                labelMaxOdyniecUP.Text = isOdyniec.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void pictureBox7_Click_14(object sender, EventArgs e)//powieksza magazyn dla psa
        {

            if (isDog <= money)
            {
                DogLimit = DogLimit * 2;
                money = money - isDog;
                isDog = (isDog * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxDog.Text = DogLimit.ToString();
                labelMaxDogUP.Text = isDog.ToString();

            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void button1_Click_9(object sender, EventArgs e)//odblokuj kangura
        {

            if (isKango <= money)
            {
                KangoLimit = KangoLimit + 1;
                money = money - isKango;
                isKango = (isKango * 3);
                MoneyLabel.Text = money.ToString();
                labelMaxKango.Text = KangoLimit.ToString();


                labelMaxKangoUP.Text = isKango.ToString();
                buttonBuyKango.Hide();
                pictureBoxBlockKango.Hide();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void button1_Click_10(object sender, EventArgs e)//odblokuj krowe
        {

            if (80 <= money)
            {
                CowLimit = 2;
                money = money - 80;

                MoneyLabel.Text = money.ToString();
                labelMaxCow.Text = CowLimit.ToString();

                labelMaxCowUP.Text = isCow.ToString();
                buttonBuyCow.Hide();
                pictureBoxBlockCow.Hide();
            }
            else
            {
                MessageBox.Show("Nie możesz kupić pastwiska, ponieważ nie masz tylu pieniędzy! ");
            }
        }

        private void StartGame_Click(object sender, EventArgs e)//zaczyna program
        {
            TimerRabit.Interval = 1000;
            TimerRabit.Start();
            TimerDog.Interval = 2000;
            TimerDog.Start();
            TimerOdyniec.Interval = 5000;
            TimerOdyniec.Start();
            TimerCow.Interval = 10000;
            TimerCow.Start();
            TimerKango.Interval = 15000;
            TimerKango.Start();
            timerLoseGameSeba.Interval = LoseCounterValue;
            timerLoseGameSeba.Start();
            timerDisaster.Interval = 60000;
            timerDisaster.Start();
            timerLoseGameShaman.Interval = LoseCounterValue;
            timerLoseGameShaman.Start();


            StartGame.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void timerDisasterShaman_Tick(object sender, EventArgs e)
        {
            if (LoseCounterShaman > 15)
            {
                buttonShaman.Show();
            }
            else
            {
                buttonShaman.Hide();
            }
            if (LoseCounterShaman < 500)
            {
                LoseCounterShaman = LoseCounterShaman + 1;
                labelLoseCounterShaman.Text = LoseCounterShaman.ToString();

            }
            else
            {
                {
                    LoseCounter = 0;
                    MessageBox.Show("Przegrales. Szaman rzuciał na ciebie zaklęcie i umarłeś. ");
                    Close();

                }
            }
        }

        private void timerLoseGame_Tick(object sender, EventArgs e)
        {
            if (LoseCounter < 100)
            {
                LoseCounter = LoseCounter + 1;
                labelLoseCounter.Text = LoseCounter.ToString();
                
            }
            else
            {
                {
                    LoseCounter = 0;
                    MessageBox.Show("Pzregrałeś, gangster zabił ciebie i zjadł twoje zwierzęta. Licznik wściekłości przekroszył wartość 100 więc gangster stracił cierpliwość.");
                    Close();
                   
                }
            }
        }

        private void buttonKangoTimeUP_Click(object sender, EventArgs e)
        {
            if (itKango <= money)
            {
                TimevalueKango = TimevalueKango + 1;
                money = money - itKango;
                itKango = (itKango * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTKango.Text = itKango.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        public Form1()
        {
            InitializeComponent();
                    

        }

        private void StockroomRabitUP_Click(object sender, EventArgs e)
        {

            if (itRabit <= money)
            {
                TimevalueRabit = TimevalueRabit + 1;
                money = money - itRabit;
                itRabit = (itRabit * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTRabit.Text = itRabit.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Zmienna prezech. wartosci
            string dataString = " ";
            dataString = RabitShow.Text;
            counterRabit = Int32.Parse(dataString);
            counterRabit++;
           // MessageBox.Show(counterGold.ToString());
            RabitShow.Text = counterRabit.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 0;
            x = Int32.Parse(textBoxSellKango.Text);
            if (x <= counterKango)
            {
                money = money + x * valueKango;
                MoneyLabel.Text = money.ToString();
                counterKango = counterKango - x;
                KangoShow.Text = counterKango.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu zwierzat! ");
            }

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

            if (itRabit <= money)
            {
                TimevalueRabit = TimevalueRabit+1;
                money = money - itRabit;
                itRabit = (itRabit * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceTRabit.Text = itRabit.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            int x=0;
            x = Int32.Parse(textBoxSellDog.Text);
            if (x <= counterDog)
            {
                money = money + x * valueDog;

                MoneyLabel.Text = money.ToString();
                counterDog = counterDog - x;
                DogShow.Text = counterDog.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu zwierzat! ");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0;
            x = Int32.Parse(textBoxSellCow.Text);
            if (x <= counterCow)
            {
                money = money + x * valueCow;
                MoneyLabel.Text = money.ToString();
                counterCow = counterCow - x;
                CowShow.Text = counterCow.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu zwierzat! ");
            }

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            int x = 0;
            x = Int32.Parse(textBoxSellOdyniec.Text);
            if (x <= counterOdyniec)
            {
                money = money + x * valueOdyniec;
                MoneyLabel.Text = money.ToString();
                counterOdyniec = counterOdyniec - x;
                OdyniecShow.Text = counterOdyniec.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu zwierzat! ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)//pokazuje nowe okno z instrukcja
        {
            var RabitStats = new RabitStats();
            RabitStats.Show();
        }

        private void buttonRabitUP_Click(object sender, EventArgs e)
        {

            if (iRabit <= money)
            {
                if(iRabit>50)
                {
                    LoseCounterValue = 2;
                }
                valueRabit = 1+ valueRabit;
                money = money - iRabit;
                iRabit = (iRabit*2);
                MoneyLabel.Text = money.ToString();
                labelPriceRabit.Text = iRabit.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            int  x;
            x = Int32.Parse(textBoxSellRabit.Text);
            if (x <= counterRabit)
            {
                money = money + x * valueRabit;
                MoneyLabel.Text = money.ToString();
                counterRabit = counterRabit - x;
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu zwierzat! ");
            }

            
        }

        private void buttonOdyniecUP_Click(object sender, EventArgs e)
        {
            
            if (iOdyniec <= money)
            {
                valueOdyniec = 10+ valueOdyniec;
                money = money - iOdyniec;
                iOdyniec = ((iOdyniec + 20)*2);
                MoneyLabel.Text = money.ToString();
                labelPriceOdyniec.Text = iOdyniec.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }

        }

        private void buttonCowUP_Click(object sender, EventArgs e)
        {
            
            if (iCow <= money)
            {
                valueCow = 15+ valueCow;
                money = money - iDog;
                iCow = (iCow *2);
                MoneyLabel.Text = money.ToString();
                labelPriceCow.Text = iCow.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }

        }

        private void buttonKangUP_Click(object sender, EventArgs e)
        {
            
            if (iKango <= money)
            {
                valueKango = 25+ valueKango;
                money = money - iKango;
                iKango = (iKango * 2);
                MoneyLabel.Text = money.ToString();
                labelPriceKango.Text = iKango.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
        }

        private void buttonTEST_Click(object sender, EventArgs e)
        {
            if (iDog <= money)
            {
                valueDog = valueDog+5;
                money = money - iDog;
                iDog = (iDog *2);
                MoneyLabel.Text = money.ToString();
                labelPriceDog.Text = iDog.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz tylu pieniedzy! ");
            }
            
        }

        private void timerGold5_Tick(object sender, EventArgs e)
        {
            if (counterKango != KangoLimit)
            {
                counterKango = counterKango + TimevalueKango;
                KangoShow.Text = counterKango.ToString();
            }

        }

        private void TimerGold2_Tick(object sender, EventArgs e)
        {
            if(counterDog!= DogLimit)
            {
                counterDog = counterDog + TimevalueDog;
                DogShow.Text = counterDog.ToString();
            }
    ;


        }

        private void TimerGold3_Tick(object sender, EventArgs e)
        {
            if (counterOdyniec != OdyniecLimit)
            {
                counterOdyniec = counterOdyniec + TimevalueOdyniec;
                OdyniecShow.Text = counterOdyniec.ToString();

            }
        }

        private void TimerGold4_Tick(object sender, EventArgs e)
        {
            if (counterCow != CowLimit)
            {
                counterCow = counterCow + TimevalueCow;
                CowShow.Text = counterCow.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counterRabit= counterRabit+TimevalueRabit;
            RabitShow.Text = counterRabit.ToString();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Gold2Show_Click(object sender, EventArgs e)
        {
            counterDog = counterDog+TimevalueDog;
            DogShow.Text = counterDog.ToString();
        }
    }
}
