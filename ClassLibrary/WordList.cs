﻿using System;
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

        public WordList()
        {

        }

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }

        //Fungerar
        public static string[] GetLists()
        {
            string[] files = Directory.GetFiles(AppFolder.LocalAppFolder);
            return files;
        }

        //Fungerar
        public void Save()
        {
            string fileName = Name;
            string newList = fileName + ".dat";

            if (!File.Exists(AppFolder.LocalAppFolder + newList))
            {
                using (StreamWriter sw = new StreamWriter(AppFolder.LocalAppFolder + newList))
                {
                    sw.WriteLine();
                }
            }

            if (File.Exists(AppFolder.LocalAppFolder + newList))
            {
                using (StreamWriter sw = new StreamWriter(AppFolder.LocalAppFolder + newList))
                {
                    foreach (var item in Languages)
                    {
                        sw.Write(item + ";");
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(AppFolder.LocalAppFolder + newList, append: true))
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

            using (StreamReader sr = new StreamReader(AppFolder.LocalAppFolder + name + ".dat"))
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

        //public bool Remove(int translation, string word)
        //{
        ////translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. 
        //}

        //Fungerar
        public int Count()
        {
            return words.Count();
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            //sortByTranslation = Vilket språk listan ska sorteras på.
            //showTranslations = Callback som anropas för varje ord i listan.
        }

        //public Word GetWordToPractice()
        //{
        ////Returnerar slumpmässigt Word från listan, med slumpmässigt valda
        ////FromLanguage och ToLanguage(dock inte samma). 
        //}




    }
}