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
    /// Логика взаимодействия для Contains_page.xaml
    /// </summary>
    public partial class Contains_page : Page
    {
        public Contains_page()
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
        private void Start_Contains_Click(object sender, RoutedEventArgs e)
        {
            Contains_Result.Text = (First_contains_string.Text.Contains(Second_contains_string.Text) == true) ? $"Строка \"{Second_contains_string.Text}\" содержится в \"{First_contains_string.Text}\"" : $"Строка \"{Second_contains_string.Text}\" не содержится в \"{First_contains_string.Text}\"";
        }
    }
}
