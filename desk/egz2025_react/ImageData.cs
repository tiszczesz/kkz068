using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egz2025_react
{
    public class ImageData
    {
        public int Id { get; set; }
        public string Alt { get; set; }
        public string Filename { get; set; }
        public int Category { get; set; }
        public int Downloads { get; set; }
       
    }
    public class  ImageDataRepo
    {
        public static List<ImageData> GetImageDataList()
        {
            return new List<ImageData>
            {
                new ImageData { Id = 0, Alt = "Mak", Filename = "obraz1.jpg", Category = 1, Downloads = 35 },
                new ImageData { Id = 1, Alt = "Bukiet", Filename = "obraz2.jpg", Category = 1, Downloads = 43 },
                new ImageData { Id = 2, Alt = "Dalmatyńczyk", Filename = "obraz3.jpg", Category = 2, Downloads = 2 },
                new ImageData { Id = 3, Alt = "Świnka morska", Filename = "obraz4.jpg", Category = 2, Downloads = 53 },
                new ImageData { Id = 4, Alt = "Rotwailer", Filename = "obraz5.jpg", Category = 2, Downloads = 43 },
                new ImageData { Id = 5, Alt = "Audi", Filename = "obraz6.jpg", Category = 3, Downloads = 11 },
                new ImageData { Id = 6, Alt = "kotki", Filename = "obraz7.jpg", Category = 2, Downloads = 22 },
                new ImageData { Id = 7, Alt = "Róża", Filename = "obraz8.jpg", Category = 1, Downloads = 33 },
                new ImageData { Id = 8, Alt = "Świnka morska", Filename = "obraz9.jpg", Category = 2, Downloads = 123 },
                new ImageData { Id = 9, Alt = "Foksterier", Filename = "obraz10.jpg", Category = 2, Downloads = 22 },
                new ImageData { Id = 10, Alt = "Szczeniak", Filename = "obraz11.jpg", Category = 2, Downloads = 12 },
                new ImageData { Id = 11, Alt = "Garbus", Filename = "obraz12.jpg", Category = 3, Downloads = 321 }
            };
        }
    }
}

