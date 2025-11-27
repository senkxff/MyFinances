using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyFinances.UserControls
{
    /// <summary>
    /// Логика взаимодействия для CollapseButton.xaml
    /// </summary>
    public partial class CollapseButton : UserControl
    {
        public CollapseButton()
        {
            InitializeComponent();
        }

        private void CollapseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.WindowState = WindowState.Minimized;
        }
    }
}
