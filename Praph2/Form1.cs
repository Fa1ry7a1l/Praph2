using FastBitmap;

namespace Praph2
{
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

            Bitmap bitmap =  new Bitmap("../../../../images/ФРУКТЫ.jpg");
            graphics.DrawImage(bitmap, 0, 0);
        }

        //Преобразовать изображение из RGB в HSV. Добавить возможность изменять значения оттенка, насыщенности и яркости.
        //Результат сохранять в файл, предварительно преобразовав обратно.
        private void button3_Click(object sender, EventArgs e)
        {
            curentState = State.Task3;

            graphics.Clear(Color.White);

        }
    }

    enum State
    {
        Task0, Task1, Task2, Task3
    }
}