namespace BTLT06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            font = new ComboBox();
            size = new ComboBox();
            color = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // font
            // 
            font.FormattingEnabled = true;
            font.Location = new Point(34, 19);
            font.Name = "font";
            font.Size = new Size(121, 23);
            font.TabIndex = 0;
            font.Text = "Arial";
            font.TextChanged += font_TextChanged;
            // 
            // size
            // 
            size.FormattingEnabled = true;
            size.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            size.Location = new Point(181, 19);
            size.Name = "size";
            size.Size = new Size(121, 23);
            size.TabIndex = 1;
            size.Text = "14";
            size.TextChanged += font_TextChanged;
            // 
            // color
            // 
            color.FormattingEnabled = true;
            color.Items.AddRange(new object[] { "Black", "White", "Blue", "Green", "Red", "Orange", "Pink", "Yellow", "Purple", "Brown", "Gray" });
            color.Location = new Point(318, 19);
            color.Name = "color";
            color.Size = new Size(121, 23);
            color.TabIndex = 2;
            color.Text = "Black";
            color.TextChanged += font_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(474, 19);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "B";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Italic);
            button2.Location = new Point(564, 19);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "I";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            button3.Location = new Point(654, 19);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "U";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(34, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Thêm viền";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button4
            // 
            button4.Location = new Point(34, 403);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Trimming";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(color);
            Controls.Add(size);
            Controls.Add(font);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox font;
        private ComboBox size;
        private ComboBox color;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private Button button4;
    }
}
