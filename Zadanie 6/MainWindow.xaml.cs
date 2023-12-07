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

namespace Zadanie_6
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
            int a = Convert.ToInt32(TexA.Text);
            int b;
            bool van = false;
            bool two = true;
            while (a > 0)
            {
                b = a % 10;
                a = a / 10;
                if (b % 2 == 1)
                {
                    van = true;
                }
                else if (b % 2 == 0)
                {
                    two = false;
                }
            }
            if (van == true)
            {
                TexRE.Text += "\n" + van;

            }
            else if (two == false)
            {
                TexRE.Text += "\n" + two;

            }
        }
    }
}
