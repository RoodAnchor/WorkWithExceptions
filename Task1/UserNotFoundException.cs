namespace Task1
{
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException() : 
            base("User not found") { }
    }
}
