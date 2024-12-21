namespace TutPictureViewer_cw14
{
    public partial class Form1 : Form
    {
        private Color color = Color.Black;
        private Point p1, p2;
        private bool drawing = false;
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

        private void pan3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.Blue, 3);
            Brush brush1 = new SolidBrush(Color.Red);
            e.Graphics.DrawRectangle(pen1, 50, 0, 100, 100);
            e.Graphics.FillRectangle(brush1, 150, 150, 150, 100);
            e.Graphics.DrawEllipse(pen1, 200, 0, 150, 100);
            pen1.Color = Color.Green;
            e.Graphics.DrawLine(pen1, 50, 0, 150, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                // pan4.BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pan4.CreateGraphics();
            Pen pen1 = new Pen(color, 3);
            g.DrawRectangle(pen1, (int)nudXp.Value, (int)nudYp.Value,
                (int)nudXk.Value, (int)nudYk.Value);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pan4.CreateGraphics();
            g.Clear(Color.White);
        }

        private void pan4_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = e.Location;
            drawing = true;
        }

        private void pan4_MouseUp(object sender, MouseEventArgs e)
        {
            p2 = e.Location;
            Graphics g = pan4.CreateGraphics();
            Pen pen1 = new Pen(color, 3);
            g.DrawLine(pen1, p1, p2);
            drawing = false;

        }

        private void pan4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = pan4.CreateGraphics( );
                Pen pen1 = new Pen(color, 3);
                Brush brush1 = new SolidBrush(color);
                g.FillRectangle(brush1,  e.Location.X,e.Location.Y,1,1);
               // g.DrawLine(pen1, p1, p2);
            }
          

        }
    }
}
