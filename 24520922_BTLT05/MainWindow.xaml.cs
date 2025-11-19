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

namespace _24520922_BTLT05
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int remain = 1;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
        }
        
        private void selections_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var x = sender as ComboBox;
            if (x.SelectedItem is ComboBoxItem item)
            {
                if (item.Content.ToString() == "None") return;
                Matrix matrix = new Matrix();
                if (item.Content.ToString() == "Rotate")
                {
                    matrix.Rotate(45);
                    MatrixTransform matrixTransform = new MatrixTransform(matrix);
                    rect.RenderTransform = matrixTransform;
                }
                else if (item.Content.ToString() == "Flip")
                {
                    matrix.Scale(-1,1);
                    matrix.Translate(rect.Width, 0);
                    MatrixTransform matrixTransform = new MatrixTransform(matrix);
                    rect.RenderTransform = matrixTransform;
                }
                else if (item.Content.ToString() == "Scale")
                {
                    matrix.Scale(10, 2);
                    MatrixTransform matrixTransform = new MatrixTransform(matrix);
                    rect.RenderTransform = matrixTransform;
                }
                else
                {
                    matrix.Translate(-100, -100);
                    MatrixTransform matrixTransform = new MatrixTransform(matrix);
                    rect.RenderTransform = matrixTransform;
                }
            }
            
            timer.Start();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            if (remain > 0)
            {
                remain--;
            }
            else
            {
                rect.RenderTransform = Transform.Identity;
                timer.Stop();
                remain = 1;
            }
        }

    }
}