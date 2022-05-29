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
    /// Логика взаимодействия для EndsWith_page.xaml
    /// </summary>
    public partial class EndsWith_page : Page
    {
        public EndsWith_page()
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
        private void Start_Endswith_Click(object sender, RoutedEventArgs e)
        {
            EndsWith_Result.Text = (First_endswith_string.Text.EndsWith(Second_endswith_string.Text) == true) ? $"Строка \"{First_endswith_string.Text}\" заканчивается на \"{Second_endswith_string.Text}\"" : $"Строка \"{First_endswith_string.Text}\" не заканчивается на \"{Second_endswith_string.Text}\"";
        }
    }
}
