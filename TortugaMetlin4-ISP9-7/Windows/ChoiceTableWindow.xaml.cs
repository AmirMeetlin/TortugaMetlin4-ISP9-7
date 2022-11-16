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

namespace TortugaMetlin4_ISP9_7.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChoiceTableWindow.xaml
    /// </summary>
    public partial class ChoiceTableWindow : Window
    {
        public ChoiceTableWindow()
        {
            InitializeComponent();
            updateTables();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string id = (sender as Button).Name;
            id = id.Remove(0,3);
            EF.IDTable table = ClassHelper.AppData.Context.IDTable.Where(i => i.ID==id).FirstOrDefault();       
            table.IsAvalible = false;
            GlobaVariables.selectedTable = table;
            ClassHelper.AppData.Context.SaveChanges();
            MenuWindow menuWindow = new MenuWindow();
            GlobaVariables.menuWindow = menuWindow;
            this.Hide();
            menuWindow.ShowDialog();
            updateTables();
            this.ShowDialog();
        }

        private void updateTables()
        {
            List<EF.IDTable> tables = ClassHelper.AppData.Context.IDTable.ToList();
            foreach (EF.IDTable table in tables)
            {
                if (table.IsAvalible == false)
                {
                    if (grd.FindName("btn" + table.ID) is Button button)
                    {
                        button.IsEnabled = false;

                        if (grd.FindName("imgbtn" + table.ID) is Image image)
                        {
                            image.Source = new BitmapImage(new Uri("/Windows/Крест.png", UriKind.Relative)) { CreateOptions = BitmapCreateOptions.IgnoreImageCache };
                        }

                    }
                }
            }
        }
    }
}
