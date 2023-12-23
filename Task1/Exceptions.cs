namespace Task1
{
    public class Exceptions
    {
        #region Properties
        public Exception[] ExceptionsArray { get; set; }
        #endregion Properties

        #region Constructors
        public Exceptions()
        {
            InitArray();
        }
        #endregion Constructors

        #region Methods
        private void InitArray()
        {
            ExceptionsArray = new Exception[5];

            ExceptionsArray[0] = new IndexOutOfRangeException();
            ExceptionsArray[1] = new UserNotFoundException();
            ExceptionsArray[2] = new FileNotFoundException();
            ExceptionsArray[3] = new DirectoryNotFoundException();
            ExceptionsArray[4] = new NotFiniteNumberException();
        }
        #endregion Methods
    }
}
