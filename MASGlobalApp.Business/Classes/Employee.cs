using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MASGlobalApp.Business.Classes
{
    [Serializable]
    [DataContract]
    public abstract class Employee
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string contractTypeName { get; set; }
        [DataMember]
        public string roleId { get; set; }
        [DataMember]
        public string roleName { get; set; }
        [DataMember]
        public string roleDescription { get; set; }
        [DataMember]
        public int hourlySalary { get; set; }
        [DataMember]
        public int monthlySalary { get; set; }
        [DataMember]
        public int annualSalary { get; set; }

        public abstract void CalculateAnnualSalary();
    }
}