using System;

namespace HRManager
{
    public class Employee
    {
        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string PaySummary
        {
            get { return $"No pay info for {FirstName} {LastName}."; }
        }
    }
}
