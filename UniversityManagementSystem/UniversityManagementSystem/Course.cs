using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Course
    {
        public int Num { set; get; }
        private int corId;
        public int CorId { set; get; }

        private string corNm;
        public string CorNm
        {
            get { return CorNm; }
            set { CorNm = value; }
        }

        public int CorCr
        {
            get { return CorCr; }
            set { CorCr = value; }
        }

        public double CorTeachingHr
        {
            get { return CorTeachingHr; }
            set { CorTeachingHr = value; }
        }


        private Section[] sections;

        public int SecCount
        {
            get { return SecCount; }
            set { SecCount = value; }
        }

        public Course()
        {
            sections = new Section[10];
            SecCount = 0;
        }

        public Course(string CorNm, int CorId, int CorCr, double CorTeachingHr, int Num)
        {
            this.CorNm = CorNm;
            this.CorId = CorId;
            this.CorCr = CorCr;
            this.CorTeachingHr = CorTeachingHr;
            this.Num = Num;
            sections = new Section[10];
            SecCount = 0;
        }
        public void AddScetion(params Section[] sections)
        {
            foreach (var a in sections)
            {
                if (SecCount < 20)
                {
                    this.sections[SecCount++] = a;
                }
                else
                {
                    Console.WriteLine("Excuse me! You Cannot insert more section for that course : " + a.corId);
                }
            }
        }
        public void ShowAllTheSections()
        {
            for (int i = 0; i < SecCount; i++)
            {
                sections[i].ShowInfo();
            }
        }
        public Section SearchSection(int SecNum)
        {
            Section a = null;
            for (int i = 0; i < SecCount; i++)
            {
                if (sections[i].CorId.Equals(SecNum))
                {
                    a = sections[i];
                    break;
                }
            }
            return a;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + CorNm);
            Console.WriteLine("Course Id Number : " + CorId);
            Console.WriteLine("Course Credit Number : " + CorCr);
            Console.WriteLine("Course Teaching Hours : " + CorTeachingHr);

        }
        public void AddCorNum(int x)
        {
            Num += x;
        }

    }
}

