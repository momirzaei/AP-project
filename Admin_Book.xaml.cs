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
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Admin_Book.xaml
    /// </summary>
    
    class book
    {

    }
    public partial class Admin_Book : Window
    {
        SqlConnection book_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M.HOSEIN\Desktop\project\sql\wpfpro.mdf;Integrated Security=True;Connect Timeout=30");
        public Admin_Book()
        {
            InitializeComponent();
        }

        private void add_bookBTn_Click_01(object sender, RoutedEventArgs e)
        {
            save_book();
        }
        public void save_book()
        {
            book_con.Open();
            string command;
            command = "insert into book_Table values('" + book_name_01.Text + "','" + writer_01.Text + "','" + genre_01.Text + "','" + publication_number_01.Text + "')";
            SqlCommand book_com = new SqlCommand(command, book_con);
            book_com.BeginExecuteNonQuery();
            //user_con.Close();

            Admin A = new Admin();
            A.Show();
            this.Close();
        }
    }
}
