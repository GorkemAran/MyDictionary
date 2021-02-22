using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {   //int for student id, string for student name
            MyDictionary<int,string> students = new MyDictionary<int, string>();
            students.Add(1, "Görkem");
        }
    }
}
