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
        //FUNGERAR
        public static string[] ShowLists()
        {
            return WordList.GetLists();
        }

        //Ej fixad för winform NewListAndLanguages
        public static void NewListAndLanguages(string[] argsArguments)
        {
            //if (File.Exists(LocalAppFolder + argsArguments[1] + ".dat"))
            //{
            //    Console.WriteLine($"File {argsArguments[1]} already exists, please try <-Add> <{argsArguments[1]}> to add words.");
            //    return;
            //}

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

        //Ej fixad för winform
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

        //FUNGERAR
        public static int CountWords(string listName)
        {
            WordList loadedListForCount = WordList.LoadList(listName);
            return loadedListForCount.Count();
        }

        //Ej fixad för winform
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

        //Ej fixad för winform
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

        //Ej fixad för winform
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
