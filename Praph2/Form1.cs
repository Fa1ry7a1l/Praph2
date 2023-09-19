using System.Diagnostics;

namespace Praph2
{
    using FastBitmap;

    public partial class Form1 : Form
    {
        State curentState = State.Task0;

        private Graphics graphics;

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
                //сохраняем
                ValueTuple<double, double, double>[,] HSVData = new ValueTuple<double, double, double>[fastBitmap.Width, fastBitmap.Height];

                for (int i = 0; i < fastBitmap.Width; i++)
                {
                    for (int j = 0; j < fastBitmap.Height; j++)
                    {
                        var red = fastBitmap[i, j].R / 265d;
                        var green = fastBitmap[i, j].G / 265d;
                        var blue = fastBitmap[i, j].B / 265d;
                        var max = Math.Max(red, Math.Max(green, blue));
                        var min = Math.Min(red, Math.Min(green, blue));
                        if (max == red)
                        {
                            if(green>=blue)
                            {
                                HSVData[i, j].Item1 = 60 *(green - blue)/(max-min);
                            }
                            else
                            {
                                HSVData[i, j].Item1 = 60 * (green - blue) / (max - min) + 360;
                            }
                        }
                        else if (max == green)
                        {
                            HSVData[i, j].Item1 = 60 * (green - blue) / (max - min) + 360;
                        }
                        else
                        {

                        }
                    }
        }
    }

    graphics.Clear(Color.White);

        }
    }

    enum State
{
    Task0, Task1, Task2, Task3
}
}