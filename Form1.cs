using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4__Lists
{

    public partial class Form1 : Form
    {             
        List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();           
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            string name, position, city, street;
            decimal salary;
            int number;

            if (!string.IsNullOrEmpty(nameTextBox.Text) && posComboBox.SelectedItem != null &&
                cityComboBox.SelectedItem != null && streetComboBox.SelectedItem != null)
            {                
                name = nameTextBox.Text;
                position = posComboBox.SelectedItem.ToString();
                city = cityComboBox.SelectedItem.ToString();
                street = streetComboBox.SelectedItem.ToString();
                salary = salNumericUpDown.Value;
                number = int.Parse(numHpuseTextBox.Text);
                Employee tempemp = new Employee(name, salary, position, city, street, number);

                employees.Add(tempemp);

                empListBox.Items.Add(tempemp.ToString());
                ClearFields();
            }
            else
            {
                MessageBox.Show("Fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void newPosButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newPosTextBox.Text))
            {
                posComboBox.Items.Add(newPosTextBox.Text);
                newPosTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Enter new position!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void newCityButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newCityTextBox.Text))
            {
                cityComboBox.Items.Add(newCityTextBox.Text);
                newCityTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Enter new city!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void newStreetButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newStreetTextBox.Text))
            {
                streetComboBox.Items.Add(newStreetTextBox.Text);
            newStreetTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Enter new street!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            try
            {
                using (Stream fStream = File.Create("employees.bin"))
                {
                    binFormat.Serialize(fStream, employees);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            try
            {
                using (Stream fStream = File.OpenRead("employees.bin"))
                {
                    employees = (List<Employee>)binFormat.Deserialize(fStream);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            empListBox.Items.Clear();
            foreach (var item in employees)
            {
                empListBox.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (empListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No selected items!");
                return;
            }

            for (int i = 0; i < empListBox.SelectedItems.Count; i++)
            {
                empListBox.Items.Remove(empListBox.SelectedItems[i]);
                --i;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (empListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No selected items!");
                return;
            }

            
            int index = empListBox.SelectedIndex;
               
            nameTextBox.Text = employees[index].FullName;
            posComboBox.SelectedItem = employees[index].Position;
            cityComboBox.SelectedItem = employees[index].City;
            streetComboBox.SelectedItem = employees[index].Street;
            salNumericUpDown.Value = employees[index].Salary;
            numHpuseTextBox.Text = employees[index].NumberOfHouse.ToString();

            confirmEditButton.Enabled = true;
            confirmEditButton.Visible = true;
            addEmpButton.Enabled = false;
            addEmpButton.Visible = false;


        }

        private void confirmEditButton_Click(object sender, EventArgs e)
        {
            int index = empListBox.SelectedIndex;


            if (!string.IsNullOrEmpty(nameTextBox.Text) && posComboBox.SelectedItem != null &&
                cityComboBox.SelectedItem != null && streetComboBox.SelectedItem != null)
            {
                employees[index].FullName = nameTextBox.Text;
                employees[index].Position = posComboBox.SelectedItem.ToString();
                employees[index].City = cityComboBox.SelectedItem.ToString();
                employees[index].Street = streetComboBox.SelectedItem.ToString();
                employees[index].Salary = salNumericUpDown.Value;
                employees[index].NumberOfHouse = int.Parse(numHpuseTextBox.Text);

                empListBox.Items.RemoveAt(index);
                empListBox.Items.Insert(index, employees[index]);
               
                ClearFields();
                confirmEditButton.Enabled = false;
                confirmEditButton.Visible = false;
                addEmpButton.Enabled = true;
                addEmpButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ClearFields();
        }

        private void ClearFields()
        {
            nameTextBox.Text = "";
            posComboBox.SelectedIndex = -1;
            cityComboBox.SelectedIndex = -1;
            streetComboBox.SelectedIndex=-1;
            salNumericUpDown.Value = salNumericUpDown.Minimum;
            numHpuseTextBox.Text = "" ;
        }

        private void empListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (empListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No selected items!");
                return;
            }

            int index = empListBox.SelectedIndex;

            MessageBox.Show($"Fullname: { employees[index].FullName}\n" +
                $"Salary: {employees[index].Salary}\n" +
                $"Position: {employees[index].Position}\n" +
                $"Address: {employees[index].City}, {employees[index].Street} St., {employees[index].NumberOfHouse}\n","Employee info");
           
        }
    }
}
