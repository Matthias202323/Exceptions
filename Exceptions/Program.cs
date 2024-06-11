namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = Int32.Parse("abc");
            }
            catch (Exception ex)
            {
                throw new CustomException("Houston ? On a un problème !",DateTime.Now);
            }
        }

    }
}
