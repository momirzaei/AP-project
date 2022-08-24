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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void employesBTn_Click_01(object sender, RoutedEventArgs e)
        {
            Admin_Employes AE = new Admin_Employes();
            AE.Show();
            this.Close();
        }

        private void booksBTn_Click_01(object sender, RoutedEventArgs e)
        {
            BOOKLIST BL = new BOOKLIST();
            BL.Show();
            this.Close();
        }

        private void bankBTn_Click_01(object sender, RoutedEventArgs e)
        {
            Admin_Bank ABANK = new Admin_Bank();
            ABANK.Show();
            this.Close();
        }
    }
}
