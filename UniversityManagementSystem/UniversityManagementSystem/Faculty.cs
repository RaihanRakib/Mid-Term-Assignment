using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem
{
    class Faculty
    {
        public string FacultyNm { get; set; }
        public string FacultyId { get; set; }
        TeachingHour[] teachingHrs;
        public int CreditCount { get; set; }
        public Faculty()
        {
            teachingHrs = new TeachingHour[100];
        }
        public Departments Departments { get; set; }

        public Faculty(string facultyNm, string facultyId)
        {
            this.FacultyNm = facultyNm;
            this.FacultyId = facultyId;
            teachingHrs = new TeachingHour[100];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + FacultyNm);
            Console.WriteLine("Id: " + FacultyId);
        }
        public void AddCredit(params TeachingHour[] teaching_Hour)
        {
            foreach (var a in teaching_Hour)
            {
                if (CreditCount < 7)
                {
                    this.teachingHrs[CreditCount++] = a;

                }
                else
                {
                    Console.WriteLine("Note:Sir/Maam your maximum credit limit is 21 Credits");
                    Console.WriteLine("Cannot take any more course credit : " + a.CrCount);
                }

            }


        }
        public void ShowAllCredits()
        {
            Console.WriteLine();
            for (int i = 0; i < CreditCount; i++)
            {
                teachingHrs[i].ShowInfo();
            }
        }
    }
}
