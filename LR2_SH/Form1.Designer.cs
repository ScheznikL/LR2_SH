namespace LR2_SH
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbUnName = new System.Windows.Forms.TextBox();
            this.BtDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtUniteUn = new System.Windows.Forms.Button();
            this.BtAddmition = new System.Windows.Forms.Button();
            this.BtExpulsion = new System.Windows.Forms.Button();
            this.BtAddLectorium = new System.Windows.Forms.Button();
            this.BtAddLaboratory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtHireEngineer = new System.Windows.Forms.Button();
            this.BtHireTeacher = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtFireEngineer = new System.Windows.Forms.Button();
            this.BtFireTeacher = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFaculty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbUnName
            // 
            this.TbUnName.Location = new System.Drawing.Point(17, 77);
            this.TbUnName.Name = "TbUnName";
            this.TbUnName.ReadOnly = true;
            this.TbUnName.Size = new System.Drawing.Size(255, 21);
            this.TbUnName.TabIndex = 4;
           // this.TbUnName.TextChanged += new System.EventHandler(this.TbUnName_TextChanged);
            // 
            // BtDone
            // 
            this.BtDone.Location = new System.Drawing.Point(17, 423);
            this.BtDone.Name = "BtDone";
            this.BtDone.Size = new System.Drawing.Size(113, 27);
            this.BtDone.TabIndex = 6;
            this.BtDone.Text = "Done";
            this.BtDone.UseVisualStyleBackColor = true;
            this.BtDone.Click += new System.EventHandler(this.BtDone_OnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Modify University data below:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Location = new System.Drawing.Point(14, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(627, 303);
            this.dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Uneversity name";
            // 
            // BtUniteUn
            // 
            this.BtUniteUn.Location = new System.Drawing.Point(513, 426);
            this.BtUniteUn.Name = "BtUniteUn";
            this.BtUniteUn.Size = new System.Drawing.Size(128, 27);
            this.BtUniteUn.TabIndex = 10;
            this.BtUniteUn.Text = "Unite 2 Universities";
            this.BtUniteUn.UseVisualStyleBackColor = true;
            this.BtUniteUn.Click += new System.EventHandler(this.BtUniteUn_Click);
            // 
            // BtAddmition
            // 
            this.BtAddmition.Location = new System.Drawing.Point(23, 22);
            this.BtAddmition.Name = "BtAddmition";
            this.BtAddmition.Size = new System.Drawing.Size(128, 27);
            this.BtAddmition.TabIndex = 11;
            this.BtAddmition.Text = "Addmition";
            this.BtAddmition.UseVisualStyleBackColor = true;
            this.BtAddmition.Click += new System.EventHandler(this.BtAddmition_Click);
            // 
            // BtExpulsion
            // 
            this.BtExpulsion.Location = new System.Drawing.Point(23, 58);
            this.BtExpulsion.Name = "BtExpulsion";
            this.BtExpulsion.Size = new System.Drawing.Size(128, 27);
            this.BtExpulsion.TabIndex = 12;
            this.BtExpulsion.Text = "Expulsion";
            this.BtExpulsion.UseVisualStyleBackColor = true;
            this.BtExpulsion.Click += new System.EventHandler(this.BtExpulsion_Click);
            // 
            // BtAddLectorium
            // 
            this.BtAddLectorium.Location = new System.Drawing.Point(23, 55);
            this.BtAddLectorium.Name = "BtAddLectorium";
            this.BtAddLectorium.Size = new System.Drawing.Size(128, 27);
            this.BtAddLectorium.TabIndex = 14;
            this.BtAddLectorium.Text = "Lecture aud.";
            this.BtAddLectorium.UseVisualStyleBackColor = true;
            this.BtAddLectorium.Click += new System.EventHandler(this.BtAddLectorium_Click);
            // 
            // BtAddLaboratory
            // 
            this.BtAddLaboratory.Location = new System.Drawing.Point(23, 22);
            this.BtAddLaboratory.Name = "BtAddLaboratory";
            this.BtAddLaboratory.Size = new System.Drawing.Size(128, 27);
            this.BtAddLaboratory.TabIndex = 13;
            this.BtAddLaboratory.Text = "Laboratory";
            this.BtAddLaboratory.UseVisualStyleBackColor = true;
            this.BtAddLaboratory.Click += new System.EventHandler(this.BtAddLaboratory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtAddLaboratory);
            this.groupBox1.Controls.Add(this.BtAddLectorium);
            this.groupBox1.Location = new System.Drawing.Point(647, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 92);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtAddmition);
            this.groupBox2.Controls.Add(this.BtExpulsion);
            this.groupBox2.Location = new System.Drawing.Point(647, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 97);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtHireEngineer);
            this.groupBox3.Controls.Add(this.BtHireTeacher);
            this.groupBox3.Location = new System.Drawing.Point(647, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 92);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hire";
            // 
            // BtHireEngineer
            // 
            this.BtHireEngineer.Location = new System.Drawing.Point(23, 22);
            this.BtHireEngineer.Name = "BtHireEngineer";
            this.BtHireEngineer.Size = new System.Drawing.Size(128, 27);
            this.BtHireEngineer.TabIndex = 13;
            this.BtHireEngineer.Text = "Engineer";
            this.BtHireEngineer.UseVisualStyleBackColor = true;
            this.BtHireEngineer.Click += new System.EventHandler(this.BtHireEngineer_Click);
            // 
            // BtHireTeacher
            // 
            this.BtHireTeacher.Location = new System.Drawing.Point(23, 55);
            this.BtHireTeacher.Name = "BtHireTeacher";
            this.BtHireTeacher.Size = new System.Drawing.Size(128, 27);
            this.BtHireTeacher.TabIndex = 14;
            this.BtHireTeacher.Text = "Teacher";
            this.BtHireTeacher.UseVisualStyleBackColor = true;
            this.BtHireTeacher.Click += new System.EventHandler(this.BtHireTeacher_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtFireEngineer);
            this.groupBox4.Controls.Add(this.BtFireTeacher);
            this.groupBox4.Location = new System.Drawing.Point(647, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 92);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fire";
            // 
            // BtFireEngineer
            // 
            this.BtFireEngineer.Location = new System.Drawing.Point(23, 22);
            this.BtFireEngineer.Name = "BtFireEngineer";
            this.BtFireEngineer.Size = new System.Drawing.Size(128, 27);
            this.BtFireEngineer.TabIndex = 13;
            this.BtFireEngineer.Text = "Engineer";
            this.BtFireEngineer.UseVisualStyleBackColor = true;
            this.BtFireEngineer.Click += new System.EventHandler(this.BtFireEngineer_Click);
            // 
            // BtFireTeacher
            // 
            this.BtFireTeacher.Location = new System.Drawing.Point(23, 55);
            this.BtFireTeacher.Name = "BtFireTeacher";
            this.BtFireTeacher.Size = new System.Drawing.Size(128, 27);
            this.BtFireTeacher.TabIndex = 14;
            this.BtFireTeacher.Text = "Teacher";
            this.BtFireTeacher.UseVisualStyleBackColor = true;
            this.BtFireTeacher.Click += new System.EventHandler(this.BtFireTeacher_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.informationToolStripMenuItem.Text = "New";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // tbFaculty
            // 
            this.tbFaculty.Location = new System.Drawing.Point(587, 77);
            this.tbFaculty.Name = "tbFaculty";
            this.tbFaculty.ReadOnly = true;
            this.tbFaculty.Size = new System.Drawing.Size(54, 21);
            this.tbFaculty.TabIndex = 19;
           // this.tbFaculty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Numb. of Faculties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFaculty);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtUniteUn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtDone);
            this.Controls.Add(this.TbUnName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "University";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbUnName;
        private System.Windows.Forms.Button BtDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtUniteUn;
        private System.Windows.Forms.Button BtAddmition;
        private System.Windows.Forms.Button BtExpulsion;
        private System.Windows.Forms.Button BtAddLectorium;
        private System.Windows.Forms.Button BtAddLaboratory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtHireEngineer;
        private System.Windows.Forms.Button BtHireTeacher;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtFireEngineer;
        private System.Windows.Forms.Button BtFireTeacher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.TextBox tbFaculty;
        private System.Windows.Forms.Label label3;
    }
}

