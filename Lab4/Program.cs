using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /** Tips och råd
    Håll rent i din kod genom att använda regions och block-kommentarer:

    Använd "[hastag]region" och "[hashtag]endregion" för att skapa block som du kan minimera.
    Använd "[backward slash][asterisk][asterisk]" och "[asterisk][backward slash]" för att skapa block-kommentarer som du kan minimera.

    Försök använda identifiers som beskriver innehåll eller funktion.
    Unvik att "kommentera ut" för mycket kod och färstidställa något innan du fortsätter med något annat.
    Bestäm ett system för kommentarer till koden, så att det blir enkelt för ögonen att direkt se vad som är vad.
    */

    class Program
    {
        private static void MenuList()
        {
            Console.WriteLine("Use any of the following parameters:");
            Console.WriteLine("-lists");
            Console.WriteLine("-new <list name> <language 1> <language 2>..<language n>");
            Console.WriteLine("-add <list name>");
            Console.WriteLine("-remove <list name> <language> <word 1><word 2>..<word n>");
            Console.WriteLine("-words <listname><sortByLanguage>");
            Console.WriteLine("-count <listname>");
            Console.WriteLine("-practice <listname>");
        }

        //Switch, läser in från args där index 0 blir menyval.
        private static void ConsoleAppListChoice(string listChoice, string[] argsArguments)
        {
            switch (listChoice)
            {
                case "-lists":
                    MethodsForConsoleApp.ShowLists();
                    break;

                case "-new":
                    MethodsForConsoleApp.NewListAndLanguages(argsArguments);
                    break;

                case "-add":
                    MethodsForConsoleApp.AddWordsToList(argsArguments[1]);
                    break;

                case "-remove":
                    Console.WriteLine("Remove is under construction");
                    break;

                case "-words":
                    Console.WriteLine("Words is under construction");
                    break;

                case "-count":
                    MethodsForConsoleApp.CountWords(argsArguments[1]);
                    break;

                case "-practice":
                    Console.WriteLine("Practice is under construction");
                    break;

                default:
                    Console.WriteLine("Wrong input, please use the following commands.");
                    MenuList();
                    break;
            }
        }
        static void Main(string[] args)
        {
            AppFolder.CheckForLocalDirectory();
            
            
            //Kommentera ut dessa när testing av metoder görs
            string argsInput = args[0].ToString();
            ConsoleAppListChoice(argsInput, args);
            
            Console.ReadKey();
        }
    }
}
