using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HR_Management.Properties;

namespace HR_Management
{

    public partial class Main : Form
    {

        private List<Employee> employeesList = new List<Employee>();

        private FileHelper<List<Employee>> fileHelper;

        private DataHelper dataHelper = new DataHelper();

        public bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;
            }
        }

        public Main()
        {
            InitializeComponent();
            
            fileHelper = new FileHelper<List<Employee>>(dataHelper.EmployeeFilePath);
            dgvEmployeeInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployeeInfo.RowHeadersVisible = false;
            SetFilterValues();
            EmployeeData_DataRefreshEvent();
            SetColumnsHeader();

            if (IsMaximize)
                WindowState = FormWindowState.Maximized;

            
        }

        private void SetColumnsHeader()
        {
            dgvEmployeeInfo.Columns[0].HeaderText = "ID";
            dgvEmployeeInfo.Columns[1].HeaderText = "Dział";
            dgvEmployeeInfo.Columns[2].HeaderText = "Imie";
            dgvEmployeeInfo.Columns[3].HeaderText = "Nazwisko";
            dgvEmployeeInfo.Columns[4].HeaderText = "Wypłata";
            dgvEmployeeInfo.Columns[5].HeaderText = "Liczba Dni Urlopowych";
            dgvEmployeeInfo.Columns[6].HeaderText = "Wykozystane Dni Uroplu";
            dgvEmployeeInfo.Columns[7].HeaderText = "Pozostałe Dni Urlopu";
            dgvEmployeeInfo.Columns[8].HeaderText = "Dzień Zatrudnienia";
            dgvEmployeeInfo.Columns[9].HeaderText = "Dzień Zwolnienia";
            dgvEmployeeInfo.Columns[10].HeaderText = "Zwolniony";
            dgvEmployeeInfo.Columns[11].HeaderText = "L4";
            dgvEmployeeInfo.Columns[12].HeaderText = "Komentarz";
            dgvEmployeeInfo.RowTemplate.ReadOnly = true;
        }

        private void SetFilterValues()
        {
            var dataHelperFilter = dataHelper.Departments;
            dataHelperFilter.Insert(0, "Wszystko");
            cbxDepartmentFilter.DataSource = dataHelperFilter;
            cbxWorkingFilter.DataSource = new List<string>( dataHelper.FilterYesNo);
            cbxSickFilter.DataSource = new List<string>(dataHelper.FilterYesNo);

            cbxDepartmentFilter.SelectedIndex = 0;
            cbxWorkingFilter.SelectedIndex = 0;
            cbxSickFilter.SelectedIndex = 0;
        }

        private List<Employee> FilterDataGridView()
        {
            var departmentFilter = cbxDepartmentFilter.SelectedItem.ToString();
            var workingFilter = cbxWorkingFilter.SelectedItem.ToString();
            var sickFilter = cbxSickFilter.SelectedItem.ToString();

            var filteredEmplyeeList = new List<Employee>(employeesList);

            if (!departmentFilter.Equals("Wszystko"))
                filteredEmplyeeList = filteredEmplyeeList.Where(x => x.Department.Equals(departmentFilter)).ToList();

            if (!workingFilter.Equals("Wszystko"))
            {
                var working = ChangeYesNotToBool(workingFilter);
                filteredEmplyeeList = filteredEmplyeeList.Where(x => x.RealeaseWorker.Equals(!working)).ToList();
            }

            if (!sickFilter.Equals("Wszystko"))
            {
                var sick = ChangeYesNotToBool(sickFilter);
                filteredEmplyeeList = filteredEmplyeeList.Where(x => x.SickLeave.Equals(sick)).ToList();
            }

            return filteredEmplyeeList;

        }

        private bool ChangeYesNotToBool(string str)
        {
            if (str.Equals("Tak"))
                return true;

            return false;
        }

        private void EmployeeData_DataRefreshEvent()
        {
            LoadEmployeeDataFromFile();

            var filteredEmplyeeList = FilterDataGridView();

            SortEmplyeeList(filteredEmplyeeList);

        }

        private void SortEmplyeeList(List<Employee> emplyeeList)
        {
            var sortedEmployeeList = emplyeeList.OrderBy(x => x.Id).ToList<Employee>();

            if (sortedEmployeeList != null)
                FillUpEmployeeDataGridView(sortedEmployeeList);
        }

        private void LoadEmployeeDataFromFile()
        {
            employeesList = fileHelper.DeserializeData();
            if (employeesList == null)
                employeesList = new List<Employee>();
        }

        private void FillUpEmployeeDataGridView(List<Employee> newEmployeeList)
        {
            dgvEmployeeInfo.DataSource = newEmployeeList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var employeeData = new EmplyeeData();
            employeeData.DataRefreshEvent += EmployeeData_DataRefreshEvent;
            employeeData.NewEmployee();
            employeeData.ShowDialog();
            employeeData.DataRefreshEvent -= EmployeeData_DataRefreshEvent;
        }

        private void btnEddit_Click(object sender, EventArgs e)
        {
            var employeeData = new EmplyeeData();
            employeeData.DataRefreshEvent += EmployeeData_DataRefreshEvent;
            var id = Convert.ToInt32(dgvEmployeeInfo.SelectedRows[0].Cells["Id"].Value);
            employeeData.EmployeeEdit(id);
            employeeData.ShowDialog();
            employeeData.DataRefreshEvent -= EmployeeData_DataRefreshEvent;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            EmployeeData_DataRefreshEvent();
        }

        private void cbxWorkingFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EmployeeData_DataRefreshEvent();
        }

        private void cbxDepartmentFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EmployeeData_DataRefreshEvent();
        }

        private void cbxSickFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EmployeeData_DataRefreshEvent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximize = true;
            else
                IsMaximize = false;

            Settings.Default.Save();
        }
    }
}
