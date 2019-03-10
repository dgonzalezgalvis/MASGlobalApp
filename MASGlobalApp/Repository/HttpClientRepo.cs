using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MASGlobalApp.Business.Interfaces;
using MASGlobalApp.Business.Classes;

namespace MASGlobalApp.Repository
{
    public class HttpClientRepo
    {
        private HttpClient client = new HttpClient();
        private static string userAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36";
        private static Uri url = new Uri("http://masglobaltestapi.azurewebsites.net/api/Employees");

        public List<IEmployee> list;

        public static List<EmployeeDto> GetEmployees()
        {
            var list = new List<EmployeeDto>();
            using (
                var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
                var response = httpClient.GetStringAsync(url).Result;
                list = JArray.Parse(response).ToObject<List<EmployeeDto>>();
                foreach(var employee in list)
                {
                    employee.annualSalary = EmployeeFactory.GetEmployee(employee).annualSalary;
                }
            }

            return list;
        }
    }
}