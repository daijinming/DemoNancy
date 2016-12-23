using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace DemoNancy
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {   

            this.Get["/"] = _ => {
                
                return this.Response.AsText("Hello Nancy");
            };

            this.Get["/abc"] = _ =>
            {

                return this.Response.AsText("Hello abc");
            };

            this.Post["/abc"] = _ =>
            {

                return this.Response.AsText("Hello abc,POST");
            };
        }
    }
}