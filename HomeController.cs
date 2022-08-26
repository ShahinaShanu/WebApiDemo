using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MyApp.Controllers
{
    public class HomeController : ApiController
    {
        static List<string> strings = new List<string>()
        {
            "value0", "value1", "value2"
        };
        public IEnumerable<string> Get()
        {
            return strings;
        }
        public string Get(int id)
        {
            string a = strings[id];
            return a;
        }
        
        [HttpPost]
        public string Post([FromBody]string value)
        {
         //value = "new string";
         strings.Add(value);
         return "successfully inserted " + value;
        }
        public string Put(int id, [FromBody]string value)
        {
            //value = "update string";
            strings[id] = value;
            return "successfully updated  " + value;
        }
        public string Delete(int id)
        {
            strings.RemoveAt(id);
            return "successfully deleted at "+ id;
        }
    }
}
