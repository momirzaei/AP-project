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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Admin_Bank.xaml
    /// </summary>
    public partial class Admin_Bank : Window
    {
        public Admin_Bank()
        {
            InitializeComponent();
            balance_label.Content = File.ReadAllText("bankmoney.txt");

        }


        private void BANKENTER_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(BANKDONATION.Text) > 0)
            {
                mainpayment MP = new mainpayment();
                MP.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("amount is not correct");
            }


        }
    }
}
