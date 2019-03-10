using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MASGlobalApp.Business.Interfaces
{
    public interface IEmployee
    {
        string Id { get; set; }
        string Name { get; set; }
        string ContractTypeName { get; set; }
        string RoleId { get; set; }
        string RoleName { get; set; }
        string RoleDescription { get; set; }
        int HourlySalary { get; set; }
        int MonthlySalary { get; set; }
        int AnnualSalary { get; set; }

        void CalculateAnnualSalary();
    }
}
