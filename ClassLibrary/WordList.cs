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

        //Kollar vad projektet heter och skapar en mapp i AppData\Local för användaren
        public static void CheckForLocalDirectory()
        {
            string ProjectName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            LocalAppFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ProjectName + "\\");
            Directory.CreateDirectory(LocalAppFolder);
        }

        //Tar fram alla ordlistor som ligger i den skapade mappen
        public static string[] GetLists()
        {
            CheckForLocalDirectory();
            string[] files = Directory.GetFiles(LocalAppFolder);
            return files;
        }

        //Sparar ny lista och ord till befintliga listor
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
                    foreach (var language in Languages)
                    {
                        sw.Write(language.ToLower() + ";");
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
                        sw.Write(ord.ToLower() + ";");

                    }
                }
            }
        }

        //Laddar en ordlista
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

        //Lägger till ord i ordlista
        public void Add(params string[] translations)
        {
            if (translations.Length % Languages.Length != 0)
            {
                throw new Exception("Not the correct number of words");
            }
            words.Add(new Word(translations));
        }

        //Tar bord från ordlista
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

        //Anger antalet ord i en ordlista
        public int Count()
        {
            return words.Count();
        }

        //Listar alla ord i en ordlista och sorterar efter språk
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedListOfWords = words.OrderBy(word => word.Translations[sortByTranslation]).ToList();

            foreach (Word word in sortedListOfWords)
            {
                showTranslations(word.Translations);
            }
        }

        //Tar fram ett slumpat språk och ord, be användaren att översätta till ett slumpvalt språk i ordlistan
        public Word GetWordToPractice()
        {
            Random rnd = new Random();
            int fromLanguage = rnd.Next(0, Languages.Length);
            int toLanguage = rnd.Next(0, Languages.Length);

            int randomWord = rnd.Next(words.Count);
            Word word = words[randomWord];

            while (fromLanguage == toLanguage)
            {
                toLanguage = rnd.Next(0, Languages.Length);
            }
            
            Word wordsForPractice = new Word(fromLanguage, toLanguage, word.Translations);

            return wordsForPractice;
        }
    }
}
