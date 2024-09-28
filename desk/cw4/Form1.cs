namespace cw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbItem_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = tbItem.Text.Trim().Length > 2;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var color = tbItem.Text;
            lbColors.Items.Add(color);
            tbItem.Text = "";
        }
    }
}
