namespace cw11
{
    public partial class Form1 : Form
    {
        public Color color;
        public Form1()
        {
            InitializeComponent();
            panelBackgroundColorUpdate();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbRed.Text = "Red: " + trackBar1.Value.ToString();
            panelBackgroundColorUpdate();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            lbGreen.Text = "Green: " + trackBar2.Value.ToString();
            panelBackgroundColorUpdate();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            lbBlue.Text = "Blue: " + trackBar3.Value.ToString();
            panelBackgroundColorUpdate();
        }

        private void panelBackgroundColorUpdate()
        {
            //Console.WriteLine(trackBar4.Value.ToString(), trackBar1.Value.ToString(), trackBar2.Value.ToString(), trackBar3.Value.ToString());
            color = Color.FromArgb(trackBar4.Value, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            panel1.BackColor = color;
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            lbOpacity.Text = "Opacity: " + trackBar4.Value.ToString();
            panelBackgroundColorUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(this).ShowDialog();
        }
        public Label GetLabel()
        {
            return label1;
        }
    }
}
