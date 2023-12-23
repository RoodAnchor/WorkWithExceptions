namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LastNamesCollection lastNames = new LastNamesCollection();

            InputReader inputReader = new InputReader();
            inputReader.NumberEntered += lastNames.Sort;

            inputReader.ReadInput();

            foreach (String name in lastNames.Items)
            {
                Console.WriteLine(name);
            }

            Console.Read();
        }
    }
}