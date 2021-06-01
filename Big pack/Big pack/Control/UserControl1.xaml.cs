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

namespace Big_pack.Control
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Tovar_Loaded(object sender, RoutedEventArgs e) { Load_Data(""); }
        private void Search_TextChanged(object sender,TextChangedEventArgs e) { Load_Data("");}

        //фильтры
        private void Sort_SelectionChanged_1(object sender,SelectionChangedEventArgs e)
        {
            i
        }
        }
    }
}
