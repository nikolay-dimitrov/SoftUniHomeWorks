using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;



class WordCount
{
    static void Main()
    {

        //read words list:
        List<string> wordsList = new List<string>();
        using (StreamReader wordsListReader = new StreamReader("../../words.txt"))
        {
            string line;
            while ((line = wordsListReader.ReadLine()) != null)
                wordsList.Add(line);
        }

        //read text to be searched:
        StringBuilder textBuilder = new StringBuilder();
        using (StreamReader textReader = new StreamReader("../../text.txt"))
        {
            string line;
            while ((line = textReader.ReadLine()) != null)
                textBuilder.Append(line);
        }

        //count matches:
        string text = textBuilder.ToString();
        var wordsDict = new Dictionary<string, int>();
        foreach (string word in wordsList)
        {
            Regex wordRegEx = new Regex(@"\b" + word + @"\b", RegexOptions.IgnoreCase);
            MatchCollection matches = wordRegEx.Matches(text);
            if (matches.Count > 0)
                wordsDict[word] = matches.Count;
        }

        //sort dictionary by value
        wordsDict = wordsDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        //print result:
        foreach (KeyValuePair<string, int> pair in wordsDict)
            Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
    }
}