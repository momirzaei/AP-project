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
    /// Interaction logic for Admin_Employes.xaml
    /// </summary>
    public class delEMP
    {
        public static string deleteEMP1;
    }
    public partial class Admin_Employes : Window
    {
        SqlConnection EMP_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M.HOSEIN\Desktop\project\sql\wpfpro.mdf;Integrated Security=True;Connect Timeout=30");
        public Admin_Employes()
        {
            InitializeComponent();

            try
            {
                EMP_con.Open();
                string command = "select * from Table_employe ";
                SqlCommand EMP_com = new SqlCommand(command, EMP_con);
                EMP_com.ExecuteNonQuery();

                SqlDataAdapter EMP_DA = new SqlDataAdapter(EMP_com);
                DataTable EMP_DT = new DataTable("book_Table");
                EMP_DA.Fill(EMP_DT);
                EMP_datagrid.ItemsSource = EMP_DT.DefaultView;
                EMP_DA.Update(EMP_DT);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Admin_Employes_Add_Click_01(object sender, RoutedEventArgs e)
        {
            which.whichpage = "Admin_Employes";
            user U = new user();
            U.Show();
            this.Close();
        }

        private void Admin_Employes_payment_Click_01(object sender, RoutedEventArgs e)
        {
            Admin_Employee_pay AEP = new Admin_Employee_pay();
            AEP.Show();
            //this.Close();
        }

        private void deleteEMP_BTN_Click(object sender, RoutedEventArgs e)
        {
            SqlDataAdapter DA_USER_NAME = new SqlDataAdapter("select user_name from Table_employe where user_name = '" + deleteEMP.Text + "'", EMP_con);
            DataTable DT_USER_NAME = new DataTable();
            DA_USER_NAME.Fill(DT_USER_NAME);

            if (DT_USER_NAME.Rows.Count == 0 )
            {
                MessageBox.Show("this person is not available !");
            }
            else
            {
                delEMP.deleteEMP1 = deleteEMP.Text;
                Delete del = new Delete();
                del.Show();
                //this.Close();
            }



        }

    }
}
