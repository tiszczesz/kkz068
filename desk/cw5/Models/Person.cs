using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw5.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public bool IsFamily { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Phone}";
        }

        public static Person? GetPerson(string line) {
            var items = line.Split(',');
            if (items.Length == 5)
            {
                return new Person
                {
                    FirstName = items[0],
                    LastName = items[1],
                    Age = Convert.ToInt32(items[2]),
                    Phone = items[3],
                    IsFamily = Convert.ToBoolean(items[4])
                };
            }
            return null;
        }

        public static string PersonToLine(Person p) {
            return $"{p.FirstName},{p.LastName},{p.Age},{p.Phone},{p.IsFamily}";
        }
    }
}
