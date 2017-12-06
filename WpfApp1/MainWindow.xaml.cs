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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int number = 15;
            //number = number + 10;
            //number = 36 * 15;
            //number = 12 - (42 / 7);
            //number += 10;
            //number *= 3;
            //number = 71 / 3;
            //int count = 0;
            //count++;
            //count--;
            //string result = "hello";
            //result += " again " + result;
            //MessageBox.Show(result);
            //result = "the value is: " + count;
            //result = "";
            //bool yesNo = false;
            //bool anotherBool = true;
            //yesNo = !anotherBool;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x + 3;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name
                + "\nx is " + x
                + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if(x == 10)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if((someValue == 3) && (name == "Joe"))
            {
                myLabel.Text = "x is 3 and the name is Joe";
            }
            myLabel.Text = "this line runs no matter what";

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count = count+1;
            }
            int length = 5;
            for (int i = 0; i < length; i++)
            {
                count = count-1;
            }
            myLabel.Text = "The answer is " + count;
        }
    }
}
