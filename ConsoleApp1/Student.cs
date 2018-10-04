using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student:Human, IComparable<Student>
    {
        public int Mark { get; set; }

        public int CompareTo(Student other)
        {
            return this.Mark.CompareTo(other.Mark);
        }
    }
}
