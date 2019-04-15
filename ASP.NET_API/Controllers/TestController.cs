using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_API.Controllers
{
    public class TestController : ApiController
    {
        [HttpPost]
        public string getss()
        {
            Msg m = new Msg();
            m.ID = 1;
            m.Name = "姚恒锋";
            return JsonConvert.SerializeObject(m);
        }
        [HttpGet]
        public string getsss()
        {
            Msg m = new Msg();
            m.ID = 1;
            m.Name = "姚恒锋111111111get";
            return JsonConvert.SerializeObject(m);
        }


        [HttpPost]
        public string Pp()
        {
            Msg m = new Msg();
            m.ID = 1;
            m.Name = "dfgdfgd";
            return JsonConvert.SerializeObject(m);
        }

        class Msg
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
