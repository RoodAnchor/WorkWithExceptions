namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exceptions exceptions = new Exceptions();

            foreach (Exception ex in exceptions.ExceptionsArray)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}