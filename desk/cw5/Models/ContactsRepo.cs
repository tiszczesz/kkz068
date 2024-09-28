using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw5.Models
{
    public class ContactsRepo {
        private List<Person>? _people;

        public List<Person> People {
            get {
                return _people ?? (_people = new List<Person>());
            }
        }
        public void GetFromFile(string filename) {
            List<string> lines = File.ReadAllLines(filename).ToList();
            _people = new List<Person>();
            foreach (var line in lines) {
                var p = Person.GetPerson(line);
                if (p != null) {
                    _people.Add(p);
                }
            }
        }
    }
}
