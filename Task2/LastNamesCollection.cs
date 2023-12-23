using Task2.Enums;

namespace Task2
{
    /// <summary>
    /// Класс предоставляющий доступ к коллекции фамилий,
    /// а ткаже методу сортировки коллекции.
    /// </summary>
    public class LastNamesCollection
    {
        #region Properties
        public List<String> Items { get; set; } = new List<String>();
        #endregion Properties

        #region Constructors
        public LastNamesCollection()
        {
            InitList();
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Метод заполняет список фамилиями
        /// </summary>
        private void InitList()
        {
            Items.Add("Bill");
            Items.Add("Steve");
            Items.Add("Michael");
            Items.Add("Joe");
            Items.Add("Donald");
        }

        /// <summary>
        /// Метод сортирует коллекцию фамилий в зависимости 
        /// от параметра режима сортировки
        /// </summary>
        /// <param name="mode">Параметр режима сортировки</param>
        public void Sort(Byte mode)
        {
            switch ((SortModeEnum)mode)
            {
                case SortModeEnum.Asc:
                    Items = Items.OrderBy(x => x).ToList();
                    break;

                default:
                    Items = Items.OrderByDescending(x => x).ToList();
                    break;
            }
        }
        #endregion Methods
    }
}
