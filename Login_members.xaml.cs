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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Login_members.xaml
    /// </summary>
    public partial class Login_members : Window
    {
        public Login_members()
        {
            InitializeComponent();
        }

        private void member_Books_BTN_Click_03(object sender, RoutedEventArgs e)
        {
            memberBOOKS M1 = new memberBOOKS();
            M1.Show();
            this.Close();
        }

        private void Member_My_BooksBTN_Click(object sender, RoutedEventArgs e)
        {
            MyBooks M2 = new MyBooks();
            M2.Show();
            this.Close();
        }

        private void Member_SubscriptionBTN_Click(object sender, RoutedEventArgs e)
        {
            Share M3 = new Share();
            M3.Show();
            this.Close();
        }

        private void Member_WalletBTN_Click_03(object sender, RoutedEventArgs e)
        {
            memberWallet M4 = new memberWallet();
            M4.Show();
            this.Close();
        }

        private void Member_editing_informationBTN_Click_03(object sender, RoutedEventArgs e)
        {
            Edit_Member_information M5 = new Edit_Member_information();
            M5.Show();
            this.Close();
        }

        private void Login_members_BackBTN_Click_03(object sender, RoutedEventArgs e)
        {
            MainWindow M6 = new MainWindow();
            M6.Show();
            this.Close();
        }
    }
}
