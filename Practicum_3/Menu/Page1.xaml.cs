using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practicum_3
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[0].Close();
        }
        private void Join_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Join_page());
        }
        private void Concat_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Concat_page());
        }
        private void ToLUpper_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ToUpper_page());
        }

        private void Contains_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Contains_page());
        }
        private void EndsWith_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EndsWith_page());
        }
        private void IndexOf_LastIndexOf_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new IndexOf_LastIndexOf_page());
        }
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Insert_page());
        }

        private void Replace_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Replace_page());
        }
        private void Split_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Split_page());
        }
        private void Substring_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Substring());
        }
        private void Trim_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Trim_page());
        }
    }
}
