using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_predication
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string studentId = txtId.Text;
                double marks = double.Parse(txtMarks.Text);

                Student newStudent = new Student(name, age, studentId, marks);
                students.Add(newStudent);

                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid data. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayResult_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students have been added yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Displaying the result for the last added student for demonstration
            Student lastStudent = students.Last();
            
            // Console-based prototype logic check (writing to trace)
            Console.WriteLine(lastStudent.GetDetails()); 

            string resultMessage = $"Last Added Student:\n\n{lastStudent.GetDetails()}\nResult: {lastStudent.CalculateResult()}";
            MessageBox.Show(resultMessage, "Student Result Prediction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(students);
            form2.Show();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtAge.Clear();
            txtId.Clear();
            txtMarks.Clear();
            txtName.Focus();
        }
    }
}
