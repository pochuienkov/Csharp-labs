using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Campus : ICloneable
    {
        public string name, address;
        public int room => list_room.Count;
        public int student => dictionary_student.Count;
        public int staff => list_worker.Count;
        public int income;
        public List<Room> list_room;
        private List<Worker> list_worker;
        private Dictionary<string, Student> dictionary_student;

        public Campus()
        {
            list_room = new List<Room>();
            list_worker = new List<Worker>();
            dictionary_student = new Dictionary<string, Student>();
        }

        public Campus(string name, string address, int income)
        {
            this.name = name;
            this.address = address;
            this.income = income;
            list_room = new List<Room>();
            list_worker = new List<Worker>();
            dictionary_student = new Dictionary<string, Student>();
        }

        public object Cloneable()
        {
            return new Campus
            {
                name = this.name,
                address = this.address,
                income = this.income
            };
        }

        public void NewStudent(Student student)
        {
            try
            {
                dictionary_student.Add(student.number, student);
            }
            catch
            {
            }
        }
    }
}
