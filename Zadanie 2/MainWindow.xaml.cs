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

namespace Zadanie_2
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
            string c = "";
            string b = "";
            string v = "";
            switch (a/10)
            {
                case 2:b = "Двадцать"; break;
                case 3:b = "Тридцать"; break;
                case 4:b = "Сорок"; break;
                case 5:b = "Пятдесят"; break;
                case 6:b = "Шестьдесят"; break;
            }
            switch (a % 10)
            {
                case 1: v = " один";break;
                case 2: v = " два"; break;
                case 3: v = " три"; break;
                case 4: v = " четыре"; break;
                case 5: v = " пять"; break;
                case 6: v = " шесть"; break;
                case 7: v = " семь"; break;
                case 8: v = " восемь"; break;
                case 9: v = " девять"; break;
            }
            switch (a % 10)
            {
                case 0: c = " лет"; break;
                case 1: c = " год"; break;
                case 2: c = " года"; break;
                case 3: c = " года"; break;
                case 4: c = " года"; break;
                case 5: c = " лет"; break;
                case 6: c = " лет"; break;
                case 7: c = " лет"; break;
                case 8: c = " лет"; break;
                case 9: c = " лет"; break;
            }
            TexRE.Text += "\n" + b + v + c ;
        }
    }
}
