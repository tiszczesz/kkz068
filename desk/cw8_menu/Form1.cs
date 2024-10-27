namespace cw8_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                tbEdit.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
    }
}
