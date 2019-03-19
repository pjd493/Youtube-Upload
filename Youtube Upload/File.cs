using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class File
{
    public string title;
    public string description;
    public string tag;
    public string Id;
    public string privacy;
    public string filepath;

    public File()
    {

    }

    public File(string filename)
    {

    }
    public File(string title, string description, string tag, string Id, string privacy, string filepath)
    {
        this.title = title;
        this.description = description;
        this.tag = tag;
        this.Id = Id;
        this.privacy = privacy;
        this.filepath = filepath;
        
    }
}

