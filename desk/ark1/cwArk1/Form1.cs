using cwArk1.Models;

namespace cwArk1;

public partial class Form1 : Form {
    private string _password;
    public Form1()
    {
        InitializeComponent();

    }

    private void btnAccept_Click(object sender, EventArgs e)
    {
        MessageBox
            .Show($"{tbFirstname.Text} {tbLastname.Text} "+
                  $"{cbOcupation.Text} Has³o: {_password}");
    }

    private void btnGener_Click(object sender, EventArgs e) {
        try {
            PasswordGenerator generator =
                new PasswordGenerator(Convert.ToInt32(tbSize.Text)
                    ,isUpper:cbIsUpper.Checked,isNumber:cbIsNumber.Checked,
                    isSpecial:cbIsSpecial.Checked);
            _password = generator.getPassword();
        }
        catch (FormatException ex) {
            MessageBox.Show("B³êdny rozmiar");
        }
        
    }
}
