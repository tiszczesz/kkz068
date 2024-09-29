using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwArk1.Models
{
    public class PasswordGenerator
    {
        private bool isUpper;
        private bool isNumber;
        private bool isSpecial;
        private int size;
        public PasswordGenerator(int size, bool isUpper = false, 
            bool isNumber = false,
            bool isSpecial = false
           )
        {
            this.isUpper = isUpper;
            this.isNumber = isNumber;
            this.isSpecial = isSpecial;
            this.size = size;
        }

        public string getPassword() {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            string specials = "!@#$%^&*()_+-=";
            StringBuilder result = new StringBuilder();
            if (isUpper) {
                int random = new Random().Next(0, chars.Length);
                result.Append(chars[random].ToString().ToUpper());
            }

            if (isNumber) {
                result.Append(new Random().Next(0, 9));
            }
            if(isSpecial) {
                result.Append(specials[new Random().Next(specials.Length)]);
            }

            // string rr = String.ToUpper()

            while (result.Length < size) {
                result.Append(chars[new Random().Next(chars.Length)]);
            }

            return result.ToString();
        }
    }
}
