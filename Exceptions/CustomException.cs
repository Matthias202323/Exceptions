using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CustomException : Exception
    {

        public DateTime Date { get; }
        public string Message { get; }
        public CustomException(string message ,DateTime date)
        {
            
            Date = date;
            Message=message;
            base.Data.Add("Date", Date);
            base.Data.Add("Message", Message);
           
        }
    }
}
