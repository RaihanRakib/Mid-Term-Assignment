using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! Welcome to University Management System");
            Console.WriteLine("Developed by Kuratoli Software Solutions");
            Course c = new Course("C++", 101, 3, 5.0, 1);
            Course c1 = new Course("JAVA", 202, 3, 5.0, 2);
            Section s = new Section("A", "C++", 101, 3, 5.0, 1);
            Section s1 = new Section("B", "C++", 101, 3, 3.0, 1);
            Section s2 = new Section("C", "C++", 101, 3, 3.0, 1);
            Section s3 = new Section("D", "C++", 101, 3, 3.0, 1);
            Section s4 = new Section("E", "C++", 101, 3, 3.0, 1);
            Section s5 = new Section("AA", "JAVA", 202, 3, 3.0, 2);
            Section s6 = new Section("AB", "JAVA", 202, 3, 3.0, 2);
            Section s7 = new Section("AC", "JAVA", 202, 3, 3.0, 2);
            Section s8 = new Section("AD", "JAVA", 202, 3, 3.0, 2);
            Section s9 = new Section("AE", "JAVA", 202, 3, 3.0, 2);
            s.SearchSection(101);
            Console.WriteLine("Seacrhing Section.......");
            c.SearchSection(101);
            Console.WriteLine();
            c.ShowInfo();
            Console.WriteLine("````````````````````````````````````````");
            Departments d = new Departments("CSE");
            Departments d1 = new Departments("CSSE");
            Departments d2 = new Departments("CIS");
            Departments d3 = new Departments("SE");
            d.AddCourse(c1, c);
            d.ShowAllCourses();
            Console.WriteLine();
            Console.WriteLine("Adding Courses In Department......");
            d.AddCourse(s, s1, s2, s3, s4, s5, s6, s7, s8, s9);
            d.ShowAllCourses();
            Console.WriteLine("Information about Faculties who are taking courses");
            Faculty f = new Faculty("MD. TAnvir Ahmed", "19-1");
            Faculty f1 = new Faculty("MD. Rajib Hayat", "16-1");
            Faculty f2 = new Faculty("MD. Mohainin Bin Noor", "16-1");
            Faculty f3 = new Faculty("MD. Sohag Barman", "19-3");
            Faculty f4 = new Faculty("MD. Avijit Bowmik", "15-1");
            TeachingHour t = new TeachingHour("C language", 3, d);
            TeachingHour t1 = new TeachingHour("Data Base", 3, d);
            TeachingHour t2 = new TeachingHour("Java ", 3, d);
            TeachingHour t3 = new TeachingHour("TOC", 3, d);
            TeachingHour t4 = new TeachingHour("OS", 3, d);
            TeachingHour t5 = new TeachingHour("OOAD", 3, d);
            TeachingHour t6 = new TeachingHour("Accounting", 3, d2);
            TeachingHour t7 = new TeachingHour("COA", 3, d);
            TeachingHour t8 = new TeachingHour("DLC", 3, d1);
            TeachingHour t9 = new TeachingHour("DLD", 3, d1);
            TeachingHour t10 = new TeachingHour("MATH 1", 3, d1);
            TeachingHour t11 = new TeachingHour("MATH 2", 3, d1);
            TeachingHour t12 = new TeachingHour("ECO", 3, d2);
            TeachingHour t13 = new TeachingHour("MATH 3", 3, d2);
            TeachingHour t14 = new TeachingHour("BUSS COMM", 3, d2);
            TeachingHour t15 = new TeachingHour("MATH 4", 3, d3);
            TeachingHour t16 = new TeachingHour("CS MATH", 3, d3);
            TeachingHour t17 = new TeachingHour("C#", 3, d3);
            TeachingHour t18 = new TeachingHour("AI", 3, d);
            TeachingHour t19 = new TeachingHour("SE", 3, d);
            TeachingHour t20 = new TeachingHour("SQT", 3, d);
            Console.WriteLine("Faculty Informations are given below:");
            f.ShowInfo();
            f.AddCredit(t, t1, t2, t3, t4, t5, t18);
            f.ShowAllCredits();
            Console.WriteLine("Faculty Informations are given below:");
            f1.ShowInfo();
            f1.AddCredit(t6, t7, t8, t9, t10, t11, t12, t13);
            f1.ShowAllCredits();
            Console.WriteLine("Faculty Informations are given below:");
            f1.ShowInfo();
            f1.AddCredit(t, t1, t2, t3, t4, t5, t18, t19);
            f1.ShowAllCredits();
            Console.WriteLine("Faculty Informations are given below:");
            f1.ShowInfo();
            f1.AddCredit(t14, t15, t16, t17, t19, t20);
            f1.ShowAllCredits();


        }
    }
}
