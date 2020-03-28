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

namespace TDPS___Water_Spill_Machine_S1
{
    /// <summary>
    /// Логика взаимодействия для Three_hundred_buckses.xaml
    /// </summary>
    public partial class Three_hundred_buckses : Window
    {
        private int b_buffer = 0;
        public Three_hundred_buckses()
        {
            InitializeComponent();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void Ok_click(object sender, RoutedEventArgs e)
        {
            try
            {
                int buff_1, buff_2;
                buff_1 = b_buffer % 10;
                DepozitGlobalVar.col_d10 += (b_buffer - buff_1) / 10;
                buff_2 = buff_1 % 5;
                DepozitGlobalVar.col_d5 += (buff_1 - buff_2) / 5;
                DepozitGlobalVar.col_d1 += buff_2;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error","Operation Unsuccessfully!");
            }
        }

        private void Close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Diposit_text_changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                b_buffer = Convert.ToInt32(Content_buckses.Text);
            }
            catch
            {
                Central_label.FontSize = 14;
                Central_label.Content = "  Вводите только цифры!";
                Content_buckses.Text = "";
            }
        }
    }
}
