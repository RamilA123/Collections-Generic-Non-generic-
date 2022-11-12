using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //DateTime start = DateTime.Now.AddDays(-2);
            //DateTime end = DateTime.Now.AddDays(20);
            //double salary = 2000;

            //// double salary = 2000;
            ////IEmployeeService employeeService = new EmployeeService();
            ////int result =  employeeService.GetFilteredEmployeesCount(start, end, salary);
            ////Console.WriteLine(result);

            //var result = GetEmployeesCount(start, end, salary);
            //Console.WriteLine("Person count: " + result);
            #endregion

            #region Task 1 - Author adli list yaratmaq

            //List<Author> authors = new List<Author>();
            //authors.Add(new Author { Name = "Ferid", Surname = "Huseynov", Age = 25 });
            //authors.Add(new Author { Name = "Pervin", Surname = "Memmedov", Age = 45 });
            //authors.Add(new Author { Name = "Kamran", Surname = "Agayev", Age = 30 });
            //authors.Add(new Author { Name = "Ehmed", Surname = "Veliyev", Age = 55 });
            //authors.Add(new Author { Name = "Nicat", Surname = "Qurbanov", Age = 15 });
            //ShowNamesAndSurnames(authors);

            #endregion

            #region List
            //List<int> nums = new List<int>() { 200, 300, 400, 500 };

            //List<int> numbers = new List<int>();

            //numbers.Add(11);
            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(111);
            //numbers.Add(112);
            //numbers.Add(91);
            //numbers.Add(11);

            //numbers.AddRange(nums);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers.Contains(5);

            //var result = numbers.Find(m => m > 100); 

            //var result = numbers.FindLast(m => m > 100);

            //var result = numbers.FindAll(m => m > 100);

            //var result = numbers.FindIndex(m => m > 100);

            //var result = numbers.FindLastIndex(m => m > 100);

            //numbers.Sort();

            //var result = numbers.ToArray();

            //var result2 = result.ToList();

            //var result = numbers.BinarySearch(11);

            //Console.WriteLine(result);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //if (result)
            //{
            //    Console.WriteLine("Yes");
            //}


            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

            //var result = names.FindAll(m => m == "Nicat");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var searchText = Console.ReadLine();

            //var result = Search(names, searchText);

            //if (result.Count == 0)
            //{
            //    Console.WriteLine("Not found");
            //}
            //else
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine(result.Count());

            //List<Person> people = new List<Person>();
            //people.Add(new Person { FullName = "Qoshqar Nerimanli", Birthday = DateTime.Now.AddDays(-10), Salary = 1500 });
            //people.Add(new Person { FullName = "Ramil Allahverdiyev", Birthday = DateTime.Now.AddDays(10), Salary = 1700 });
            //people.Add(new Person { FullName = "Nihad Veliyev", Birthday = DateTime.Now.AddDays(12), Salary = 1800 });
            //people.Add(new Person { FullName = "Gultac Ceferova", Birthday = DateTime.Now.AddDays(10), Salary = 2500 });

            //var result = people.FindAll(m => m.Salary > 1600 && m.FullName.StartsWith("R"));
            //foreach (var person in result)
            //{
            //    Console.WriteLine("FullName: {0}, Birthday: {1}, Salary: {2}", person.FullName, person.Birthday, person.Salary);
            //}
            #endregion

            //Hashtable hastable = new Hashtable();
            //hastable.Add(1, "Resul");
            //hastable.Add(2, "Nicat");
            //hastable.Add(3, "Vuqar");


            //foreach (DictionaryEntry item  in hastable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList sortedlist = new SortedList();

            //sortedlist.Add(1, "Resul");
            //sortedlist.Add(2, "Nicat");
            //sortedlist.Add(3, "Vuqar");

            //foreach (DictionaryEntry item in sortedlist)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //ArrayList arraylist = new ArrayList();
            //arraylist.Add("salam");
            //arraylist.Add(555);

            //foreach (var item in arraylist)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList<string, string> list = new SortedList<string, string>();

            //list.Add("Admin", "Qoshqar");
            //list.Add("Member", "Test");

            //foreach (KeyValuePair<string,string> item in list)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Dictionary<string, string> dictionarylist = new Dictionary<string, string>();
            //dictionarylist.Add("Admin", "Ramil");

            //Console.WriteLine(dictionarylist["Admin"]);

            //foreach (KeyValuePair<string, string> item in dictionarylist)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(5);
            //queue.Enqueue(10);
            //queue.Enqueue(3);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();
            //stack.Push(11);
            //stack.Push(22);
            //stack.Push(3);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in hastable.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in hastable.Values)
            //{
            //    Console.WriteLine(item);
            //}

        }

        private static List<string> Search(List<string> datas, string str)
        {
            var result = datas.FindAll(m => m.ToLower().Contains(str.ToLower()));
            return result;
        }

        //public static int GetEmployeesCount(DateTime start, DateTime end, double salary)
        //{
        //    Person person1 = new Person(DateTime.Now.AddDays(5), 3000);
        //    Person person2 = new Person(DateTime.Now.AddDays(15), 6000);
        //    Person person3 = new Person(DateTime.Now.AddDays(10), 1000);
        //    Person person4 = new Person(DateTime.Now.AddDays(25), 2500);

        //    Person[] people = { person1, person2, person3, person4 };
            
        //    int count = 0;

        //    foreach (Person person in people)
        //    {
        //        if ((person.Birthday > start && person.Birthday < end) && person.Salary > salary)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}


        private static void ShowNamesAndSurnames(List<Author> authors)
        {
            var result = authors.FindAll(m => m.Age > 40);
            foreach (var author in result)
            {
                Console.WriteLine("Name: {0}, Surname: {1}", author.Name, author.Surname);
            }

        }
    }
}
