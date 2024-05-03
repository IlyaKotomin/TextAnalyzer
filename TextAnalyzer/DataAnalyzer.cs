using System.Linq;

namespace TextAnalyzer;

public class DataAnalyzer(string data)
{
    public int GetCharCount(char charToFind) 
        => data.Count(@char => @char == charToFind);
}