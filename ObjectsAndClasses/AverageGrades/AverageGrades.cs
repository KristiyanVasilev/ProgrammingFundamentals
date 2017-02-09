namespace AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            var studentName = "";
            var grade = 0.0;
            
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToArray();
                studentName = line[0];
                if (students.ContainsKey(studentName))
                {
                    studentName += i;
                }

                for (int j = 1; j < line.Length; j++)
                {
                    grade = double.Parse(line[j]);
                    if (!students.ContainsKey(studentName))
                    {
                        students[studentName] = new List<double>();
                    }                   
                    students[studentName].Add(grade);
                }
            }
            var goodGrade = new SortedDictionary<string, double>();
            foreach (var student in students)
            {
                var name = student.Key;
                var average = student.Value.Average();
                if (average >= 5.00)
                {
                    goodGrade[name] = average;
                }
            }
            foreach (var guy in goodGrade)
            {
                Console.WriteLine($"{guy.Key:f2} -> {guy.Value:f2}");
            }
        }
    }
}
