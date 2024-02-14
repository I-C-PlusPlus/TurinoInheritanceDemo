using System;

namespace HRManager
{
    public class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee() : base()
        {
            HourlyRate = 15.00M; 
        }

        public override string PaySummary
        {
            get { return $"Hourly employee {FirstName} {LastName} is owed {HourlyRate * 40M:C} for the week."; }
        }
    }
}
