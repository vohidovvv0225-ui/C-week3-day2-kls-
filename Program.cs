// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Person
// {
//     public string Name;
//     public int Age;

//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("=== 1 ===");
//         List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
//         Console.WriteLine(numbers1.Sum());

//         Console.WriteLine("\n=== 2 ===");
//         List<string> words2 = new List<string>
//         {
//             "Hi", "Hello", "Programming", "Cat"
//         };
//         words2 = words2.OrderByDescending(x => x.Length).ToList();
//         Console.WriteLine(string.Join(", ", words2));

//         Console.WriteLine("\n=== 3 ===");
//         List<Person> people3 = new List<Person>
//         {
//             new Person("Ali", 20),
//             new Person("Vali", 16),
//             new Person("Hasan", 25)
//         };
//         people3 = people3.OrderBy(x => x.Age).ToList();

//         foreach (Person p in people3)
//             Console.WriteLine($"{p.Name} - {p.Age}");

//         Console.WriteLine("\n=== 4 ===");
//         List<int> numbers4 = new List<int> { 2, 5, 8, 1, 10, 3 };
//         int limit = 5;
//         numbers4.RemoveAll(x => x < limit);
//         Console.WriteLine(string.Join(", ", numbers4));

//         Console.WriteLine("\n=== 5 ===");
//         List<string> words5 = new List<string>
//         {
//             "hello", "world", "csharp"
//         };
//         words5 = words5.Select(x => x.ToUpper()).ToList();
//         Console.WriteLine(string.Join(", ", words5));

//         Console.WriteLine("\n=== 6 ===");
//         List<int> numbers6 = new List<int> { 10, 3, 25, 7, 1 };
//         Console.WriteLine("Max: " + numbers6.Max());
//         Console.WriteLine("Min: " + numbers6.Min());

//         Console.WriteLine("\n=== 7 ===");
//         List<string> words7 = new List<string>
//         {
//             "cat", "hello", "dog"
//         };

//         foreach (string word in words7)
//         {
//             bool unique = word.Distinct().Count() == word.Length;
//             Console.WriteLine($"{word}: {unique}");
//         }

//         Console.WriteLine("\n=== 8 ===");
//         List<Person> people8 = new List<Person>
//         {
//             new Person("Ali", 20),
//             new Person("Vali", 30),
//             new Person("Hasan", 25)
//         };
//         Console.WriteLine(people8.Average(x => x.Age));

//         Console.WriteLine("\n=== 9 ===");
//         List<int> numbers9 = new List<int>
//         {
//             1, 2, 2, 3, 4, 4, 5
//         };
//         numbers9 = numbers9.Distinct().ToList();
//         Console.WriteLine(string.Join(", ", numbers9));

//         Console.WriteLine("\n=== 10 ===");
//         List<string> words10 = new List<string>
//         {
//             "level", "hello", "madam", "cat"
//         };

//         foreach (string word in words10)
//         {
//             string reversed = new string(word.Reverse().ToArray());
//             Console.WriteLine($"{word}: {word == reversed}");
//         }

//         Console.WriteLine("\n=== 11 ===");
//         List<Person> people11 = new List<Person>
//         {
//             new Person("Ali", 20),
//             new Person("Vali", 15),
//             new Person("Hasan", 25)
//         };
//         people11 = people11.Where(x => x.Age > 18).ToList();

//         foreach (Person p in people11)
//             Console.WriteLine($"{p.Name} - {p.Age}");

//         Console.WriteLine("\n=== 12 ===");
//         List<string> words12 = new List<string>
//         {
//             "Apple", "Banana", "Orange"
//         };
//         Console.WriteLine(string.Join(", ", words12));

//         Console.WriteLine("\n=== 13 ===");
//         List<int> numbers13 = new List<int>
//         {
//             10, 20, 30, 40, 50
//         };
//         int sum13 = 0;

//         for (int i = 1; i < numbers13.Count; i += 2)
//             sum13 += numbers13[i];

//         Console.WriteLine(sum13);

//         Console.WriteLine("\n=== 14 ===");
//         List<string> words14 = new List<string>
//         {
//             "Cat", "Programming", "Hello", "World"
//         };
//         Console.WriteLine(words14.OrderByDescending(x => x.Length).First());

//         Console.WriteLine("\n=== 15 ===");
//         List<Person> people15 = new List<Person>
//         {
//             new Person("Vali", 20),
//             new Person("Ali", 18),
//             new Person("Hasan", 25)
//         };
//         people15 = people15.OrderBy(x => x.Name).ToList();

//         foreach (Person p in people15)
//             Console.WriteLine(p.Name);

//         Console.WriteLine("\n=== 16 ===");
//         List<int> numbers16 = new List<int>
//         {
//             1, 2, 3, 4, 5, 6
//         };
//         int target = 7;

//         for (int i = 0; i < numbers16.Count; i++)
//         {
//             for (int j = i + 1; j < numbers16.Count; j++)
//             {
//                 if (numbers16[i] + numbers16[j] == target)
//                 {
//                     Console.WriteLine(
//                         $"{numbers16[i]} + {numbers16[j]} = {target}");
//                 }
//             }
//         }

//         Console.WriteLine("\n=== 17 ===");
//         List<Person> people17 = new List<Person>
//         {
//             new Person("Ali", 18),
//             new Person("Vali", 25),
//             new Person("Hasan", 30)
//         };
//         people17 = people17.Where(x => x.Age > 20).ToList();

//         foreach (Person p in people17)
//             Console.WriteLine($"{p.Name} - {p.Age}");

//         Console.WriteLine("\n=== 18 ===");
//         List<string> words18 = new List<string>
//         {
//             "I love CSharp",
//             "Hello world",
//             "CSharp is easy",
//             "Good morning"
//         };
//         words18.RemoveAll(x => x.Contains("CSharp"));

//         foreach (string word in words18)
//             Console.WriteLine(word);

//         Console.WriteLine("\n=== 19 ===");
//         List<int> numbers19 = new List<int>
//         {
//             -5, 10, -3, 7, -8
//         };
//         numbers19 = numbers19.Select(x => Math.Abs(x)).ToList();
//         Console.WriteLine(string.Join(", ", numbers19));

//         Console.WriteLine("\n=== 20 ===");
//         List<Person> people20 = new List<Person>
//         {
//             new Person("Ali", 20),
//             new Person("Vali", 20),
//             new Person("Hasan", 25),
//             new Person("Karim", 25),
//             new Person("Ahmad", 30)
//         };

//         var groups = people20.GroupBy(x => x.Age);

//         foreach (var group in groups)
//         {
//             Console.WriteLine("Age: " + group.Key);

//             foreach (Person p in group)
//                 Console.WriteLine(p.Name);
//         }
//     }
// }
