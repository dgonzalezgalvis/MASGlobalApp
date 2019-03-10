using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MASGlobalApp.Business.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MASGlobalApp.Tests.Business
{
    [TestClass]
    class EmployeeDtoTest
    {
        [TestMethod]
        public void CreateEmployeeDto()
        {
            var myEmployeeDto = new EmployeeDto();

            Assert.IsNotNull(myEmployeeDto);
            Assert.IsNotNull(myEmployeeDto.annualSalary);
            Assert.AreEqual(myEmployeeDto.annualSalary,0);
        }

        [TestMethod]
        public void CreateMontlyContractEmployeeDto()
        {
            var monthlySalary = 20;
            var myEmployeeDto = new EmployeeDto()
            {
                   id="1",
                   name="Diego",
                   contractTypeName = "HourlySalaryEmployee",
                   monthlySalary = monthlySalary,
                   hourlySalary = 0

            };
            var myMonthlyContractEmployeeDto = new MonthlyContractEmployeeDto(myEmployeeDto);

            Assert.IsNotNull(myMonthlyContractEmployeeDto);
            Assert.IsNotNull(myMonthlyContractEmployeeDto.annualSalary);
            Assert.AreEqual(myMonthlyContractEmployeeDto.annualSalary, monthlySalary*12);
        }

        [TestMethod]
        public void CreateHourlyContractEmployeeDto()
        {
            var hourlySalary = 20;
            var myEmployeeDto = new EmployeeDto()
            {
                id = "1",
                name = "Diego",
                contractTypeName = "HourlySalaryEmployee",
                monthlySalary = 0,
                hourlySalary = hourlySalary

            };
            var myHurlylyContractEmployeeDto = new HourlyContractEmployeeDto(myEmployeeDto);

            Assert.IsNotNull(myHurlylyContractEmployeeDto);
            Assert.IsNotNull(myHurlylyContractEmployeeDto.annualSalary);
            Assert.AreEqual(myHurlylyContractEmployeeDto.annualSalary, hourlySalary * 12 * 120);
        }
    }
}
