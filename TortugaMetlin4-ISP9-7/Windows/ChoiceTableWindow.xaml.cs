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
            List<EF.IDTable> tables = ClassHelper.AppData.Context.IDTable.ToList();
            foreach (EF.IDTable table in tables)
            {
                if (table.IsAvalible == false)
                {
                    if (grd.FindName("btn" + table.ID) is Button button)
                    {
                        button.IsEnabled = false;
                        button.
                    }
                }
            }
        }
    }
}
