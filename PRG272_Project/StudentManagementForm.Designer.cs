﻿namespace PRG272_Project
{
    sealed partial class StudentManagementForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabViewAllStudents = new System.Windows.Forms.TabPage();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnNavigateNext = new System.Windows.Forms.Button();
            this.btnNavigateLast = new System.Windows.Forms.Button();
            this.btnNavigatePrev = new System.Windows.Forms.Button();
            this.btnNavigateFirst = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.tabAddStudent = new System.Windows.Forms.TabPage();
            this.grpBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.lblNewStudentCourse = new System.Windows.Forms.Label();
            this.lblNewStudentAge = new System.Windows.Forms.Label();
            this.lblNewStudentSurname = new System.Windows.Forms.Label();
            this.lblNewStudentName = new System.Windows.Forms.Label();
            this.lblNewStudentId = new System.Windows.Forms.Label();
            this.tabUpdateStudent = new System.Windows.Forms.TabPage();
            this.tabDeleteStudent = new System.Windows.Forms.TabPage();
            this.tabSummaryReport = new System.Windows.Forms.TabPage();
            this.txtNewStudentId = new System.Windows.Forms.TextBox();
            this.txtNewStudentName = new System.Windows.Forms.TextBox();
            this.txtNewStudentSurname = new System.Windows.Forms.TextBox();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.sedNewStudentAge = new System.Windows.Forms.NumericUpDown();
            this.cmbNewStudentCourse = new System.Windows.Forms.ComboBox();
            this.btnRefreshTableData = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabViewAllStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.tabAddStudent.SuspendLayout();
            this.grpBoxAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNewStudentAge)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabViewAllStudents);
            this.tabControl.Controls.Add(this.tabAddStudent);
            this.tabControl.Controls.Add(this.tabUpdateStudent);
            this.tabControl.Controls.Add(this.tabDeleteStudent);
            this.tabControl.Controls.Add(this.tabSummaryReport);
            this.tabControl.Location = new System.Drawing.Point(42, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(904, 464);
            this.tabControl.TabIndex = 0;
            // 
            // tabViewAllStudents
            // 
            this.tabViewAllStudents.Controls.Add(this.btnRefreshTableData);
            this.tabViewAllStudents.Controls.Add(this.btnSearchStudent);
            this.tabViewAllStudents.Controls.Add(this.txtSearchStudent);
            this.tabViewAllStudents.Controls.Add(this.btnNavigateNext);
            this.tabViewAllStudents.Controls.Add(this.btnNavigateLast);
            this.tabViewAllStudents.Controls.Add(this.btnNavigatePrev);
            this.tabViewAllStudents.Controls.Add(this.btnNavigateFirst);
            this.tabViewAllStudents.Controls.Add(this.dataGridStudents);
            this.tabViewAllStudents.Location = new System.Drawing.Point(4, 22);
            this.tabViewAllStudents.Name = "tabViewAllStudents";
            this.tabViewAllStudents.Size = new System.Drawing.Size(896, 438);
            this.tabViewAllStudents.TabIndex = 3;
            this.tabViewAllStudents.Text = "View All Students";
            this.tabViewAllStudents.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(713, 27);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(133, 26);
            this.btnSearchStudent.TabIndex = 6;
            this.btnSearchStudent.Text = "Search table";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(456, 31);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(251, 20);
            this.txtSearchStudent.TabIndex = 5;
            // 
            // btnNavigateNext
            // 
            this.btnNavigateNext.Location = new System.Drawing.Point(660, 389);
            this.btnNavigateNext.Name = "btnNavigateNext";
            this.btnNavigateNext.Size = new System.Drawing.Size(90, 30);
            this.btnNavigateNext.TabIndex = 4;
            this.btnNavigateNext.Text = "Next";
            this.btnNavigateNext.UseVisualStyleBackColor = true;
            this.btnNavigateNext.Click += new System.EventHandler(this.btnNavigateNext_Click);
            // 
            // btnNavigateLast
            // 
            this.btnNavigateLast.Location = new System.Drawing.Point(756, 389);
            this.btnNavigateLast.Name = "btnNavigateLast";
            this.btnNavigateLast.Size = new System.Drawing.Size(90, 30);
            this.btnNavigateLast.TabIndex = 3;
            this.btnNavigateLast.Text = "Last";
            this.btnNavigateLast.UseVisualStyleBackColor = true;
            this.btnNavigateLast.Click += new System.EventHandler(this.btnNavigateLast_Click);
            // 
            // btnNavigatePrev
            // 
            this.btnNavigatePrev.Location = new System.Drawing.Point(145, 389);
            this.btnNavigatePrev.Name = "btnNavigatePrev";
            this.btnNavigatePrev.Size = new System.Drawing.Size(90, 30);
            this.btnNavigatePrev.TabIndex = 2;
            this.btnNavigatePrev.Text = "Prev";
            this.btnNavigatePrev.UseVisualStyleBackColor = true;
            this.btnNavigatePrev.Click += new System.EventHandler(this.btnNavigatePrev_Click);
            // 
            // btnNavigateFirst
            // 
            this.btnNavigateFirst.Location = new System.Drawing.Point(49, 389);
            this.btnNavigateFirst.Name = "btnNavigateFirst";
            this.btnNavigateFirst.Size = new System.Drawing.Size(90, 30);
            this.btnNavigateFirst.TabIndex = 1;
            this.btnNavigateFirst.Text = "First";
            this.btnNavigateFirst.UseVisualStyleBackColor = true;
            this.btnNavigateFirst.Click += new System.EventHandler(this.btnNavigateFirst_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudents.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(49, 57);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.Size = new System.Drawing.Size(797, 326);
            this.dataGridStudents.TabIndex = 0;
            this.dataGridStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellClick);
            // 
            // tabAddStudent
            // 
            this.tabAddStudent.Controls.Add(this.grpBoxAddStudent);
            this.tabAddStudent.Location = new System.Drawing.Point(4, 22);
            this.tabAddStudent.Name = "tabAddStudent";
            this.tabAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddStudent.Size = new System.Drawing.Size(896, 438);
            this.tabAddStudent.TabIndex = 0;
            this.tabAddStudent.Text = "Add Student";
            this.tabAddStudent.UseVisualStyleBackColor = true;
            // 
            // grpBoxAddStudent
            // 
            this.grpBoxAddStudent.Controls.Add(this.cmbNewStudentCourse);
            this.grpBoxAddStudent.Controls.Add(this.sedNewStudentAge);
            this.grpBoxAddStudent.Controls.Add(this.btnAddNewStudent);
            this.grpBoxAddStudent.Controls.Add(this.txtNewStudentSurname);
            this.grpBoxAddStudent.Controls.Add(this.txtNewStudentName);
            this.grpBoxAddStudent.Controls.Add(this.txtNewStudentId);
            this.grpBoxAddStudent.Controls.Add(this.lblNewStudentCourse);
            this.grpBoxAddStudent.Controls.Add(this.lblNewStudentAge);
            this.grpBoxAddStudent.Controls.Add(this.lblNewStudentSurname);
            this.grpBoxAddStudent.Controls.Add(this.lblNewStudentName);
            this.grpBoxAddStudent.Controls.Add(this.lblNewStudentId);
            this.grpBoxAddStudent.Location = new System.Drawing.Point(215, 85);
            this.grpBoxAddStudent.Name = "grpBoxAddStudent";
            this.grpBoxAddStudent.Size = new System.Drawing.Size(489, 288);
            this.grpBoxAddStudent.TabIndex = 0;
            this.grpBoxAddStudent.TabStop = false;
            this.grpBoxAddStudent.Text = "Add new student";
            // 
            // lblNewStudentCourse
            // 
            this.lblNewStudentCourse.AutoSize = true;
            this.lblNewStudentCourse.Location = new System.Drawing.Point(112, 202);
            this.lblNewStudentCourse.Name = "lblNewStudentCourse";
            this.lblNewStudentCourse.Size = new System.Drawing.Size(40, 13);
            this.lblNewStudentCourse.TabIndex = 4;
            this.lblNewStudentCourse.Text = "Course";
            // 
            // lblNewStudentAge
            // 
            this.lblNewStudentAge.AutoSize = true;
            this.lblNewStudentAge.Location = new System.Drawing.Point(112, 167);
            this.lblNewStudentAge.Name = "lblNewStudentAge";
            this.lblNewStudentAge.Size = new System.Drawing.Size(26, 13);
            this.lblNewStudentAge.TabIndex = 3;
            this.lblNewStudentAge.Text = "Age";
            // 
            // lblNewStudentSurname
            // 
            this.lblNewStudentSurname.AutoSize = true;
            this.lblNewStudentSurname.Location = new System.Drawing.Point(112, 129);
            this.lblNewStudentSurname.Name = "lblNewStudentSurname";
            this.lblNewStudentSurname.Size = new System.Drawing.Size(49, 13);
            this.lblNewStudentSurname.TabIndex = 2;
            this.lblNewStudentSurname.Text = "Surname";
            // 
            // lblNewStudentName
            // 
            this.lblNewStudentName.AutoSize = true;
            this.lblNewStudentName.Location = new System.Drawing.Point(112, 99);
            this.lblNewStudentName.Name = "lblNewStudentName";
            this.lblNewStudentName.Size = new System.Drawing.Size(35, 13);
            this.lblNewStudentName.TabIndex = 1;
            this.lblNewStudentName.Text = "Name";
            // 
            // lblNewStudentId
            // 
            this.lblNewStudentId.AutoSize = true;
            this.lblNewStudentId.Location = new System.Drawing.Point(112, 66);
            this.lblNewStudentId.Name = "lblNewStudentId";
            this.lblNewStudentId.Size = new System.Drawing.Size(58, 13);
            this.lblNewStudentId.TabIndex = 0;
            this.lblNewStudentId.Text = "Student ID";
            // 
            // tabUpdateStudent
            // 
            this.tabUpdateStudent.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateStudent.Name = "tabUpdateStudent";
            this.tabUpdateStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateStudent.Size = new System.Drawing.Size(896, 438);
            this.tabUpdateStudent.TabIndex = 1;
            this.tabUpdateStudent.Text = "Update Student";
            this.tabUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // tabDeleteStudent
            // 
            this.tabDeleteStudent.Location = new System.Drawing.Point(4, 22);
            this.tabDeleteStudent.Name = "tabDeleteStudent";
            this.tabDeleteStudent.Size = new System.Drawing.Size(896, 438);
            this.tabDeleteStudent.TabIndex = 2;
            this.tabDeleteStudent.Text = "Delete Student";
            this.tabDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // tabSummaryReport
            // 
            this.tabSummaryReport.Location = new System.Drawing.Point(4, 22);
            this.tabSummaryReport.Name = "tabSummaryReport";
            this.tabSummaryReport.Size = new System.Drawing.Size(896, 438);
            this.tabSummaryReport.TabIndex = 4;
            this.tabSummaryReport.Text = "Summary Report";
            this.tabSummaryReport.UseVisualStyleBackColor = true;
            // 
            // txtNewStudentId
            // 
            this.txtNewStudentId.Location = new System.Drawing.Point(201, 59);
            this.txtNewStudentId.Name = "txtNewStudentId";
            this.txtNewStudentId.Size = new System.Drawing.Size(160, 20);
            this.txtNewStudentId.TabIndex = 5;
            // 
            // txtNewStudentName
            // 
            this.txtNewStudentName.Location = new System.Drawing.Point(201, 92);
            this.txtNewStudentName.Name = "txtNewStudentName";
            this.txtNewStudentName.Size = new System.Drawing.Size(160, 20);
            this.txtNewStudentName.TabIndex = 6;
            // 
            // txtNewStudentSurname
            // 
            this.txtNewStudentSurname.Location = new System.Drawing.Point(201, 122);
            this.txtNewStudentSurname.Name = "txtNewStudentSurname";
            this.txtNewStudentSurname.Size = new System.Drawing.Size(160, 20);
            this.txtNewStudentSurname.TabIndex = 7;
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(376, 250);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(107, 32);
            this.btnAddNewStudent.TabIndex = 10;
            this.btnAddNewStudent.Text = "Add Student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // sedNewStudentAge
            // 
            this.sedNewStudentAge.Location = new System.Drawing.Point(201, 160);
            this.sedNewStudentAge.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.sedNewStudentAge.Name = "sedNewStudentAge";
            this.sedNewStudentAge.Size = new System.Drawing.Size(160, 20);
            this.sedNewStudentAge.TabIndex = 11;
            this.sedNewStudentAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cmbNewStudentCourse
            // 
            this.cmbNewStudentCourse.FormattingEnabled = true;
            this.cmbNewStudentCourse.Items.AddRange(new object[] {
            "Computer Science",
            "Mathematics",
            "Engineering",
            "Health Sciences",
            "Physics",
            "Chemistry",
            "Environmental Studies",
            "Graphic Design",
            "Business Administration"});
            this.cmbNewStudentCourse.Location = new System.Drawing.Point(201, 194);
            this.cmbNewStudentCourse.Name = "cmbNewStudentCourse";
            this.cmbNewStudentCourse.Size = new System.Drawing.Size(160, 21);
            this.cmbNewStudentCourse.TabIndex = 12;
            // 
            // btnRefreshTableData
            // 
            this.btnRefreshTableData.Location = new System.Drawing.Point(406, 389);
            this.btnRefreshTableData.Name = "btnRefreshTableData";
            this.btnRefreshTableData.Size = new System.Drawing.Size(127, 30);
            this.btnRefreshTableData.TabIndex = 7;
            this.btnRefreshTableData.Text = "Refresh Table Data";
            this.btnRefreshTableData.UseVisualStyleBackColor = true;
            this.btnRefreshTableData.Click += new System.EventHandler(this.btnRefreshTableData_Click);
            // 
            // StudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 522);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "StudentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.tabControl.ResumeLayout(false);
            this.tabViewAllStudents.ResumeLayout(false);
            this.tabViewAllStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.tabAddStudent.ResumeLayout(false);
            this.grpBoxAddStudent.ResumeLayout(false);
            this.grpBoxAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNewStudentAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAddStudent;
        private System.Windows.Forms.TabPage tabUpdateStudent;
        private System.Windows.Forms.TabPage tabDeleteStudent;
        private System.Windows.Forms.TabPage tabViewAllStudents;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Button btnNavigateFirst;
        private System.Windows.Forms.Button btnNavigatePrev;
        private System.Windows.Forms.Button btnNavigateNext;
        private System.Windows.Forms.Button btnNavigateLast;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TabPage tabSummaryReport;
        private System.Windows.Forms.GroupBox grpBoxAddStudent;
        private System.Windows.Forms.Label lblNewStudentId;
        private System.Windows.Forms.Label lblNewStudentCourse;
        private System.Windows.Forms.Label lblNewStudentAge;
        private System.Windows.Forms.Label lblNewStudentSurname;
        private System.Windows.Forms.Label lblNewStudentName;
        private System.Windows.Forms.TextBox txtNewStudentSurname;
        private System.Windows.Forms.TextBox txtNewStudentName;
        private System.Windows.Forms.TextBox txtNewStudentId;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.NumericUpDown sedNewStudentAge;
        private System.Windows.Forms.ComboBox cmbNewStudentCourse;
        private System.Windows.Forms.Button btnRefreshTableData;
    }
}
