namespace cw13
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //„Pies”, „Kot”, „Œwinka morska”
            listBox1.Items.Add("Pies");
            listBox1.Items.Add("Kot");
            listBox1.Items.Add("Œwinka morska");
            tracBarAge.Value = 0;

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                return;
            }
            string? selected = listBox1.SelectedItems[0]?.ToString();
            switch (selected)
            {
                case "Pies":
                    tracBarAge.Maximum = 18;
                    break;
                case "Kot":
                    tracBarAge.Maximum = 20;
                    break;
                case "Œwinka morska":
                    tracBarAge.Maximum = 9; ;
                    break;                                                  
            }
            lbAge.Text = "ile ma lat: " + tracBarAge.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lbAge.Text = "ile ma lat: " + tracBarAge.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
