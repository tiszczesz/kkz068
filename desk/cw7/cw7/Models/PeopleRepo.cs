using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cw7.Models
{
    public class PeopleRepo
    {
        public List<Person>? People { get; set; }
        public PeopleRepo(string pathFile = "people.json") {
            string content = File.ReadAllText(pathFile);
            People = JsonSerializer.Deserialize<List<Person>>(content);
        }
        public int GetLastId()
        {
            if(People == null || People.Count == 0)
            {
                return 0;
            }
            return People.Max(p => p.Id);
        }

        public void SaveToFile(string pathFile = "people.json")
        {
            string content = JsonSerializer.Serialize(People,new JsonSerializerOptions { WriteIndented=true});  
            File.WriteAllText(pathFile, content);
        }
    }
}
