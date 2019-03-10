using MASGlobalApp.Business.Interfaces;

namespace MASGlobalApp.Business.Classes
{
    public class EmployeeFactory
    {
        public static Employee GetEmployee(Employee employee)
        {
            if (employee.contractTypeName.Equals("HourlySalaryEmployee"))
            {
                return new HourlyContractEmployeeDto(employee);
            }

            return new MonthlyContractEmployeeDto(employee);
        }
    }
}