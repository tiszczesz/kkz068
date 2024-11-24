using System;

namespace cw10.Models;

public class FileRepo
{
    private readonly string? _path;
    public FileRepo(string? path="settings.txt")
    {
        _path = path;
    }
    public List<Setting> ReadSettings(){
        List<Setting> settings = new ();
        var lines = File.ReadAllLines(_path);
        for (int i = 0; i < lines.Length; i+=6) { 
            settings.Add(new Setting
            {
                Color = lines[i],
                Width = Convert.ToInt32(lines[i + 1]),
                Height = Convert.ToInt32(lines[i + 2]),
                Opacity = int.Parse(lines[i + 3]),
                Platform = lines[i + 4]
            });
        }
        //string www = "www";
        //www.stoi()
        return settings;
    }

}
