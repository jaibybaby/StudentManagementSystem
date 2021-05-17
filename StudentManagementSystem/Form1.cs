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
    public partial class Form1 : Form
    {
        Student student = new Student();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtAge.Text == "" & txtEmail.Text == "" && txtFees.Text == "")
            {
                MessageBox.Show("Enter All Fields");
            }
            else
            {
                student.Name = txtName.Text;
                student.Age = Convert.ToInt32(txtAge.Text);
                student.Fees =Convert.ToDouble(txtFees.Text);
                student.Email = txtEmail.Text;
                MessageBox.Show("Saved Successfully");
                txtName.Text = "";
                txtAge.Text = "";
                txtEmail.Text = "";
                txtFees.Text = ""
;

            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtNameRead.Text = student.Name.ToUpper();
            txtAgeRead.Text = student.Age.ToString();
            double tution = student.Fees + 1000;
            txtFeesRead.Text = tution.ToString();
            txtEmailRead.Text = student.Email;
        }


    }
}
