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
    /// Логика взаимодействия для Replace_page.xaml
    /// </summary>
    public partial class Replace_page : Page
    {
        public Replace_page()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Start_Replace_Click(object sender, RoutedEventArgs e)
        {
            Replace_Result.Text = First_replace_string.Text.Replace(Index_string.Text, Second_replace_string.Text);
        }
    }
}
