using cw6.Models;

namespace cw6;

public partial class Form1 : Form
{
    private Numbers numbers;
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int size = Convert.ToInt32(numSize.Value);
        numbers = new Numbers(size);
        lbNumbers.DataSource = numbers.NumbersList;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (numbers.NumbersList.Count > 0) {
            int index = numbers.GetMax();
            lbMax.Text = numbers.NumbersList[index].ToString();
            lbNumbers.SelectedIndex = index;
        }
    }
}
