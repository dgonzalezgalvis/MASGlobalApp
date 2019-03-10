using MASGlobalApp.Business.Interfaces;

namespace MASGlobalApp.Business.Classes
{
    public class EmployeeDto : Employee
    {
        override public void CalculateAnnualSalary()
        {
            this.annualSalary = 0;
        }
    }
}