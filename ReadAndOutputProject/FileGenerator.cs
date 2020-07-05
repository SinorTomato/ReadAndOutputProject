using System;
using System.IO;

namespace ReadAndOutput
{
public class FileGenerator
{
    string _Path;
    public string GetPath
    {
        get 
        {            
            CreateNewFileIfNotExists();
            return _Path;
        }
    }
    
    public FileGenerator(string filePath)
    {
        _Path = filePath;
    }
    private void CreateNewFileIfNotExists()
    {   
        if(!File.Exists(_Path))
        CreateAndFillFile();              
        
    }

    private void CreateAndFillFile()
    {
        _Path = $"{AppDomain.CurrentDomain.BaseDirectory}file.txt";
        Random random = new Random();
        using (StreamWriter writer = new StreamWriter(_Path))
        {
            for(int i = 0; i < 10; i++)
            {
                writer.Write($"word{random.Next() % 4} ");
            }                 
        }
    }
}
}