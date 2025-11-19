using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatGPT_Playground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ModeButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var child in ModePanel.Children)
            {
                if (child is ToggleButton btn && btn != sender)
                    btn.IsChecked = false;
            }
        }
        private void AttachButton_Click(object sender, RoutedEventArgs e)
        {
            AttachPopup.IsOpen = !AttachPopup.IsOpen;
        }
    }
}