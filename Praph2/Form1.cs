using System.Diagnostics;

namespace Praph2
{
    using FastBitmap;

    public partial class Form1 : Form
    {
        State curentState = State.Task0;
        private int BitmapHeight;
        private int BitmapWidth;
        int S, H, V;

        private Graphics graphics;

        ValueTuple<double, double, double>[,] HSVData;

        public Form1()
        {
            InitializeComponent();
            graphics = Canvas.CreateGraphics();
        }

        //Преобразовать изображение из RGB в оттенки серого. Реализовать два варианта формулы с учетом разных вкладов R, G и B в интенсивность (см презентацию).
        //Затем найти разность полученных полутоновых изображений. Построить гистограммы интенсивности после одного и второго преобразования.
        private void button1_Click(object sender, EventArgs e)
        {
            curentState = State.Task1;
        }

        //Выделить из полноцветного изображения каждый из каналов R, G, B  и вывести результат. Построить гистограмму по цветам (3 штуки).
        private void button2_Click(object sender, EventArgs e)
        {
            curentState = State.Task2;

            graphics.Clear(Color.White);

            float mult = 2.5f;
            int div = 8;

            Bitmap bitmap_og = new Bitmap("../../../../images/ФРУКТЫ.jpg");
            Bitmap bitmap = new Bitmap(bitmap_og, new Size((int)(bitmap_og.Width / mult), (int)(bitmap_og.Height / mult)));
            Bitmap bitmap_r = new Bitmap(bitmap);
            Bitmap bitmap_g = new Bitmap(bitmap);
            Bitmap bitmap_b = new Bitmap(bitmap);

            int width = bitmap.Width;
            int height = bitmap.Height;
            int start = width;

            graphics.DrawImage(bitmap, start + 20, 20);

            Debug.WriteLine(bitmap.Width * bitmap.Height);

            //ValueTuple<short, short, short>[] arr = new ValueTuple<short, short, short>[width * height];
            int[] arr_r = new int[256];
            int[] arr_g = new int[256];
            int[] arr_b = new int[256];
            int j = 0;

            using (var fastBitmap_r = new FastBitmap(bitmap_r))
            using (var fastBitmap_g = new FastBitmap(bitmap_g))
            using (var fastBitmap_b = new FastBitmap(bitmap_b))
            {
                for (var x = 0; x < fastBitmap_r.Width; x++)
                    for (var y = 0; y < fastBitmap_r.Height; y++)
                    {
                        var color = fastBitmap_r[x, y];
                        arr_r[color.R]++;
                        arr_g[color.G]++;
                        arr_b[color.B]++;
                        j++;
                        fastBitmap_r[x, y] = Color.FromArgb(color.R, 0, 0);
                        fastBitmap_g[x, y] = Color.FromArgb(0, color.G, 0);
                        fastBitmap_b[x, y] = Color.FromArgb(0, 0, color.B);
                    }
            }

            for (int i = 0; i < 256; i++)
            {
                arr_r[i] /= div;
                arr_g[i] /= div;
                arr_b[i] /= div;
            }

            graphics.DrawImage(bitmap_r, start + 20, 40 + height);
            graphics.DrawImage(bitmap_g, start + 40 + width, 20);
            graphics.DrawImage(bitmap_b, start + 40 + width, 40 + height);

            float boldness = 1.4f;
            Pen pen_r = new Pen(Color.Red, boldness);
            Pen pen_g = new Pen(Color.Green, boldness);
            Pen pen_b = new Pen(Color.Blue, boldness);

            int shift_vert = 20;
            int shift_hor = 4;
            int shift_left = 20;

            for (int i = 2; i < 256; i++)
            {
                graphics.DrawLine(pen_r, new Point(shift_left + (i - 1) * shift_hor, Canvas.Height - arr_r[i - 1] - shift_vert), new Point(shift_left + i * shift_hor, Canvas.Height - arr_r[i] - shift_vert));
                graphics.DrawLine(pen_g, new Point(shift_left + (i - 1) * shift_hor, Canvas.Height - arr_g[i - 1] - shift_vert), new Point(shift_left + i * shift_hor, Canvas.Height - arr_g[i] - shift_vert));
                graphics.DrawLine(pen_b, new Point(shift_left + (i - 1) * shift_hor, Canvas.Height - arr_b[i - 1] - shift_vert), new Point(shift_left + i * shift_hor, Canvas.Height - arr_b[i] - shift_vert));
            }
        }

        //Преобразовать изображение из RGB в HSV. Добавить возможность изменять значения оттенка, насыщенности и яркости.
        //Результат сохранять в файл, предварительно преобразовав обратно.
        private void button3_Click(object sender, EventArgs e)
        {
            curentState = State.Task3;

            Bitmap bitmap = new Bitmap("../../../../images/ФРУКТЫ.jpg");



            using (var fastBitmap = new FastBitmap(bitmap))
            {
                //сохраняем H S V
                HSVData = new ValueTuple<double, double, double>[fastBitmap.Width, fastBitmap.Height];
                BitmapHeight = fastBitmap.Height;
                BitmapWidth = fastBitmap.Width;

                for (int i = 0; i < fastBitmap.Width; i++)
                {
                    for (int j = 0; j < fastBitmap.Height; j++)
                    {
                        var red = fastBitmap[i, j].R / 265d;
                        var green = fastBitmap[i, j].G / 265d;
                        var blue = fastBitmap[i, j].B / 265d;
                        var max = Math.Max(red, Math.Max(green, blue));
                        var min = Math.Min(red, Math.Min(green, blue));
                        if (max == min)
                        {
                            HSVData[i, j].Item1 = 0;
                        }
                        else if (max == red)
                        {
                            if (green >= blue)
                            {
                                HSVData[i, j].Item1 = 60 * (green - blue) / (max - min);
                            }
                            else
                            {
                                HSVData[i, j].Item1 = 60 * (green - blue) / (max - min) + 360;
                            }
                        }
                        else if (max == green)
                        {
                            HSVData[i, j].Item1 = 60 * (blue - red) / (max - min) + 120;
                        }
                        else
                        {
                            HSVData[i, j].Item1 = 60 * (red - green) / (max - min) + 240;

                        }

                        if (max < double.Epsilon)
                        {
                            HSVData[i, j].Item2 = 0;
                        }
                        else
                        {
                            HSVData[i, j].Item2 = 1 - min / max;
                        }
                        HSVData[i, j].Item3 = max;
                    }
                }
            }

            graphics.Clear(Color.White);
            graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

            trackBar1.Minimum = 0;
            trackBar1.Maximum = 359;
            H = 180;
            S = 100;
            V = 100;

            trackBar1.Value = 180;

            trackBar2.Maximum = 200;
            trackBar2.Minimum = 0;
            trackBar2.Value = 100;

            trackBar3.Maximum = 200;
            trackBar3.Minimum = 0;
            trackBar3.Value = 100;
        }

        private Bitmap GetBitmap()
        {
            Bitmap bitmap = new Bitmap(BitmapWidth, BitmapHeight);
            using (var fastBitmap = new FastBitmap(bitmap))
            {

                for (int i = 0; i < fastBitmap.Width; i++)
                {
                    for (int j = 0; j < fastBitmap.Height; j++)
                    {
                        var Hi = (int)Math.Floor(HSVData[i, j].Item1 / 60) % 6;
                        var f = HSVData[i, j].Item1 / 60 - Math.Floor(HSVData[i, j].Item1 / 60);
                        var p = HSVData[i, j].Item3 * (1 - HSVData[i, j].Item2);
                        var q = HSVData[i, j].Item3 * (1 - f * HSVData[i, j].Item2);
                        var t = HSVData[i, j].Item3 * (1 - (1 - f) * HSVData[i, j].Item2);
                        switch (Hi)
                        {
                            case 0:
                                fastBitmap[i, j] = Color.FromArgb((int)(HSVData[i, j].Item3 * 255), (int)(t * 255), (int)(p * 255));
                                break;
                            case 1:
                                fastBitmap[i, j] = Color.FromArgb((int)(q * 255), (int)(HSVData[i, j].Item3 * 255), (int)(p * 255));
                                break;
                            case 2:
                                fastBitmap[i, j] = Color.FromArgb((int)(p * 255), (int)(HSVData[i, j].Item3 * 255), (int)(t * 255));
                                break;
                            case 3:
                                fastBitmap[i, j] = Color.FromArgb((int)(p * 255), (int)(q * 255), (int)(HSVData[i, j].Item3 * 255));
                                break;
                            case 4:
                                fastBitmap[i, j] = Color.FromArgb((int)(t * 255), (int)(p * 255), (int)(HSVData[i, j].Item3 * 255));
                                break;
                            case 5:
                                fastBitmap[i, j] = Color.FromArgb((int)(HSVData[i, j].Item3 * 255), (int)(p * 255), (int)(q * 255));
                                break;
                        }


                    }
                }


            }
            return bitmap;
        }


        //сохранение задания 3 по формулам из презы
        private void button4_Click(object sender, EventArgs e)
        {
            if (curentState == State.Task3)
            {
                Bitmap bitmap = GetBitmap();
                bitmap.Save("../../../../images/результат.jpg");
                curentState = State.Task0;
                graphics.Clear(Color.White);
                Process.Start("explorer.exe", @"..\..\..\..\images\");
            }
        }

        //яркость
        private void trackBar3_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (curentState == State.Task3)
            {
                double delta = (trackBar3.Value - V) / 200d;
                for (int i = 0; i < BitmapWidth; i++)
                {
                    for (int j = 0; j < BitmapHeight; j++)
                    {
                        HSVData[i, j].Item3 = Math.Min(1, Math.Max(HSVData[i, j].Item3 + delta, 0));
                    }
                }
                V = trackBar3.Value;
                Bitmap bitmap = GetBitmap();
                graphics.Clear(Color.White);
                graphics.DrawImage(bitmap, 0, 0);  
            }
        }

        //насыщенность
        private void trackBar2_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (curentState == State.Task3)
            {
                double delta = (trackBar2.Value - S) / 200d;
                for (int i = 0; i < BitmapWidth; i++)
                {
                    for (int j = 0; j < BitmapHeight; j++)
                    {
                        HSVData[i, j].Item2 = Math.Min(1, Math.Max(HSVData[i, j].Item2 + delta, 0));
                    }
                }
                S = trackBar2.Value;

                Bitmap bitmap = GetBitmap();
                graphics.Clear(Color.White);
                graphics.DrawImage(bitmap, 0, 0);
            }

            }

        //цветовой тон
        private void trackBar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (curentState == State.Task3)
            {
                double delta = trackBar1.Value - H ;
                for (int i = 0; i < BitmapWidth; i++)
                {
                    for (int j = 0; j < BitmapHeight; j++)
                    {
                        HSVData[i, j].Item1 = Math.Min(359, Math.Max(trackBar1.Value, 0));
                    }
                }
                H = trackBar1.Value;

                Bitmap bitmap = GetBitmap();
                graphics.Clear(Color.White);
                graphics.DrawImage(bitmap, 0, 0);
            }
        }
    }

    enum State
    {
        Task0, Task1, Task2, Task3
    }
}