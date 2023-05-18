namespace v0518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            player.Left += 20;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            player.Top -= 20;
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            player.Left -= 20;
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            player.Top += 20;
        }
    }
}