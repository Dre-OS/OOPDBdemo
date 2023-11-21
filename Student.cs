using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPDBdemo
{
    internal class Student
    {
        public string idnumber { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string course { get; set; }

        public Student()
        {
            idnumber= string.Empty;
            lastname= string.Empty;
            firstname= string.Empty;
            course= string.Empty;
        }

    }
}
