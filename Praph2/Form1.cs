
namespace Praph2
{
    using FastBitmap;

    public partial class Form1 : Form
    {
        State curentState = State.Task0;
        private int H;
        private int W;

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

            Bitmap bitmap = new Bitmap("../../../../images/ФРУКТЫ.jpg");
            graphics.DrawImage(bitmap, 0, 0);
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
                H = fastBitmap.Height;
                W = fastBitmap.Width;

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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (curentState == State.Task3)
            {
                Bitmap bitmap = new Bitmap(W, H);
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
                                    fastBitmap[i, j] = Color.FromArgb((int)(HSVData[i, j].Item3 * 256), (int)(t * 256), (int)(p * 256));
                                    break;
                                case 1:
                                    fastBitmap[i, j] = Color.FromArgb((int)(q * 256), (int)(HSVData[i, j].Item3 * 256), (int)(p * 256));
                                    break;
                                case 2:
                                    fastBitmap[i, j] = Color.FromArgb((int)(p * 256), (int)(HSVData[i, j].Item3 * 256), (int)(t * 256));
                                    break;
                                case 3:
                                    fastBitmap[i, j] = Color.FromArgb((int)(p * 256), (int)(q * 256), (int)(HSVData[i, j].Item3 * 256));
                                    break;
                                case 4:
                                    fastBitmap[i, j] = Color.FromArgb((int)(t * 256), (int)(p * 256), (int)(HSVData[i, j].Item3 * 256));
                                    break;
                                case 5:
                                    fastBitmap[i, j] = Color.FromArgb((int)(HSVData[i, j].Item3 * 256), (int)(p * 256), (int)(q * 256));
                                    break;
                            }


                        }
                    }


                }
                bitmap.Save("../../../../images/результат.jpg");

            }
        }
    }

    enum State
    {
        Task0, Task1, Task2, Task3
    }
}