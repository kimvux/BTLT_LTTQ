namespace BT
{
    public partial class Form1 : Form
    {
        private Bitmap sprite;
        //  Back buffer
        private Bitmap backBuffer;
        private System.Windows.Forms.Timer timer;
        public Graphics graphics;
        // Số thự tự của frame (25 frame ảnh)
        private int index;
        //  dòng hiện tại của frame
        private int curFrameColumn;
        // cột hiện tại của frame
        private int curFrameRow;
        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            // Tạo back buffer
            backBuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            // Lấy ảnh sprite
            sprite = new Bitmap("C:\\Users\\mammu\\Desktop\\LTTQ\\BT\\1.png");
            index = 0;
            // Khởi tạo một đồng hồ
            timer = new System.Windows.Forms.Timer();
            timer.Enabled = true;
            timer.Interval = 60;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void Render()
        {
            // Lấy đối tượng graphics để vẽ lên back buffer
            Graphics g = Graphics.FromImage(backBuffer);
            g.Clear(Color.White);

            // Xác dịnh số dòng, cột của một frame trên ảnh sprite
            curFrameColumn = index % 5;
            curFrameRow = index / 5;

            // Vẽ lên buffer
            g.DrawImage(sprite, 200, 200,
                        new Rectangle(curFrameColumn * 96,curFrameRow * 100, 100, 100), GraphicsUnit.Pixel);
            g.Dispose();

            // Tăng thứ tự frame để lấy frame tiếp theo
            index++;
            if (index >= 25)
                index = 0;
            else
                index++;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Render();
            // Vẽ lên màn hình
            graphics.DrawImageUnscaled(backBuffer, 0, 0);
        }
    }
}
