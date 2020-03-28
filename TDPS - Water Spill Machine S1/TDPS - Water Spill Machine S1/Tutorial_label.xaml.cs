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
using System.Windows.Interop;

namespace TDPS___Water_Spill_Machine_S1
{
    public partial class Tutorial_label : Window
    {
        public Tutorial_label()
        {
            InitializeComponent();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (GlobalVar.max_tutor_windows_is_increased == false)
            {
                this.Width = 600;
                this.Height = 900;
                Button_arr.Width = 40;
                Button_arr.Height = 40;
                Button_search.Width = 40;
                Button_search.Height = 40;
                Button_arr.Margin = new Thickness(522, 176, 0, 0);
                Button_search.Margin = new Thickness(480, 176, 0, 0);
                GlobalVar.max_tutor_windows_is_increased = true;
            }
            else
            {
                this.Width = 300;
                this.Height = 450;
                Button_arr.Width = 20;
                Button_arr.Height = 20;
                Button_search.Width = 20;
                Button_search.Height = 20;
                Button_arr.Margin = new Thickness(263, 88, 0, 0);
                Button_search.Margin = new Thickness(242, 88, 0, 0);
                GlobalVar.max_tutor_windows_is_increased = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GlobalVar.tutorial_window_is_open = false;
            this.Close();
        }
    }
}
