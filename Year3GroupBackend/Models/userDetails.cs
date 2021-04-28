using System;
using System.Collections.Generic;

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




        if (string.IsNullOrEmpty(DOB))
        {
            Console.WriteLine("Enter your date of birth");

        }

         if (string.IsNullOrEmpty(course))
        {
            Console.WriteLine("Enter the name of your course");

        }

         if (string.IsNullOrEmpty(firstName))
        {
            Console.WriteLine("Enter your first name");

        }

         if (string.IsNullOrEmpty(lastName))
        {
            Console.WriteLine("Enter your last name");

        }

         if (string.IsNullOrEmpty(gender))
        {
            Console.WriteLine("Enter your gender");

        }

         if (string.IsNullOrEmpty(gradYear))
        {
            Console.WriteLine("Enter your graduation vibe");

        }

         if (string.IsNullOrEmpty(institutionName))
        {
            Console.WriteLine("Enter the name of your instatution");

        }

         if (string.IsNullOrEmpty(studentID))
        {
            Console.WriteLine("Enter your student ID");

        }

    }

    