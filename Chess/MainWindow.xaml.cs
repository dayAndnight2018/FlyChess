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

namespace Chess
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, string> list = new Dictionary<int, string>();
        Random r = new Random();
        Label older = null;
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            list.Add(3, "五万触手币");
            list.Add(4, "画脸");
            list.Add(6, "海马一匹");
            list.Add(7, "终极大奖");
            list.Add(9, "泡泡520");
            list.Add(10, "房管一枚");
            list.Add(12, "真心话");
            list.Add(13, "1万触手币");
            list.Add(16, "后退4步");
            list.Add(17, "前进1步");
            list.Add(18, "海马两匹");
            list.Add(20, "查房一次");
            list.Add(22, "表演蛙跳10个");
            list.Add(25, "谢谢大哥支持");
            list.Add(27, "再来一次");
            list.Add(28, "5个海星支持");
            list.Add(30, "5千触手币");
            list.Add(32, "一段骚舞安排");
            list.Add(34, "炸气球1个");
            list.Add(35, "大冒险");
            list.Add(37, "一瓶矿泉水");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (older != null)
            {
                older.Opacity = 1;
            }

            int number = r.Next(1, 7);
            step.Content = number.ToString();
            int current = Convert.ToInt32(flag.Tag);
            int after = number + current;
            if (after > 38)
            {
                Grid.SetColumn(flag, 1);
                Grid.SetRow(flag, 1);
                flag.Tag = 0;
                return;
            }
            Label label = ((Label)this.FindName("L" + after));
            label.Opacity = 0.6;
            older = label;
            int col = Grid.GetColumn(label);
            int row = Grid.GetRow(label);
            Grid.SetColumn(flag, col);
            Grid.SetRow(flag, row);
            flag.Tag = after;
            if (list.Keys.Contains(after))
            {
                tip.Content = list[after];
            }
            else
            {
                tip.Content = null;
            }
        }
    }
}
