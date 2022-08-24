using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for BOOKLIST.xaml
    /// </summary>
    public partial class BOOKLIST : Window
    {
        SqlConnection addbook_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M.HOSEIN\Desktop\project\sql\wpfpro.mdf;Integrated Security=True;Connect Timeout=30");
        public BOOKLIST()
        {
            InitializeComponent();
            try
            {
                addbook_con.Open();
                string command = "select * from book_Table ";
                SqlCommand addbook_com = new SqlCommand(command, addbook_con);
                addbook_com.ExecuteNonQuery();

                SqlDataAdapter addbook_DA = new SqlDataAdapter(addbook_com);
                DataTable addbook_DT = new DataTable("book_Table");
                addbook_DA.Fill(addbook_DT);
                addbook_datagrid.ItemsSource = addbook_DT.DefaultView;
                addbook_DA.Update(addbook_DT);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addbookBTN_Click_01(object sender, RoutedEventArgs e)
        {
            Admin_Book AB = new Admin_Book();
            AB.Show();
            this.Hide();
        }


    }
}
