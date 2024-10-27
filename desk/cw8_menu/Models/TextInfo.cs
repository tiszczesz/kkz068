using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8_menu.Models
{
    public class TextInfo
    {
        public List<string> Content { get; set; }
        public TextInfo(List<string> lines)
        {
            Content = lines;
        }
        public int GetLines()
        {
            return Content.Count;
        }
        public int GetChars()
        {
            int result = 0;
            foreach (var line in Content)
            {
                result += line.Length;//result = result + line.Length;
            }
            return result;
        }
        public int GetLetters()
        {
            int result = 0;
            foreach (var line in Content)
            {
                foreach (var c in line)
                {
                    //if(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                    if (char.IsLetter(c))
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        public int GetVowels()
        {
            string vowels = "aeiouyąęó";
            int result = 0;
            foreach (var line in Content)
            {
                foreach (var c in line)
                {
                    if (vowels.Contains(char.ToLower(c)))
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        public int GetConsonants()
        {
            return GetLetters() - GetVowels();
        }
    }
}
