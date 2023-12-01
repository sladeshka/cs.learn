namespace Book4._0
{
    internal class Magazine : Item
    {
        #region Fields
        private string volume;
        private int number;
        private string title;
        private int year;
        #endregion

        #region Constructors
        public Magazine()
        {
            
        }

        public Magazine(string volume, int number, string title, int year, long inventoryNumber, bool taken) : base(inventoryNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }
        #endregion

        #region Methods
        public override void Return()
        {
            taken = true;
        }
        public override string ToString()
        {
            return $"\nMagazine:\nVolume: {volume}\nNumber: {number}\nTitle: {title}\nPublished: {year}" + base.ToString();
        }
        #endregion
    }
}
