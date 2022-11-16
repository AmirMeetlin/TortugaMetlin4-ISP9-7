﻿using System;
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
using TortugaMetlin4_ISP9_7.ClassHelper;
using TortugaMetlin4_ISP9_7.Windows;

namespace TortugaMetlin4_ISP9_7.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            lvOrder.ItemsSource = GlobaVariables.ContainerOrder.preOrderList;
            CountSum();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            var OrderRow = (sender as Button).DataContext as GlobaVariables.preOrder;
            if (OrderRow.qty==1)
            {
                GlobaVariables.ContainerOrder.preOrderList.Remove(OrderRow);
            }
            else
            {
                OrderRow.qty--;
            }
            lvOrder.ItemsSource = null;
            lvOrder.ItemsSource = GlobaVariables.ContainerOrder.preOrderList;
            CountSum();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            var OrderRow = (sender as Button).DataContext as GlobaVariables.preOrder;
            OrderRow.qty++;
            lvOrder.ItemsSource = null;
            lvOrder.ItemsSource = GlobaVariables.ContainerOrder.preOrderList;
            CountSum();
        }

        private void CountSum()
        {
            decimal sum = 0;
            foreach(GlobaVariables.preOrder Row in GlobaVariables.ContainerOrder.preOrderList)
            {
                sum+=Row.sum;
            }
            tbSummary.Text = "Итого: "+sum.ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            var resClick = MessageBox.Show("Вы уверены, что готовы оформить заказ?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (resClick == MessageBoxResult.No)
            {
                return;
            }
            EF.Order order = new EF.Order();
            order.IDEmpl = 1;
            order.IDTable = GlobaVariables.selectedTable.ID;
            AppData.Context.Order.Add(order);
            AppData.Context.SaveChanges();
            foreach(GlobaVariables.preOrder Row in GlobaVariables.ContainerOrder.preOrderList)
            {
                EF.OrderDish orderDish = new EF.OrderDish();
                orderDish.IDOrder = order.ID;
                orderDish.IDDish = Row.id;
                orderDish.QTY = Row.qty;
                AppData.Context.OrderDish.Add(orderDish);
            }
            AppData.Context.SaveChanges();           
            MessageBox.Show("Заказ был успешно офрмлен, пожалуйста ожидайте, к вам подойдет официант", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
            GlobaVariables.menuWindow.Close();
            
        }
    }
}
