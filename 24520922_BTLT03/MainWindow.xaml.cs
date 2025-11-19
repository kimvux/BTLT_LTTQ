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

namespace _24520922_BTLT03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point pt1 = new Point(100, 100);
        Point pt2 = new Point(0, 0);
        double width = 100;
        double height = 100;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            PaintArea.Children.Clear();
        }

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pt1.X = double.Parse(x1.Text);
                pt1.Y = double.Parse(y1.Text);
                if (shape.Text == "Line")
                {
                    pt2.X = double.Parse(x2.Text);
                    pt2.Y = double.Parse(y2.Text);
                }
                else
                {
                    width = double.Parse(w.Text);
                    height = double.Parse(h.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the right format in the box :3");
                return;
            }
            if (shape.Text == "Line")
            {
                Line line = new Line
                {
                    X1 = pt1.X,
                    Y1 = pt1.Y,
                    X2 = pt2.X,
                    Y2 = pt2.Y,
                    Stroke = (SolidColorBrush)(new BrushConverter().ConvertFromString(color.Text) ?? "Black"),
                };
                PaintArea.Children.Add(line);
            }
            else if (shape.Text == "Rectangle")
            {
                Rectangle rectangle = new Rectangle
                {
                    Height = height,
                    Width = width,
                    Stroke = (SolidColorBrush)(new BrushConverter().ConvertFromString(color.Text) ?? "Black"),
                };
                Canvas.SetLeft(rectangle, pt1.X);
                Canvas.SetTop(rectangle, pt1.Y);
                if (fill.IsChecked == true)
                {
                    rectangle.Fill = (SolidColorBrush)(new BrushConverter().ConvertFromString(color.Text) ?? "");
                }
                PaintArea.Children.Add(rectangle);
            }
            else
            {
                Ellipse ellipse = new Ellipse
                {
                    Height = height,
                    Width = width,
                    Stroke = (SolidColorBrush)(new BrushConverter().ConvertFromString(color.Text) ?? "Black"),
                };
                Canvas.SetLeft(ellipse, pt1.X);
                Canvas.SetTop(ellipse, pt1.Y);
                if (fill.IsChecked == true)
                {
                    ellipse.Fill = (SolidColorBrush)(new BrushConverter().ConvertFromString(color.Text) ?? "");
                }
                PaintArea.Children.Add(ellipse);
            }
            
            
        }

        private void shape_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (x2 == null || y2 == null) return;

            if (shape.Text == "Line")
            {
                string fg = "#B3AFA8";
                x2.IsReadOnly = true;
                x2.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFromString(fg) ?? "Black");
                y2.IsReadOnly = true;
                y2.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFromString(fg) ?? "Black");
            }
            else
            {
                string fg = "Black";
                x2.IsReadOnly = false;
                x2.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFromString(fg) ?? "Black");
                y2.IsReadOnly = false;
                y2.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFromString(fg) ?? "Black");
            }
        }
    }
}