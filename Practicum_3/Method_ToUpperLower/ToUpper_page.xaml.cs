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
    /// Логика взаимодействия для ToUpper_page.xaml
    /// </summary>
    public partial class ToUpper_page : Page
    {
        public ToUpper_page()
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
        private void Start_ToLUpper_Click(object sender, RoutedEventArgs e)
        {
            ToLUpper_Result.Text = First_tolupper_string.Text.ToUpper();
            ToLower_Result.Text = First_tolupper_string.Text.ToLower();
        }
    }
}
