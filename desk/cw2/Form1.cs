namespace cw2
{
    public partial class Form1 : Form
    {
        private int _counter;
        private int _query;
        public Form1()
        {
            InitializeComponent();
            _counter = 0;
            lbCount.Text = _counter.ToString();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            _counter--;
            lbCount.Text = _counter.ToString();
            updateButtons();
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            _counter++;
            lbCount.Text = _counter.ToString();
            updateButtons();
        }

        private void updateButtons()
        {
            btnAsc.Enabled = _counter < 20;
            btnDesc.Enabled = _counter > -20;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            _query = rnd.Next(100);
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            try {
                int actual = Convert.ToInt32(tbNumber.Text);
                //sprawdzanie
            }
            catch (FormatException ex) {
                MessageBox.Show("B³edne dane");
                return;
            }
           
            
        }
    }
}
