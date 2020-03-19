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
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Animation Section
            #region 
            this.InitializeComponent();

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonDoubleClickClose(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Coin_Acceptor_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("AAA!");
        }
    }
}
