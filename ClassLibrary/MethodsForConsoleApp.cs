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
        //Metod för att lista alla ordlistor
        public static void ShowLists()
        {
            Console.WriteLine("These are your wordlists.");
            foreach (string file in WordList.GetLists())
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
        }

        //Metod för att skapa ny ordlista med valfritt antal språk
        public static void NewListAndLanguages(string[] argsArguments)
        {
            if (File.Exists(WordList.LocalAppFolder + argsArguments[1] + ".dat"))
            {
                Console.WriteLine($"Dictionary {argsArguments[1]} already exists, please try <-Add> <{argsArguments[1]}> to add words.");
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

        //Metod för att lägga till ord till befintlig lista
        public static void AddWordsToList(string listName)
        {
            WordList loadedList = WordList.LoadList(listName);
            string word = "";

            do
            {
                string[] newWordForDictionary = new string[loadedList.Languages.Length];

                for (int i = 0; i < loadedList.Languages.Length; i++)
                {
                    Console.Write($"Write a word in {loadedList.Languages[i]}: ");
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

        //Metod för att räkna ord i befintlig lista
        public static void CountWords(string listName)
        {
            WordList loadedListForCount = WordList.LoadList(listName);
            Console.WriteLine($"Words in {listName}: {loadedListForCount.Count()}");
        }

        //Metod för att tabort ett eller flera ord från en lista
        public static void RemoveWords(string listName, string[] argsArguments)
        {
            WordList listForRemoveWord = WordList.LoadList(listName);
            string language = argsArguments[2];
            int languageForRemoveAsIndex = 0;

            for (int i = 0; i < listForRemoveWord.Languages.Length; i++)
            {
                if (listForRemoveWord.Languages[i] == language)
                {
                    languageForRemoveAsIndex = i;
                }
            }

            for (int i = 3; i < argsArguments.Length; i++)
            {
                if (listForRemoveWord.Remove(languageForRemoveAsIndex, argsArguments[i]))
                {
                    Console.WriteLine($"Your word {argsArguments[i]} is removed.");
                }
                else
                {
                    Console.WriteLine($"Your word {argsArguments[i]} was not in the list.");
                }
            }
        }

        //Metod för att träna på slumpade ord från en specifik lista
        public static void Practice(string listName)
        {
            WordList wordForPractice = WordList.LoadList(listName);

            double correctTranslation = 0.0;
            double numberOfWordsTranslated = 0.0;
            string wordTranslated = "";

            do
            {
                Console.Clear();
                Console.WriteLine($"Practice vocabulary by writing the translation, quit be press \"enter\" on a empty line.");
                Console.WriteLine("After practice you will see your result.");
                Console.WriteLine();
                
                Word word = wordForPractice.GetWordToPractice();
                Console.WriteLine($"Word in {wordForPractice.Languages[word.FromLanguage]}: {word.Translations[0]}");
                Console.Write($"To {wordForPractice.Languages[word.ToLanguage]}: ");
                wordTranslated = Console.ReadLine();
                numberOfWordsTranslated++;
                
                if (wordTranslated == "")
                {
                    break;
                }

                if (wordTranslated == word.Translations[1])
                {
                    correctTranslation++;
                }

            } while (wordTranslated != "");

            double correctAnswersInProcent = (correctTranslation / numberOfWordsTranslated) * 100;

            Console.WriteLine();
            Console.WriteLine($"Number of words you practiced: {numberOfWordsTranslated}");
            Console.WriteLine($"Correct amount of translations: {correctTranslation}");
            Console.WriteLine($"Your score: {correctAnswersInProcent:F1}%");
        }

        //Metod för att lista alla ord sorterade efter språk
        public static void ListWordsAlphabetically(string listName, string[] argsArgument)
        {
            WordList sortByLanguage = WordList.LoadList(listName);
            string language = argsArgument[2];
            int languageIndex = 0;
            
            for (int i = 0; i < sortByLanguage.Languages.Length; i++)
            {
                if (language == sortByLanguage.Languages[i])
                {
                    languageIndex = i;
                    break;
                }
            }
            
            int changeRow = 0;

            for (int i = 0; i < sortByLanguage.Languages.Length; i++)
            {
                Console.Write($"{sortByLanguage.Languages[i],-20}");
            }
            Console.WriteLine();

            Action<string[]> printWords = (input) =>
            {
                if (changeRow == sortByLanguage.Languages.Length)
                {
                    Console.WriteLine();
                    changeRow = 0;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    changeRow++;
                    Console.Write($"{input[i],-20}");
                }
            };

            sortByLanguage.List(languageIndex, printWords);
        }
    }
}
