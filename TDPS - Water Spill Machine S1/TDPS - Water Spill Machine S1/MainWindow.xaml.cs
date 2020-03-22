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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace TDPS___Water_Spill_Machine_S1
{
    static public class GlobalVar
    {
        static public bool button_animation_switch_stat = true;
        static public int cash_deposit = 0;
        static public int cash_change = 0;
        static public int goods_cost = 10;
        static public bool hidden_mess_status = false;
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            // Animation Section
            #region 

            transform.BeginAnimation(RotateTransform.AngleProperty,
        new DoubleAnimation
        {
            From = 0,
            To = 16000,
            Duration = TimeSpan.FromSeconds(360)
        });
            transform2.BeginAnimation(RotateTransform.AngleProperty,
        new DoubleAnimation
        {
            From = 80,
            To = 16080,
            Duration = TimeSpan.FromSeconds(360)
        });
            #endregion
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 4);
            timer.Start();
        }

        private void GetWater(object sender, RoutedEventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (GlobalVar.button_animation_switch_stat == false)
            {
                Storyboard_1.Begin();
                GlobalVar.button_animation_switch_stat = true;
            }
            else
            {
                Storyboard_2.Begin();
                GlobalVar.button_animation_switch_stat = false;
            }
        }

        private void ButtonDoubleClickClose(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Coin_Acceptor_Click(object sender, RoutedEventArgs e)
        {
            Window_coin_acceptor _Coin_Acceptor = new Window_coin_acceptor();
            _Coin_Acceptor.Owner = this;
            _Coin_Acceptor.Show();
        }

        private void Coin_Extradition_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("AAA!");
        }

        private void Label_Vim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("AAA!");
        }

         async private void ButtonGoWater_Click(object sender, RoutedEventArgs e)
        {
            int buff_1, buff_2;
            if (GlobalVar.cash_deposit >= GlobalVar.goods_cost)
            {
                GlobalVar.cash_deposit -= GlobalVar.goods_cost;
                GlobalVar.cash_change = GlobalVar.cash_deposit;
                Сhange.Text = GlobalVar.cash_change.ToString() + '$';
                buff_1 = GlobalVar.cash_change % 10;
                DepozitGlobalVar.buff_col_d10 = (GlobalVar.cash_change - buff_1) / 10;
                buff_2 = buff_1 % 5;
                DepozitGlobalVar.buff_col_d5 = (buff_1 - buff_2) / 5;
                DepozitGlobalVar.buff_col_d1 = buff_2;
                MessageBox.Show(buff_1.ToString());
                MessageBox.Show(buff_2.ToString());
                MessageBox.Show(DepozitGlobalVar.buff_col_d1.ToString());
                MessageBox.Show(DepozitGlobalVar.buff_col_d5.ToString());
                MessageBox.Show(DepozitGlobalVar.buff_col_d10.ToString());
            }
            MessCloudGroup.Visibility = Visibility.Visible;
            if (GlobalVar.hidden_mess_status == false)
            {
                MessCloudGroup.BeginAnimation(OpacityProperty,
                new DoubleAnimation
                {
                    From = 0.0,
                    To = 1.0,
                    Duration = TimeSpan.FromSeconds(3)
                });
                  await Task.Delay(4000);
                MessCloudGroup.BeginAnimation(OpacityProperty,
                new DoubleAnimation
                {
                    From = 1.0,
                    To = 0.0,
                    Duration = TimeSpan.FromSeconds(3)
                });

                //  MessCloudGroup.Visibility = Visibility.Visible;
               // GlobalVar.hidden_mess_status = true;
            }
        }
        private void Coin_Acceptor_Drop(object sender, DragEventArgs e)
        {
            MessageBox.Show("AAA!");
        }
    }
}
