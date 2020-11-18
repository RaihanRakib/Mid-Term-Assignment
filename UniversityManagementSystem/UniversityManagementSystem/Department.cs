using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Departments
    {
        public string DepartmentName { get; set; }
        Course[] listOfCourses;
        public int totalCourse { get; set; }
        public Section Section { get; set; }
        TeachingHour[] teachingHrs;
        public int CreditCount { get; set; }
        public Departments()
        {
            listOfCourses = new Course[100];
            teachingHrs = new TeachingHour[1000];
        }
        public Departments(string name)
        {
            DepartmentName = name;
            listOfCourses = new Course[100];
            teachingHrs = new TeachingHour[1000];


        }
        public void ShowInfo()
        {
            Console.WriteLine("Name Of The Department: " + DepartmentName);
            Console.WriteLine("Total Number Of Courses: " + totalCourse);
        }
        public void AddCourse(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (totalCourse < 100)
                    listOfCourses[totalCourse++] = course;
            }
        }
        public void RemoveCourse(Course course)
        {
            for (int i = 0; i < totalCourse; i++)
            {
                if (course.CorId.Equals(listOfCourses[i].CorId))
                {
                    for (int j = i; j < totalCourse - 1; j++)
                    {
                        listOfCourses[j] = listOfCourses[j + 1];
                    }
                    totalCourse--;
                    break;
                }

            }
        }
        public void AddNewCourseNumber(Course cor, int num)
        {
            cor.AddCorNum(num);
        }
        public Course SearchCourse(string id)
        {
            Course b = null;
            for (int i = 0; i < totalCourse; i++)
            {
                if (listOfCourses[i].CorId.Equals(id))
                {
                    b = listOfCourses[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllCourses()
        {
            for (int i = 0; i < totalCourse; i++)
            {
                listOfCourses[i].ShowInfo();
            }
        }
        public void AddTeachingHours(TeachingHour teachingHr)
        {
            teachingHrs[CreditCount++] = teachingHr;
        }
        public void ShowAllCredits()
        {

            for (int i = 0; i < CreditCount; i++)
            {
                Console.WriteLine("Department");
                teachingHrs[i].Departments.ShowInfo();
                Console.WriteLine("Teaching  Hours");
                teachingHrs[i].ShowInfo();
                Console.WriteLine();
            }

        }


    }
}
