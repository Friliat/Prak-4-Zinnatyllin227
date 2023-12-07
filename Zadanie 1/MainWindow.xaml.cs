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

namespace Zadanie_1
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
            string cc = Convert.ToString(TexA.Text);
            int nn = Convert.ToInt32(TexC.Text);
            if (cc == "З")
            {
                switch (nn)
                {
                    case 1: cc = "Ю"; break;
                    case 0: cc = "З"; break;
                    case -1: cc = "С"; break;
                }
            }
                if (cc == "С")
                {
                    switch (nn)
                    {
                        case 1: cc = "З"; break;
                        case 0: cc = "С"; break;
                        case -1: cc = "В"; break;
                    }
                }
                if (cc == "Ю")
                {
                    switch (nn)
                    {
                        case 1: cc = "В"; break;
                        case 0: cc = "Ю"; break;
                        case -1: cc = "З"; break;
                    }
                }
                if(cc == "В")
                {
                    switch (nn)
                    {
                        case 1: cc = "С"; break;
                        case 0: cc = "В"; break;
                        case -1: cc = "Ю"; break;
                    }
                }
            TexRE.Text += "\n" + "Направление:" + cc;
        }
    }
}
