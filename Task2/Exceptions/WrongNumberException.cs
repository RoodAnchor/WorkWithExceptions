namespace Task2.Exceptions
{
    public class WrongNumberException : Exception
    {
        public WrongNumberException() : 
            base("Wrong number entered") { }
    }
}
