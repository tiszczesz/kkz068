using cw8_menu.Models;

namespace cw8_menu
{
    public partial class Form1 : Form
    {
        private TextInfo _textInfo;
        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                _textInfo = new TextInfo(File.ReadAllLines(openFileDialog1.FileName).ToList());
                tbEdit.Lines = _textInfo.Content.ToArray();
            }
        }
    }
}
