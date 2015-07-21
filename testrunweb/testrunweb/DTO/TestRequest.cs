using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testrunweb
{
    [Route("/test")]
    public class TestRequest
    {
        public int member_id { get; set; }
        public string full_name { get; set; }
    }
}