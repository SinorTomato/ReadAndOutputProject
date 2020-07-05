using System;

namespace ReadAndOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "file.txt";
            FileGenerator fileGenerator = new FileGenerator(filePath);

            var stringFromFile = Logic.ReadStringFromFile(fileGenerator.GetPath);
            var dictionary = Logic.ParseStringToDictionary(stringFromFile);
            var sortedDictionary = Logic.SortDictionary(dictionary);

            foreach (var el in sortedDictionary)
            {
                 Console.WriteLine("{0} {1}times", el.Key, el.Value);
            }
         
        }


        
    }
}
