using MASGlobalApp.Business.Interfaces;
using System;
using System.Runtime.Serialization;

namespace MASGlobalApp.Business.Classes
{
    [Serializable]
    [DataContract]
    public class MonthlyContractEmployeeDto : Employee
    {

        public MonthlyContractEmployeeDto(Employee employee)
        {
            id = employee.id;
            name = employee.name;
            contractTypeName = employee.contractTypeName;
            roleId = employee.roleId;
            roleName = employee.roleName;
            roleDescription = employee.roleDescription;
            hourlySalary = employee.hourlySalary;
            monthlySalary = employee.monthlySalary;

            CalculateAnnualSalary();
        }

        override public void CalculateAnnualSalary()
        {
            annualSalary = monthlySalary * 120 * 12;
        }
    }
}