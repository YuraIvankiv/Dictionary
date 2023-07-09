using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Dictionary
    {
        private Dictionary<string, List<string>> dictionary;
        public Dictionary()
        {
            dictionary = new Dictionary<string, List<string>>();
        }
        public void AddWord(string word, List<string> translations)//Додати слово та його переклад
        {
            if (!dictionary.ContainsKey(word))
            {
                dictionary.Add(word, translations);
                Console.WriteLine("Word added successfully.");
            }
            else
            {
                Console.WriteLine("The word already exists. Unable to add word.");
            }
        }
        public void RemoveWord(string word)//Видали слово 
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary.Remove(word);
                Console.WriteLine("Word deleted successfully.");
            }
            else
            {
                Console.WriteLine("No word found.");
            }
        }
        public void RemoveTranslation(string word, string translation)//Видалити переклад
        {
            if (dictionary.ContainsKey(word))
            {
                List<string> translations = dictionary[word];
                if (translations.Contains(translation))
                {
                    translations.Remove(translation);
                    Console.WriteLine("Translation deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No translation found.");
                }
            }
            else
            {
                Console.WriteLine("No word found.");
            }
        }
        public void UpdateWord(string oldWord, string newWord)//Оновлення слова в  словнику
        {
            if (dictionary.ContainsKey(oldWord))
            {
                List<string> translations = dictionary[oldWord];
                dictionary.Remove(oldWord);
                dictionary.Add(newWord, translations);
                Console.WriteLine("Word information updated successfully.");
            }
            else
            {
                Console.WriteLine("No word found.");
            }
        }
        public void UpdateTranslation(string word, string oldTranslation, string newTranslation)//Оновлення перекладу
        {
            if (dictionary.ContainsKey(word))
            {
                List<string> translations = dictionary[word];
                if (translations.Contains(oldTranslation))
                {
                    int index = translations.IndexOf(oldTranslation);
                    translations[index] = newTranslation;
                    Console.WriteLine("Word information updated successfully.");
                }
                else
                {
                    Console.WriteLine("No translation found.");
                }
            }
            else
            {
                Console.WriteLine("No word found.");
            }
        }
        public void SearchTranslation(string word)//Пошук перекладу на французьку
        {
            bool found = false;

            foreach (var entry in dictionary)
            {
                if (entry.Key == word)
                {
                    Console.WriteLine($"Translate the words '{word}':");

                    foreach (string translation in entry.Value)
                    {
                        Console.WriteLine($"- {translation}");
                    }

                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No word found.");
            }
        }
    }
}
