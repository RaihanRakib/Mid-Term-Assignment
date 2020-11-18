using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem
{
    class TeachingHour
    {
        public string CorNm { get; set; }
        public int CorCrNum { get; set; }
        public Departments Departments { get; set; }
        Course[] courses;
        public int CrCount { get; set; }
        public TeachingHour()
        {
            courses = new Course[5];
        }
        public TeachingHour(string corNm, int corCrNum, Departments departments)
        {
            CorNm = corNm;
            CorCrNum = corCrNum;
            Departments = departments;
            courses = new Course[5];
        }
        public void AddTeachingHours(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (CrCount < 7)
                    this.courses[CrCount++] = course;
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine("The Course Name is : " + CorNm);
            Console.WriteLine("The Course Credit Number is : " + CorCrNum);
            for (int i = 0; i < CrCount; i++)
            {
                courses[i].ShowInfo();
            }
        }
    }
}
