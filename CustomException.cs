using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyHallmanagementSystem
{
    public class CustomException: Exception
    {
        public CustomException()
        {
            Console.WriteLine("File not found");
        }
        public string NullReferenceException()
        {
            return "Null Reference Exception";
        }
    }
}
