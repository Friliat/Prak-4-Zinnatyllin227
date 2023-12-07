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
using static System.Math;

namespace Zadanie_3
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
            double b = Convert.ToDouble(TexB.Text);
            switch(a)
            {
                case 1: double R = b; 
                    double D = R * 2;
                    double l = 2 * PI * R;
                    double S = PI * Pow(R, 2);
                    TexRE.Text += "\n" + "R="+  R;
                    TexRE.Text += "\n" + "D="+  D;
                    TexRE.Text += "\n"+ "l=" +  l;
                    TexRE.Text += "\n" + "S=" + S;
                    break;
                case 2:
                    R = a / 2;
                    D = b;
                    l = 2 * PI * R;
                     S = PI * Pow(R, 2);
                    TexRE.Text += "\n" + "R=" + R;
                    TexRE.Text += "\n" + "D=" + D;
                    TexRE.Text += "\n" + "l=" + l;
                    TexRE.Text += "\n" + "S=" + S;
                    break;
                case 3:
                    R = a / 2 * PI;
                    D = 2 * R;
                    l = b;
                    S = PI * Pow(R, 2);
                    TexRE.Text += "\n" + "R=" + R;
                    TexRE.Text += "\n" + "D=" + D;
                    TexRE.Text += "\n" + "l=" + l;
                    TexRE.Text += "\n" + "S=" + S;
                    break;
                case 4:
                    R = Sqrt(a / 3.14);
                    D = 2 * R;
                    l = 2 * PI * R;
                    S =b;
                    TexRE.Text += "\n" + "R=" + R;
                    TexRE.Text += "\n" + "D=" + D;
                    TexRE.Text += "\n" + "l=" + l;
                    TexRE.Text += "\n" + "S=" + S;
                    break;
            }
        }
    }
}
