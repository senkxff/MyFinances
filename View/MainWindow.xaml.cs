using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace MyFinances.View
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

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void LeftRowButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();

            doubleAnimation.From = 250;
            doubleAnimation.To = 70;
            doubleAnimation.Duration = TimeSpan.FromSeconds(0.3);
            LeftPannel.BeginAnimation(ButtonBase.WidthProperty, doubleAnimation);

            LeftRowButton.Visibility = Visibility.Hidden; 
            RightRowButton.Visibility = Visibility.Visible;
        }

        private void RightRowButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();

            doubleAnimation.From = 70;
            doubleAnimation.To = 250;
            doubleAnimation.Duration = TimeSpan.FromSeconds(0.3);
            LeftPannel.BeginAnimation(ButtonBase.WidthProperty, doubleAnimation);

            RightRowButton.Visibility = Visibility.Hidden;
            LeftRowButton.Visibility = Visibility.Visible;
        }
    }
}
