namespace _4__Lists
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numHpuseTextBox = new System.Windows.Forms.TextBox();
            this.posComboBox = new System.Windows.Forms.ComboBox();
            this.salNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.streetComboBox = new System.Windows.Forms.ComboBox();
            this.addEmpButton = new System.Windows.Forms.Button();
            this.newPosButton = new System.Windows.Forms.Button();
            this.newPosTextBox = new System.Windows.Forms.TextBox();
            this.newCityTextBox = new System.Windows.Forms.TextBox();
            this.newCityButton = new System.Windows.Forms.Button();
            this.newStreetTextBox = new System.Windows.Forms.TextBox();
            this.newStreetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmEditButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Street:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of the house:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(632, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "= List of employees =";
            // 
            // empListBox
            // 
            this.empListBox.FormattingEnabled = true;
            this.empListBox.HorizontalScrollbar = true;
            this.empListBox.Location = new System.Drawing.Point(576, 52);
            this.empListBox.MultiColumn = true;
            this.empListBox.Name = "empListBox";
            this.empListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.empListBox.Size = new System.Drawing.Size(303, 251);
            this.empListBox.TabIndex = 7;
            this.empListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.empListBox_MouseDoubleClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(131, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(157, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // numHpuseTextBox
            // 
            this.numHpuseTextBox.Location = new System.Drawing.Point(178, 270);
            this.numHpuseTextBox.Name = "numHpuseTextBox";
            this.numHpuseTextBox.Size = new System.Drawing.Size(110, 20);
            this.numHpuseTextBox.TabIndex = 9;
            // 
            // posComboBox
            // 
            this.posComboBox.FormattingEnabled = true;
            this.posComboBox.Items.AddRange(new object[] {
            "Director",
            "Manager",
            "Secretary",
            "Cleaner",
            "Guardian",
            "Accountant"});
            this.posComboBox.Location = new System.Drawing.Point(131, 94);
            this.posComboBox.Name = "posComboBox";
            this.posComboBox.Size = new System.Drawing.Size(157, 21);
            this.posComboBox.TabIndex = 10;
            // 
            // salNumericUpDown
            // 
            this.salNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salNumericUpDown.Location = new System.Drawing.Point(131, 137);
            this.salNumericUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.salNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salNumericUpDown.Name = "salNumericUpDown";
            this.salNumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.salNumericUpDown.TabIndex = 11;
            this.salNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(216, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "$";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Rivne",
            "Lviv",
            "Kiev",
            "Dnipro",
            "Odessa"});
            this.cityComboBox.Location = new System.Drawing.Point(131, 182);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(157, 21);
            this.cityComboBox.TabIndex = 13;
            // 
            // streetComboBox
            // 
            this.streetComboBox.FormattingEnabled = true;
            this.streetComboBox.Items.AddRange(new object[] {
            "Shevchenko",
            "Soborna",
            "Zgodu",
            "Sonjachna"});
            this.streetComboBox.Location = new System.Drawing.Point(131, 224);
            this.streetComboBox.Name = "streetComboBox";
            this.streetComboBox.Size = new System.Drawing.Size(157, 21);
            this.streetComboBox.TabIndex = 14;
            // 
            // addEmpButton
            // 
            this.addEmpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmpButton.Location = new System.Drawing.Point(18, 326);
            this.addEmpButton.Name = "addEmpButton";
            this.addEmpButton.Size = new System.Drawing.Size(270, 68);
            this.addEmpButton.TabIndex = 15;
            this.addEmpButton.Text = "Add employee";
            this.addEmpButton.UseVisualStyleBackColor = true;
            this.addEmpButton.Click += new System.EventHandler(this.addEmpButton_Click);
            // 
            // newPosButton
            // 
            this.newPosButton.Location = new System.Drawing.Point(449, 83);
            this.newPosButton.Name = "newPosButton";
            this.newPosButton.Size = new System.Drawing.Size(82, 43);
            this.newPosButton.TabIndex = 16;
            this.newPosButton.Text = "Add new position";
            this.newPosButton.UseVisualStyleBackColor = true;
            this.newPosButton.Click += new System.EventHandler(this.newPosButton_Click);
            // 
            // newPosTextBox
            // 
            this.newPosTextBox.Location = new System.Drawing.Point(308, 95);
            this.newPosTextBox.Name = "newPosTextBox";
            this.newPosTextBox.Size = new System.Drawing.Size(119, 20);
            this.newPosTextBox.TabIndex = 17;
            // 
            // newCityTextBox
            // 
            this.newCityTextBox.Location = new System.Drawing.Point(308, 184);
            this.newCityTextBox.Name = "newCityTextBox";
            this.newCityTextBox.Size = new System.Drawing.Size(119, 20);
            this.newCityTextBox.TabIndex = 19;
            // 
            // newCityButton
            // 
            this.newCityButton.Location = new System.Drawing.Point(449, 183);
            this.newCityButton.Name = "newCityButton";
            this.newCityButton.Size = new System.Drawing.Size(82, 25);
            this.newCityButton.TabIndex = 18;
            this.newCityButton.Text = "Add new city";
            this.newCityButton.UseVisualStyleBackColor = true;
            this.newCityButton.Click += new System.EventHandler(this.newCityButton_Click);
            // 
            // newStreetTextBox
            // 
            this.newStreetTextBox.Location = new System.Drawing.Point(308, 226);
            this.newStreetTextBox.Name = "newStreetTextBox";
            this.newStreetTextBox.Size = new System.Drawing.Size(119, 20);
            this.newStreetTextBox.TabIndex = 21;
            // 
            // newStreetButton
            // 
            this.newStreetButton.Location = new System.Drawing.Point(449, 216);
            this.newStreetButton.Name = "newStreetButton";
            this.newStreetButton.Size = new System.Drawing.Size(82, 38);
            this.newStreetButton.TabIndex = 20;
            this.newStreetButton.Text = "Add new street";
            this.newStreetButton.UseVisualStyleBackColor = true;
            this.newStreetButton.Click += new System.EventHandler(this.newStreetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(28, 28);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 30);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(28, 64);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(108, 30);
            this.loadButton.TabIndex = 23;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(576, 326);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 68);
            this.editButton.TabIndex = 24;
            this.editButton.Text = " Edit employee";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(779, 326);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 68);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Delete employee";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(344, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 112);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // confirmEditButton
            // 
            this.confirmEditButton.Enabled = false;
            this.confirmEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmEditButton.Location = new System.Drawing.Point(18, 326);
            this.confirmEditButton.Name = "confirmEditButton";
            this.confirmEditButton.Size = new System.Drawing.Size(270, 68);
            this.confirmEditButton.TabIndex = 27;
            this.confirmEditButton.Text = "Confirm edited";
            this.confirmEditButton.UseVisualStyleBackColor = true;
            this.confirmEditButton.Visible = false;
            this.confirmEditButton.Click += new System.EventHandler(this.confirmEditButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(606, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "(Double click on item to show employee info)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(921, 419);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirmEditButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newStreetTextBox);
            this.Controls.Add(this.newStreetButton);
            this.Controls.Add(this.newCityTextBox);
            this.Controls.Add(this.newCityButton);
            this.Controls.Add(this.newPosTextBox);
            this.Controls.Add(this.newPosButton);
            this.Controls.Add(this.addEmpButton);
            this.Controls.Add(this.streetComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salNumericUpDown);
            this.Controls.Add(this.posComboBox);
            this.Controls.Add(this.numHpuseTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.empListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.salNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox empListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numHpuseTextBox;
        private System.Windows.Forms.ComboBox posComboBox;
        private System.Windows.Forms.NumericUpDown salNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox streetComboBox;
        private System.Windows.Forms.Button addEmpButton;
        private System.Windows.Forms.Button newPosButton;
        private System.Windows.Forms.TextBox newPosTextBox;
        private System.Windows.Forms.TextBox newCityTextBox;
        private System.Windows.Forms.Button newCityButton;
        private System.Windows.Forms.TextBox newStreetTextBox;
        private System.Windows.Forms.Button newStreetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button confirmEditButton;
        private System.Windows.Forms.Label label9;
    }
}

