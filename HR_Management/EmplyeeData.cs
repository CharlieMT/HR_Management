using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace HR_Management
{
    public partial class EmplyeeData : Form
    {
        public delegate void EmployeeDataRefresh();

        public event EmployeeDataRefresh DataRefreshEvent;

        private List<Employee> employeeList;

        private DataHelper dataHelper = new DataHelper();

        private Employee employee;

        private FileHelper<List<Employee>> employeeFileHelper;

        public EmplyeeData()
        {
            InitializeComponent();
            SetStartingValues();
            SetReleaseDateTimePicker();
        }

        private void SetStartingValues()
        {
            employeeFileHelper = new FileHelper<List<Employee>>(dataHelper.EmployeeFilePath);
            employeeList = employeeFileHelper.DeserializeData();
            tbEmployeeNumber.ReadOnly = true;
        }

        private void SetReleaseDateTimePicker()
        {
            dtpReleaseDay.CustomFormat = " ";
            dtpReleaseDay.Format = cbxReleaseWorker.Checked ? DateTimePickerFormat.Short : DateTimePickerFormat.Custom;
        }

        private void OnDataRefresh()
        {
            DataRefreshEvent?.Invoke();
        }

        public void NewEmployee()
        {
            this.Text = "Nowy Pracownik";
            tbEmployeeNumber.Text = GetHighestEmployeeIdNumber().ToString();
            cbxDepartment.DataSource = dataHelper.Departments;
        }

        public void EmployeeEdit(int id)
        {
            this.Text = "Edycja Pracownika";
            employee = employeeList.FirstOrDefault(x => x.Id == id);

            if (employee != null)
                EmployeeDataLoader();
        }

        private void EmployeeDataColector()
        {
            employee = new Employee();

            employee.Id = Convert.ToInt32(tbEmployeeNumber.Text);
            employee.Department = cbxDepartment.SelectedItem.ToString();
            employee.Name = tbName.Text;
            employee.LastName = tbName.Text;
            employee.Salary = Convert.ToDouble(tbSalary.Text);
            employee.NumberOfVacationDays = Convert.ToInt32(tbNumberOfVacationDays.Text);
            employee.RemainingVacationDays = Convert.ToInt32(tbRemainVacationDays.Text);
            employee.UsedVacationDays = Convert.ToInt32(tbUsedVacationDays.Text);
            employee.HireDay = dtpHireDay.Value;
            employee.RealeaseWorker = cbxReleaseWorker.Checked;
            employee.SickLeave = ckbSickLeave.Checked;
            employee.Comments = rtbComments.Text;
            if (!cbxReleaseWorker.Checked)
                employee.ReleaseDay = null;
            else
                employee.ReleaseDay = dtpReleaseDay.Value;
        }


        private int GetHighestEmployeeIdNumber()
        {
            if (employeeList != null)
            {
                var id = employeeList.OrderBy(x => x.Id).LastOrDefault().Id;
                return ++id;
            }

            return 1;
        }

        private void EmployeeDataLoader()
        {
            tbEmployeeNumber.Text = employee.Id.ToString();
            cbxDepartment.DataSource = dataHelper.Departments;
            cbxDepartment.SelectedItem = employee.Department;
            tbName.Text = employee.Name;
            tbLastName.Text = employee.LastName;
            tbSalary.Text = employee.Salary.ToString();
            tbNumberOfVacationDays.Text = employee.NumberOfVacationDays.ToString();
            tbRemainVacationDays.Text = employee.RemainingVacationDays.ToString();
            tbUsedVacationDays.Text = employee.UsedVacationDays.ToString();
            dtpHireDay.Value = employee.HireDay;
            cbxReleaseWorker.Checked = employee.RealeaseWorker;
            employee.SickLeave = employee.SickLeave;
            employee.Comments = employee.Comments;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (employeeList == null)
                employeeList = new List<Employee>();

            if (employeeList.Contains(employee))
                employeeList.Remove(employee);

            EmployeeDataColector();

            employeeList.Add(employee);
            employeeFileHelper.SerializeData(employeeList);

            OnDataRefresh();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnDataRefresh();
            Close();
        }

        private void cbxReleaseWorker_CheckedChanged(object sender, EventArgs e)
        {
            SetReleaseDateTimePicker();
        }
    }
}
