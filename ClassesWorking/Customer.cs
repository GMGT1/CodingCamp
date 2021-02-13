using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesWorking
{
    class Customer
    {

        //set, değer atamayı; get ise değeri almayı ifade eder.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        /////////////////////////////////////////////////////////////////
        private string myVar;
        public string Unvan
        {
            get { return "Unvanı " + myVar; }   //propfull + tabtab
            set { myVar = value; }
        }
        /////////////////////////////////////////////////////////////////

    }
}
