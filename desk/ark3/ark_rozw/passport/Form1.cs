namespace passport;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void tbNumber_Leave(object sender, EventArgs e)
    {
        switch (tbNumber.Text)
        {
            case "111":
                pb1.Image = Image.FromFile("111-zdjecie.jpg");
                pb2.Image = Image.FromFile("111-odcisk.jpg");
                break;

            case "333":
                pb1.Image = Image.FromFile("333-zdjecie.jpg");
                pb2.Image = Image.FromFile("333-odcisk.jpg");
                break;
            case "000":
                pb1.Image = Image.FromFile("000-zdjecie.jpg");
                pb2.Image = Image.FromFile("000-odcisk.jpg");
                break;
            default:
                pb1.Image = null;
                pb2.Image = null;
                break;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string firstname = tbFirstname.Text.Trim();
        string lastname = tbLastname.Text.Trim();
        string number = tbNumber.Text.Trim();
        string eyes = "";
        if (radioButton1.Checked)
        {
            eyes = "niebieskie";
        }
        else if (radioButton2.Checked)
        {
            eyes = "zielone";
        }
        else if (radioButton3.Checked)
        {
            eyes = "piwne";
        }
        if(firstname.Length==0 || lastname.Length==0 || number.Length == 0)
        {
            MessageBox.Show("Wype³nij wszystkie pola");
            return;
        }
        MessageBox.Show($"Witaj {firstname} {lastname}. Masz {eyes} oczy.");
    }
}
