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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float first = 0;
        float second = 0;

        char op = '+';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResult.Text += btn.Content.ToString();
            second = Int32.Parse(TxtResult.Text);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '/';
            TxtResult.Clear();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = 'x';
            TxtResult.Clear();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '-';
            TxtResult.Clear();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '+';
            TxtResult.Clear();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(TxtResult.Text);
            float result = 0;

            if (op == '+') result = first + second;
            if (op == '-') result = first - second;
            if (op == '/') result = first / second;
            if (op == '*') result = first * second;
            if (TxtResult.Text == "0") TxtResult.Clear();
            TxtResult.Text = result.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            first = 0;
            second = 0;
            TxtResult.Clear();
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(TxtResult.Text);
            first = first * first;
            TxtResult.Text = first.ToString();
        }
    }
}
