namespace ThirdProject
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int height = this.Height;
            int width = this.Width;

            int new_height = random.Next(0, height - button1.Height - 39);
            int new_width = random.Next(0, width - button1.Width);

            button1.Location = new Point(new_width, new_height);
        }
    }
}
