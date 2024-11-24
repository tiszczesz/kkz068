using System;

namespace cw10.Models;

public class FileRepo
{
    private readonly string? _path;
    public FileRepo(string? path)
    {
        _path = path;
    }
    public List<Setting> ReadSettings(){
        List<Setting> settings = new ();
       // File

        return settings;
    }

}
