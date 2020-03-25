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
    static public class DepozitGlobalVar
    {
        static public int col_d1 = 2;
        static public int col_d5 = 2;
        static public int col_d10 = 2;
        static public int buff_col_d1;
        static public int buff_col_d5;
        static public int buff_col_d10;
    }
    public partial class Window_coin_acceptor : Window
    {
        public Window_coin_acceptor()
        {
            InitializeComponent();
            Have_d1.Text = DepozitGlobalVar.col_d1.ToString();
            Have_d5.Text = DepozitGlobalVar.col_d5.ToString();
            Have_d10.Text = DepozitGlobalVar.col_d10.ToString();
            Deposit_set_d1.Text = DepozitGlobalVar.buff_col_d1.ToString();
            Deposit_set_d5.Text = DepozitGlobalVar.buff_col_d5.ToString();
            Deposit_set_d10.Text = DepozitGlobalVar.buff_col_d10.ToString();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        //1d
        private void D1_pl_Click(object sender, RoutedEventArgs e)
        {
            if (DepozitGlobalVar.col_d1 > 0)
            {
                GlobalVar.cash_deposit++;
                DepozitGlobalVar.col_d1--;
                DepozitGlobalVar.buff_col_d1++;
                Have_d1.Text = DepozitGlobalVar.col_d1.ToString();
                Deposit_set_d1.Text = DepozitGlobalVar.buff_col_d1.ToString();
                f_Deposit.Text = GlobalVar.cash_deposit.ToString() + "$";
            }
        }
        private void D1_ms_Click(object sender, RoutedEventArgs e)
        {
            if (DepozitGlobalVar.buff_col_d1 > 0)
            {
                GlobalVar.cash_deposit--;
                DepozitGlobalVar.col_d1++;
                DepozitGlobalVar.buff_col_d1--;
                Have_d1.Text = DepozitGlobalVar.col_d1.ToString();
                Deposit_set_d1.Text = DepozitGlobalVar.buff_col_d1.ToString();
                f_Deposit.Text = GlobalVar.cash_deposit.ToString() + "$";
            }
        }
        //5d
        private void D5_pl_Click(object sender, RoutedEventArgs e)
        {
            if (DepozitGlobalVar.col_d5 > 0)
            {
                GlobalVar.cash_deposit += 5;
                DepozitGlobalVar.col_d5--;
                DepozitGlobalVar.buff_col_d5++;
                Have_d5.Text = DepozitGlobalVar.col_d5.ToString();
                Deposit_set_d5.Text = DepozitGlobalVar.buff_col_d5.ToString();
                f_Deposit.Text = GlobalVar.cash_deposit.ToString() + "$";
            }
        }
        private void D5_ms_Click(object sender, RoutedEventArgs e)
        {
            if (DepozitGlobalVar.buff_col_d5 > 0)
            {
                GlobalVar.cash_deposit -= 5;
                DepozitGlobalVar.col_d5++;
                DepozitGlobalVar.buff_col_d5--;
                Have_d5.Text = DepozitGlobalVar.col_d5.ToString();
                Deposit_set_d5.Text = DepozitGlobalVar.buff_col_d5.ToString();
                f_Deposit.Text = GlobalVar.cash_deposit.ToString() + "$";
            }
        }
        //10d
        private void D10_pl_Click(object sender, RoutedEventArgs e)
        {
            if (DepozitGlobalVar.col_d10 > 0)
            {
                GlobalVar.cash_deposit += 10;
                DepozitGlobalVar.col_d10--;
                DepozitGlobalVar.buff_col_d10++;
                Have_d10.Text = DepozitGlobalVar.col_d10.ToString();
                Deposit_set_d10.Text = DepozitGlobalVar.buff_col_d10.ToString();
                f_Deposit.Text = GlobalVar.cash_deposit.ToString() + "$";
            }
        }

        private void D10_ms_Click(object sender, RoutedEventArgs e)
        {
            if (DepozitGlobalVar.buff_col_d10 > 0)
            {
                GlobalVar.cash_deposit -=10;
                DepozitGlobalVar.col_d10++;
                DepozitGlobalVar.buff_col_d10--;
                Have_d10.Text = DepozitGlobalVar.col_d10.ToString();
                Deposit_set_d10.Text = DepozitGlobalVar.buff_col_d10.ToString();
                f_Deposit.Text = GlobalVar.cash_deposit.ToString() + "$";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DepozitGlobalVar.col_d1++;
            DepozitGlobalVar.col_d5++;
            DepozitGlobalVar.col_d10++;
            Have_d1.Text = DepozitGlobalVar.col_d1.ToString();
            Have_d5.Text = DepozitGlobalVar.col_d5.ToString();
            Have_d10.Text = DepozitGlobalVar.col_d10.ToString();
        }
    }
}
