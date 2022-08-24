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
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        SqlConnection EMP_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M.HOSEIN\Desktop\project\sql\wpfpro.mdf;Integrated Security=True;Connect Timeout=30");
        public Delete()
        {
            InitializeComponent();
        }

        private void YES_Click_01(object sender, RoutedEventArgs e)
        {
            EMP_con.Open();
            string command = "delete from Table_employe where  user_name='" + delEMP.deleteEMP1 + "' ";
            SqlCommand EMP_com = new SqlCommand(command, EMP_con);
            EMP_com.ExecuteNonQuery();
            MessageBox.Show("deleted!");
        }

        private void NO_Click_01(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
