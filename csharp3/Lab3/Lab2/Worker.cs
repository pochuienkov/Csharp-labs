using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Worker
    {
        public string surname { get; set; }
        public string name { get; set; }
        public Job job { get; set; }
        public string salary { get; set; }
        public string number { get; set; }

        public Worker(string surname, string name, Job job, string salary, string number)
        {
            this.surname = surname;
            this.name = name;
            this.job = job;
            this.salary = salary;
            this.number = number;
        }

        public Worker() { }
    }
    public enum Job
    {
        Комендант,
        Завгосп,
        Охоронець,
        Прибиральник
    }
}