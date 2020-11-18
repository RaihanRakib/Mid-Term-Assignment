using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Section : Course
    {
        private string secNm;

        public string SecNm
        {
            get { return SecNm; }
            set { SecNm = value; }
        }

        public Section() { }
        public Section(string SecNm, string CorNm, int CorId, int CorCr, double CorTeachingHr, int Num) : base(CorNm, CorId, CorCr, CorTeachingHr, Num)
        {
            this.SecNm = SecNm;
        }
        virtual public void ShowSectionInfo()
        {
            Console.WriteLine("Section Name : " + SecNm);

        }
    }
}

