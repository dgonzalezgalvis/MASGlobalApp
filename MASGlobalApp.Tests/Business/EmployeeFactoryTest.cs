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
    class EmployeeFactoryTest
    {
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
            var myFactoryEmployeeDto = EmployeeFactory.GetEmployee(myEmployeeDto);

            Assert.IsNotNull(myFactoryEmployeeDto);
            Assert.AreEqual(myFactoryEmployeeDto, typeof(HourlyContractEmployeeDto));
            Assert.IsNotNull(myFactoryEmployeeDto.annualSalary);
            Assert.AreEqual(myFactoryEmployeeDto.annualSalary, hourlySalary * 12);
        }

        [TestMethod]
        public void CreateMontlyContractEmployeeDto()
        {
            var monthlySalary = 20;
            var myEmployeeDto = new EmployeeDto()
            {
                id = "1",
                name = "Diego",
                contractTypeName = "HourlySalaryEmployee",
                monthlySalary = monthlySalary,
                hourlySalary = 0

            };
            var myFactoryEmployeeDto = EmployeeFactory.GetEmployee(myEmployeeDto);

            Assert.IsNotNull(myFactoryEmployeeDto);
            Assert.AreEqual(myFactoryEmployeeDto, typeof(MonthlyContractEmployeeDto));
            Assert.IsNotNull(myFactoryEmployeeDto.annualSalary);
            Assert.AreEqual(myFactoryEmployeeDto.annualSalary, monthlySalary * 12);
        }
    }
}
