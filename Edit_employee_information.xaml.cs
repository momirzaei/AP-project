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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Edit_employee_information.xaml
    /// </summary>
    public partial class Edit_employee_information : Window
    {
        public Edit_employee_information()
        {
            InitializeComponent();
        }

        private void imageBTN_Click_0(object sender, RoutedEventArgs e)
        {

        }

        private void EditBTN2_Click(object sender, RoutedEventArgs e)
        {
            if (user_name_0.Text == null)
            {
                MessageBox.Show("User_name cannot be null");
            }
            try
            {

                if (phone_number_0.Text.Length != 11)
                {
                    MessageBox.Show("phone number must have 11 digits .");
                }
                if (phone_number_0.Text[0] != '0' && (phone_number_0.Text[1] != '9'))
                {
                    MessageBox.Show("phone number must be start with 09 .");
                }
                for (int z = 0; z < 11; z++)
                {
                    if (phone_number_0.Text[z] != '0' && phone_number_0.Text[z] != '1' && phone_number_0.Text[z] != '2' && phone_number_0.Text[z] != '3' && phone_number_0.Text[z] != '4' &&
                        phone_number_0.Text[z] != '5' && phone_number_0.Text[z] != '6' && phone_number_0.Text[z] != '7' && phone_number_0.Text[z] != '8' && phone_number_0.Text[z] != '9')
                    {
                        MessageBox.Show("phone number must be digit");
                    }
                }
            }
            catch (Exception mm)
            {
                MessageBox.Show(mm.Message);
            }

            for (int i = 0; i < email_0.Text.Length; i++)
            {
                for (int j = 0; j < email_0.Text.Length; j++)
                {
                    if ((email_0.Text[i] == '@' && i > 30) || (email_0.Text[j] == '.' && email_0.Text[i] == '@' && ((j - i) > 8)) || (email_0.Text.Length - j > 3))
                    {
                        MessageBox.Show("digit out of range");
                    }
                }
            }

            Regex reg = new Regex(@"^[a-zA-Z0-9].*@[a-zA-Z0-9]+\.[a-zA-Z]");
            if (!reg.IsMatch(email_0.Text))
            {
                MessageBox.Show("email is wrong!");
            }


        }

        private void Edit_employee_information_backBTN_Click_02(object sender, RoutedEventArgs e)
        {
            Employee Main = new Employee();
            Main.Show();
            this.Close();
        }
    }
}
