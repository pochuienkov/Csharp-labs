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
    public partial class Form1 : Form
    {
        Campus UAcampus = new Campus("НУРЕ", "Харків, просп. Науки, 14, 61166", 320, 2700, 400, 3300000);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTable();
        }
        
        public void FillTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(UAcampus.name, UAcampus.address, UAcampus.room, UAcampus.student, UAcampus.staff, UAcampus.income);
        } 

        public void SettleStudent()
        {
            try
            {
                int number = Convert.ToInt32(textBox2.Text);
                if (number <= 0) { MessageBox.Show("Кількість студентів не може бути нулем або меншою за нуль!", "Помилка"); textBox2.Clear(); return; }
                UAcampus.student += number;
                textBox2.Clear();
                FillTable();
            }
            catch { MessageBox.Show("Помилка!", "Помилка"); }
        }

        public void EvictStudent()
        {
            try
            {
                int number = Convert.ToInt32(textBox2.Text);
                if (number <= 0) { MessageBox.Show("Кількість студентів не може бути нулем або меншою за нуль!", "Помилка"); textBox2.Clear(); return; }
                if (number > UAcampus.student) { MessageBox.Show("Кількість занадто велика! Зменшіть число!", "Помилка"); textBox2.Clear(); return; }
                UAcampus.student -= number;
                textBox2.Clear();
                FillTable();
            }
            catch { MessageBox.Show("Помилка!", "Помилка"); }
        }

        public void AddRoom()
        {
            try
            {
                int number = Convert.ToInt32(textBox1.Text);
                if (number <= 0) { MessageBox.Show("Кількість кімнат не може бути нулем або меншою за нуль!", "Помилка"); textBox1.Clear(); return; }
                UAcampus.room += number;
                textBox1.Clear();
                FillTable();
            }
            catch { MessageBox.Show("Помилка!", "Помилка"); }
        }

        public void ToString()
        {
            string str = (UAcampus.name + " " + UAcampus.address + " " + UAcampus.room + " " + UAcampus.student + " " + UAcampus.staff + " " + UAcampus.income);
            MessageBox.Show(str, "ToString");
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SettleStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EvictStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRoom();
        }

        private void toStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToString();
        }

        private void створитиКлонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campus campus = (Campus)UAcampus.Cloneable();
            dataGridView1.Rows.Add(campus.name, campus.address, campus.room, campus.student, campus.staff, campus.income);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UAcampus.Cook();
            FillTable();
        }
    }
}
