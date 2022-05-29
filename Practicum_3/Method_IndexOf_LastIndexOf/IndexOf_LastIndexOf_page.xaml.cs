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
    /// Логика взаимодействия для IndexOf_LastIndexOf_page.xaml
    /// </summary>
    public partial class IndexOf_LastIndexOf_page : Page
    {
        public IndexOf_LastIndexOf_page()
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
        private void Start_IndexOf_LastIndexOf_Click(object sender, RoutedEventArgs e)
        {
            if (First_index_string.Text.IndexOf(Second_index_string.Text) >= 0)
            {
                IndexOf_LastIndexOf_Result.Text = $"Первое вхождение элемента \"{Second_index_string.Text}\" можно увидеть по индексу {First_index_string.Text.IndexOf(Second_index_string.Text)} элемента строки \"{First_index_string.Text}\"";
                IndexOf_LastIndexOf_Result.Text += $"\nПоследнее вхождение элемента \"{Second_index_string.Text}\" можно увидеть по индексу {First_index_string.Text.LastIndexOf(Second_index_string.Text)} элемента строки \"{First_index_string.Text}\"";
            }
            else { IndexOf_LastIndexOf_Result.Text = $"Элемент \"{Second_index_string.Text}\" не содержится в строке \"{First_index_string.Text}\""; }
        }
    }
}
