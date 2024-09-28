using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw5.Models
{
    public class ContactsRepo {
        private List<Person>? _people;
        private bool _isDirty = false;

        public List<Person> People {
            get {
                return _people ?? (_people = new List<Person>());
            }
        }
        public void GetFromFile(string filename) {
            if(_isDirty) return;
            List<string> lines = File.ReadAllLines(filename).ToList();
            if(_people == null) _people = new List<Person>();
            foreach (var line in lines) {
                var p = Person.GetPerson(line);
                if (p != null) {
                    _people.Add(p);
                }
            }
            _isDirty = true;
        }

        public void SaveToFile(string filename) {
            List<string> lines = new List<string>();
            foreach (var p in People)
            {
                lines.Add(Person.PersonToLine(p));
            }
            File.WriteAllLines(filename, lines);
            _isDirty = false;
        }
    }
}
