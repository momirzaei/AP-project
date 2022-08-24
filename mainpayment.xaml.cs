using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for mainpayment.xaml
    /// </summary>
    public partial class mainpayment : Window
    {
       
        public mainpayment()
        {
            InitializeComponent();
        }

        private void PAYENTER_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;int b = 0;int c= 0;int d= 0;

            if(int.Parse(AMOUNT.Text)>0)
            {
                a = 1;
            }
            else
            {
                MessageBox.Show("amount is not correct");
            }

            for (int i = 0; i < CARDNUMBER.Text.Length; i++)
            {
                if (CARDNUMBER.Text[i] != '0' && CARDNUMBER.Text[i] != '1' && CARDNUMBER.Text[i] != '2' && CARDNUMBER.Text[i] != '3'
                    && CARDNUMBER.Text[i] != '4' && CARDNUMBER.Text[i] != '5' && CARDNUMBER.Text[i] != '6' && CARDNUMBER.Text[i] != '7' && CARDNUMBER.Text[i] != '8' && CARDNUMBER.Text[i] != '9')
                {
                    MessageBox.Show("card number must be digit");
                }
            }
            if (CARDNUMBER.Text.Length == 16)
            {
                int digit = 0;
                int sum = 0;
                for (int i = 0; i < CARDNUMBER.Text.Length; i = i ++)
                {
                    digit = CARDNUMBER.Text[i];
                    if (i%2==0)
                    {
                        digit = digit * 2;
                        if (digit >= 10)
                        {
                            int i1 = 0;
                            i1 = digit % 10;
                            digit = 1 + i1;
                        }
                        sum += digit;
                    }
                    else
                    {
                        sum += digit;
                    }

                }
                if (sum % 10 == 0)
                {
                    b = 1;
                }
                else
                {
                    MessageBox.Show("invalid card number");
                }
            }
            else
            {
                MessageBox.Show("card number must have 16 digits");
            }

            Regex reg_cvv = new Regex(@"^[0-9]{3,4}$");
            if (!reg_cvv.IsMatch(CVV.Text))
            {
                MessageBox.Show("CVV is wrong!");
            }
            else
            {
                c = 1;
            }

            string timee = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(timee);
            //label1.Text = DateTime.Now.ToString("HH:mm:ss tt");
            int monthexe = int.Parse(monthEXE.Text);
            char w1 = timee[3]; char w2 = timee[4];
            string nowmonth1 = string.Concat(w1, w2);
            int nowmonth = int.Parse(nowmonth1);



            int yearexe = int.Parse(yearEXE.Text);
            char w3 = timee[6]; char w4 = timee[7]; char w5 = timee[8]; char w6 = timee[9];
            string nowyear1 = string.Concat(w3, w4, w5, w6);
            int nowyear = int.Parse(nowyear1);
            //int y2 = int.Parse(timee);


            /* if (yearexe == nowyear)
             {
                 if (y3 - y4 >= 3)
                 {

                 }
                 else
                 {
                     MessageBox.Show("tarikh engeza kart gozashte ast");
                 }
             }
             if (y1 > y2)
             {
                 MessageBox.Show("tarikh engeza kart gozashte ast");
             }*/
            if (nowyear+2<=yearexe)
            {
                d = 1;
            }
          else if(nowyear + 1 == yearexe)
            {
                int exe = monthexe + 12;
                if(exe >= nowmonth+3)
                {
                    d = 1;
                }
            }
          else if(nowyear  == yearexe)
            {
                if(monthexe>=nowmonth+3)
                {
                    d = 1;
                }
            }
            else
            {
                MessageBox.Show("card has been expired");
            }

           if(a==1 && b == 1 && c == 1 && d == 1)
            {
                int money = int.Parse(File.ReadAllText("bankmoney.txt"));
                int new_money = int.Parse(AMOUNT.Text);
                string all = (money + new_money).ToString();
                File.WriteAllText("bankmoney.txt",all );

                Admin A = new Admin();
                A.Show();
                this.Close();
            }

        }
    }
}
