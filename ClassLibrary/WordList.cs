using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WordList
    {
        public string Name { get; }

        public string[] Languages { get; }

        private List<Word> words = new List<Word>();

        public static string LocalAppFolder { get; private set; }


        public WordList()
        {

        }

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }

        public static void CheckForLocalDirectory()
        {
            string ProjectName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            LocalAppFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ProjectName + "\\");
            Directory.CreateDirectory(LocalAppFolder);
        }

        //Fungerar
        public static string[] GetLists()
        {
            CheckForLocalDirectory();
            string[] files = Directory.GetFiles(LocalAppFolder);
            return files;
        }

        //Fungerar
        public void Save()
        {
            string fileName = Name;
            string newList = fileName + ".dat";

            if (!File.Exists(LocalAppFolder + newList))
            {
                using (StreamWriter sw = new StreamWriter(LocalAppFolder + newList))
                {
                    sw.WriteLine();
                }
            }

            if (File.Exists(LocalAppFolder + newList))
            {
                using (StreamWriter sw = new StreamWriter(LocalAppFolder + newList))
                {
                    foreach (var item in Languages)
                    {
                        sw.Write(item + ";");
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(LocalAppFolder + newList, append: true))
            {
                foreach (var word in words)
                {
                    sw.WriteLine();

                    foreach (var ord in word.Translations)
                    {
                        sw.Write(ord + ";");

                    }
                }
            }
        }

        //Fungerar
        public static WordList LoadList(string name)
        {
            string[] loadedListLangugages;

            using (StreamReader sr = new StreamReader(LocalAppFolder + name + ".dat"))
            {
                loadedListLangugages = sr.ReadLine().TrimEnd(';').Split(';');
                WordList loadedList = new WordList(name, loadedListLangugages);

                while (!sr.EndOfStream)
                {
                    string[] translations = sr.ReadLine().TrimEnd(';').Split(';');
                    loadedList.Add(translations);
                }
                return loadedList;
            }
        }

        //Fungerar
        public void Add(params string[] translations)
        {
            if (translations.Length % Languages.Length != 0)
            {
                throw new Exception("Not the correct number of words");
            }
            words.Add(new Word(translations));
        }

        //Fungerar
        public bool Remove(int translation, string word)
        {
            LoadList(Name);

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Translations[translation] == word)
                {
                    words.RemoveAt(i);
                    Save();
                    return true;
                }
            }

            return false;
        }

        //Fungerar
        public int Count()
        {
            return words.Count();
        }

        //Fungerar
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedListOfWords = words.OrderBy(word => word.Translations[sortByTranslation]).ToList();

            foreach (Word word in sortedListOfWords)
            {
                showTranslations(word.Translations);
            }
        }

        //Fungerar
        public Word GetWordToPractice()
        {
            Random rndLanguage = new Random();
            int fromLanguage = rndLanguage.Next(0, Languages.Length);
            int toLanguage = rndLanguage.Next(0, Languages.Length);

            while (fromLanguage == toLanguage)
            {
                toLanguage = rndLanguage.Next(0, Languages.Length);
            }

            string[] wordsToPracticeWith = new string[2] { words[fromLanguage].Translations[fromLanguage],
                words[fromLanguage].Translations[toLanguage] };
            
            Word wordsForPractice = new Word(fromLanguage, toLanguage, wordsToPracticeWith);

            return wordsForPractice;
        }
    }
}
