namespace TutPictureViewer_cw14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pan1_MouseEnter(object sender, EventArgs e)
        {
            pan1.BackColor = Color.Red;
        }

        private void pan1_MouseLeave(object sender, EventArgs e)
        {
            pan1.BackColor = Color.FromArgb(255, 255, 192);
            lbX.Text = "--";
            lbY.Text = "--";
        }

        private void pan1_MouseMove(object sender, MouseEventArgs e)
        {
            lbX.Text = e.X.ToString();
            lbY.Text = (pan1.Height - e.Y).ToString();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int red = e.Y;
            int green = e.X;
            int blue = (e.X + e.Y) / 2;
            pan2.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
