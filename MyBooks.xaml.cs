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
    /// Interaction logic for MyBooks.xaml
    /// </summary>
    public partial class MyBooks : Window
    {
        public MyBooks()
        {
            InitializeComponent();
        }

        private void Return_the_bookBTN_Click1(object sender, RoutedEventArgs e)
        {

        }

        private void MyBooks_BackBTN_Click_03(object sender, RoutedEventArgs e)
        {
            Login_members Main = new Login_members();
            Main.Show();
            this.Close();
        }
    }
}
