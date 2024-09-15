namespace cw3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
       // cbOparation.SelectedIndex = 0;
    }

    private void cbOparation_SelectedIndexChanged(object sender, EventArgs e)
    {
        try {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);

            string resultOp = cbOparation.Items[cbOparation.SelectedIndex]
                .ToString();
            switch (resultOp) {
                case "+":
                    lbResult.Text = $"{a} + {b} = {a + b}";
                    break;
                case "-":
                    lbResult.Text = $"{a} - {b} = {a - b}";
                    break;
                case "*":
                    lbResult.Text = $"{a} * {b} = {a * b}";
                    break;
                case "/":
                    lbResult.Text = 
                        $"{a} / {b} = {(b!=0? Math.Round(a / b,2):"BRAK WYNIKU")}";
                    break;
                default: MessageBox.Show("B³êdne dzia³anie");
                    break;
            }

        }
        catch (FormatException ex) {
            MessageBox.Show("Brak lub b³êdne liczby");
            lbResult.Text = "";
        }
    }
}
