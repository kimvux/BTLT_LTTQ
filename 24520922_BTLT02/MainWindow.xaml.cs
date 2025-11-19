using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace btvn2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer returnTimer;

        public MainWindow()
        {
            InitializeComponent();
            Area.Focus();
            this.KeyDown += Dot_movement;
            this.MouseDown += Dot_mouse;

            returnTimer = new DispatcherTimer();
            returnTimer.Interval = TimeSpan.FromSeconds(5);
            returnTimer.Tick += ReturnTimer_Tick;
            returnTimer.Start();
        }
        private void Dot_movement(object sender, KeyEventArgs x)
        {
            double left = Canvas.GetLeft(Dot);
            double top = Canvas.GetTop(Dot);
            switch (x.Key)
            {
                case Key.W:
                    Canvas.SetTop(Dot, top - 25);
                    break;
                case Key.S:
                    Canvas.SetTop(Dot, top + 25);
                    break;
                case Key.A:
                    Canvas.SetLeft(Dot, left - 25);
                    break;
                case Key.D:
                    Canvas.SetLeft(Dot, left + 25);
                    break;
            }
        }
        private void Dot_mouse(object sender, MouseButtonEventArgs x)
        {
            if (x.LeftButton == MouseButtonState.Pressed)
            {
                Point cr = x.GetPosition(Area);
                Canvas.SetLeft(Dot, cr.X - Dot.Width / 2);
                Canvas.SetTop(Dot, cr.Y - Dot.Height / 2);
            }
        }
        private void ReturnTimer_Tick(object sender, EventArgs e)
        {
            Canvas.SetLeft(Dot, 255);
            Canvas.SetTop(Dot, 215);
        }
    }
}