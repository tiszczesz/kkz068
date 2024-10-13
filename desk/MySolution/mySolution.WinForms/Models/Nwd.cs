namespace mySolution.WinForms.Models;

public class Nwd {
    public static int FindNwd(int a, int b) {
        var temp = a;
        while (b != 0) {
            temp = a;
            a = b;
            b = temp % b;
        }

        return a;
    }
}