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
    /// Interaction logic for memberWallet.xaml
    /// </summary>
    public partial class memberWallet : Window
    {
        public memberWallet()
        {
            InitializeComponent();
        }


        private void membersWallet_increaseBTN_Click_03(object sender, RoutedEventArgs e)
        {
            mainpayment M1 = new mainpayment();
            M1.Show();
            this.Close();
        }

        private void Login_members_BackBTN_Click_03(object sender, RoutedEventArgs e)
        {
            Login_members M2 = new Login_members();
            M2.Show();
            this.Close();
        }
    }
}
