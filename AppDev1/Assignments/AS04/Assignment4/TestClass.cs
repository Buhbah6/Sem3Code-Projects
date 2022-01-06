using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace Assignment4
{
    class TestClass
    {
        public static Rootobject getEmployeeData()
        {
            Rootobject result = null;
            var client = new RestClient("http://dummy.restapiexample.com/api/v1/");
            var request = new RestRequest("employees");
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;
                result = JsonConvert.DeserializeObject<Rootobject>(rawResponse);
            }
            return result;
        }

        /*
        public static void CreateEmployee()
        {
            var client = new RestClient("http://dummy.restapiexample.com/api/v1/");
            var request = new RestRequest("create", Method.POST);
            request.AddParameter("Name", "Test Employee");
            request.AddParameter("Salary", "123");
            request.AddParameter("Age", "23");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            var response = client.Execute(request);
        }
        */
    }
    public class Rootobject
    {
        public string status { get; set; }
        public Datum[] data { get; set; }
        public string message { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }
    }

}
