using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyFinances.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ExpandButton.xaml
    /// </summary>
    public partial class ExpandButton : UserControl
    {
        private bool isExpanded = false;

        private double originalWidth, originalHeight, originalLeft, originalTop;

        public ExpandButton()
        {
            InitializeComponent();
        }

        // Расчет параметров окна в развернутой форме с учетом панели задач
        private void ExpandButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window = Window.GetWindow(this);
            var workArea = SystemParameters.WorkArea;

            if (!isExpanded)
            {
                originalLeft = window.Left;
                originalTop = window.Top;
                originalWidth = window.Width;
                originalHeight = window.Height;

                window.Left = workArea.Left;
                window.Top = workArea.Top;
                window.Width = workArea.Width;
                window.Height = workArea.Height;

                isExpanded = true;
            }
            else
            {
                window.Left = originalLeft;
                window.Top = originalTop;
                window.Width = originalWidth;
                window.Height = originalHeight;

               isExpanded = false;
            }
        }
    }
}
