using System.Text;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using WebApplicationmvc_1___7.Models;

namespace WebApplicationmvc_1___7.Controllers
{
    public class EmployeeController1 : Controller
    {

        public IActionResult homepage()
        {
            return View();
        }
        public IActionResult viewemployeereport()
        {
            return View();
        }
        public IActionResult insertemployee()
        {
            return View();
        }

        public IActionResult viewemployeereport_model()
        {
            return View();
        }

        public IActionResult insertemployee_model()
        {
            return View();
        }

        public string getAPIData(string datas)     //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7082/" + datas;

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






        public async Task<dynamic> PostAPIData(string datas)


        {
            string[] datastring1 = datas.Split("$");
            string ApiPath = "https://localhost:7082/" + datastring1[0];
            var data = "";

            string[] datastring2 = datastring1[1].Split("-");
            using (HttpClient client = new HttpClient())
            {
                string content = JsonConvert.SerializeObject(new
                {
                    id = datastring2[0],
                    name = datastring2[1],
                    designation = datastring2[2],
                    department = datastring2[3]
                });




                var buffer = Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new
                    System.Net.Http.Headers.MediaTypeHeaderValue
                    ("application/json");

                HttpResponseMessage result = await client.PostAsync(ApiPath, byteContent);
                if (result.IsSuccessStatusCode)
                {
                    data = result.Content.ReadAsStringAsync().Result;
                }

            }
            return data;

        }


        public List<employeemodel> getapidata_model(string datas)   //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7082/" + datas;

            // Create an instance of HttpClient to make the HTTP request
            using (var client = new HttpClient())
            {
                // Initialize a variable to hold the response data

                List<employeemodel> employees = new List<employeemodel>();
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
                        var employee = new employeemodel
                        {
                            empcode = item.id,
                            empname = item.name,
                            position = item.designation,
                            emp_department = item.department,
                        };
                        employees.Add(employee);
                    }

                }
                return employees;

            }
        }



        public async Task<IActionResult> PostAPIData_model([FromBody] employeemodel employee)

        {
           
            string ApiPath = "https://localhost:7082/insertemployee";
            var apidata = new
            {
                id = employee.empcode,
                name = employee.empname,
                designation = employee.position,
                department = employee.emp_department
            };
            var data = "";
            using (HttpClient client = new HttpClient())
            {
                string content = JsonConvert.SerializeObject(apidata);

                var buffer = Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new
                    System.Net.Http.Headers.MediaTypeHeaderValue
                    ("application/json");

                HttpResponseMessage result = await client.PostAsync(ApiPath,byteContent);
                if (result.IsSuccessStatusCode)
                {
                    data = await result.Content.ReadAsStringAsync();
                    return Ok(data);
                }
                else
                {
                    return StatusCode((int)result.StatusCode,"error occured");
                }

            }
            

        }

    }
    
}
