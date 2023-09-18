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
            panel1 = new Panel();
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
            groupBox1.Location = new Point(650, 0);
            groupBox1.MinimumSize = new Size(150, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Панелька";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 375);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Яркость";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(20, 393);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(124, 45);
            trackBar3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 314);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 6;
            label2.Text = "Насыщенность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 246);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 5;
            label1.Text = "Оттенок";
            label1.Click += label1_Click;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(20, 332);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(124, 45);
            trackBar2.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(20, 266);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(124, 45);
            trackBar1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(36, 221);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Задание 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 153);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Задание 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(36, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Задание 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 450);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
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
        private Panel panel1;
    }
}