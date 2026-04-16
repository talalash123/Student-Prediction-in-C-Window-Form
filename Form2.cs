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
    public partial class Form2 : Form
    {
        private List<Student> _students;

        public Form2(List<Student> students)
        {
            InitializeComponent();
            _students = students;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Bind the List directly to the DataGridView
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = _students;

            // Optional: Format the columns if they exist
            if (dgvStudents.Columns["Name"] != null) dgvStudents.Columns["Name"].HeaderText = "Student Name";
            if (dgvStudents.Columns["Age"] != null) dgvStudents.Columns["Age"].HeaderText = "Age";
            if (dgvStudents.Columns["StudentId"] != null) dgvStudents.Columns["StudentId"].HeaderText = "ID";
            if (dgvStudents.Columns["Marks"] != null) dgvStudents.Columns["Marks"].HeaderText = "Marks";
        }
    }
}
