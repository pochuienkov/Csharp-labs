using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Campus : ICloneable
    {
        public string name, address;
        public int room, student, staff, income;

        public Campus() { }

        public Campus(string name, string address, int room, int student, int staff, int income)
        {
            this.name = name;
            this.address = address;
            this.room = room;
            this.student = student;
            this.staff = staff;
            this.income = income;
        }
        
        public object Cloneable()
        {
            return new Campus
            {
                name = this.name,
                address = this.address,
                room = this.room,
                student = this.student,
                staff = this.staff,
                income = this.income
            };
        }
    }
}
