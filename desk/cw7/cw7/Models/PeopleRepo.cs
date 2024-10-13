using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cw7.Models
{
    public class PeopleRepo
    {
        public List<Person>? People { get; set; }
        public PeopleRepo(string pathFile = "people.json") {
            string content = File.ReadAllText(pathFile);
            People = JsonSerializer.Deserialize<List<Person>>(content);
        }
    }
}
