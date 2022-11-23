using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        List<Class1> class1 = new List<Class1>();
        public Form1()
        {
            InitializeComponent();
        }
        string[] stdnm = new string[] { "kamran", "ali", "umar", "usama", "asim", "sameer", "ali", "azeem", "salman", "abdullah", "farooqeazam", "umar", "ahad" };
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

            string combinestring = "";
            var myname = from std in stdnm
                         where std == textBox1.Text

                         select std;
            foreach (String student in myname)
            {
                combinestring = combinestring + student + "\n" + "  ";
            }
            textBox5.Text = combinestring;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

            string combinestring = "";
            var myname = from std in stdnm

                         orderby std ascending
                         select std;
            foreach (String student in myname)
            {
                combinestring = combinestring + student + "\n" + "  ";
            }
            textBox5.Text = combinestring;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

            string combinestring = "";
            var myname = from student in stdnm
                         where student.Contains(textBox4.Text)
                         select student;
            foreach (String student in myname)
            {
                combinestring = combinestring + student + "\n" + "  ";
            }
            textBox5.Text = combinestring;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

            string combinestring = "";
            var myname = from word in stdnm
                         where word.Length == int.Parse(textBox3.Text)
                         select word;
            foreach (String student in myname)
            {
                combinestring = combinestring + student + "\n" + "  ";
            }
            textBox5.Text = combinestring;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

            string combinestring = "";
            var myname = from student in stdnm
                         where student.StartsWith(textBox2.Text)
                         select student;
            foreach (String student in myname)
            {
                combinestring = combinestring + student + "\n" + "  ";
            }
            textBox5.Text = combinestring;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var myString = from mark in class1
                           orderby mark.marks descending
                           select mark;
            foreach (Class1 s in myString)
            {
                dataGridView1.Rows.Add(s.StudentID, s.StudentName, s.Age, s.marks, s.gender);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                Class1 s = new Class1();
                s.StudentID = int.Parse(textBox6.Text);
                s.StudentName = textBox7.Text;
                s.Age = int.Parse(textBox8.Text);
                s.marks = int.Parse(textBox9.Text);
                s.gender = textBox10.Text;
                class1.Add(s);

                MessageBox.Show("Record Save Successfully");
                textBox6.Clear();   
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();

            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (textBox15.Text == "")
            {
                MessageBox.Show("Please Enter Name Firstly");
            }
            else
            {
                var myString = from std in class1
                               where std.StudentName == textBox15.Text
                               select std;
                foreach (Class1 s in myString)
                {
                    dataGridView1.Rows.Add(s.StudentID, s.StudentName, s.Age, s.marks, s.gender);
                }
                textBox15.Clear();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (textBox11.Text == "")
            {
                MessageBox.Show("Please Enter Marks Firstly");
            }
            else
            {
                var myString = from mark in class1
                               where mark.marks > int.Parse(textBox11.Text)
                               orderby mark.marks descending
                               select mark;
                foreach (Class1 s in myString)
                {
                    dataGridView1.Rows.Add(s.StudentID, s.StudentName, s.Age, s.marks, s.gender);

                }
                textBox11.Clear();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var myString = from s in class1
                           orderby s.gender ascending, s.marks descending, s.Age ascending
                           select s;
            foreach (Class1 s in myString)
            {
                dataGridView1.Rows.Add(s.StudentID, s.StudentName, s.Age, s.marks, s.gender);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Class1 s in class1)
            {
                dataGridView1.Rows.Add(s.StudentID, s.StudentName, s.Age, s.marks, s.gender);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
