using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24520922_BTLT07
{
    public partial class Image : Form
    {
        public Image(string filename)
        {
            InitializeComponent();
            Graphics graphics = this.CreateGraphics();
            System.Drawing.Image image = System.Drawing.Image.FromFile(filename);
            pictureBox1.Image = image;
        }
    }
}
