using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Year3GroupBackend.Models
{
    public class userDetails
    {
         public int studentID { get; set; }
        
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string gender { get; set; }

        public DateTime DOB { get; set; }
       
        public string institutionName { get; set; }

        public string course { get; set; }

        public string gradYear { get; set; }





            public userDetails()
    {

        Regex r = new Regex("^[a-zA-Z0-9]*$");


        if (string.IsNullOrEmpty(this.firstName))
        {
            Console.WriteLine("Please enter first name");
        }


        if(string.IsNullOrEmpty(this.lastName))
        {
            Console.WriteLine("Please enter last name");
        }


        if (!r.IsMatch(this.firstName))
        {
            Console.WriteLine("Name must only contain letters");
        }
    }
        


        

        
    }





    







}

    