using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form1 form { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Student> Students { get; set; }
        public Form2(Form1 form, List<Room> Rooms, List<Student> Students)
        {
            this.form = form;
            this.Rooms = this.form.Rooms;
            this.Students = this.form.Students;
            InitializeComponent();
        }

        private void FillTable1()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            foreach (var student in Students)
            {
                dataGridView1.Rows.Add(student.surname, student.name, student.patronymic, student.faculty, student.gender, student.group, student.number, student.course);
            }
            foreach (var room in Rooms)
            {
                string str = "";
                foreach (var stud in room.student_number)
                {
                    str += stud + " . ";
                }
                dataGridView2.Rows.Add(room.number, room.type, room.quantity, room.cost, room.already, str, room.gender);
            }
        }

        private void GetStudent()
        {
            Student addstudent = new Student();
            try
            {
                if (String.IsNullOrWhiteSpace(textBox1.Text.ToString()) || String.IsNullOrWhiteSpace(textBox2.Text.ToString()) || String.IsNullOrWhiteSpace(textBox3.Text.ToString()) ||
                    String.IsNullOrWhiteSpace(textBox4.Text.ToString()) || String.IsNullOrWhiteSpace(comboBox1.Text.ToString()) || String.IsNullOrWhiteSpace(textBox6.Text.ToString()) ||
                    String.IsNullOrWhiteSpace(textBox5.Text.ToString()) || textBox6.Text.Length != 8 || String.IsNullOrWhiteSpace(comboBox2.Text.ToString()))
                {
                    MessageBox.Show("Помилка!");
                    return;
                }
                switch (comboBox2.Text)
                {
                    case "I":
                        {
                            addstudent.course = Course.I;
                            break;
                        }
                    case "II":
                        {
                            addstudent.course = Course.II;
                            break;
                        }
                    case "III":
                        {
                            addstudent.course = Course.III;
                            break;
                        }
                    case "IV":
                        { 
                        addstudent.course = Course.IV;
                        break;
                        }
                    case "V":
                        {
                            addstudent.course = Course.V;
                            break;
                        }
                    default:
                        MessageBox.Show("Помилка!");
                        break;
                }
                switch (comboBox1.Text)
                {
                    case "Чоловік":
                        {
                            addstudent.gender = "Чоловік";
                            break;
                        }
                    case "Жінка":
                        {
                            addstudent.gender = "Жінка";
                            break;
                        }
                    default:
                        MessageBox.Show("Помилка!");
                        break;
                }
                addstudent.surname = textBox1.Text;
                addstudent.name = textBox2.Text;
                addstudent.patronymic = textBox3.Text;
                addstudent.faculty = textBox4.Text;
                addstudent.group = textBox5.Text;
                addstudent.number = textBox6.Text;
                foreach (var student in Students)
                {
                    if (addstudent.number == student.number)
                    {
                        MessageBox.Show("Такий номер залікової книжки вже зайнятий!");
                        return;
                    }
                }
                Students.Add(addstudent);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetStudent();
            FillTable1();
        }

        private void AddStudentToRoom()
        {
            foreach (var room in Rooms)
            {
                foreach (var student in Students)
                {
                    try
                    {
                        string checker = textBox7.Text;
                        foreach (var iden in room.student_number)
                        {
                            if (iden == checker)
                            {
                                MessageBox.Show("Студент з таким номером вже проживає в іншій кімнаті!");
                                return;
                            }
                        }
                        if (room.number == Int32.Parse(textBox8.Text) && textBox7.Text.ToString() == student.number)
                        {
                            if (room.gender == "")
                            {
                                room.gender = student.gender;
                            }
                            else
                            {
                                if (student.gender != room.gender)
                                {
                                    MessageBox.Show("В кімнаті проживає студент іншої статі!");
                                    return;
                                }
                            }
                            if (room.quantity <= room.already)
                            {
                                MessageBox.Show("Немає місця!");
                                return;
                            }
                            if (room.quantity > room.already)
                            {
                                room.already++;
                                room.student_number.Add(student.number);
                                return;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Помилка!");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudentToRoom();
            FillTable1();
        }

        private void RemoveStudentFromRoom()
        {
            foreach (var room in Rooms)
            {
                foreach (var student in Students)
                {
                    try
                    {
                        if (room.number == Int32.Parse(textBox8.Text) && textBox7.Text.ToString() == student.number)
                        {
                            if (room.already - 1 < 0)
                            {
                                MessageBox.Show("В кімнаті ніхто не проживає!");
                                return;
                            }
                            if (room.quantity >= room.already)
                            {
                                room.already--;
                                room.student_number.Remove(student.number);
                                if (room.already == 0)
                                {
                                    room.gender = "";
                                }
                                return;
                            }
                            else
                            {
                                MessageBox.Show("В кімнаті немає місця!");
                                return;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Помилка!");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveStudentFromRoom();
            FillTable1();
        }

        private void MoveStudentToRoom()
        {
            foreach (var room in Rooms)
            {
                foreach (var newroom in Rooms)
                {
                    foreach (var student in Students)
                    {
                        try
                        {
                            if (room.number == Int32.Parse(textBox8.Text) && textBox7.Text.ToString() == student.number && newroom.number == Int32.Parse(textBox9.Text))
                            {
                                if (room.already - 1 < 0)
                                {
                                    MessageBox.Show("В кімнаті ніхто не проживає!");
                                    return;
                                }
                                if (newroom.gender == "")
                                {
                                    newroom.gender = student.gender;
                                }
                                else if (student.gender != newroom.gender)
                                {
                                    MessageBox.Show("В кімнаті проживає студент іншої статі!");
                                    return;
                                }
                                if (room.quantity >= room.already)
                                {
                                    room.already--;
                                    room.student_number.Remove(student.number);
                                    if (room.already == 0)
                                    {
                                        room.gender = "";
                                    }

                                    if (newroom.quantity > newroom.already)
                                    {
                                        newroom.already++;
                                        newroom.student_number.Add(student.number);
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("В кімнаті немає місця!");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Помилка!");
                                    return;
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Помилка!");
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoveStudentToRoom();
            FillTable1();
        }
    }
}
