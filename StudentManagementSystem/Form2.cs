using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Fees { get; set; }
        public string Email { get; set; }
        public Student()

        {
            Name = "No Record";
            Age = 0;
            Fees = 0;
            Email = "No Record";
        }
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    }
}
