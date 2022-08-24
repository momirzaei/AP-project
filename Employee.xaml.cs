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
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_BooksBTN1_Click(object sender, RoutedEventArgs e)
        {
            BOOKS B1 = new BOOKS();
            B1.Show();
            this.Close();
        }

        private void Employee_BackBTN_Click_02(object sender, RoutedEventArgs e)
        {
            MainWindow main1 = new MainWindow();
            main1.Show();
            this.Close();
        }

        private void Employee_MemberBTN3_Click(object sender, RoutedEventArgs e)
        {
            MEMBER M1 = new MEMBER();
            M1.Show();
            this.Close();
        }

        private void Employee_walletBTN3_Click(object sender, RoutedEventArgs e)
        {
            wallet W1 = new wallet();
            W1.Show();
            this.Close();
        }

        private void Employee_Edit_InformationBTN3_Click(object sender, RoutedEventArgs e)
        {
            Edit_employee_information E2 = new Edit_employee_information();
            E2.Show();
            this.Close();
        }
    }
}
