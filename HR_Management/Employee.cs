using System;

namespace HR_Management
{
    class Employee 
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public double Salary { get; set; }

        public int NumberOfVacationDays { get; set; }

        public int UsedVacationDays { get; set; }

        public int RemainingVacationDays { get; set; }

        public DateTime HireDay { get; set; }

        public DateTime? ReleaseDay { get; set; }

        public bool RealeaseWorker { get; set; }

        public bool SickLeave { get; set; }

        public string Comments { get; set; }

    }
}
