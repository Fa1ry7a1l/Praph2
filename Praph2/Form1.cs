namespace Praph2
{
    public partial class Form1 : Form
    {
        State curentState = State.Task0;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            curentState = State.Task3;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            curentState = State.Task2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            curentState = State.Task1;

        }
    }

    enum State
    {
        Task0, Task1, Task2, Task3
    }
}