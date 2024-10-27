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
    }
}
