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

namespace TortugaMetlin4_ISP9_7.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnBar_Click(object sender, RoutedEventArgs e)
        {
            tbBar.TextDecorations = TextDecorations.Underline;
            tbHotDishes.TextDecorations = TextDecorations.Underline;
        }

        private void btnHotDishes_Click(object sender, RoutedEventArgs e)
        {
            tbHotDishes.TextDecorations = TextDecorations.Underline;
        }

        private void btnDesserts_Click(object sender, RoutedEventArgs e)
        {
            tbDesserts.TextDecorations = TextDecorations.Underline;
        }

        private void btnSalads_Click(object sender, RoutedEventArgs e)
        {
            tbSalads.TextDecorations = TextDecorations.Underline;
        }

        private void btnSnacks_Click(object sender, RoutedEventArgs e)
        {
            tbSnacks.TextDecorations = TextDecorations.Underline;
        }
    }
}
