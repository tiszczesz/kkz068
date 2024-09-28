namespace cw4
{
    public partial class Form1 : Form
    {
        private string _fileName = "colors.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void tbItem_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = tbItem.Text.Trim().Length > 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("fffff");
            var color = tbItem.Text;
            if (!cbIsInsert.Checked)
            {
                lbColors.Items.Add(color);
            }
            else
            {
                if (lbColors.SelectedIndex != -1)
                {
                    lbColors.Items.Insert(lbColors.SelectedIndex, color);
                }
            }
            tbItem.Text = "";

        }

        private void cbIsInsert_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Text = cbIsInsert.Checked ? "Wstaw" : "Dodaj";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (lbColors.Items.Count > 0)
                lbColors.SelectedIndex = 0;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (lbColors.Items.Count != 0)
            {
                File.WriteAllLines(_fileName,
                     lbColors.Items.Cast<string>().ToList());
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(_fileName)) {
                lbColors.Items.Clear();
                lbColors.Items.AddRange(File.ReadAllLines(_fileName));
            }
        }
    }
}
