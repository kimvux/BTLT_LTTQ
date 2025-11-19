using System.Runtime.InteropServices;

namespace BTLT06
{
    public partial class Form1 : Form
    {
        bool isBold = false;
        bool isUnderline = false;
        bool isItalic = false;
        Font crfont = new Font("Arial", 14);
        string ttext = "hehehihihuhu :3";
        Brush crbrush = Brushes.Black;
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families)
            {
                this.font.Items.Add(font.Name);
            }
        }
        private void font_TextChanged(object sender, EventArgs e)
        {
            try
            {
                crfont = new Font(font.Text, float.Parse(size.Text));
                crbrush = new SolidBrush(Color.FromName(color.Text));
            }
            catch (FormatException)
            {
                size.Text = "14";
            }
            catch (ArgumentException)
            {
                size.Text = "14";
            }
            checkBox1_CheckedChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isBold == false)
            {
                crfont = new Font(crfont, crfont.Style | FontStyle.Bold);
                isBold = true;
            }
            else
            {
                crfont = new Font(crfont, crfont.Style & ~FontStyle.Bold);
                isBold = false;
            }
            checkBox1_CheckedChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isItalic == false)
            {
                crfont = new Font(crfont, crfont.Style | FontStyle.Italic);
                isItalic = true;
            }
            else
            {
                crfont = new Font(crfont, crfont.Style & ~FontStyle.Italic);
                isItalic = false;
            }
            checkBox1_CheckedChanged(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isUnderline == false)
            {
                crfont = new Font(crfont, crfont.Style | FontStyle.Underline);
                isUnderline = true;
            }
            else
            {
                crfont = new Font(crfont, crfont.Style & ~FontStyle.Underline);
                isUnderline = false;
            }
            checkBox1_CheckedChanged(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);
            if (float.Parse(size.Text) >= 14)
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            }
            else if (float.Parse(size.Text) >= 8)
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            }
            else
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            }


            try
            {
                g.DrawString(ttext, crfont, crbrush, new PointF(100, 150));
            }
            catch (ExternalException)
            {
                size.Text = "14";
                g.DrawString(ttext, crfont, crbrush, new PointF(100, 150));
            }


            if (checkBox1.CheckState == CheckState.Checked)
            {
                Graphics graphics = this.CreateGraphics();
                SizeF sizeF = graphics.MeasureString(ttext, crfont);
                graphics.DrawRectangle(new Pen(Color.Blue, 3), 100, 150, sizeF.Width, sizeF.Height);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Trimming = StringTrimming.EllipsisCharacter;
            Rectangle rectangle = new Rectangle(100, 150, 70, 23);
            g.DrawString(ttext, new Font("Arial",14), Brushes.Black, rectangle, stringFormat);
            g.DrawRectangle(Pens.Black, rectangle);
        }
    }
}
