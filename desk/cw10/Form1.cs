using cw10.Models;

namespace cw10;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string solutionDirectory = AppDomain.CurrentDomain.BaseDirectory;
        MessageBox.Show(solutionDirectory, "Solution Directory");

        string exePath = AppDomain.CurrentDomain.BaseDirectory;
        string solutionDirectory2 = Directory.GetParent(Directory.GetParent(
            Directory.GetParent(Directory.GetParent(exePath).FullName).FullName).FullName).FullName;
        MessageBox.Show(solutionDirectory2, "Solution Directory");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var repo = new FileRepo("settings.txt");
        var settings = repo.ReadSettings();
        dataGridView1.DataSource = settings;
    }
}
