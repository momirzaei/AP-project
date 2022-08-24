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
    /// Interaction logic for wallet.xaml
    /// </summary>
    public partial class wallet : Window
    {
        public wallet()
        {
            InitializeComponent();
        }

        private void EmployeeWallet_BackBTN_Click_02(object sender, RoutedEventArgs e)
        {
            Employee E1 = new Employee();
            E1.Show();
            this.Close();
        }
    }
}
