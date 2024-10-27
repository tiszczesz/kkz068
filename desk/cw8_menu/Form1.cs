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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _textInfo = new TextInfo(File.
                    ReadAllLines(openFileDialog1.FileName).ToList());
                tbEdit.Lines = _textInfo.Content.ToArray();
                UpdateInfo();
            }
        }
        private void UpdateInfo()
        {
            lbChars.Text = _textInfo.GetChars().ToString();
            lbLines.Text = _textInfo.GetLines().ToString();
            lbLetters.Text = _textInfo.GetLetters().ToString();
            lbVowels.Text = _textInfo.GetVowels().ToString();
            lbConsonants.Text = _textInfo.GetConsonants().ToString();
        }

        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            if (_textInfo == null)
            {
                _textInfo = new TextInfo(tbEdit.Lines.ToList());
            }
            _textInfo.Content = tbEdit.Lines.ToList();
            UpdateInfo();
            toolStripStatusLabel1.Text = "Zmieniono tekst";
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, tbEdit.Lines);
                toolStripStatusLabel1.Text = "Zapisano plik";
            }
        }
    }
}
