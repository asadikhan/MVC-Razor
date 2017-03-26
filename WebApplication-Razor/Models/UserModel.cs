using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApplication_Razor.Models
{
    public class UserModel
    {
        [DisplayName("User ID")]
        public int Id { get; set; }
        [DisplayName("Name")]
        public String Name { get; set; }
        [DisplayName("Email")]
        public String Email { get; set; }
        [DisplayName("Phone")]
        public String Phone { get; set; }
        
    }

    public static class UserModelBAL
    {
        private const string Address = "http://jsonplaceholder.typicode.com/users";

        public static List<UserModel> FetchUsers()
        {
            List<UserModel> users = null;

            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(Address).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;
                        string responseString = responseContent.ReadAsStringAsync().Result;
                        users = JsonConvert.DeserializeObject<List<UserModel>>(responseString);
                    }
                }
            }
            catch (Exception ex)
            {
                // log exception
            }

            return users;
        }

    }
}