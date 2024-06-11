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
        public CustomException(string message ,DateTime date)
        {
            Date = date;
            base.Data.Add("Date", Date);
        }
    }
}
