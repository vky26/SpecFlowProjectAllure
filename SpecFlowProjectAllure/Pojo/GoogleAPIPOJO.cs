using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProjectAllure.Pojo
{
    class GoogleAPIPOJO
    {
        //Login Token Post Request //delete
        public String status { get; set; }
        public String placeID { get; set; }

        //Get Place Details
        public String name { get; set; }
        public String address { get; set; }

        //Update Request Post
        public String msg { get; set; }

    }
}
