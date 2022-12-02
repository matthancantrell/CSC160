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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dungeons_Dragons_Random
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

        private void Btn_Random_Click(object sender, RoutedEventArgs e)
        {
            Character c = new Character();

            c = c.randomCharacter();

            Age_Out.Content = c.age;
            Gender_Out.Content = c.gender;
            Class_Out.Content = c.Class;
            Race_Out.Content = c.race;
        }
    }
}
