using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string faculty { get; set; }
        public string gender { get; set; }
        public string group { get; set; }
        public string number { get; set; }
        public Course course { get; set; }
    }
    public enum Course
    {
        I,
        II,
        III,
        IV,
        V
    }
}