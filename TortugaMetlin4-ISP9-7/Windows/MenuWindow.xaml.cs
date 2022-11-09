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
using System.Windows.Shapes;
using TortugaMetlin4_ISP9_7.ClassHelper;
using TortugaMetlin4_ISP9_7.Pages;

namespace TortugaMetlin4_ISP9_7.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            frPages.Content = new MenuPage();

        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            tbOrder.Foreground = new SolidColorBrush(Colors.Black);
            tbChooseTable.Foreground= new SolidColorBrush(Colors.Black);
            tbMenu.Foreground=new SolidColorBrush(Colors.LimeGreen);
            frPages.Content = new MenuPage();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            tbOrder.Foreground = new SolidColorBrush(Colors.LimeGreen);
            tbChooseTable.Foreground = new SolidColorBrush(Colors.Black);
            tbMenu.Foreground = new SolidColorBrush(Colors.Black);
            frPages.Content = new OrderPage();
        }

        private void btnChooseTable_Click(object sender, RoutedEventArgs e)
        {
            tbOrder.Foreground = new SolidColorBrush(Colors.Black);
            tbChooseTable.Foreground = new SolidColorBrush(Colors.LimeGreen);
            tbMenu.Foreground = new SolidColorBrush(Colors.Black);
            GlobaVariables.selectedTable.IsAvalible = true;
            AppData.Context.SaveChanges();
            this.Close();
        }

    }
}
