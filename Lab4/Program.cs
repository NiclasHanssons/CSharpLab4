using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    class Program
    {
        private static void MenuList()
        {
            Console.WriteLine();
            Console.WriteLine("Use any of the following commands:");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2>..<language n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name> <language> <word 1><word 2>..<word n>");
            Console.WriteLine("-words <listname><sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
        }

        private static void ConsoleAppListChoice(string listChoice, string[] argsArguments)
        {
            switch (listChoice)
            {
                case "-lists":
                    Console.WriteLine();
                    MethodsForConsoleApp.ShowLists();
                    break;

                case "-new":
                    Console.WriteLine();
                    MethodsForConsoleApp.NewListAndLanguages(argsArguments);
                    break;

                case "-add":
                    Console.WriteLine();
                    MethodsForConsoleApp.AddWordsToList(argsArguments[1]);
                    break;

                case "-remove":
                    Console.WriteLine();
                    MethodsForConsoleApp.RemoveWords(argsArguments[1], argsArguments);
                    break;

                case "-words":
                    Console.WriteLine();
                    MethodsForConsoleApp.ListWordsAlphabetically(argsArguments[1], argsArguments);
                    break;

                case "-count":
                    Console.WriteLine();
                    MethodsForConsoleApp.CountWords(argsArguments[1]);
                    break;

                case "-practice":
                    Console.WriteLine();
                    MethodsForConsoleApp.Practice(argsArguments[1]);
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Wrong input, please use the following commands.");
                    MenuList();
                    break;
            }
        }
        static void Main(string[] args)
        {
            WordList.CheckForLocalDirectory();

            try
            {
                if (args.Length != 0)
                {
                    string argsInput = args[0].ToString().ToLower();
                    ConsoleAppListChoice(argsInput, args);
                }

                else
                {
                    MenuList();
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Wrong input, please use the following commands.");
                Console.WriteLine();
                MenuList();
            }
            Console.ReadKey();
        }
    }
}
