using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MethodsForConsoleApp
    {
        //Metod för att lista alla ordlistor - FUNGERAR
        public static void ShowLists()
        {
            Console.WriteLine("These are your wordlists.");
            foreach (string file in WordList.GetLists())
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
        }

        //Metod för att skapa ny ordlista med valfritt antal språk - FUNGERAR
        public static void NewListAndLanguages(string[] argsArguments)
        {
            if (File.Exists(AppFolder.LocalAppFolder + argsArguments[1] + ".dat"))
            {
                Console.WriteLine($"File {argsArguments[1]} already exists, please try <-Add> <{argsArguments[1]}> to add words.");
                return;
            }

            string newList = argsArguments[1];
            var languagesArray = new string[argsArguments.Length - 2];

            for (int i = 0; i < argsArguments.Length - 2; i++)
            {
                languagesArray[i] = argsArguments[i + 2];
            }

            List<string> bufferList = new List<string>();
            for (int i = 0; i < languagesArray.Length; i++)
            {
                bufferList.Add(languagesArray[i] + ";");
            }

            string[] languageInput = bufferList.ToArray();

            WordList newWordList = new WordList(newList, languagesArray);

            newWordList.Save();
            AddWordsToList(newList);
        }

        //Metod för att lägga till ord till befintlig lista - FUNGERAR
        public static void AddWordsToList(string listName)
        {
            WordList loadedList = WordList.LoadList(listName);
            string word = "";

            do
            {
                string[] newWordForDictionary = new string[loadedList.Languages.Length];

                for (int i = 0; i < loadedList.Languages.Length; i++)
                {
                    Console.Write($"Ange ord för {loadedList.Languages[i]}: ");
                    word = Console.ReadLine();

                    if (word == "")
                    {
                        break;
                    }

                    newWordForDictionary[i] = word;
                }

                if (!newWordForDictionary.Contains(null))
                {
                    loadedList.Add(newWordForDictionary);
                }

            } while (word != "");

            loadedList.Save();
        }

        //Metod för att räkna ord i befintlig lista - FUNGERAR
        public static void CountWords(string listName)
        {
            WordList loadedListForCount = WordList.LoadList(listName);
            Console.WriteLine($"Words in {listName}: {loadedListForCount.Count()}");
        }
    }

}
