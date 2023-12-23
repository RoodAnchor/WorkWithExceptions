using Task2.Exceptions;

namespace Task2
{
    /// <summary>
    /// Класс для работы с введёнными данными из консоли
    /// </summary>
    public class InputReader
    {
        #region Delegates
        public delegate void NumberEnteredDelegate(Byte input);
        #endregion Delegates

        #region Events
        public event NumberEnteredDelegate NumberEntered;
        #endregion Events

        #region Methods
        /// <summary>
        /// Метод считывает значение введённое пользователем и проводит валидацию.
        /// При непрохождении валидации выдаёт исключение.
        /// </summary>
        /// <exception cref="WrongNumberException"></exception>
        public void ReadInput()
        {
            Boolean isInputCorrect = false;
            Byte inp = 0;

            while (!isInputCorrect)
            {
                try
                {
                    Console.WriteLine("Enter sort mode: 1 - Ascending, 2 - Descending");

                    if (Byte.TryParse(Console.ReadLine(), out inp)
                        && (inp == 1 || inp == 2))
                    {
                        isInputCorrect = true;
                        NumberEntered?.Invoke(inp);
                    }
                    else
                    {
                        throw new WrongNumberException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        #endregion Methods
    }
}