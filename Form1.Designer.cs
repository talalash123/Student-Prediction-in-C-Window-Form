namespace student_predication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDisplayResult = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 70);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 110);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(71, 16);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Student ID:";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(30, 150);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(48, 16);
            this.lblMarks.TabIndex = 3;
            this.lblMarks.Text = "Marks:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(120, 67);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 22);
            this.txtAge.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 107);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.TabIndex = 6;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(120, 147);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(200, 22);
            this.txtMarks.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(120, 190);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 30);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDisplayResult
            // 
            this.btnDisplayResult.Location = new System.Drawing.Point(120, 230);
            this.btnDisplayResult.Name = "btnDisplayResult";
            this.btnDisplayResult.Size = new System.Drawing.Size(200, 30);
            this.btnDisplayResult.TabIndex = 9;
            this.btnDisplayResult.Text = "Display Result";
            this.btnDisplayResult.UseVisualStyleBackColor = true;
            this.btnDisplayResult.Click += new System.EventHandler(this.btnDisplayResult_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(120, 270);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(200, 30);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "Show All Records";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDisplayResult);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Student Data Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDisplayResult;
        private System.Windows.Forms.Button btnShowAll;
    }
}
