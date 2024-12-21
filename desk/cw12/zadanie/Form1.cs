namespace zadanie
{
    public partial class Form1 : Form
    {
       // private List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //list.Add(textBox1.Text);
            // int liczba = Convert.ToInt32(text);
            //list
           // listBox1.DataSource = null;
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            // listBox1.DataSource = list;
            label2.Text = "iloœæ elementów: "+listBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
            button2.ForeColor = Color.Red;
        }

      
    }
}
