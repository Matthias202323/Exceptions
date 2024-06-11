using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomException("Houston an a un problème!",DateTime.Now);
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Message: {ex.Data["Message"]}");
                Console.WriteLine($"Additional data: {ex.Data["Date"]}");
            }
        }

    }
}
