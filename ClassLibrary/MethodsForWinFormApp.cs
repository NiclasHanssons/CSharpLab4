using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MethodsForWinFormApp
    {
        //Laddar in alla ordlistor
        public static string[] ShowLists()
        {
            return WordList.GetLists();
        }
        
        //Räknar antal ord i en lista
        public static int CountWords(string listName)
        {
            WordList loadedListForCount = WordList.LoadList(listName);
            return loadedListForCount.Count();
        }

        //Laddar in en lista och listar alla orden, använder sig av Action delegate 
        public static string[] ListWordsAlphabetically(string listName)
        {
            WordList wordList = WordList.LoadList(listName);
            List<string> words = new List<string>();
            
            Action<string[]> allWords = (input) =>
            {
                foreach (var word in input)
                {
                    words.Add(word);
                }
            };

            wordList.List(0, allWords);

            return words.ToArray();
        }
    }
}
