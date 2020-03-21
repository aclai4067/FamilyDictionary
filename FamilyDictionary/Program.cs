using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var familyDictionary = new Dictionary<string, Dictionary<string, string>>();
            familyDictionary.Add("mother", new Dictionary<string, string>() { { "name", "Janie" }, { "age", "66" } });
            familyDictionary.Add("father", new Dictionary<string, string>() { { "name", "Tom" }, { "age", "71" } });
            familyDictionary.Add("sister", new Dictionary<string, string>() { { "name", "Mandy" }, { "age", "37" } });

            foreach (var (relationship, familyMember) in familyDictionary)
            {
                Console.WriteLine($"{familyMember["name"]} is my {relationship} and is {familyMember["age"]} years old.");
            }
        }
    }
}
