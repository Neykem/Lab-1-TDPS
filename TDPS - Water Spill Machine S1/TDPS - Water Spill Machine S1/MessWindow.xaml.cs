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
    public partial class MessWindow : Window
    {
        public MessWindow()
        {
            InitializeComponent();
            if (DepozitGlobalVar.buff_col_d1 != 0 || DepozitGlobalVar.buff_col_d5 != 0 || DepozitGlobalVar.buff_col_d10 != 0)
            {
                Cash_remove.Text = "10$ - " + DepozitGlobalVar.buff_col_d10.ToString() + "      " + "5$ - " + DepozitGlobalVar.buff_col_d5.ToString() + "      " + "1$ - " + DepozitGlobalVar.buff_col_d1.ToString();
            }
            else 
            {
                Main_page_label.Text = "";
                Cash_remove.Text = "Приемник пуст!";
                OK_cash_remove.Content = "Принять";
            }
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
