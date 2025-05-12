using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication8.Models;
using static System.Net.WebRequestMethods;
namespace WebApplication8.Controllers
{
    public class branchController : Controller
    {
        public IActionResult homepage()
        {
            return View();
        }
        public IActionResult getalldetails()
        {
            return View();
        }
        public IActionResult getbynameandid()
        {
            return View();
        }
        public IActionResult getbyid()
        {
            return View();
        }

        public IActionResult viewbranchreport_model()
        {
            return View();
        }


        public IActionResult searchbranch_model()
        {
            return View();
        }


        public string getAPIData(string datas)     //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7183/" + datas;

            // Create an instance of HttpClient to make the HTTP request
            using (var client = new HttpClient())
            {
                // Initialize a variable to hold the response data
                string data = "";
                // Set the base address of the HttpClient to the constructed API path
                client.BaseAddress = new Uri(ApiPath);
                // Make a GET request to the API and wait for the result
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                // Check if the response indicates success
                if (result.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    data = result.Content.ReadAsStringAsync().Result;
                }
                // Return the response data 
                return data;
            }
        }

        public List<branchmodel> getapidata_model(string datas)   //Get API Response  //----branchmodel this should be same as our model class name
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7183/" + datas;  //this link shoul be taken from the api swagger window

            // Create an instance of HttpClient to make the HTTP request
            using (var client = new HttpClient())
            {
                // Initialize a variable to hold the response data

                List<branchmodel> branches = new List<branchmodel>();
                //string data = "";
                // Set the base address of the HttpClient to the constructed API path
                client.BaseAddress = new Uri(ApiPath);
                // Make a GET request to the API and wait for the result
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                // Check if the response indicates success
                if (result.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    var jsonData = result.Content.ReadAsStringAsync().Result;
                    var apiResponse = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);

                    foreach (var item in apiResponse)
                    {
                        var branch = new branchmodel
                        {
                           brId = item.brid,  //item.brid-this brid should be same as those in api swagger window-------brId this should be same as those in model
                            Name = item.brname,
                            head = item.head,
                            noofemployees = item.noofemployees
                        };
                        branches.Add(branch);
                    }

                }
                return branches;

            }
        }

    }
}
