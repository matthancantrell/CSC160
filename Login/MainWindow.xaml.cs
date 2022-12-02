using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            txtReturn.Text = "";

            ht.Clear(); // Clear Hashtable before useage

            // Add Values Based On User Input
            ht.Add("@Username", txtUsername.Text);
            ht.Add("@Password", txtPassword.Text);

            // SQL Statement to Pull Data From Database based on user input
            sql = "Select Name from Users where Username=@Username and Password=@Password";

            dt = ExDB.GetDataTable("CantrellDB", ht, sql); // Grab Datatable From Database

            if (dt.Rows.Count > 0)
            {
                txtReturn.Text = "Login Successful"; // If The datatable returns a value matching that entered, SUCCESS
            }
            else
            {
                txtReturn.Text = "Login Failed"; // If no data in the datatable matches that entered, FAIL
            }

            // Reset Values After Execution
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            // Emptying Hashtable Before Use
            ht.Clear();

            // SQL Statement Made To Add/Insert User Data To Table
            sql = "Insert into Users (Name, Username, Password, Email) Values (@Name, @Username, @Password, @Email)";

            // Adding Values To The Hashtable based on values provided by user
            ht.Add("@Name", txtRName.Text);
            ht.Add("@Username", txtRUsername.Text);
            ht.Add("@Password", txtRPassword.Text);
            ht.Add("@Email", txtREmail.Text);

            // Execute Registration To The SQL Database
            lngReturn = ExDB.ExecuteIt("CantrellDB", sql, ht);

            // Reset Values After Execution
            txtRName.Text = "";
            txtRUsername.Text = "";
            txtRPassword.Text = "";
            txtREmail.Text = "";
        }
    }
}
