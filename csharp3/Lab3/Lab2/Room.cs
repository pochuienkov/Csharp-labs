using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Room
    {
        public int number { get; set; }
        public RType type { get; set; }
        public int quantity { get; set; }
        public double cost { get; set; }
        public int already { get; set; }
        public List<string> student_number { get; set; }
        public string gender { get; set; }

        public Room(int number, RType type, int quantity, double cost, int already, string student_number, string gender)
        {
            this.number = number;
            this.type = type;
            this.quantity = quantity;
            this.cost = cost;
            this.already = already;
            this.gender = gender;
            this.student_number = new List<string>();
            this.student_number.Add(student_number);
            switch (type)
            {
                case RType.Single:
                    {
                        quantity = 1;
                        cost = 1000;
                        break;
                    }
                case RType.Comfort:
                    {
                        quantity = 2;
                        cost = 500;
                        break;
                    }
                case RType.Standard:
                    {
                        quantity = 4;
                        cost = 250;
                        break;
                    }
                default:
                    quantity = 1;
                    break;
            }
        }
    }
    public enum RType
    {
        Standard,
        Comfort,
        Single
    }
}