using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFrameWork
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the  Case Number ");
            int x = Convert.ToInt32(Console.ReadLine()); 
            switch (x) 
            {
                case 1:
                Dictionary<int,string> student = new Dictionary<int,string>();
                    student.Add(1, "Aman");
                    student.Add(2, "Mohan");
                    student.Add(3, "Rohan");
                    student.Add(4, "Sohan");
                    foreach(KeyValuePair<int,string> kv in student)
                    {
                        Console.WriteLine(kv.Key+" "+kv.Value);
                    }
                    Console.WriteLine("Enter the Key");
                    int j = Convert.ToInt32(Console.ReadLine());
                    if (student.ContainsKey(j))
                    {
                        Console.WriteLine("Student name found is :" + student[j]);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                    Console.WriteLine(student.Remove(j));
                    break;
                case 2:
                    SortedDictionary<int, string> student1 = new SortedDictionary<int, string>();
                    student1.Add(4, "Aman");
                    student1.Add(2, "Mohan");
                    student1.Add(1, "Rohan");
                    student1.Add(3, "Sohan");
                    foreach (KeyValuePair<int, string> kv in student1)
                    {
                        Console.WriteLine(kv.Key + " " + kv.Value);
                    }
                    break;
                    case 3:
                      SortedList<int,string> std = new SortedList<int,string>();
                    std.Add(4, "Aman");
                    std.Add(2, "Mohan");
                    std.Add(1, "Rohan");
                    std.Add(3, "Sohan");
                    foreach(KeyValuePair<int, string> kv in std)
                    {
                        Console.WriteLine(kv.Key+" "+kv.Value);
                    }
                    Console.WriteLine("Enter the key to search for Name: ");
                    int z = Convert.ToInt32(Console.ReadLine());
                    if (std.ContainsKey(z))
                    {
                        Console.WriteLine("Student Name Found is :" + std[z]);
                    }
                    std.Remove(z);
                    foreach (KeyValuePair<int, string> kv in std)
                    {
                        Console.WriteLine(kv.Key + " " + kv.Value);
                    }
                    break;

                    case 4:
                    int N = 4;
                    List<int> startPages = new List<int> { 1, 5, 9, 17 };
                    List<int> endPages = new List<int> { 4, 7, 16, 26 };
                    int K = 7;
                    int currentChapter = 0;
                    for (int i = 0; i < N; i++)
                    {
                        if (K >= startPages[i] && K <= endPages[i])
                        {
                            currentChapter = i;
                            break;
                        }
                    }
                    int chaptersLeft = N - currentChapter;
                    Console.WriteLine(chaptersLeft);
                    break;
                default:
                    Console.WriteLine("Case don't match");
                break;
            }
            Console.ReadLine();
        }
    }
}
