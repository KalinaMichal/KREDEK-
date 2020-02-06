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
        int AttackCountryTime = 0;//Licznik czasu kiedy nastapi atak
        int BattleAttackPower = 0; //Zmienna potrzebna przy atakowaniu
        int AndzejCounter = 0, AntekCounter = 0, IvanCounter = 0, MarekCounter = 0, MietekCounter = 0, RadekCounter;//Liczą jednostki
        int StaminaOfCountryUveClicked = 0; //Wytrzymałość farmy którą wybrałeś/aś
        int chooseWarrior = 0;//Potrzebne do wyboru odpowiedniej jednostki podczas pojawiania się nowych okien
        int MyCountryStamina = 0;//Wytrzymałość mojej farmy
        bool War = false; //Czy wojna ma się odbyć (po przekrczeniu czasu zmieni sie na true i zaatakuje wioskę gracza w TimerCountryAttack
        int TimeAttackPower = 0;//Zmienna potrzeba przy czasie po którym wioska atakuje. Włyży ona do wybrania ataku odpowiedniej wioski w TimerCountryAttack

        //szczegółowa deklaracja jednostek i wiosek odbywa się w przycisku StartGame
       
        #region
            Country Country1 = new Country();
            Country Country2 = new Country();
            Country Country3 = new Country();
            Country Country4 = new Country();
        #endregion
        //Deklaracja Wiosek

        #region
            AttackTroops Andzej = new AttackTroops();
            AttackTroops Antek = new AttackTroops();
            AttackTroops Ivan = new AttackTroops();
        #endregion
        //Deklaracja jednostek Atakujacych

        #region
            DefenseTroops Mietek = new DefenseTroops();
            DefenseTroops Marek = new DefenseTroops();
            DefenseTroops Radek = new DefenseTroops();
        #endregion
        //Deklaracja jednostek Broniacych

        private void HideWarrior()//UKRYWA obrazek wiesniaka w shop-ie
        {
            #region
            pictureBoxAndzej.Hide();
            pictureBoxAntek.Hide();
            pictureBoxIvan.Hide();
            pictureBoxMietek.Hide();
            pictureBoxMarek.Hide();
            pictureBoxRadek.Hide();
            #endregion
            //ukrywanie obrazka wiesniaka
        }
        private void ShowMyTroops()//Odswierza jednostki
        {
            labelAndzejCounter.Text = AndzejCounter.ToString();
            labelRadekCounter.Text = RadekCounter.ToString();
            labelAntekCounter.Text = AntekCounter.ToString();
            labelIvanCounter.Text = IvanCounter.ToString();
            labelMietekCounter.Text = MietekCounter.ToString();
            labelMarekCounter.Text = MarekCounter.ToString();
        }
        private bool IsBattleWon(int DefenseStamina,int TroopsPower)//Rozstrzyga kto wygra
        {
            if(DefenseStamina>=TroopsPower)
                return false;
            else
                return true;
        }

        //   ^
        //   |
        //   |
        //   |
        //   
        //WOJKSO

        //FARMA
        //   |
        //   |
        //   |
        //   V
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

        private void button1_Click_8(object sender, EventArgs e)//rozpoczyna program farmy
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

        private void StartGame_Click(object sender, EventArgs e)//zaczyna program caly
        {
            #region
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
            timerCountryAttack.Interval = 1000;
            timerCountryAttack.Start();
#endregion
            //włączanie wszystkich timerow w grze

            StartGame.Hide();
            #region
            
                Andzej.Name = "Wieśniak Andzej";
                Andzej.Power = 1;
                Andzej.RabitPrice = 10;
                Andzej.DogPrice = 1;
                Andzej.OdyniecPrice = 0;
                Andzej.CowPrice = 0;
                Andzej.KangoPrice = 0;



            Antek.Name = "Wieśniak Antek";
                Antek.Power = 2;
                Antek.RabitPrice = 25;
                Antek.DogPrice = 10;
                Antek.OdyniecPrice = 2;
                Antek.CowPrice = 1;
                Antek.KangoPrice = 0;


            Ivan.Name = "Wieśniak Ivan";
                Ivan.Power = 5;
                Ivan.RabitPrice = 100;
                Ivan.DogPrice = 14;
                Ivan.OdyniecPrice = 10;
                Ivan.CowPrice = 6;
                Ivan.KangoPrice = 4;
            #endregion
            //tworzenie jednostek atakujacych
            #region

            Mietek.Name = "Wieśniak Mietek";
                Mietek.Power = 1;
            Mietek.RabitPrice = 10;
            Mietek.DogPrice = 1;
            Mietek.OdyniecPrice = 0;
            Mietek.CowPrice = 0;
            Mietek.KangoPrice = 0;



           
                Marek.Name = "Wieśniak Marek";
            Marek.Power = 5;
            Marek.RabitPrice = 100;
            Marek.DogPrice = 14;
            Marek.OdyniecPrice = 10;
            Marek.CowPrice = 6;
            Marek.KangoPrice = 4;

            
                Radek.Name = "Wieśniak Radek";
                Radek.Power = 2;
            Radek.RabitPrice = 25;
            Radek.DogPrice = 10;
            Radek.OdyniecPrice = 2;
            Radek.CowPrice = 1;
            Radek.KangoPrice = 0;

            #endregion
            //tworzenie jednostek obronnych
            #region



            Country1.RabitCounter = 100;
            Country1.DogCounter = 50;
            Country1.OdyniecCounter = 2;
            Country1.CowCounter = 0;
            Country1.KangoCounter = 0;
            Country1.CountryStamina = 50;
            Country1.CountryAttack = 10;


            Country2.RabitCounter = 500;
            Country2.DogCounter = 100;
            Country2.OdyniecCounter = 5;
            Country2.CowCounter = 1;
            Country2.KangoCounter = 0;
            Country2.CountryStamina = 100;
            Country2.CountryAttack = 50;


            Country3.RabitCounter = 1000;
            Country3.DogCounter = 500;
            Country3.OdyniecCounter = 20;
            Country3.CowCounter = 10;
            Country3.KangoCounter = 0;
            Country3.CountryStamina = 200;
            Country3.CountryAttack = 500;

            Country4.RabitCounter = 5000;
            Country4.DogCounter =1000;
            Country4.OdyniecCounter = 200;
            Country4.CowCounter = 20;
            Country4.KangoCounter = 10;
            Country4.CountryStamina = 500;
            Country4.CountryAttack = 1000;

            #endregion
            //tworzenie innych wiosek

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxBattle_Click(object sender, EventArgs e)//rozpoczyna wojenne menu
        {
            panelShop.Hide();
            buttonLoseUP.Hide();
            panelBattle.Show();
            buttonLoseUpWhenBattle.Show();

            #region
            labelAndzejCounter.Text = AndzejCounter.ToString();

            labelAntekCounter.Text = AntekCounter.ToString();

            labelIvanCounter.Text = IvanCounter.ToString();

            labelMietekCounter.Text = MietekCounter.ToString();

            labelMarekCounter.Text = MarekCounter.ToString();

            labelRadekCounter.Text = RadekCounter.ToString();
            #endregion
            //wczytywanie obecnego stanu wojska

            #region
            labelAndzejPower.Text = Andzej.Power.ToString();
            labelAntekPower.Text = Antek.Power.ToString();
            labelIvanPower.Text = Ivan.Power.ToString();

            #endregion
            //wczytywanie wartosci ataku jednostek atakujacych
            #region
            labelMietekStamina.Text = Mietek.Power.ToString();
            labelRadekStamina.Text = Radek.Power.ToString();
            labelMarekStamina.Text = Marek.Power.ToString();

            #endregion

        }




        private void panelBattle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelShop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxCountry1_Click(object sender, EventArgs e)//Farma nr 1
        {
            panelAttackCountry.Show();
            StaminaOfCountryUveClicked = Country1.CountryStamina;
            labelCountryStamina.Text = StaminaOfCountryUveClicked.ToString();
            labelCountryRabit.Text = Country1.RabitCounter.ToString();
            labelCountryDog.Text = Country1.DogCounter.ToString();
            labelCountryCow.Text = Country1.CowCounter.ToString();
            labelCountryOdyniec.Text = Country1.OdyniecCounter.ToString();
            labelCountryKango.Text = Country1.KangoCounter.ToString();

        }

        private void pictureBoxCountry2_Click(object sender, EventArgs e)//Farma nr 2
        {
            panelAttackCountry.Show();
            StaminaOfCountryUveClicked = Country2.CountryStamina;
            labelCountryStamina.Text = StaminaOfCountryUveClicked.ToString();
            labelCountryRabit.Text = Country2.RabitCounter.ToString();
            labelCountryDog.Text = Country2.DogCounter.ToString();
            labelCountryCow.Text = Country2.CowCounter.ToString();
            labelCountryOdyniec.Text = Country2.OdyniecCounter.ToString();
            labelCountryKango.Text = Country2.KangoCounter.ToString();
        }

        private void pictureBoxCountry3_Click(object sender, EventArgs e)//Farma nr 3
        {
            panelAttackCountry.Show();
            StaminaOfCountryUveClicked = Country3.CountryStamina;
            labelCountryStamina.Text = StaminaOfCountryUveClicked.ToString();
            labelCountryRabit.Text = Country3.RabitCounter.ToString();
            labelCountryDog.Text = Country3.DogCounter.ToString();
            labelCountryCow.Text = Country3.CowCounter.ToString();
            labelCountryOdyniec.Text = Country3.OdyniecCounter.ToString();
            labelCountryKango.Text = Country3.KangoCounter.ToString();
        }

        private void pictureBoxCountery4_Click(object sender, EventArgs e)//Farma nr 4
        {
            panelAttackCountry.Show();
            StaminaOfCountryUveClicked = Country4.CountryStamina;
            labelCountryStamina.Text = StaminaOfCountryUveClicked.ToString();
            labelCountryRabit.Text = Country4.RabitCounter.ToString();
            labelCountryDog.Text = Country4.DogCounter.ToString();
            labelCountryCow.Text = Country4.CowCounter.ToString();
            labelCountryOdyniec.Text = Country4.OdyniecCounter.ToString();
            labelCountryKango.Text = Country4.KangoCounter.ToString();
        }

        private void buttonBuyDefenseMietek_Click(object sender, EventArgs e)
        {
           


        }

        private void buttonBuyAttackAndzej_Click(object sender, EventArgs e)
        {

        }

        private void buttonAttackCountry1_Click(object sender, EventArgs e)//Atakuje famre
        {
            if ((AndzejCounter >= Int32.Parse(textBoxCountry1Andzej.Text)) && (IvanCounter >= Int32.Parse(textBoxCountry1Ivan.Text)) && (AntekCounter >= Int32.Parse(textBoxCountry1Antek.Text)))
            {
                BattleAttackPower = BattleAttackPower + Andzej.Power * Int32.Parse(textBoxCountry1Andzej.Text);
                AndzejCounter = AndzejCounter - Int32.Parse(textBoxCountry1Andzej.Text);

                BattleAttackPower = BattleAttackPower + Antek.Power * Int32.Parse(textBoxCountry1Antek.Text);
                AntekCounter = AntekCounter - Int32.Parse(textBoxCountry1Antek.Text);

                BattleAttackPower = BattleAttackPower + Ivan.Power * Int32.Parse(textBoxCountry1Ivan.Text);
                IvanCounter = AndzejCounter - Int32.Parse(textBoxCountry1Ivan.Text);

                if (IsBattleWon(StaminaOfCountryUveClicked, BattleAttackPower) == true)//sprawdza czy bitwa zostala wygrana. Jesli tak to przy[isuje do stada nowe zwierzeta. jesli nie to wyswietla komunikat
                {
                    counterRabit = counterRabit + Int32.Parse(labelCountryRabit.Text);
                    counterKango = counterKango + Int32.Parse(labelCountryKango.Text);
                    counterDog = counterDog + Int32.Parse(labelCountryDog.Text);
                    counterCow = counterCow + Int32.Parse(labelCountryCow.Text);
                    counterOdyniec = counterOdyniec + Int32.Parse(labelCountryOdyniec.Text);
                    AttackCountryTime = 0;
                    MessageBox.Show("Wygrałeś Bitwę");
                    ShowMyTroops();
                }
                else
                {
                    MessageBox.Show("Przegrales Bitwę");
                    ShowMyTroops();
                }

            }
            else MessageBox.Show("Nie posiadasz takiej armii");
        }

        private void buttonBuyAttackAntek_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuyAttackIvan_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuyDefenceRadek_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuyDefenceMarek_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_13(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBoxTroopsValue.Text);//x - to wartosc ile jednostek ktos chce kupic
            if (x * Int32.Parse(labelWarriorRabit.Text) <= counterRabit && x * Int32.Parse(labelWarriorDog.Text) <= counterDog && x * Int32.Parse(labelWarriorOdyniec.Text) <= counterOdyniec && x * Int32.Parse(labelWarriorCow.Text) <= counterCow && x * Int32.Parse(labelWarriorKango.Text) <= counterKango)
            {
                #region
                counterRabit = counterRabit - (x * Int32.Parse(labelWarriorRabit.Text));
                counterDog = counterDog - (x * Int32.Parse(labelWarriorDog.Text));
                counterOdyniec = counterOdyniec - (x * Int32.Parse(labelWarriorOdyniec.Text));
                counterCow = counterCow - (x * Int32.Parse(labelWarriorCow.Text));
                counterRabit = counterKango - (x * Int32.Parse(labelWarriorKango.Text));
                #endregion
                //zabieranie odpowiedniej liczby zwierzat
                #region
                RabitShow.Text = counterRabit.ToString();
                DogShow.Text = counterDog.ToString();
                OdyniecShow.Text = counterOdyniec.ToString();
                CowShow.Text = counterCow.ToString();
                KangoShow.Text = counterKango.ToString();
                #endregion
                //odswierzanie Label-a pokazującego zwierzęta
                #region
                if (chooseWarrior == 1)
                {
                    AndzejCounter = x + AndzejCounter;
                    labelAndzejCounter.Text = AndzejCounter.ToString();


                }
                if (chooseWarrior == 2)
                {
                    AntekCounter = x + AntekCounter;
                    labelAntekCounter.Text = AntekCounter.ToString();
                }
                if (chooseWarrior == 3)
                { 
                    IvanCounter = x + IvanCounter;
                    labelIvanCounter.Text = IvanCounter.ToString();
                    
                }
                if (chooseWarrior == 4)
                {
                    MietekCounter = x + MietekCounter;
                    labelMietekCounter.Text = MietekCounter.ToString();
                    MyCountryStamina = MyCountryStamina+x* Mietek.Power;
                    labelMyFarmStamina.Text = MyCountryStamina.ToString();
                }
                if (chooseWarrior == 5)
                {
                    MarekCounter = x + MarekCounter;
                    labelMarekCounter.Text = MarekCounter.ToString();
                    MyCountryStamina = MyCountryStamina+x * Marek.Power;
                    labelMyFarmStamina.Text = MyCountryStamina.ToString();
                }
                if(chooseWarrior==6)
                {
                    RadekCounter = x + RadekCounter;
                    labelRadekCounter.Text = RadekCounter.ToString();
                    MyCountryStamina = MyCountryStamina+x * Radek.Power;
                    labelMyFarmStamina.Text = MyCountryStamina.ToString();
                }
                    #endregion
                //Sprawdzanie którą jednostkę kupiono i dodawanie jej odpowiedniej ilości
                panelWarriorShop.Hide();
            }
            else MessageBox.Show("Nie posiadasz tylu zwierząt");
        }

        private void textBoxSellOdyniec_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCountryStamina_Click(object sender, EventArgs e)
        {

        }

        private void labelFarmStaminaText_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackPanelWarrior_Click(object sender, EventArgs e)//Wraca do menu zamyka panel kupowania jednostek
        {
            panelWarriorShop.Hide();
            HideWarrior();


        }

        private void buttonBackPanelCountry_Click(object sender, EventArgs e)//Wraca do menu zamyka panel ataku innych wiosek
        {
            panelAttackCountry.Hide();
        }

        private void pictureBox7_Click_15(object sender, EventArgs e)//powot do farmy
        {
            panelBattle.Hide();
            buttonLoseUpWhenBattle.Hide();
            panelShop.Show();
            buttonLoseUP.Show();

        }

        private void pictureBoxAntek_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxInstrukcjaWar_Click(object sender, EventArgs e)//wyswietla okno z instrukcja
        {
            var FormInstructionOfWar = new FormInstructionOfWar();
            FormInstructionOfWar.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)//kup wojsko
        {
            HideWarrior();
            chooseWarrior = 1;
            panelWarriorShop.Show();
            pictureBoxAndzej.Show();
            #region
            labelWarriorRabit.Text = Andzej.RabitPrice.ToString();
            labelWarriorDog.Text = Andzej.DogPrice.ToString();
            labelWarriorOdyniec.Text = Andzej.OdyniecPrice.ToString();
            labelWarriorCow.Text = Andzej.CowPrice.ToString();
            labelWarriorKango.Text = Andzej.KangoPrice.ToString();
            #endregion
            //Tworzenie okna pod potrzeby danego wojownika
        }

        private void pictureBoxBuyAttackAndzej_MouseCaptureChanged(object sender, EventArgs e)//nie dziala do poprawy kiedys jak bede umial
        {
            //pictureBoxBuyAttackAndzej.Image = Image.FromFile("kupswiecace");
            //nieudana proba dodania zmiany obrazu
        }

        private void pictureBoxBuyAttackMarek_Click(object sender, EventArgs e)//kup wojsko
        {
            HideWarrior();
            chooseWarrior = 5;
            panelWarriorShop.Show();
            pictureBoxMarek.Show();
            #region
            labelWarriorRabit.Text = Marek.RabitPrice.ToString();
            labelWarriorDog.Text = Marek.DogPrice.ToString();
            labelWarriorOdyniec.Text = Marek.OdyniecPrice.ToString();
            labelWarriorCow.Text = Marek.CowPrice.ToString();
            labelWarriorKango.Text = Marek.KangoPrice.ToString();
            #endregion
            //Tworzenie okna pod potrzeby danego wojownika
        }

        private void pictureBoxBuyAttackRadek_Click(object sender, EventArgs e)//kup wojsko
        {
            HideWarrior();
            panelWarriorShop.Show();
            chooseWarrior = 6;
            pictureBoxRadek.Show();
            #region
            labelWarriorRabit.Text = Radek.RabitPrice.ToString();
            labelWarriorDog.Text = Radek.DogPrice.ToString();
            labelWarriorOdyniec.Text = Radek.OdyniecPrice.ToString();
            labelWarriorCow.Text = Radek.CowPrice.ToString();
            labelWarriorKango.Text = Radek.KangoPrice.ToString();
            #endregion
            //Tworzenie okna pod potrzeby danego wojownika
        }

        private void pictureBoxBuyAttackMietek_Click(object sender, EventArgs e)//kup wojsko
        {
            HideWarrior();
            chooseWarrior = 4;
            panelWarriorShop.Show();
            pictureBoxMietek.Show();


            #region
            labelWarriorRabit.Text = Mietek.RabitPrice.ToString();
            labelWarriorDog.Text = Mietek.DogPrice.ToString();
            labelWarriorOdyniec.Text = Mietek.OdyniecPrice.ToString();
            labelWarriorCow.Text = Mietek.CowPrice.ToString();
            labelWarriorKango.Text = Mietek.KangoPrice.ToString();
            #endregion
            //tworzenie okna pod potrzeby danego wojownika
        }

        private void pictureBoxBuyAttackAntek_Click(object sender, EventArgs e)//kup wojsko
            {
            HideWarrior();
            chooseWarrior = 2;
            panelWarriorShop.Show();
            pictureBoxAntek.Show();
            #region
            labelWarriorRabit.Text = Antek.RabitPrice.ToString();
            labelWarriorDog.Text = Antek.DogPrice.ToString();
            labelWarriorOdyniec.Text = Antek.OdyniecPrice.ToString();
            labelWarriorCow.Text = Antek.CowPrice.ToString();
            labelWarriorKango.Text = Antek.KangoPrice.ToString();
            #endregion
            //Tworzenie okna pod potrzeby danego wojownika
        }

        private void pictureBoxBuyAttackIvan_Click(object sender, EventArgs e)//kup wojsko
        {
            HideWarrior();
            chooseWarrior = 3;
            panelWarriorShop.Show();
            pictureBoxIvan.Show();
            #region
            labelWarriorRabit.Text = Ivan.RabitPrice.ToString();
            labelWarriorDog.Text = Ivan.DogPrice.ToString();
            labelWarriorOdyniec.Text = Ivan.OdyniecPrice.ToString();
            labelWarriorCow.Text = Ivan.CowPrice.ToString();
            labelWarriorKango.Text = Ivan.KangoPrice.ToString();
            #endregion
            //Tworzenie okna pod potrzeby danego wojownika
        }

        private void button1_Click_12(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_7(object sender, EventArgs e)//placenie haraczu
        {
            if (money >= 100)
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

        private void button1_Click_11(object sender, EventArgs e)
        {
            
      
        }

        private void timerCountryAttack_Tick(object sender, EventArgs e)//odmierza kiedy atakowac
        {
            AttackCountryTime++;
            #region

            if(AttackCountryTime==15)
            {
                War = true;
                TimeAttackPower = Country1.CountryAttack;
                timerCountryAttack.Stop();



            }
            if (AttackCountryTime == 150)
            {
                War = true;
                TimeAttackPower = Country2.CountryAttack;
                timerCountryAttack.Stop();
            }
            if (AttackCountryTime == 350)
            {
                War = true;
                TimeAttackPower = Country3.CountryAttack;
                timerCountryAttack.Stop();
            }
            if (AttackCountryTime == 800)
            {
                War = true;
                TimeAttackPower = Country4.CountryAttack;
                timerCountryAttack.Stop();
            }
            if(War)
            {
                if (IsBattleWon(MyCountryStamina, TimeAttackPower))
                {
                    #region
                    counterRabit = 0;
                    counterDog = 0;
                    counterOdyniec = 0;
                    counterCow = 0;
                    counterKango = 0;
                    money = 0;
                    #endregion
                    //zabieranie wszystkich zwierząt

                    #region
                    RabitShow.Text = counterRabit.ToString();
                    DogShow.Text = counterDog.ToString();
                    OdyniecShow.Text = counterOdyniec.ToString();
                    CowShow.Text = counterCow.ToString();
                    KangoShow.Text = counterKango.ToString();
                    MoneyLabel.Text = money.ToString();
                    #endregion
                    //wyswietlanie (odświerzanie) stanu zwierząt

                    MessageBox.Show("Wroga farma ciebie zaatakowała i splądrowała twoją farmę");
                }
                else
                {
                    MessageBox.Show("Wroga farma ciebie zaatakowała ale udało się tobie obronić");
                    
                }
                War = false;
                timerCountryAttack.Start();
            }
            #endregion
            //sprawdzanie co ma się wydarzyć

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

        private void StockroomRabitUP_Click(object sender, EventArgs e)//ulepsza
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

        private void button4_Click(object sender, EventArgs e)//sprzedawanie zwierzat
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

        private void button1_Click_3(object sender, EventArgs e)//sprzedawanie zwierzat
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

        private void button1_Click_2(object sender, EventArgs e)//sprzedawanie zwierzat
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
