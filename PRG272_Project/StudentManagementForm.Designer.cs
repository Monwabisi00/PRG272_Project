namespace PRG272_Project
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
            this.btnRefreshTableData = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnNavigateNext = new System.Windows.Forms.Button();
            this.btnNavigateLast = new System.Windows.Forms.Button();
            this.btnNavigatePrev = new System.Windows.Forms.Button();
            this.btnNavigateFirst = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.tabAddStudent = new System.Windows.Forms.TabPage();
            this.grpBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.cmbNewStudentCourse = new System.Windows.Forms.ComboBox();
            this.sedNewStudentAge = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.txtNewStudentSurname = new System.Windows.Forms.TextBox();
            this.txtNewStudentName = new System.Windows.Forms.TextBox();
            this.txtNewStudentId = new System.Windows.Forms.TextBox();
            this.lblNewStudentCourse = new System.Windows.Forms.Label();
            this.lblNewStudentAge = new System.Windows.Forms.Label();
            this.lblNewStudentSurname = new System.Windows.Forms.Label();
            this.lblNewStudentName = new System.Windows.Forms.Label();
            this.lblNewStudentId = new System.Windows.Forms.Label();
            this.tabUpdateStudent = new System.Windows.Forms.TabPage();
            this.nudUpdateStudentAge = new System.Windows.Forms.NumericUpDown();
            this.cmbUpdateStudentCourse = new System.Windows.Forms.ComboBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.txtUpdateStudentSurname = new System.Windows.Forms.TextBox();
            this.txtUpdateStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tabSummaryReport = new System.Windows.Forms.TabPage();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabViewAllStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.tabAddStudent.SuspendLayout();
            this.grpBoxAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sedNewStudentAge)).BeginInit();
            this.tabUpdateStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateStudentAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabSummaryReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabViewAllStudents);
            this.tabControl.Controls.Add(this.tabAddStudent);
            this.tabControl.Controls.Add(this.tabUpdateStudent);
            this.tabControl.Controls.Add(this.tabSummaryReport);
            this.tabControl.Location = new System.Drawing.Point(56, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1205, 571);
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
            this.tabViewAllStudents.Location = new System.Drawing.Point(4, 25);
            this.tabViewAllStudents.Margin = new System.Windows.Forms.Padding(4);
            this.tabViewAllStudents.Name = "tabViewAllStudents";
            this.tabViewAllStudents.Size = new System.Drawing.Size(1197, 542);
            this.tabViewAllStudents.TabIndex = 3;
            this.tabViewAllStudents.Text = "View All Students";
            this.tabViewAllStudents.UseVisualStyleBackColor = true;
            // 
            // btnRefreshTableData
            // 
            this.btnRefreshTableData.Location = new System.Drawing.Point(541, 479);
            this.btnRefreshTableData.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshTableData.Name = "btnRefreshTableData";
            this.btnRefreshTableData.Size = new System.Drawing.Size(169, 37);
            this.btnRefreshTableData.TabIndex = 7;
            this.btnRefreshTableData.Text = "Refresh Table Data";
            this.btnRefreshTableData.UseVisualStyleBackColor = true;
            this.btnRefreshTableData.Click += new System.EventHandler(this.btnRefreshTableData_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(951, 33);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(177, 32);
            this.btnSearchStudent.TabIndex = 6;
            this.btnSearchStudent.Text = "Search table";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(608, 38);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(333, 22);
            this.txtSearchStudent.TabIndex = 5;
            // 
            // btnNavigateNext
            // 
            this.btnNavigateNext.Location = new System.Drawing.Point(880, 479);
            this.btnNavigateNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavigateNext.Name = "btnNavigateNext";
            this.btnNavigateNext.Size = new System.Drawing.Size(120, 37);
            this.btnNavigateNext.TabIndex = 4;
            this.btnNavigateNext.Text = "Next";
            this.btnNavigateNext.UseVisualStyleBackColor = true;
            this.btnNavigateNext.Click += new System.EventHandler(this.btnNavigateNext_Click);
            // 
            // btnNavigateLast
            // 
            this.btnNavigateLast.Location = new System.Drawing.Point(1008, 479);
            this.btnNavigateLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavigateLast.Name = "btnNavigateLast";
            this.btnNavigateLast.Size = new System.Drawing.Size(120, 37);
            this.btnNavigateLast.TabIndex = 3;
            this.btnNavigateLast.Text = "Last";
            this.btnNavigateLast.UseVisualStyleBackColor = true;
            this.btnNavigateLast.Click += new System.EventHandler(this.btnNavigateLast_Click);
            // 
            // btnNavigatePrev
            // 
            this.btnNavigatePrev.Location = new System.Drawing.Point(193, 479);
            this.btnNavigatePrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavigatePrev.Name = "btnNavigatePrev";
            this.btnNavigatePrev.Size = new System.Drawing.Size(120, 37);
            this.btnNavigatePrev.TabIndex = 2;
            this.btnNavigatePrev.Text = "Prev";
            this.btnNavigatePrev.UseVisualStyleBackColor = true;
            this.btnNavigatePrev.Click += new System.EventHandler(this.btnNavigatePrev_Click);
            // 
            // btnNavigateFirst
            // 
            this.btnNavigateFirst.Location = new System.Drawing.Point(65, 479);
            this.btnNavigateFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavigateFirst.Name = "btnNavigateFirst";
            this.btnNavigateFirst.Size = new System.Drawing.Size(120, 37);
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
            this.dataGridStudents.Location = new System.Drawing.Point(65, 70);
            this.dataGridStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowHeadersWidth = 51;
            this.dataGridStudents.Size = new System.Drawing.Size(1063, 401);
            this.dataGridStudents.TabIndex = 0;
            this.dataGridStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellClick);
            // 
            // tabAddStudent
            // 
            this.tabAddStudent.Controls.Add(this.grpBoxAddStudent);
            this.tabAddStudent.Location = new System.Drawing.Point(4, 25);
            this.tabAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.tabAddStudent.Name = "tabAddStudent";
            this.tabAddStudent.Padding = new System.Windows.Forms.Padding(4);
            this.tabAddStudent.Size = new System.Drawing.Size(1197, 542);
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
            this.grpBoxAddStudent.Location = new System.Drawing.Point(287, 105);
            this.grpBoxAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxAddStudent.Name = "grpBoxAddStudent";
            this.grpBoxAddStudent.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxAddStudent.Size = new System.Drawing.Size(652, 354);
            this.grpBoxAddStudent.TabIndex = 0;
            this.grpBoxAddStudent.TabStop = false;
            this.grpBoxAddStudent.Text = "Add new student";
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
            this.cmbNewStudentCourse.Location = new System.Drawing.Point(268, 239);
            this.cmbNewStudentCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNewStudentCourse.Name = "cmbNewStudentCourse";
            this.cmbNewStudentCourse.Size = new System.Drawing.Size(212, 24);
            this.cmbNewStudentCourse.TabIndex = 12;
            // 
            // sedNewStudentAge
            // 
            this.sedNewStudentAge.Location = new System.Drawing.Point(268, 197);
            this.sedNewStudentAge.Margin = new System.Windows.Forms.Padding(4);
            this.sedNewStudentAge.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.sedNewStudentAge.Name = "sedNewStudentAge";
            this.sedNewStudentAge.Size = new System.Drawing.Size(213, 22);
            this.sedNewStudentAge.TabIndex = 11;
            this.sedNewStudentAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(501, 308);
            this.btnAddNewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(143, 39);
            this.btnAddNewStudent.TabIndex = 10;
            this.btnAddNewStudent.Text = "Add Student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // txtNewStudentSurname
            // 
            this.txtNewStudentSurname.Location = new System.Drawing.Point(268, 150);
            this.txtNewStudentSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewStudentSurname.Name = "txtNewStudentSurname";
            this.txtNewStudentSurname.Size = new System.Drawing.Size(212, 22);
            this.txtNewStudentSurname.TabIndex = 7;
            // 
            // txtNewStudentName
            // 
            this.txtNewStudentName.Location = new System.Drawing.Point(268, 113);
            this.txtNewStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewStudentName.Name = "txtNewStudentName";
            this.txtNewStudentName.Size = new System.Drawing.Size(212, 22);
            this.txtNewStudentName.TabIndex = 6;
            // 
            // txtNewStudentId
            // 
            this.txtNewStudentId.Location = new System.Drawing.Point(268, 73);
            this.txtNewStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewStudentId.Name = "txtNewStudentId";
            this.txtNewStudentId.Size = new System.Drawing.Size(212, 22);
            this.txtNewStudentId.TabIndex = 5;
            // 
            // lblNewStudentCourse
            // 
            this.lblNewStudentCourse.AutoSize = true;
            this.lblNewStudentCourse.Location = new System.Drawing.Point(149, 249);
            this.lblNewStudentCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStudentCourse.Name = "lblNewStudentCourse";
            this.lblNewStudentCourse.Size = new System.Drawing.Size(50, 16);
            this.lblNewStudentCourse.TabIndex = 4;
            this.lblNewStudentCourse.Text = "Course";
            // 
            // lblNewStudentAge
            // 
            this.lblNewStudentAge.AutoSize = true;
            this.lblNewStudentAge.Location = new System.Drawing.Point(149, 206);
            this.lblNewStudentAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStudentAge.Name = "lblNewStudentAge";
            this.lblNewStudentAge.Size = new System.Drawing.Size(32, 16);
            this.lblNewStudentAge.TabIndex = 3;
            this.lblNewStudentAge.Text = "Age";
            // 
            // lblNewStudentSurname
            // 
            this.lblNewStudentSurname.AutoSize = true;
            this.lblNewStudentSurname.Location = new System.Drawing.Point(149, 159);
            this.lblNewStudentSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStudentSurname.Name = "lblNewStudentSurname";
            this.lblNewStudentSurname.Size = new System.Drawing.Size(61, 16);
            this.lblNewStudentSurname.TabIndex = 2;
            this.lblNewStudentSurname.Text = "Surname";
            // 
            // lblNewStudentName
            // 
            this.lblNewStudentName.AutoSize = true;
            this.lblNewStudentName.Location = new System.Drawing.Point(149, 122);
            this.lblNewStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStudentName.Name = "lblNewStudentName";
            this.lblNewStudentName.Size = new System.Drawing.Size(44, 16);
            this.lblNewStudentName.TabIndex = 1;
            this.lblNewStudentName.Text = "Name";
            // 
            // lblNewStudentId
            // 
            this.lblNewStudentId.AutoSize = true;
            this.lblNewStudentId.Location = new System.Drawing.Point(149, 81);
            this.lblNewStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewStudentId.Name = "lblNewStudentId";
            this.lblNewStudentId.Size = new System.Drawing.Size(68, 16);
            this.lblNewStudentId.TabIndex = 0;
            this.lblNewStudentId.Text = "Student ID";
            // 
            // tabUpdateStudent
            // 
            this.tabUpdateStudent.Controls.Add(this.nudUpdateStudentAge);
            this.tabUpdateStudent.Controls.Add(this.cmbUpdateStudentCourse);
            this.tabUpdateStudent.Controls.Add(this.dataGridViewStudents);
            this.tabUpdateStudent.Controls.Add(this.btnDeleteStudent);
            this.tabUpdateStudent.Controls.Add(this.btnUpdateStudent);
            this.tabUpdateStudent.Controls.Add(this.txtUpdateStudentSurname);
            this.tabUpdateStudent.Controls.Add(this.txtUpdateStudentName);
            this.tabUpdateStudent.Controls.Add(this.label4);
            this.tabUpdateStudent.Controls.Add(this.label3);
            this.tabUpdateStudent.Controls.Add(this.label2);
            this.tabUpdateStudent.Controls.Add(this.label);
            this.tabUpdateStudent.Location = new System.Drawing.Point(4, 25);
            this.tabUpdateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.tabUpdateStudent.Name = "tabUpdateStudent";
            this.tabUpdateStudent.Padding = new System.Windows.Forms.Padding(4);
            this.tabUpdateStudent.Size = new System.Drawing.Size(1197, 542);
            this.tabUpdateStudent.TabIndex = 1;
            this.tabUpdateStudent.Text = "Update Student";
            this.tabUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // nudUpdateStudentAge
            // 
            this.nudUpdateStudentAge.Location = new System.Drawing.Point(140, 158);
            this.nudUpdateStudentAge.Name = "nudUpdateStudentAge";
            this.nudUpdateStudentAge.Size = new System.Drawing.Size(217, 22);
            this.nudUpdateStudentAge.TabIndex = 13;
            this.nudUpdateStudentAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cmbUpdateStudentCourse
            // 
            this.cmbUpdateStudentCourse.FormattingEnabled = true;
            this.cmbUpdateStudentCourse.Items.AddRange(new object[] {
            "Computer Science",
            "Mathematics",
            "Engineering",
            "Health Sciences",
            "Physics",
            "Chemistry",
            "Environmental Studies",
            "Graphic Design",
            "Business Administration"});
            this.cmbUpdateStudentCourse.Location = new System.Drawing.Point(140, 197);
            this.cmbUpdateStudentCourse.Name = "cmbUpdateStudentCourse";
            this.cmbUpdateStudentCourse.Size = new System.Drawing.Size(217, 24);
            this.cmbUpdateStudentCourse.TabIndex = 12;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.Name,
            this.Surname,
            this.Age,
            this.Course});
            this.dataGridViewStudents.Location = new System.Drawing.Point(495, 62);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(631, 368);
            this.dataGridViewStudents.TabIndex = 11;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(273, 389);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(175, 42);
            this.btnDeleteStudent.TabIndex = 10;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(48, 389);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(175, 42);
            this.btnUpdateStudent.TabIndex = 9;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // txtUpdateStudentSurname
            // 
            this.txtUpdateStudentSurname.Location = new System.Drawing.Point(140, 116);
            this.txtUpdateStudentSurname.Name = "txtUpdateStudentSurname";
            this.txtUpdateStudentSurname.Size = new System.Drawing.Size(217, 22);
            this.txtUpdateStudentSurname.TabIndex = 5;
            // 
            // txtUpdateStudentName
            // 
            this.txtUpdateStudentName.Location = new System.Drawing.Point(140, 84);
            this.txtUpdateStudentName.Name = "txtUpdateStudentName";
            this.txtUpdateStudentName.Size = new System.Drawing.Size(217, 22);
            this.txtUpdateStudentName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 200);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Courses";
            // 
            // tabSummaryReport
            // 
            this.tabSummaryReport.Controls.Add(this.txtAverage);
            this.tabSummaryReport.Controls.Add(this.txtTotal);
            this.tabSummaryReport.Controls.Add(this.lblAverage);
            this.tabSummaryReport.Controls.Add(this.lblTotal);
            this.tabSummaryReport.Location = new System.Drawing.Point(4, 25);
            this.tabSummaryReport.Margin = new System.Windows.Forms.Padding(4);
            this.tabSummaryReport.Name = "tabSummaryReport";
            this.tabSummaryReport.Size = new System.Drawing.Size(1197, 542);
            this.tabSummaryReport.TabIndex = 4;
            this.tabSummaryReport.Text = "Summary Report";
            this.tabSummaryReport.UseVisualStyleBackColor = true;
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(716, 276);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(4);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(132, 46);
            this.txtAverage.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(716, 218);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 46);
            this.txtTotal.TabIndex = 2;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(347, 276);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(340, 39);
            this.lblAverage.TabIndex = 1;
            this.lblAverage.Text = "Average Student Age";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(455, 218);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(236, 39);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Students";
            // 
            // StudentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 642);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            
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
            this.tabUpdateStudent.ResumeLayout(false);
            this.tabUpdateStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateStudentAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabSummaryReport.ResumeLayout(false);
            this.tabSummaryReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAddStudent;
        private System.Windows.Forms.TabPage tabUpdateStudent;
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
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateStudentSurname;
        private System.Windows.Forms.TextBox txtUpdateStudentName;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ComboBox cmbUpdateStudentCourse;
        private System.Windows.Forms.NumericUpDown nudUpdateStudentAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
    }
}

