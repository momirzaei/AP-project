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
    /// Interaction logic for user.xaml
    /// </summary>
    ///

    public partial class user : Window
    {
        SqlConnection user_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M.HOSEIN\Desktop\project\sql\wpfpro.mdf;Integrated Security=True;Connect Timeout=30");
        public List<string> NAMEUSER = new List<string>();
        public List<string> EMAILUSER = new List<string>();
        public List<string> PHONEUSER = new List<string>();
        string path = "";

        public user()
        {
            InitializeComponent();
            ;
        }
        public void saving_member()
        {
            SqlDataAdapter DA_USER_NAME = new SqlDataAdapter("select user_name from Table_user where user_name = '" + user_name.Text + "'", user_con);
            DataTable DT_USER_NAME = new DataTable();
            DA_USER_NAME.Fill(DT_USER_NAME);

            SqlDataAdapter DA_USER_PHONE = new SqlDataAdapter("select phone_number from Table_user where phone_number = '" + phone_number.Text + "'", user_con);
            DataTable DT_USER_PHONE = new DataTable();
            DA_USER_PHONE.Fill(DT_USER_PHONE);

            SqlDataAdapter DA_USER_email = new SqlDataAdapter("select email from Table_user where email = '" + email.Text + "'", user_con);
            DataTable DT_USER_email = new DataTable();
            DA_USER_email.Fill(DT_USER_email);

            /* SqlDataAdapter DA_USER_password = new SqlDataAdapter("select password from user_Table where password = '" + password_signup.Text + "'", user_con);
             DataTable DT_USER_password = new DataTable();
             DA_USER_password.Fill(DT_USER_password);*/


            if (DT_USER_NAME.Rows.Count >= 1 || DT_USER_PHONE.Rows.Count >= 1 || DT_USER_email.Rows.Count >= 1 /*|| DT_USER_password.Rows.Count >= 1 */)
            {
                MessageBox.Show("can not repeat");
            }
            else
            {
                user_con.Open();

                byte[] img_user = null;
                FileStream fs_user = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br_user = new BinaryReader(fs_user);
                img_user = br_user.ReadBytes((int)fs_user.Length);

                string command;
                command = "insert into Table_user values('" + user_name.Text + "','" + phone_number.Text + "','" + email.Text + "','" + password_signup.Text + "',@img_user)";
                SqlCommand user_com = new SqlCommand(command, user_con);
                user_com.Parameters.Add(new SqlParameter("@img_user", img_user));
                user_com.BeginExecuteNonQuery();
                //user_con.Close();
                mainpayment MP = new mainpayment();
                MP.Show();
                this.Close();
            }
        }
        public void saving_employe()
        {
            SqlDataAdapter DA_USER_NAME = new SqlDataAdapter("select user_name from Table_employe where user_name = '" + user_name.Text + "'", user_con);
            DataTable DT_USER_NAME = new DataTable();
            DA_USER_NAME.Fill(DT_USER_NAME);

            SqlDataAdapter DA_USER_PHONE = new SqlDataAdapter("select phone_number from Table_employe where phone_number = '" + phone_number.Text + "'", user_con);
            DataTable DT_USER_PHONE = new DataTable();
            DA_USER_PHONE.Fill(DT_USER_PHONE);

            SqlDataAdapter DA_USER_email = new SqlDataAdapter("select email from Table_employe where email = '" + email.Text + "'", user_con);
            DataTable DT_USER_email = new DataTable();
            DA_USER_email.Fill(DT_USER_email);

            /* SqlDataAdapter DA_USER_password = new SqlDataAdapter("select password from user_Table where password = '" + password_signup.Text + "'", user_con);
             DataTable DT_USER_password = new DataTable();
             DA_USER_password.Fill(DT_USER_password);*/


            if (DT_USER_NAME.Rows.Count >= 1 || DT_USER_PHONE.Rows.Count >= 1 || DT_USER_email.Rows.Count >= 1 /*|| DT_USER_password.Rows.Count >= 1 */)
            {
                MessageBox.Show("can not repeat");
            }
            else
            {
                user_con.Open();

                byte[] img_user = null;
                FileStream fs_user = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br_user = new BinaryReader(fs_user);
                img_user = br_user.ReadBytes((int)fs_user.Length);

                string command;
                command = "insert into Table_employe values('" + user_name.Text + "','" + phone_number.Text + "','" + email.Text + "','" + password_signup.Text + "',@img_user)";
                SqlCommand user_com = new SqlCommand(command, user_con);
                user_com.Parameters.Add(new SqlParameter("@img_user", img_user));
                user_com.BeginExecuteNonQuery();
                //user_con.Close();
                Admin_Employes AE = new Admin_Employes();
                AE.Show();
                this.Close();
            }
        }
        private void peymentBTN_Click(object sender, RoutedEventArgs e)
        {


            int a = 0, b = 0, c = 0, d = 0;
            Regex reg_user_name = new Regex(@"^[A-Za-z0-9]{3,32}$");
            if (!reg_user_name.IsMatch(user_name.Text))
            {
                MessageBox.Show("user_name is wrong!");
            }
            else
            {
                a = 1;
            }

            Regex reg_phone_number = new Regex(@"^09[0-9]{9}$");
            if (!reg_phone_number.IsMatch(phone_number.Text))
            {
                MessageBox.Show("phone_number is wrong!");
            }
            else
            {
                b = 1;
            }

            Regex reg_email = new Regex(@"^[A-Za-z0-9_-]{1,32}@[A-Za-z0-9]{1,8}\.[A-Za-z]{1,3}$");
            if (!reg_email.IsMatch(email.Text))
            {
                MessageBox.Show("email is wrong!");
            }
            else
            {
                c = 1;
            }

            Regex reg_password = new Regex(@"(?=.*[a-z])(?=.*[A-Z])[a-zA-Z]{8,32}");
            if (!reg_password.IsMatch(password_signup.Text))
            {
                MessageBox.Show("password is wrong!");
            }
            else
            {
                d = 1;
            }

            if (a == 1 && b == 1 && c == 1 && d == 1)
            {
                if(which.whichpage== "MainWindow")
                {
                    saving_member();
                }
                if (which.whichpage == "Admin_Employes")
                {
                    saving_employe();
                }
            }

        }


        private void backBTN_Click(object sender, RoutedEventArgs e)
        {
            if (which.whichpage == "MainWindow")
            {
                MainWindow Main = new MainWindow();
                Main.Show();
                this.Close();

            }
            if (which.whichpage == "Admin_Employes")
            {
                Admin_Employes AE = new Admin_Employes();
                AE.Show();
                this.Close();
            }

        }



        private void imageBTN_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openfiledlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = openfiledlg.ShowDialog();
            if (result == true)
            {
                path = openfiledlg.FileName.ToString(); ;
                FileNameTextBox.Text = openfiledlg.FileName;
                image_singup.Source = new BitmapImage(new Uri(FileNameTextBox.Text));

            }
        }

    }
}
