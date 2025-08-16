using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void PrintStudents(SortedDictionary<int, string> students)
        {
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("ID: " + student.Key + ", Name: " + student.Value);
            }
        }

        static void PrintEmployees(SortedList<int, string> employees)
        {
            foreach (KeyValuePair<int, string> emp in employees)
            {
                Console.WriteLine("ID: " + emp.Key + ", Name: " + emp.Value);
            }
        }
        static void Main(string[] args)
        {
            //#region Task (1)
            //int[] numbers = { 1, 2, 2, 3, 1, 4, 2, 3, 3, 3 };


            //Dictionary<int, int> frequency = new Dictionary<int, int>();


            //foreach (int num in numbers)
            //{
            //    if (frequency.ContainsKey(num))
            //    {
            //        frequency[num]++; // Increment count
            //    }
            //    else
            //    {
            //        frequency[num] = 1; // First occurrence
            //    }
            //}


            //Console.WriteLine("Element\tFrequency");
            //foreach (KeyValuePair<int, int> pair in frequency)
            //{
            //    Console.WriteLine(pair.Key + "\t" + pair.Value);
            //}
            //#endregion

            /* ========================= */

            //#region Task (2)

            //Hashtable table = new Hashtable();
            //table["A"] = 10;
            //table["B"] = 25;
            //table["C"] = 18;
            //table["D"] = 25;

            //object maxKey = null;
            //int maxValue = int.MinValue;

            //foreach (DictionaryEntry entry in table)
            //{
            //    int value = (int)entry.Value;
            //    if (value > maxValue)
            //    {
            //        maxValue = value;
            //        maxKey = entry.Key;
            //    }
            //}

            //Console.WriteLine("Key with highest value: " + maxKey);
            //Console.WriteLine("Highest value: " + maxValue);
            //#endregion

            /* =============================== */

            //#region Task (3)
            //Hashtable table = new Hashtable();
            //table["key1"] = "apple";
            //table["key2"] = "banana";
            //table["key3"] = "apple";


            //Console.Write("Enter target value: ");
            //string targetValue = Console.ReadLine();

            //bool found = false;


            //foreach (DictionaryEntry entry in table)
            //{
            //    if (entry.Value.ToString().Equals(targetValue, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine(entry.Key);
            //        found = true;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("Key not found");
            //}
            //#endregion

            /* ========================= */

            //#region Task (4)
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };


            //Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            //foreach (string word in words)
            //{
            //    char[] chars = word.ToCharArray();
            //    Array.Sort(chars); 
            //    string sortedWord = new string(chars);

            //    if (!anagramGroups.ContainsKey(sortedWord))
            //    {
            //        anagramGroups[sortedWord] = new List<string>();
            //    }
            //    anagramGroups[sortedWord].Add(word);
            //}


            //foreach (KeyValuePair<string, List<string>> group in anagramGroups)
            //{
            //    Console.WriteLine(string.Join(", ", group.Value));
            //}
            //#endregion

            /* ========================= */

            //#region Task (5)
            //int[] numbers = { 1, 2, 3, 4, 5, 2 };

            //bool hasDuplicate = false;
            //HashSet<int> seen = new HashSet<int>();

            //foreach (int num in numbers)
            //{
            //    if (seen.Contains(num))
            //    {
            //        hasDuplicate = true;
            //        break; // No need to check further
            //    }
            //    seen.Add(num);
            //}

            //if (hasDuplicate)
            //    Console.WriteLine("Array contains duplicates");
            //else
            //    Console.WriteLine("Array does not contain duplicates");
            //#endregion

            /* ========================= */

            //#region Task (6)

            //SortedDictionary<int, string> students = new SortedDictionary<int, string>();


            //students.Add(102, "Alice");
            //students.Add(101, "Bob");
            //students.Add(103, "Charlie");

            //Console.WriteLine("Students after adding:");
            //PrintStudents(students);


            //students.Remove(101);
            //Console.WriteLine("\nStudents after removing ID 101:");
            //PrintStudents(students);


            //int searchId = 103;
            //if (students.ContainsKey(searchId))
            //{
            //    Console.WriteLine("\nStudent with ID " + searchId + ": " + students[searchId]);
            //}
            //else
            //{
            //    Console.WriteLine("\nStudent ID not found.");
            //}

            //#endregion

            /* ========================= */

            //#region Task (7)

            //SortedList<int, string> employees = new SortedList<int, string>();


            //employees.Add(102, "Alice");
            //employees.Add(101, "Bob");
            //employees.Add(103, "Charlie");

            //Console.WriteLine("Employee Directory:");
            //PrintEmployees(employees);


            //employees.Remove(101);
            //Console.WriteLine("\nAfter removing employee with ID 101:");
            //PrintEmployees(employees);


            //int searchId = 103;
            //if (employees.ContainsKey(searchId))
            //{
            //    Console.WriteLine("\nEmployee with ID " + searchId + ": " + employees[searchId]);
            //}
            //else
            //{
            //    Console.WriteLine("\nEmployee ID not found.");
            //}


            //int index = 0;
            //Console.WriteLine("\nEmployee at index " + index + ": " + employees.Values[index]);
            //#endregion

            /* ========================= */

            //    #region Task (8)
            //    int N = 10;
            //    int[] numbers = { 1, 2, 4, 5, 7, 9, 10 };

            //    List<int> missingNumbers = FindMissingNumbers(numbers, N);

            //    Console.WriteLine("Missing numbers: " + string.Join(", ", missingNumbers));


            //static List<int> FindMissingNumbers(int[] arr, int N)
            //    {
            //        HashSet<int> present = new HashSet<int>(arr);
            //        List<int> missing = new List<int>();

            //        for (int i = 1; i <= N; i++)
            //        {
            //            if (!present.Contains(i))
            //            {
            //                missing.Add(i);
            //            }
            //        }

            //        return missing;
            //    }
            //    #endregion

            /* ========================= */

            //#region Task (9)
            //List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 1 };

            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            //Console.WriteLine("Unique values:");
            //foreach (int num in uniqueNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            //#endregion

            /* ========================= */

            //#region Task (10)
            //Hashtable original = new Hashtable();
            //original["A"] = 1;
            //original["B"] = 2;
            //original["C"] = 3;


            //Hashtable swapped = new Hashtable();

            //foreach (DictionaryEntry entry in original)
            //{
            //    swapped[entry.Value] = entry.Key;
            //}

            //Console.WriteLine("Swapped Hashtable:");
            //foreach (DictionaryEntry entry in swapped)
            //{
            //    Console.WriteLine(entry.Key + " -> " + entry.Value);
            //}
            //#endregion

            /* ========================= */

            //#region Task (11)
            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };


            //HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };


            //set1.UnionWith(set2); 

            //Console.WriteLine("Union of sets:");
            //foreach (int num in set1)
            //{
            //    Console.WriteLine(num);
            //}
            //#endregion

            /* ========================= */

            //#region Task (12)
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //dict["apple"] = 1;
            //dict["animal"] = 2;
            //dict["airport"] = 3;
            //dict["banana"] = 4;


            //Console.Write("Enter target character: ");
            //char targetChar = Console.ReadLine()[0]; 

            //int count = 0;

            //foreach (string key in dict.Keys)
            //{
            //    if (key.StartsWith(targetChar.ToString(), StringComparison.OrdinalIgnoreCase))
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine("Number of keys starting with '" + targetChar + "': " + count);
            //#endregion

            /* ========================= */

            //#region Task (13)

            //SortedSet<int> numbers = new SortedSet<int>() { 2, 5, 7, 10, 15, 20 };


            //Console.Write("Enter target number: ");
            //int target = int.Parse(Console.ReadLine());


            //List<int> greaterThanTarget = new List<int>();

            //foreach (int num in numbers)
            //{
            //    if (num > target)
            //    {
            //        greaterThanTarget.Add(num);
            //    }
            //}


            //if (greaterThanTarget.Count > 0)
            //{
            //    Console.WriteLine("Numbers greater than " + target + " are => " + string.Join(", ", greaterThanTarget));
            //}
            //else
            //{
            //    Console.WriteLine("didn't find Numbers greater than " + target);
            //}
            //#endregion

            /* ========================= */

            #region Task (14)
            
            SortedList<int, int> sortedList = new SortedList<int, int>();

           
            sortedList.Add(101, 5);
            sortedList.Add(102, 8);
            sortedList.Add(103, 12);
            sortedList.Add(104, 7);
            sortedList.Add(105, 10);

            
            List<int> keysWithEvenValues = new List<int>();

            foreach (KeyValuePair<int, int> entry in sortedList)
            {
                if (entry.Value % 2 == 0) // check even
                {
                    keysWithEvenValues.Add(entry.Key);
                }
            }

            
            if (keysWithEvenValues.Count > 0)
            {
                Console.WriteLine("Keys with even values: " + string.Join(", ", keysWithEvenValues));
            }
            else
            {
                Console.WriteLine("No keys found with even values.");
            }
            #endregion
        }
    }
}
