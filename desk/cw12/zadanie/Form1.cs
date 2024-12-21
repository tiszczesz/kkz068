namespace zadanie
{
    public partial class Form1 : Form
    {
        // private List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            // textBox1.Multiline = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //list.Add(textBox1.Text);
            // int liczba = Convert.ToInt32(text);
            //list
            // listBox1.DataSource = null;
            listBox1.Items.Add(textBox1.Text);

            textBox1.Text = String.Empty;
            // listBox1.DataSource = list;
            label2.Text = "iloœæ elementów: " + listBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                // listBox1.Items.Remove(listBox1.SelectedItems[0]);
                label2.Text = "iloœæ elementów: " + listBox1.Items.Count.ToString();
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            //listBox1.BackColor = Color.Red;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Klikniêto w formularz");
            this.BackColor = Color.Red;
        }
    }
}
