using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Campus UAcampus = new Campus("НУРЕ", "Харків, просп. Науки, 14, 61166", 3300000);
        public List<Student> Students { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Worker> Workers { get; set; }

        public Form1()
        {
            Students = new List<Student>();
            Rooms = new List<Room>();
            Rooms.Add(new Room(1, RType.Standard, 4, 250, 0, "", ""));
            Rooms.Add(new Room(2, RType.Comfort, 2, 500, 0, "", ""));
            Rooms.Add(new Room(3, RType.Single, 1, 1000, 0, "", ""));
            Rooms.Add(new Room(4, RType.Standard, 4, 250, 0, "", ""));
            Rooms.Add(new Room(5, RType.Comfort, 2, 500, 0, "", ""));
            Rooms.Add(new Room(6, RType.Single, 1, 1000, 0, "", ""));
            Workers = new List<Worker>();
            Workers.Add(new Worker("Шевченко", "Данило", Job.Комендант, "40000", "8954745362"));
            Workers.Add(new Worker("Нагорний", "Юрій", Job.Завгосп, "30000", "5438276045"));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory($"CampusData");
            File.AppendAllText($"Data.txt", "");
            File.AppendAllText($"Data.txt", $"{UAcampus.name} - {UAcampus.address}");

            foreach (var room in Rooms)
            {
                File.AppendAllText($"CampusData\\Students.txt", "");
                File.AppendAllText($"CampusData\\Students.txt", $"{room.number} " + $"{room.type} " + $"{room.quantity} " + $"{room.cost} " + $"{room.already} " + $"{room.gender}");

                foreach (var number in room.student_number)
                {
                    File.AppendAllText($"CampusData\\Students.txt", $"{number} ");
                }
                File.AppendAllText($"CampusData\\Students.txt", $"\n");
            }

            foreach (var worker in Workers)
            {
                File.AppendAllText($"CampusData\\Workers.txt", "");
                File.AppendAllText($"CampusData\\Workers.txt", $"{worker.surname} " + $"{worker.name} " + $"{worker.job} " + $"{worker.salary} " + $"{worker.number}\n");
            }
            FillTable();
        }

        public void FillTable()
        {
            UAcampus.list_room = Rooms;
            foreach (var student in Students)
            {
                UAcampus.NewStudent(student);
            }
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Add(UAcampus.name, UAcampus.address, UAcampus.room, UAcampus.student, UAcampus.income);
            foreach (var worker in Workers)
            {
                dataGridView2.Rows.Add(worker.surname, worker.name, worker.job, worker.salary, worker.number);
            }
        } 

        public void ToString()
        {
            string str = (UAcampus.name + " " + UAcampus.address + " " + UAcampus.room + " " + UAcampus.student + " " + UAcampus.income);
            MessageBox.Show(str, "ToString");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex == 0) { MessageBox.Show("Дохід за місяць: " + UAcampus.income, "Розрахунок"); return; }
                if (listBox1.SelectedIndex == 1) { MessageBox.Show("Дохід за півроку: " + UAcampus.income * 6, "Розрахунок"); return; }
                if (listBox1.SelectedIndex == 2) { MessageBox.Show("Дохід за рік: " + UAcampus.income * 12, "Розрахунок"); return;  }
                else { MessageBox.Show("Оберіть період!", "Помилка"); }
            }
            catch { MessageBox.Show("Помилка!"); }
        }

        private void toStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToString();
        }

        private void створитиКлонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campus campus = (Campus)UAcampus.Cloneable();
            dataGridView1.Rows.Add(campus.name, campus.address, campus.room, campus.student, campus.income);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, Rooms, Students);
            form2.Show();
        }

        private void управлінняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Worker addworker = new Worker();
            try
            {
                if (String.IsNullOrWhiteSpace(textBox1.Text.ToString()) || String.IsNullOrWhiteSpace(textBox2.Text.ToString()) || String.IsNullOrWhiteSpace(comboBox1.Text.ToString()) ||
                    String.IsNullOrWhiteSpace(textBox3.Text.ToString()) || String.IsNullOrWhiteSpace(textBox4.Text.ToString()) || textBox4.Text.Length != 10 || !textBox4.Text.All(char.IsNumber) ||
                    Int32.Parse(textBox3.Text) < 8000 || Int32.Parse(textBox3.Text) > 40000)
                {
                    MessageBox.Show("Помилка!");
                    return;
                }
                switch (comboBox1.Text)
                {
                    case "Комендант":
                        {
                            addworker.job = Job.Комендант;
                            break;
                        }
                    case "Завгосп":
                        {
                            addworker.job = Job.Завгосп;
                            break;
                        }
                    case "Охоронець":
                        {
                            addworker.job = Job.Охоронець;
                            break;
                        }
                    case "Прибиральник":
                        {
                            addworker.job = Job.Прибиральник;
                            break;
                        }
                    default:
                        MessageBox.Show("Помилка!");
                        break;
                }
                addworker.surname = textBox1.Text;
                addworker.name = textBox2.Text;
                addworker.salary = textBox3.Text;
                addworker.number = textBox4.Text;
                foreach (var worker in Workers)
                {
                    if (addworker.number == worker.number)
                    {
                        MessageBox.Show("Податковий номер вже існує!", "Помилка!");
                        return;
                    }
                }
                Workers.Add(addworker);
                File.AppendAllText($"CampusData\\Workers.txt", "");
                File.AppendAllText($"CampusData\\Workers.txt", $"{addworker.surname} " + $"{addworker.name} " + $"{addworker.job} " + $"{addworker.salary} " + $"{addworker.number}\n");
                FillTable();
            }
            catch
            {
                MessageBox.Show("Помилка");
            }
        }
    }
}
