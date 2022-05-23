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



    }
}
