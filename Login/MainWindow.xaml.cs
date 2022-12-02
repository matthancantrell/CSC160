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

        private void btnDoIt_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            ht.Clear();

            sql = "Insert into Users (Name, Password) Values (@Name, @Password)";

            ht.Add("@Name", txtName.Text);
            ht.Add("@Password", txtPassword.Text);

            lngReturn = ExDB.ExecuteIt("CantrellDB", sql, ht);

            sql = "Update Names set Name=@Name, Title=@Title where ID=@ID";

        }
    }
}
