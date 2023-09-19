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
            button4 = new Button();
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
            groupBox1.Controls.Add(button4);
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
            groupBox1.Location = new Point(1142, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.MinimumSize = new Size(171, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Панелька";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 327);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Яркость";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(14, 345);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(124, 45);
            trackBar3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 266);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 6;
            label2.Text = "Насыщенность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 198);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 5;
            label1.Text = "Оттенок";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(14, 284);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(124, 45);
            trackBar2.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(14, 218);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(124, 45);
            trackBar1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(41, 173);
            button3.Name = "button3";
            button3.Size = new Size(79, 22);
            button3.TabIndex = 2;
            button3.Text = "Задание 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 125);
            button2.Name = "button2";
            button2.Size = new Size(79, 22);
            button2.TabIndex = 1;
            button2.Text = "Задание 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(41, 52);
            button1.Name = "button1";
            button1.Size = new Size(79, 22);
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
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(1142, 600);
            Canvas.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(41, 396);
            button4.Name = "button4";
            button4.Size = new Size(79, 22);
            button4.TabIndex = 9;
            button4.Text = "Сохранить";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 600);
            Controls.Add(Canvas);
            Controls.Add(groupBox1);
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
        private Button button4;
    }
}