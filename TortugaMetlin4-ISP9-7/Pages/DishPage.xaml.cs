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

namespace TortugaMetlin4_ISP9_7.Pages
{
    /// <summary>
    /// Логика взаимодействия для DishPage.xaml
    /// </summary>
    public partial class DishPage : Page
    {
        EF.Dish position;
        public DishPage(EF.Dish dish)
        {
            InitializeComponent();
            if((DateTime.Now.Day == 29 || DateTime.Now.Day == 30 || DateTime.Now.Day == 31)&& DateTime.Now.DayOfWeek.ToString()=="Saturday")
            {
                dish.Cost = dish.Cost * Convert.ToDecimal(0.89);
                tbPrice.Text = dish.Cost.ToString() + "- с учетом скидки 11%";
            }
            else
            {
                tbPrice.Text = dish.Cost.ToString();
            }
            tbTitle.Text = dish.Title;
            
            tbDescription.Text = dish.Description;
            imgDish.Source = new BitmapImage(new Uri(dish.PhotoPath, UriKind.Relative)); 
            position = dish;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //GlobaVariables.preOrder preorder = new GlobaVariables.preOrder({
            //    title = position.Title,
            //    id = position.ID,
            //    price = position.Cost,
            //    qty = 1
            //});
            GlobaVariables.preOrder preorder = new GlobaVariables.preOrder(){
                title=position.Title,
                id = position.ID,
                price = position.Cost,
                qty = 1
            };
            //List<GlobaVariables.preOrder> preorderRow = new List<GlobaVariables.preOrder>();
            //preorderRow.Add(preorder);
            GlobaVariables.ContainerOrder.preOrderList.Add(preorder);
            NavigationService.Navigate(new OrderPage());
        }
    }
}
