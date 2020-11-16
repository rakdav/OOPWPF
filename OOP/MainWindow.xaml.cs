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

namespace OOP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Button button1 = new Button();
            button1.Content = "Нажми меня";
            button1.Width = 100;
            button1.Height = 50;
            button1.Margin = new Thickness(10);
            button1.Click += Button_Click;

            Button button2 = new Button();
            button2.Content = "А лучше меня";
            button2.Width = 100;
            button2.Height = 50;
            button2.Margin = new Thickness(10);
            button2.Click += Button_Click;

            Button button3 = new Button();
            button3.Content = "А лучше меня";
            button3.Width = 100;
            button3.Height = 50;
            button3.Margin = new Thickness(10);
            button3.Click += Button_Click;

            Button button4 = new Button();
            button4.Content = "А лучше меня";
            button4.Width = 100;
            button4.Height = 50;
            button4.Margin = new Thickness(10);
            button4.Click += Button_Click;

            Button button5 = new Button();
            button5.Content = "А лучше меня";
            button5.Width = 100;
            button5.Height = 50;
            button5.Margin = new Thickness(10);
            button5.Click += Button_Click;

            Button button6 = new Button();
            button6.Content = "А лучше меня";
            button6.Width = 100;
            button6.Height = 50;
            button6.Margin = new Thickness(10);
            button6.Click += Button_Click;

            Button button7 = new Button();
            button7.Content = "А лучше меня";
            button7.Width = 100;
            button7.Height = 50;
            button7.Margin = new Thickness(10);
            button7.Click += Button_Click;

            StackPanel panel = new StackPanel();
            panel.Orientation = Orientation.Horizontal;
            panel.Height = 100;
            panel.HorizontalAlignment = HorizontalAlignment.Left;
            panel.VerticalAlignment = VerticalAlignment.Top;
            panel.Background = Brushes.Chocolate;
            panel.Children.Add(button1);
            panel.Children.Add(button2);
            panel.Children.Add(button3);
            panel.Children.Add(button4);
            panel.Children.Add(button5);
            panel.Children.Add(button6);
            panel.Children.Add(button7);
            this.Width = (button1.Width+20)*7+20;
            parent.Children.Add(panel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < parent.Children.Count; i++)
            {
                StackPanel panel = parent.Children[i] as StackPanel;
                for (int j = 0; j < panel.Children.Count; j++)
                {
                    if (panel.Children[j] is Button) (panel.Children[j] as Button).Content = "Ты меня нажал";
                    if (j == 1) panel.Children.RemoveAt(1);
                }
            }
        }
    }
}
