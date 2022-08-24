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
    /// Interaction logic for BOOKS.xaml
    /// </summary>
    public partial class BOOKS : Window
    {
        public BOOKS()
        {
            InitializeComponent();
        }


        private void EmployeeBOOKS_BackBTN_Click_02(object sender, RoutedEventArgs e)
        {
            Employee E = new Employee();
            E.Show();
            this.Close();
        }

        private void EmployeeBOOKS_All_Books_Click_02(object sender, RoutedEventArgs e)
        {

        }

        private void EmployeeBOOKS_Borrowed_books_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void EmployeeBOOKS_Available_books_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
