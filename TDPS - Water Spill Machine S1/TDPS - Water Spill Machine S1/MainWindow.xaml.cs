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
        static public bool cash_change_is_have = false;
        static public bool max_tutor_windows_is_increased = false;
        static public int bottle_col = 5;
        //public event Action<String> MyPersonalizedUCEvent;
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            MessCloudGroup.Visibility = Visibility.Hidden;
            H_textB.Text = "Депозит: ";
            B_textB.Text = "Цена: ";
            Deposit.Text = GlobalVar.cash_deposit.ToString() + "$";
            Cost.Text = GlobalVar.goods_cost.ToString() + "$";
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
            Close_form close_Form = new Close_form();
            close_Form.Owner = this;
            close_Form.Show();
        }
        private void Coin_Acceptor_Click(object sender, RoutedEventArgs e)
        {
            if (GlobalVar.cash_change == 0)
            {
                Window_coin_acceptor _Coin_Acceptor = new Window_coin_acceptor();
                _Coin_Acceptor.Owner = this;
                _Coin_Acceptor.Show();
            }
            else if (GlobalVar.cash_change != 0)
            {
                H_textB.Text = "Заберите сдачу!";
                B_textB.Text = "Сначала!";
                Cost.Text = "";
                Сhange.Text = "";
                Deposit.Text = "";
                GlobalVar.cash_change_is_have = true;
                MessCloidAnimation();
            }
        }
        private void Coin_Extradition_Click(object sender, RoutedEventArgs e)
        {
            GlobalVar.cash_change = 0;
            MessWindow messWindow = new MessWindow();
            messWindow.Owner = this;
            messWindow.Show();
            DepozitGlobalVar.col_d1 += DepozitGlobalVar.buff_col_d1;
            DepozitGlobalVar.col_d5 += DepozitGlobalVar.buff_col_d5;
            DepozitGlobalVar.col_d10 += DepozitGlobalVar.buff_col_d10;
            DepozitGlobalVar.buff_col_d1 = 0;
            DepozitGlobalVar.buff_col_d5 = 0;
            DepozitGlobalVar.buff_col_d10 = 0;
        }
        private void Label_Vim_Click(object sender, RoutedEventArgs e)
        {
            Tutorial_label tutorial_Label = new Tutorial_label();
            tutorial_Label.Owner = this;
            tutorial_Label.Show();
        }
        private void ButtonGoWater_Click(object sender, RoutedEventArgs e)
        {
            int buff_1, buff_2;
            if (GlobalVar.cash_change == 0) {
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
                    H_textB.Text = "Успешно: ";
                    B_textB.Text = "Сдача: ";
                    Deposit.Text = "";
                    Cost.Text = "";
                    GlobalVar.bottle_col--;
                    Delete_bottle();
                }
                else
                {
                    H_textB.Text = "Депозит: ";
                    B_textB.Text = "Цена: ";
                    Cost.Text = GlobalVar.goods_cost.ToString() + "$";
                    Сhange.Text = "";
                    Deposit.Text = GlobalVar.cash_deposit.ToString() + "$";
                }
            }
            else if (GlobalVar.cash_change != 0)
            {
                H_textB.Text = "Заберите сдачу!";
                B_textB.Text = "Сначала!";
                Cost.Text = "";
                Сhange.Text = "";
                Deposit.Text = "";
                GlobalVar.cash_change_is_have = true;
            }
            MessCloudGroup.Visibility = Visibility.Visible;
            MessCloidAnimation();
        }
        private void Coin_Acceptor_Drop(object sender, DragEventArgs e)
        {
            MessageBox.Show("AAA!");
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        async private void MessCloidAnimation()
        {
            MessCloudGroup.Visibility = Visibility.Visible;
            if (GlobalVar.hidden_mess_status == false)
            {
                GlobalVar.hidden_mess_status = true;
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
                GlobalVar.hidden_mess_status = false;
            }
        }
        public void Delete_bottle()
        {
            switch (GlobalVar.bottle_col)
            {
                case 4:
                    Bottle_1.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    Bottle_2.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    Bottle_3.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    Bottle_4.Visibility = Visibility.Hidden;
                    break;
                case 0:
                    Bottle_5.Visibility = Visibility.Hidden;
                    break;
                case 1488:
                    Bottle_1.Visibility = Visibility.Visible;
                    Bottle_2.Visibility = Visibility.Visible;
                    Bottle_3.Visibility = Visibility.Visible;
                    Bottle_4.Visibility = Visibility.Visible;
                    Bottle_5.Visibility = Visibility.Visible;
                    GlobalVar.bottle_col = 5;
                    break;
                default:
                    //MessageBox.Show("NO BOTTLE");
                    NoBottleWindow noBottleWindow = new NoBottleWindow();
                    noBottleWindow.Owner = this;
                    noBottleWindow.ShowDialog();
                    break;
            }
        }
    }
}
