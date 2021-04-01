using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Saif", "18-38710-3", 3.2f);
            Student s2 = new Student("Mridul", "18-38296-3", 3.5f);
            Department d1 = new Department("Computer Science", "CSE");
            s1.Department = d1;
            s2.Department = d1;
            d1.AddStudent(s1);
            d1.AddStudent(s2);
            d1.AllStudents();
        }
    }
}
