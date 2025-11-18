using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyFinances.UserControls
{
    /// <summary>
    /// Логика взаимодействия для CloseButton.xaml
    /// </summary>
    public partial class CloseButton : UserControl
    {
        public CloseButton()
        {
            InitializeComponent();
        }

        private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
