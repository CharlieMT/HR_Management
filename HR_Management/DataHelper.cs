using System;
using System.Collections.Generic;
using System.IO;

namespace HR_Management
{
    class DataHelper
    {
        private List<string> departments = new List<string>()
        {
            "Kadry", "Logistyka", "Rachunkowość", "Obsługa", "Produkcja"
        };

        public List<string> Departments
        {
            get
            {
                return departments;
            }
        }

        private static string employeeFile = Path.Combine(Environment.CurrentDirectory, "employee.txt");

        public string EmployeeFilePath
        {
            get
            {
                return employeeFile;
            }
        }

        private List<string> filterYesNo = new List<string> { "Wszystko","Tak", "Nie" };

        public List<string> FilterYesNo
        {
            get
            {
                return filterYesNo;
            }
        }

    }
}
