namespace Praph2
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            trackBar3 = new TrackBar();
            label2 = new Label();
            label1 = new Label();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Canvas = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(trackBar3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(trackBar2);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(743, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.MinimumSize = new Size(171, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(171, 600);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Панелька";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 500);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 8;
            label3.Text = "Яркость";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(17, 524);
            trackBar3.Margin = new Padding(3, 4, 3, 4);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(142, 56);
            trackBar3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 419);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 6;
            label2.Text = "Насыщенность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 328);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 5;
            label1.Text = "Оттенок";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(17, 443);
            trackBar2.Margin = new Padding(3, 4, 3, 4);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(142, 56);
            trackBar2.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(17, 355);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(142, 56);
            trackBar1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(47, 268);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.TabIndex = 2;
            button3.Text = "Задание 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(47, 167);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 1;
            button2.Text = "Задание 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(47, 69);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 0;
            button1.Text = "Задание 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Canvas
            // 
            Canvas.BackColor = SystemColors.Window;
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(0, 0);
            Canvas.Margin = new Padding(3, 4, 3, 4);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(743, 600);
            Canvas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Canvas);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Графика. Лабораторная 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private TrackBar trackBar3;
        private Panel Canvas;
    }
}