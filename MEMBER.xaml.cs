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
    /// Interaction logic for MEMBER.xaml
    /// </summary>
    public partial class MEMBER : Window
    {
        public MEMBER()
        {
            InitializeComponent();
        }

        private void All_MemberBTN_Click4(object sender, RoutedEventArgs e)
        {

        }

        private void Book_delaytBTN_Click5(object sender, RoutedEventArgs e)
        {

        }

        private void Member_delayBTN_Click6(object sender, RoutedEventArgs e)
        {

        }

        private void SHOW1BTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EmployeeMEMBER_BackBTN_Click_02(object sender, RoutedEventArgs e)
        {
            Employee E = new Employee();
            E.Show();
            this.Close();
        }
    }
}
