
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