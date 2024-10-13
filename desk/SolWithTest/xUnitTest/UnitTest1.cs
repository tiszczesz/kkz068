using cwArk1.Models;

namespace xUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            PasswordGenerator password = new PasswordGenerator(20);
            string pass = password.getPassword();
            Assert.Equal(20, pass.Length);
        }
        [Fact]
        public void Test2()
        {
            PasswordGenerator password = new PasswordGenerator(20);
            string pass = password.getPassword();
            Assert.Matches("[a-z]", pass);
        }
        [Fact]
        public void Test3()
        {
            PasswordGenerator password = new PasswordGenerator(20,isNumber:true);
            string pass = password.getPassword();
            Assert.Matches("[0-9]", pass);
        }
        [Fact]
        public void Test4()
        {
            PasswordGenerator password = new PasswordGenerator(20, isSpecial: true);
            string pass = password.getPassword();
            Assert.Matches("[!@#$%^&*()_+-=]", pass);
        }
        [Fact]
        public void Test5()
        {
            PasswordGenerator password = new PasswordGenerator(20, isUpper: true);
            string pass = password.getPassword();
            Assert.Matches("[A-Z]", pass);
        }
    }
}