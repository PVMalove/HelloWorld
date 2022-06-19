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

namespace OTUS_Modul_02
{
    
    public partial class MainWindow : Window
    {
        double num1 = 0;
        double num2 = 0;
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_num_Click(object sender, RoutedEventArgs e)
        {
            Button butten = (Button)sender;
            string num = butten.Content.ToString();
            if (txtValue.Text == "0")
                txtValue.Text = num;
            else
                txtValue.Text += num;
            
            if (operation == "")
            {
                num1 = Double.Parse(txtValue.Text);
            }
            else
            {
                num2 = Double.Parse(txtValue.Text);
            }
        }
        
        private void Btn_operation_Click(object sender, RoutedEventArgs e)
        {
            Button butten = (Button)sender;
            operation = butten.Content.ToString();
            txtValue.Text = null;
        }

        private void Btn_equal_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "min":
                    result = Math.Min(num1, num2);
                    break;
                case "max":
                    result = Math.Max(num1, num2);
                    break;
                case "avg":
                    result = (num1 + num2) / 2;
                    break;
                case "x^y":
                    result = Pow(num1, (int)num2);
                    break;
            }
            txtValue.Text = result.ToString();
            operation = "";
            num1 = result;
            num2 = 0;
        }

        private double Pow(double x, int y)
        {
            if (y == 0)
                return 1;
            return Pow(x, y - 1) * x;
        }

        private void Btn_C_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            txtValue.Text = "0";
        }

        private void Btn_CE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
                num1 = 0;
            else
                num2 = 0;
            txtValue.Text = "0";
        }

        private void Btn_backspece_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = DroplastChar(txtValue.Text);
            if (operation == "")
                num1 = Double.Parse(txtValue.Text);
            else
                num2 = Double.Parse(txtValue.Text);
        }

        private static string DroplastChar(string text)
        {
            if (text.Length == 1)
                text = "0";
            else
            {
                text = text.Remove(text.Length - 1, 1);
                if (text[text.Length - 1] == ',')
                    text = text.Remove(text.Length - 1, 1);
            }
            return text;
        }

        private void Btn_plusminus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 *= -1;
                txtValue.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                txtValue.Text = num2.ToString();
            }
        }

        private void Btn_comma_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
                SetComma(num1);
            else
                SetComma(num2);
        }

        private void SetComma(double num)
        {
            if (txtValue.Text.Contains(','))
                return;
            txtValue.Text += ',';
        }
    }
}
 