using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace S1V2
{
    public partial class EmployeeUi : Form
    {
        private DataGridView tblEmployee;
        private DataTable dataTable;

        public EmployeeUi()
        {
            InitializeComponent();
            LoadView();
            LoadTable();
            LoadGender();
        }

        private void LoadView()
        {
            dataTable = new DataTable();
            tblEmployee = new DataGridView();
            tblEmployee.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(tblEmployee);
        }

        private void LoadTable()
        {
            List<Employee> employees = EmployeeController.Get(null);
            FillTable(employees);
        }

        private void LoadGender()
        {
            List<Gender> genderList = GenderController.Get();
            cmbSearchGender.Items.Add("Select a Gender");
            cmbSearchGender.SelectedIndex = 0;

            foreach (Gender gender in genderList)
            {
                cmbSearchGender.Items.Add(gender);
            }
            cmbSearchGender.DisplayMember = "Name";
        }

        private void FillTable(List<Employee> employees)
        {
            dataTable.Clear();
            dataTable.Columns.Clear();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("NIC", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Designation", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));

            foreach (Employee emp in employees)
            {
                dataTable.Rows.Add(emp.Id, emp.Name, emp.Nic, emp.Gender.Name, emp.Designation.Name, emp.Employeestatus.Name);
            }

            tblEmployee.DataSource = dataTable;
        }

        private void ClearSearch(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Clear?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtSearchName.Text = "";
                cmbSearchGender.SelectedIndex = 0;
                LoadTable();
            }
        }

        private void SeachByName(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();
            string name = txtSearchName.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                hashtable.Add("name", name);
            }

            if (cmbSearchGender.SelectedItem != null && cmbSearchGender.SelectedIndex != 0)
            {
                Gender selectedGender = (Gender)cmbSearchGender.SelectedItem;
                hashtable.Add("gender", selectedGender);
            }

            if (hashtable.Count > 0)
            {
                List<Employee> employees = EmployeeController.Get(hashtable);
                FillTable(employees);
            }
            else
            {
                MessageBox.Show("Please provide at least one search value.");
            }
        }

    }
}
