using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadAndOutput
{
public static class Logic
{
      public static string ReadStringFromFile(string path)
    {
        String line;
        using (StreamReader reader = new StreamReader(path))
        {
            line = reader.ReadToEnd();
        }

        if(line == String.Empty)
        throw new Exception("error reading from file");

        return line; 
    }

    public static Dictionary<String, int> ParseStringToDictionary(string line)
    {
         try
        {    
           if(line == String.Empty)
        throw new Exception("nothing to parse, string is empty");

        Dictionary<String, int> dictionary = new Dictionary<string, int>();
        
        var trimString = line.Trim();
        var wordArray = trimString.Split(' ');    

          foreach (var word in wordArray)         
        {
            if(!dictionary.ContainsKey(word))
                dictionary.Add(word, 1);
            else
                 dictionary[word]++;    
        }          
        return dictionary;

        }
        catch(Exception e)
        {
            Console.WriteLine("Can't get dictionary :" + e.Message);  
            return null;        
        }        
           
    }

   public static List<KeyValuePair<String, int>> SortDictionary(Dictionary<string, int> dictionary)
    {
        List<KeyValuePair<String, int>> list = dictionary.ToList();
        list.Sort((pair1,pair2) => pair2.Value.CompareTo(pair1.Value));
        return list;
    }


}

}
