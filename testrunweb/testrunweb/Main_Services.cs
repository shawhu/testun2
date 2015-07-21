using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testrunweb
{
    [EnableCors(allowedMethods: "GET, POST, PUT, DELETE, OPTIONS", allowedHeaders: "Accept,Content-Type,Authorization")]
    public class Main_Services : Service
    {
        //test
        public int Get(TestRequest req)
        {

            return req.full_name.Length;
               
        }
    }
}